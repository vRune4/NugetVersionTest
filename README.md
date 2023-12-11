# NugetVersionTest

This repository contains a test nuget project complete with a CI/CD pipeline and automatic versioning.

[GitVersion](https://gitversion.net/) handles automatic versioning. 

The current [configuration](GitVersion.yml) runs in mainline mode. Versions are bumped by including "+semver: major|minor" in a commit message.

A new version of the nuget package is built and released as pull requests are merged with main.