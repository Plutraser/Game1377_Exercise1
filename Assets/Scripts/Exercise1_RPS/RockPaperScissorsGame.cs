/*
 * Assignment: Rock Paper Scissors Lizard Spock Game
 * 
 * Objective:
 * Implement a fully functional Rock Paper Scissors Lizard Spock game using Unity and C#. The player selects a choice via UI buttons, 
 * the computer randomly selects its choice, and the game determines the winner based on the game rules.
 * 
 * Requirements:
 * 1. The player can choose from five options: Rock, Paper, Scissors, Lizard, or Spock by pressing designated buttons in the scene.
 * 2. The computer randomly selects one of the five choices each turn.
 * 3. Game logic determines the winner based on the following rules:
 *    - Rock beats Scissors and Lizard
 *    - Scissors beats Paper and Lizard
 *    - Paper beats Rock and Spock
 *    - Lizard beats Paper and Spock
 *    - Spock beats Scissors and Rock
 * 4. Ties occur when both the player and computer choose the same option.
 * 5. All game results (player choice, computer choice, and outcome) should be output using Debug.Log.
 * 6. Use an enum to represent the five choices instead of strings.
 * 7. Update the OnClick() method in the editor to use enums instead of strings.
 * 
 * Instructions:
 * - Attach the script to any active GameObject in your Unity scene.
 * - Change the OnClick method on the UI buttons in the scene to use enums instead of strings.
 * - Observe the game results in the Console after each button press.
 * 
 * Hint:
 * - Start by just fixing up the strings and doing Rock Paper Scissors. 
 * - Once you have that working, add in the Lizard and Spock options and update the game logic accordingly.
 * - Lastly, change the method to use enums instead of strings.
 *
 */

using UnityEngine;

public class RockPaperScissorsGame : MonoBehaviour
{
    enum Choices
    {
        invalid, // 0 
        rock, // 1
        paper, // 2
        scissors, // 3
        lizard, // 4
        spock // 5
    }



    public void RockPaperScissors(int tool) //Tool is whatever button the player choices (Brings an int for enum)
    {

        int randomChoice = Random.Range(1, 5); //Randomizing Computers choice
        Choices computerChoice = (Choices)randomChoice; //Assigns the Computers int number to an Enum
        Choices playerChoice = (Choices)tool; //Assigns the Players int number to an Enum

        switch (tool)
        {
            case 0:
                Debug.Log("Invalid");
                break;

            case 1:
                Debug.Log("You chose: " + playerChoice); //Player chose Rock
                Debug.Log("Computer chose: " + computerChoice); //Computer Choice
                if (computerChoice == Choices.rock)
                {
                    Debug.Log("It's a tie! Both chose " + computerChoice);
                }
                else if (computerChoice == Choices.paper || computerChoice == Choices.spock)
                {
                    Debug.Log("You lose! " + computerChoice + " beats " + playerChoice);
                }
                else
                {
                    Debug.Log("You win! " + playerChoice + " beats " + computerChoice);
                }
                break;

            case 2:
                Debug.Log("You chose: " + playerChoice); //Player chose paper
                Debug.Log("Computer chose: " + computerChoice); //Computer Choice
                if (computerChoice == Choices.paper)
                {
                    Debug.Log("It's a tie! Both chose " + computerChoice);
                }
                else if (computerChoice == Choices.lizard || computerChoice == Choices.scissors)
                {
                    Debug.Log("You lose! " + computerChoice + " beats " + playerChoice);
                }
                else
                {
                    Debug.Log("You win! " + playerChoice + " beats " + computerChoice);
                }
                break;

            case 3:
                Debug.Log("You chose: " + playerChoice); //Player chose Scissors
                Debug.Log("Computer chose: " + computerChoice); //Computer Choice
                if (computerChoice == Choices.scissors)
                {
                    Debug.Log("It's a tie! Both chose " + computerChoice);
                }
                else if (computerChoice == Choices.rock || computerChoice == Choices.spock)
                {
                    Debug.Log("You lose! " + computerChoice + " beats " + playerChoice);
                }
                else
                {
                    Debug.Log("You win! " + playerChoice + " beats " + computerChoice);
                }
                break;

            case 4:
                Debug.Log("You chose: " + playerChoice); //Player chose Lizard
                Debug.Log("Computer chose: " + computerChoice); //Computer Choice
                if (computerChoice == Choices.lizard)
                {
                    Debug.Log("It's a tie! Both chose " + computerChoice);
                }
                else if (computerChoice == Choices.rock || computerChoice == Choices.scissors)
                {
                    Debug.Log("You lose! " + computerChoice + " beats " + playerChoice);
                }
                else
                {
                    Debug.Log("You win! " + playerChoice + " beats " + computerChoice);
                }
                break;

            case 5:
                Debug.Log("You chose: " + playerChoice); //Player chose Spock
                Debug.Log("Computer chose: " + computerChoice); //Computer Choice
                if (computerChoice == Choices.spock)
                {
                    Debug.Log("It's a tie! Both chose " + computerChoice);
                }
                else if (computerChoice == Choices.paper || computerChoice == Choices.lizard)
                {
                    Debug.Log("You lose! " + computerChoice + " beats " + playerChoice);
                }
                else
                {
                    Debug.Log("You win! " + playerChoice + " beats " + computerChoice);
                }
                break;

            default: //An error was made (should not be possible)
                Debug.Log("ERROR");
                break;

        }

    }

}
