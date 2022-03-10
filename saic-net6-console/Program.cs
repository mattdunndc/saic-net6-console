// See https://aka.ms/new-console-template for more information
using System.Text.Json;

Console.WriteLine("Hello, World!");

var peeps = JsonSerializer.Deserialize<Net6api.Models.APIModels.people>(File.ReadAllText("users-list.json"));

var x = 0;


//User: Bob has 0 stories.

//User: Carla has 2 stories.
//Story ID:8 is 8 points and due: 3 / 20 / 2022
//Story ID:3 is 3 points and due: 3 / 24 / 2022

//User: Dave has 2 stories.
//Story ID:2 is 5 points and due: 3 / 17 / 2022
//Story ID:1 is 3 points and due: 3 / 19 / 2022

//User: Emma has 3 stories.
//Story ID:6 is 5 points and due: 3 / 13 / 2022
//Story ID:4 is 5 points and due: 3 / 21 / 2022
//Story ID:9 is 2 points and due: 4 / 9 / 2022

//User: Jenny has 2 stories.
//Story ID:5 is 8 points and due: 3 / 20 / 2022
//Story ID:7 is 8 points and due: 3 / 25 / 2022

//User: Tony has 1 stories.
//Story ID:10 is 8 points and due: 3 / 18 / 2022