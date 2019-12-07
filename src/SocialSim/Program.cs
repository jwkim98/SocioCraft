﻿using System;

namespace SocialSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string peopleFilePath = "";
            string relationshipFilePath = "";

            Engine.Engine engine = new Engine.Engine(new Model.Model());
            
            engine.ReadPeopleFile(peopleFilePath);
            engine.ReadRelationshipFile(relationshipFilePath);
            
            engine.Run(100, 10, "Output");
        }
    }
}