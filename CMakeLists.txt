cmake_minimum_required(VERSION 3.1.0)

project(TTKEditor VERSION 1.0.0 LANGUAGES CXX)

if (WIN32)
	set (CMAKE_PREFIX_PATH "C:\\Qt\\5.15.2\\msvc2019_64\\")
endif(WIN32)

set(CMAKE_CXX_STANDARD 11)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

set(CMAKE_AUTOMOC ON)
set(CMAKE_AUTORCC ON)
set(CMAKE_AUTOUIC ON)

if(CMAKE_VERSION VERSION_LESS "3.7.0")
    set(CMAKE_INCLUDE_CURRENT_DIR ON)
endif()

find_package(Qt5 COMPONENTS Widgets REQUIRED)

add_subdirectory(src)

install(TARGETS TTKEditor)

