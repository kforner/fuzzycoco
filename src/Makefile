# makefile that wraps the cmake-based build system

clean:
	rm -rf .build CMakeCache.txt CMakeFiles/ *.cmake _deps

# build the FUGE-LC executable and copy it into bin/
build:
	mkdir -p .build bin
	cd .build && cmake .. && make -j 4 


