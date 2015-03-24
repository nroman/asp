using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessTracker.Models
{
    public class Exercise
    {
        public int ID { get; set; }

        public String Name { get; set; }

        public BodyPart CurrentBodyPart { get; set; }

        public MeasurementSystem Measurement { get; set; }

        public virtual List<ExerciseSet> ExerciseSet { get; set; }
    }

    public class ExerciseSet
    {
        public Double Weight { get; set; }

        public Double MovementsCount { get; set; }
            
        public virtual Exercise Exercise { get; set; }
    }

    /// <summary>
    /// The parts of the body
    /// </summary>
    public enum BodyPart
    {
        Neck = 0,
        Traps,
        Shoulders,
        Lats,
        MidleBack,
        LowerBack,        
        Chest,
        Abs,
        Biceps,
        Triceps,       
        Forearm,        
        Gluts,
        Quads,
        Hamstrings,
        Calves
    }

    public enum MeasurementSystem
    {
        Metric = 0,
        English
    }
}