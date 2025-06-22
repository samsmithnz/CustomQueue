# CustomQueue

An experimental C# library that implements a custom queue collection, similar to the built-in `Queue<T>`, designed for extending queue behaviors with custom logic. This library focuses particularly on enabling custom dequeue behavior, allowing developers to modify how items are retrieved from the queue while maintaining the standard FIFO (First-In-First-Out) queue interface.

The CustomQueue provides the same basic functionality as the standard .NET Queue collection but with the flexibility to add custom logic during dequeue operations, making it useful for scenarios where specialized queue processing is required.

[![CI/CD](https://github.com/samsmithnz/CustomQueue/actions/workflows/dotnet.yml/badge.svg)](https://github.com/samsmithnz/CustomQueue/actions/workflows/dotnet.yml)
[![Coverage Status](https://coveralls.io/repos/github/samsmithnz/CustomQueue/badge.svg?branch=main)](https://coveralls.io/github/samsmithnz/CustomQueue?branch=main)
[![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=samsmithnz_CustomQueue&metric=code_smells)](https://sonarcloud.io/summary/new_code?id=samsmithnz_CustomQueue)
[![Current Release](https://img.shields.io/github/release/samsmithnz/CustomQueue/all.svg)](https://github.com/samsmithnz/CustomQueue/releases)
