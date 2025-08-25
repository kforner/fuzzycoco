cmake_minimum_required(VERSION 3.16)
project(fuzzycoco_release VERSION 1.0 LANGUAGES C CXX)

set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED True)
set(CMAKE_CXX_FLAGS "-O2")
add_subdirectory(../src .bin)
