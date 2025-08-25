# makefile that wraps the cmake-based build system

clean: coverage/clean
	rm -rf .build CMakeCache.txt CMakeFiles/ *.cmake _deps bin

# build the FUGE-LC executable and copy it into bin/
build:
	mkdir -p .build
	cd .build && cmake .. && make -j 4 

test:
	cd .build/tests/unit && ctest

test/memcheck:
	cd .build/tests/unit && ctest --verbose --memcheck --overwrite MemoryCheckCommandOptions="--leak-check=full --error-exitcode=1"

debug:
	cd .build/tests/unit && ctest --rerun-failed --output-on-failure

verbose:
	cd .build/tests/unit && ctest -V

coverage/info:
	mkdir -p .coverage
	lcov --capture --directory . --output-file .coverage/coverage.info

coverage/html:
	genhtml .coverage/coverage.info --output-directory .coverage	

coverage: test coverage/info coverage/html

coverage/clean:
	rm -rf .coverage

install:
	mkdir -p bin
	cp .build/src/*.exe bin/