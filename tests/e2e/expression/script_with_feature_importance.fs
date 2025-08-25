/* FUGE-LC Reference script
     Note: the name of the functions cannot be changed
*/

// Experiment name appearing in the logs
experimentName = "expression21_232204_at";

// Directory where logs, fuzzy systems and temporary files are saved
savePath = ".output/fi";
// Fuzzy system parameters
fixedVars = false;
nbRules = 5;
nbMaxVarPerRule = 3;
nbOutVars = 1;
nbInSets = 2;
nbOutSets = 2;
inVarsCodeSize = 7;
outVarsCodeSize = 1;
inSetsCodeSize = 2;
outSetsCodeSize = 1;
inSetsPosCodeSize = 8;
outSetPosCodeSize = 1;

// Co-evolution parameters
// Population 1: Membership Functions (Variables)
maxGenPop1 = 300;
maxFitPop1 = 0.999;
elitePop1 = 10;
popSizePop1 = 350;
cxProbPop1 = 0.9;
mutFlipIndPop1 = 0.2;
mutFlipBitPop1 = 0.01;

// Population 2: Rules
elitePop2 = 10;
popSizePop2 = 350;
cxProbPop2 = 0.6;
mutFlipIndPop2 = 0.4;
mutFlipBitPop2 = 0.01;

// Fitness parameters
sensitivityW = 1.0;
specificityW = 1.0;
accuracyW = 0.0;
ppvW = 0.0;
rmseW = 0.5;
rrseW = 0.0;
raeW = 0.0;
mxeW = 0.0;
distanceThresholdW = 0.01;
distanceMinThresholdW = 0.0;
dontCareW = 0.35;
overLearnW = 0.0;
threshold = 0.5;
threshActivated = true;
featuresImportance = "[232204_at, 1]";

function doSetParams()
{
    this.setParams(experimentName, savePath, fixedVars, nbRules, nbMaxVarPerRule, nbOutVars, nbInSets, nbOutSets, inVarsCodeSize, outVarsCodeSize,
                 inSetsCodeSize, outSetsCodeSize, inSetsPosCodeSize, outSetPosCodeSize, maxGenPop1, maxFitPop1, elitePop1, popSizePop1,
                 cxProbPop1, mutFlipIndPop1, mutFlipBitPop1, maxGenPop1, maxFitPop1, elitePop2, popSizePop2, cxProbPop2, mutFlipIndPop2,
                 mutFlipBitPop2, sensitivityW, specificityW, accuracyW, ppvW, rmseW, rrseW, raeW, mxeW, distanceThresholdW,
                     distanceMinThresholdW, dontCareW, overLearnW, threshold, threshActivated, featuresImportance)
}

// Run function called by FUGE-LC. This function MUST also be present
function doRun()
{
    var nRuleVals = [5];
    var varVals = [3];
    var popVals = [350];
    var genVals = [300];

    // Multiple coevolution runs with different parameters
    for (var i = 0; i < nRuleVals.length; i++) {
        for (var j = 0; j < varVals.length; j++) {
            for (var k = 0; k < popVals.length; k++) {
                for (var l = 0; l < genVals.length; l++) {
                    for (var m = 0; m < 1; m++) {
                        nbRules = nRuleVals[i];
                        nbMaxVarPerRule = varVals[j];
                        maxGenPop1 = genVals[l];
                        maxGenPop2 = genVals[l];
                        popSizePop1 = popVals[k];
                        popSizePop2 = popVals[k];
                       this.runEvo();
                    }
                }
            }
        }
    }
}

