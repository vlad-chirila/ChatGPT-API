//  ~~~~~~~~~~~~~~~~~ Simple Chat GPT usage of API ~~~~~~~~~~~~~~~~~~~
//
// Do not forget to change `API KEY` with your api key from OPENAI.COM
//

using System.Text;
using Newtonsoft.Json;

if (args.Length > 0){
    HttpClient client = new HttpClient();
     var content = new StringContent("{\"model\": \"text-davinci-003\", \"prompt\": \""+ args[0] +"\",\"temperature\": 1,\"max_tokens\": 2000}",
        Encoding.UTF8, "application/json");
    
    client.DefaultRequestHeaders.Add("authorization", "Bearer `API KEY`");
    HttpResponseMessage response = await client.PostAsync("https://api.openai.com/v1/completions", content);
    string responseString = await response.Content.ReadAsStringAsync();

try{
    var chatGPTResponse = JsonConvert.DeserializeObject<dynamic>(responseString);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(chatGPTResponse!.choices[0].text);
}catch(JsonException ex){
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(ex.Message);
}
}else{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong input. Arguments missing.");
}