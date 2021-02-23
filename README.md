# Introduction 
Sandbox project to manage a list of countries. Used to learn Azure, DevOps, GitHub Actions and CockroachDB

# Getting Started

1. Install CockroachDB by following instruction from https://www.cockroachlabs.com/
2. Create Country Table by using commands from Datbase->Country.txt
3. Insert entries to the Country table by using commands from Datbase->Country.txt

# Build and Test Locally

To build and test locally, do the following:

1. Clone this repository.
2. Install CockroachDB locally and populate the country table.
3. From the project directory, where .csproj resides, run from the terminal:

`docker build -t countrysandbox -f Dockerfile ..`

To test the application, run:

`docker run -it -e "CockroachDB:Host=Ip Address Here" -p 4500:80 countrysandbox`

To access the Web UI, go to http://localhost:4500