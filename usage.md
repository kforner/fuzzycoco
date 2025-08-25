


### 1. FUZZY SYSTEM CREATION

In order to create a fuzzy system with FUGE-LC, the following steps must be performed:
- compile the application (with QMake or CMake)
- run the following command line :
 

    $ <path_to_FUGE-LC> -d <path_to_datasetFile> -s <path_to_scriptFile> -g no
- the result will be a .ffs file containing the best fuzzy system found at the path specified in the script

### 2. FUZZY SYSTEM EVALUATION
In order to evaluate a fuzzy system with FUGE-LC, the following steps must be performed:
- run the following command line :
 

    $ <path_to_FUGE-LC> --evaluate -f <path_to_fuzzySystemFile> -d <path_to_datasetFile> -s <path_to_scriptFile> -g no
- the result will be a file containing the values of the fitness measurements for the fuzzy system evaluated



### 3. FUZZY SYSTEM PREDICTION
In order to predict with a fuzzy system with FUGE-LC, the following steps must be performed:
- run the following command line :
 

    $ <path_to_FUGE-LC> --predict -f <path_to_fuzzySystemFile> -d <path_to_datasetFile> -s <path_to_scriptFile> -g no -p yes
- the result will be a file containing the values of the fitness measurements for the fuzzy system evaluated
This feature allows predicting the results for a database without outputs. The database the
user specifies must have no output rows as the program will propose to save the
prediction. This will result in adding a row for the prediction of each output variable.



## Data, scripts and parameters
### Dataset
The database file must meet the following requirements:

- CSV file type, separated by semicolons
- Each row (samples) and each column (variables) must start with a label
- The output variables must be placed in the last columns


### Parameters
#### coevolution parameters

The coevolution algorithm can be configured via the following parameters:

- Number of generations to reach before stopping the evolution
- Maximum fitness threshold to reach before stopping the evolution
- Size of the populations (number of individuals)
- Size of the elite (best individuals kept unchanged between to generations)
- Crossover probability
- Probability that an individual is a target for a mutation
- Probability that a bit of an individual is mutated

#### Fitness evaluation parameters

These parameters determine how the overall fitness of a system will be evaluated. A value is computed for all the following measurements and a weight for each one can be selected. The fitness value is the sum of these measurements multiplied by their weight. The measurements available are:

- Sensitivity : TruePos / (TruePos + FalseNeg)
- Specificity : TrueNeg / (TrueNeg + FalsePos)
- Accuracy : (TruePos +TrueNeg) / (TruePos + TrueNeg + FalsePos + FalseNeg)
- PPV : TruePos / (TruePos + FalsePos)
- RMSE : Root Mean Square Error

It is also possible to choose the threshold applied to the output values. Generally, it is selected in the middle of the minimum and maximum value.


#### Fuzzy system parameters
These parameters determine the shape of the emerged fuzzy systems (number of rules, maximum number of variables per rule, number of input/output sets) and the number of bits used to code the different elements (variables, rules, membership functions) in the genome.

There is also parameter that indicates to the software how much output variables are present in the database. Without this indication, the application has no means to know the number output variables.

Be very careful when editing these parameters. Incoherent values can lead to erroneous results and even to the crash of the application.

### Script
The script files have the .fs extension and are coded in the Javascript language. They are composed of the following elements:
- The definition of all the parameters
- The definition of the doSetParams() function
- The definition of the doRun() function which controls the execution of multiple (or single) runs of coevolution

All these elements must be present and complete in the script in order to make it valid. A reference valid script file called ref.fs is present in the bin/script/ folder. Its syntax is quite simple and should be easily understood. Basically, after having defined all the parameters and implemented the doSetParams() function, the doRun() function defines how much runs of evolution will be performed and which parameters will be modified between the runs.

