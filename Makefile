# makefile that wraps the cmake-based build system

clean: coverage/clean
	rm -rf .build CMakeCache.txt CMakeFiles/ *.cmake _deps bin

# build the FUGE-LC executable and copy it into bin/
build:
	cmake  -S . -B .build
	cmake --build .build/ -j 4

test:
	ctest --test-dir .build/tests/unit/ --output-on-failure -j 4

test/rerun-failed:
	ctest --test-dir .build/tests/unit/ --output-on-failure --rerun-failed

test/junit:
	ctest --test-dir .build/tests/unit/ --output-junit ../../../junit.xml

test/memcheck:
	ctest --test-dir .build/tests/unit --verbose --memcheck --overwrite MemoryCheckCommandOptions="--leak-check=full --error-exitcode=1"

debug:
	ctest --test-dir .build/tests/unit --rerun-failed --output-on-failure

verbose:
	ctest --test-dir .build/tests/unit  -V

COVERAGE_INFO=.coverage/coverage.info
coverage/info:
	mkdir -p .coverage
	rm -f $(COVERAGE_INFO)
	lcov --capture --base-directory .build/src --directory .build/src --filter brace --rc genhtml_exclude_lines="};" --output-file $(COVERAGE_INFO)
	# Remove external/irrelevant directories
	lcov --remove $(COVERAGE_INFO) '/usr/*' '\d*' '*/tests/*' 'tests/*' --ignore-errors unused --output-file $(COVERAGE_INFO)
	lcov --list $(COVERAGE_INFO)

coverage/html:
	genhtml .coverage/coverage.info --output-directory .coverage

coverage: test coverage/info coverage/html

coverage/clean:
	rm -rf .coverage

install:
	mkdir -p bin
	cp .build/src/*.exe bin/