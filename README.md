fuzzycoco
=========

This is a C++ implementation of the FuzzyCoCo algorithm.
It constructs systems that predict the outcome of a human decision-making 
process while providing an understandable explanation of a possible reasoning leading to it. The constructed fuzzy systems are 
composed of rules and linguistic variables. For more information about the method, please refer to Prof. Carlos Andrés Peña 
Reyes' thesis entitled "Coevolutionary Fuzzy Modeling" (*Fuzzy CoCo: a cooperative-coevolutionary approach to fuzzy modeling* from [Carlos Andrés Peña-Reyes](https://orcid.org/0000-0002-2113-6498)).

## acknowledgements

This software is a complete rewrite of the FUGE-LC software.
The goals of this reimplementation were:
  - to remove the dependency to the Qt C++ framework
  - to make it easily testable (redesign guided by the TDD (Test Driven Methodology))
  - to make it usable as a library, so that it could be wrapped in dynamic languages such as R and Python
  - to remove the previously mandatory javascript execution script

FUGE-LC credits:
- FUGE-LC by Jean-Philippe Meylan (2009-2010)
- Genetic algorithm update by Yvan Da Silva (2012)
- Code upgrade by [Rochus Keller](http://rochus-keller.ch/) <me@rochus.keller.ch> (2022)

