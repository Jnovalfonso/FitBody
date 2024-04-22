using System;
using System.Collections.Generic;
public class ExerciseLibrary
{
    private List<Exercise> exercises;
    public ExerciseLibrary()
    {
        exercises = new List<Exercise>();
    }
    public void AddExercise(Exercise exercise)
    {
        exercises.Add(exercise);
    }
    public void RemoveExercise(Exercise exercise)
    {
        exercises.Remove(exercise);
    }
    public List<Exercise> GetExercisesByMuscleGroup(string muscleGroup)
    {
        return exercises.FindAll(e => e.MuscleGroup == muscleGroup);
    }
    public void DisplayWorkoutsOnNewPage()
    {
        foreach (Exercise exercise in exercises)
    
    {
        static void Main(string[] args)
        {
            ExerciseLibrary exerciseLibrary = new ExerciseLibrary();
            // Add exercises to the library
            exerciseLibrary.AddExercise(new Exercise { Name = "Bench Press", MuscleGroup = "Chest" });
            exerciseLibrary.AddExercise(new Exercise { Name = "Squat", MuscleGroup = "Legs" });
            exerciseLibrary.AddExercise(new Exercise { Name = "Deadlift", MuscleGroup = "Back" });
            exerciseLibrary.AddExercise(new Exercise { Name = "Shoulder Press", MuscleGroup = "Shoulders" });
            exerciseLibrary.AddExercise(new Exercise { Name = "Pull-ups", MuscleGroup = "Back" });
            exerciseLibrary.AddExercise(new Exercise { Name = "Bicep Curls", MuscleGroup = "Arms" });
            exerciseLibrary.AddExercise(new Exercise { Name = "Lunges", MuscleGroup = "Legs" });
            exerciseLibrary.AddExercise(new Exercise { Name = "Push-ups", MuscleGroup = "Chest" });
            exerciseLibrary.AddExercise(new Exercise { Name = "Tricep Dips", MuscleGroup = "Arms" });
            exerciseLibrary.AddExercise(new Exercise { Name = "Rows", MuscleGroup = "Back" });
            exerciseLibrary.AddExercise(new Exercise { Name = "Plank", MuscleGroup = "Core" });
            exerciseLibrary.AddExercise(new Exercise { Name = "Russian Twists", MuscleGroup = "Core" });
            exerciseLibrary.AddExercise(new Exercise { Name = "Calf Raises", MuscleGroup = "Legs" });
            exerciseLibrary.AddExercise(new Exercise { Name = "Hammer Curls", MuscleGroup = "Arms" });
            exerciseLibrary.AddExercise(new Exercise { Name = "Side Lateral Raises", MuscleGroup = "Shoulders" });
            // Display workouts on a new page
            exerciseLibrary.DisplayWorkoutsOnNewPage();
        }
    }
        {
            Console.WriteLine("Exercise: " + exercise.Name);
            Console.WriteLine("Muscle Group: " + exercise.MuscleGroup);
            Console.WriteLine();
        }
    }
}