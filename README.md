# Binary Matrix Cluster Finder
 Count the cluster in any given boolean matrix.

The problem states as follows:
Imagine you are the owner of a big supermarket chain, and your planning to open more stores in Puerto Rico. Puerto Rico is made under a grid city plan, where the cities can be easily divided in rectangular or square blocks. The structure of the cities can be represented with a R*C blocks matrix. Each block can be either a building or a wasteland. The building are represented with a number one (1) and the wastelands with a zero (0).

A cluster is a collection of one or more adjacent buildings (one single building is considered to be a cluster). The buildings that form a diagonal are not considered adjecent to each other (at least not directly), just the one which are next to each other in a completly horizontal or vertical way.
Your supermarket chain can only open stores in clusters and just one store in each cluster.

## Exercise
Write an algorithm that determines the amount of branch offices that can be opened.

Your inputs are an interger bidimensional array which represents a binary matrix, the number of rows of the matrix, and the number of columns of the matrix.

Your output must be an interger which indicates the amounts of stores that can be opened.

## Here's an example:

**Input** </br>
rows->5 </br>
columns->4 </br>
matrix-> </br>
1, 1, 0, 0 </br>
0, 0, 1, 0 </br>
0, 1, 0, 0 </br>
1, 0, 1, 1 </br>
1, 1, 1, 1 </br>

**Output**</br>
The output must be 4 since there are 4 clusters of buildings.
