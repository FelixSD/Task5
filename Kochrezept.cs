using System;

namespace Task5 {
    class Kochrezept {
        string rezept;
        string[] ingredients;
        int ingredientsAvailable;
        bool wantToBuy;
        bool satisfied; 

        public Kochrezept(string rezept, string[] ingredients, int ingredientsAvailable, bool wantToBuy, bool satisfied) {
            this.rezept = rezept;
            this.ingredients = ingredients;
            this.ingredientsAvailable = ingredientsAvailable;
            this.wantToBuy = wantToBuy;
            this.satisfied = satisfied;
        }

        public void CheckForIngredients(string[] ingredients, int ingredientsAvailable) {
            if(ingredients.Length == ingredientsAvailable) {
                ProcessRecipeFromBook(Recipe recipe);
            } else {
                MoodToBuyIngredients(bool mood);
            }
        }

        public void ProcessRecipeFromBook(Recipe recipe) {
            foreach(string step in workSteps) {
                step.status == true;
            }

            if(workSteps.done) {
                Foodstuff foodstuff1 = new Foodstuff("Final Product", true); 
                CheckForSatisfication(foodstuff1.satisfied);
            }
        }

        public void MoodToBuyIngredients(bool mood) {
            if(mood) {
                this.wantToBuy == true;
                ProcessRecipeFromBook(Recipe recipe);
            } else {
                this.wantToBuy == false;
                System.Environment.Exit(1);     // terminates the programm if I dont want to buy neccesary ingredients
            }
        }

        public void CheckForSatisfication(bool satisfied) {
            if(satisfied) {
                this.satisfied == true;
                System.Environment.Exit(1);     // terminates the programm if Im satisfied with the final product of my work
            } else {
                this.satisfied == false;
                CheckForIngredients(this.ingredients, this.ingredientsAvailable);
            }
        }



        public static void Main(string[] args) {
            Kochrezept rezept1 = new Kochrezept("Gulasch", new string[] {"Fleisch", "Soße", "Gewürze"}, 0, false, false);

        }
    }
}
