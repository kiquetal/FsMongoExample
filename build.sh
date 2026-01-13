#!/bin/bash
# Builds the project in Release mode and outputs artifacts to the ./publish directory
dotnet publish -c Release -o ./publish
