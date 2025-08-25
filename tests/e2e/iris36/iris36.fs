
nbRules = 3;
nbMaxVarPerRule = 3;
nbOutVars = 1;
nbInSets = 2;
nbOutSets = 2;
inVarsCodeSize = 14;
outVarsCodeSize = 1;
inSetsCodeSize = 1;
outSetsCodeSize = 1;
inSetsPosCodeSize = 10;
outSetPosCodeSize = 1;
// fixedVars = false;
maxGen = 100;
maxFit = 1;
elitePop1 = 3;
popSizePop1 = 100;
cxProbPop1 = 0.8;
mutFlipIndPop1 = 0.8;
mutFlipBitPop1 = 0.1;1
elitePop2 = 3;
popSizePop2 = 100;
cxProbPop2 = 0.8;
mutFlipIndPop2 = 0.8;
mutFlipBitPop2 = 0.1;
specificityW = 0.8;
sensitivityW = 1;
distanceThresholdW = 0.2;
mxeW = 0.0;
threshold = 0.5;
// threshActivated = true;
dontCareW = 0.0;
accuracyW = 0.0;
ppvW = 0.0;
rmseW = 0.2;
rrseW = 0.0;
raeW = 0.0;
distanceMinThresholdW = 0.0;
overLearnW = 0.0;
// experimentName = "mini_IRIS";

featuresWeights = [ {"feature": "Sepal.Length", "weight": 0.8 }, {"feature": "Petal.Width", "weight": 0.3 }];

// savePath = ".output";
function doSetParams()
{
	// this.setParams(experimentName, savePath, fixedVars, nbRules, nbMaxVarPerRule, nbOutVars, nbInSets, nbOutSets, inVarsCodeSize, outVarsCodeSize,
	// 			 inSetsCodeSize, outSetsCodeSize, inSetsPosCodeSize, outSetPosCodeSize, maxGenPop1, maxFitPop1, elitePop1, popSizePop1,
	// 			 cxProbPop1, mutFlipIndPop1, mutFlipBitPop1, maxGenPop1, maxFitPop1, elitePop2, popSizePop2, cxProbPop2, mutFlipIndPop2,
	// 			 mutFlipBitPop2, sensitivityW, specificityW, accuracyW, ppvW, rmseW, rrseW, raeW, mxeW, distanceThresholdW,
	// 		         distanceMinThresholdW, dontCareW, overLearnW, threshold, threshActivated);
	setParams(nbRules, nbMaxVarPerRule, nbOutVars, nbInSets, nbOutSets, inVarsCodeSize, outVarsCodeSize,
				 inSetsCodeSize, outSetsCodeSize, inSetsPosCodeSize, outSetPosCodeSize, maxGen, maxFit, elitePop1, popSizePop1,
				 cxProbPop1, mutFlipIndPop1, mutFlipBitPop1,  elitePop2, popSizePop2, cxProbPop2, mutFlipIndPop2,
				 mutFlipBitPop2, sensitivityW, specificityW, accuracyW, ppvW, rmseW, rrseW, raeW, mxeW, distanceThresholdW,
			         distanceMinThresholdW, dontCareW, overLearnW, threshold, featuresWeights);					 
}
// Run function called by FUGE-LC. This function MUST also be present
function doRun()
{
	doSetParams();
	runEvo();
}
doRun();
