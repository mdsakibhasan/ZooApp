﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.Models;
using ZooApp.ViewModels;

namespace ZooApp.Services
{
    public class AnimalService
    {
        //create a db object
        ZooContext db = new ZooContext();
        public List<ViewAnimal> GetAll()
        {
            //fetch the db.animal data
            List<Animal> animals = db.Animals.ToList();
            List<ViewAnimal> viewAnimals = new List<ViewAnimal>();
            foreach (Animal animal in animals)
            {
                ViewAnimal viewAnimal = new ViewAnimal(animal);
                viewAnimals.Add(viewAnimal);
            }
            return viewAnimals;
        }

        public ViewAnimal Get(int id)
        {
            Animal animal = db.Animals.Find(id);
            return new ViewAnimal(animal);
        }

        public bool Save(Animal animal)
        {
            db.Animals.Add(animal);
            db.SaveChanges();
            return true;
        }

        public bool Update(Animal animal)
        {
            db.Entry(animal).State = EntityState.Modified;
            db.SaveChanges();
            return true;
        }

        public bool Delete(Animal animal)
        {
            Animal dbAnimal = db.Animals.Find(animal.Id);
            db.Animals.Remove(dbAnimal);
            db.SaveChanges();
            return true;
        }

        public Animal GetDbModel(int id)
        {
            return db.Animals.Find(id);
        }
    }
}
