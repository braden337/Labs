# Table of Contents

- [Example Labs](#example-labs)
  - [Getting Started](#getting-started)
  - [Organization](#organization)
  - [Submitting](#submitting)
- [Lab 1: FizzBuzz](#lab-1-fizzbuzz)
- [Lab 2: FizzBuzz (continued)](#lab-2-fizzbuzz-continued)
- [Lab 3: Fibonacci](#lab-3-fibonacci)

# Example Labs

This is where you will keep your lab work for this course. If you need a
refresher on git, see
[this high-level](https://rogerdudler.github.io/git-guide/) git guide.

## Getting Started

Clone this repository to your computer.

```shell
git clone https://github.com/braden337/Labs.git
```

From the `master` branch, make a new orphan branch for yourself (use your first
name with the number zero) and then delete `README.md`.

```shell
git checkout --orphan firstname-0
git rm -f README.md
```

Commit your changes, and push this to remote.

```shell
git add .gitignore
git commit -m "Ignore Visual Studio files"
git push origin firstname-0
```

Now make another new branch from the one you just created, use your first name
again and increment the number.

```shell
git checkout -b firstname-1
```

You don't need the `master` or `firstname-0` branch locally anymore, so you can
delete them.

```shell
git branch -d firstname-0
git branch -d master
```

## Organization

Let's use Lab 1: FizzBuzz as an example. In Visual Studio, create a new .NET
Core console app named `FizzBuzz` and save it at the root of this repository.

Your repository should now look like this.

```shell
.gitignore
FizzBuzz/
```

## Submitting

Once you've made all your commits to complete the lab, push your `firstname-1`
branch to remote.

```shell
git push origin `firstname-1`
```

Then you can create a pull request on GitHub comparing your two consecutive
branches.

- Lab 1 is `firstname-0` compared to `firstname-1`
- Lab 2 is `firstname-1` compared to `firstname-2`
- Lab 3 is `firstname-2` compared to `firstname-3`
- ...

Make sure you give the pull request a title that makes sense (e.g. Firstname:
Lab 1).

You can ask your peers to review the code in your pull request, give feedback
(comments in the pull request), but there is no need to merge any of these.

Now that you've made your pull request, get things ready for the next lab. From
`firstname-1`, check out a new branch.

```shell
git branch -b firstname-2
```

You can delete the previous branch because you're done with it now.

```shell
git branch -d firstname-1
```

I will close each pull request once I've looked at it and updated your grade in
mylearning.

# Lab 1: FizzBuzz

From 1 to 100:

- print Fizz for numbers that are divisible 3
- print Buzz for numbers that are divisible by 5
- print FizzBuzz for numbers that are divisible by 3 and 5
- otherwise print the number

Example for 7 to 15:

```text
7
8
Fizz
Buzz
11
Fizz
13
14
FizzBuzz
```

# Lab 2: FizzBuzz (continued)

View my solution to Lab 1 in the `Solutions/` folder.

Modify your FizzBuzz program from Lab 1 to _count down from 100_ instead of
counting up to 100.

# Lab 3: Fibonacci

Write a program that prints the first 15 Fibonacci numbers.

Example:

```text
0
1
1
2
3
5
8
```
