# makefile that wraps the cmake-based build system



clean: 
	rm -rf .build CMakeCache.txt CMakeFiles/ *.cmake _deps bin .bin

# build the FUGE-LC executable and copy it into bin/
build:
	mkdir -p .build
	cd .build && cmake .. && make -j 4 

install:
	mkdir -p bin
	cp .build/.bin/fuzzycoco*.exe bin/
