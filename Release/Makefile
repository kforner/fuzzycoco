# makefile that wraps the cmake-based build system

TOPLEVEL=..

# build and install the executable and libs in bin/
all: build install

clean: 
	rm -rf .build CMakeCache.txt CMakeFiles/ *.cmake _deps bin .bin

# build and compile the libs and executable
build:
	mkdir -p .build
	cd .build && cmake .. && make -j 4 

# copy the libs and exe to ./bin/

BIN=$(TOPLEVEL)/bin

install:
	mkdir -p $(BIN)
	cp .build/.bin/*fuzzycoco* $(BIN)

quick-test:
	$(MAKE) -s -C $(TOPLEVEL)/tests/e2e tests
