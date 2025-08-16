## Game of Sticks
If you are stuck on how to approach this program, please watch the video, otherwise, try making this flowchart on your own.

Worksheet Task: Create a flowchart describing the process of playing the game of sticks.

You can draw this on paper or a white board or use http://draw.io (Links to an external site.), but remember that your flowchart should only have the following types of objects in it:

        rectangular boxes --- describing a single step in the process (hint: a loop is not a single step) and an arrow pointing from each rectangle to the next step or branching-point in the process
        diamond-shaped boxes -- representing a branching point in the process with labeled arrows indicating the different possible next steps, the labels indicating the condition for following that branch
        (arrows as described above)

Here is an English description of the how the game of sticks goes (which you should convert into a flowchart; remember that you can make up names for variables in your flowchart rather than using long descriptions like I'm using below in my English description.  For example, your first box might say "Display the rules of the game." and it would point to a second box that says "Let numberOfSticks = 20".):

   1.  Explain the rules of the game of sticks: players will take turns choosing at least 1 and no more than 3 of the remaining sticks until the sticks are gone.  The player that takes the last stick loses.
   2.  Set the number of sticks left to 20.
   3.  Set the current player to be player 1.
   4.  Set the maximum number of sticks that can be taken to be equal to 3.
   5.  If the number of sticks left is less than 3, then set the maximum number of sticks that can be taken to be equal to the number of sticks left.
   6.  Ask the current player to choose a number of sticks between 1 and the maximum number of sticks that can be taken on this turn.
   7.  If the number of sticks chosen is not in the allowed range, print an error message and then go back to step 6; otherwise go on to step 8.
   8.  Decrease the number of sticks by the number of sticks chosen.
   9.  If the current player is player 1, set current player to be player 2; otherwise set current player to be player 1.
   10. If the number of sticks left is equal to 0, then print that the current player won; otherwise, go back to step 4.
