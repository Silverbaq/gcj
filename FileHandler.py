#!/bin/python

f = open('file.txt', 'r')
print f.read()

file = open('file2.txt', 'w')
file.write(f.read())
file.close