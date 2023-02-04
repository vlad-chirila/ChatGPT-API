# Simple ChatGPT-API client
![alt text](https://pixabay.com/get/g4dccc990fb27810252d4f8718c4d0384e5276861f60f1e715b48d8d35fac74169cae3d597c1d15d1dfc5c219cc1c445100dbb5700ccf2227071f8de4247673d4afd30f3d898808e2bb5a82fe306230d4_640.jpg)

## Getting Started
Step-by-step instructions on how to install and set up the project on a local machine.

1. Clone this repository or download it.
2. Open up the Program.cs file and search for `API KEY`.
3. Replace with your API key provided on openai platform
Line with setting up the request header should look like this:
`client.DefaultRequestHeaders.Add("authorization", "Bearer sk-...");`

## Prerequisites
List of required software, libraries, and tools to run the project.

`.Net 7 SDK`
`NewtonSoft Json`

## Usage
Instructions on how to use the project and what it does.
After building the application you can add the executable to `PATH` system variable so you can use it like this in any command line:

`chatgpt "--YOUR QUESTION--"`
EX:
`chatgpt "Which are the new features of .NET 7 ?"`
![alt text](https://i.imgur.com/QVKAe2s.png)

## Built With
List of technologies, libraries, and tools used in the project.

Visual Studio Code using .NET 7 SDK
- You can use any other text editor but keep in mind that you have to build the project afterwards by using .net 7 sdk

## Contact
vlad.chirila [at] live.com
