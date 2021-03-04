# Table of Contents

- [Example Labs](#example-labs)
  - [Getting Started](#getting-started)
  - [Organization](#organization)
  - [Submitting](#submitting)
  - [Rebase with `master`](#rebase-with-master)
- [Lab 1: FizzBuzz](#lab-1-fizzbuzz)
- [Lab 2: FizzBuzz (continued)](#lab-2-fizzbuzz-continued)
- [Lab 2: Fibonacci](#lab-3-fibonacci)

# Example Labs

This is where you will keep all of our lab work for this course. If you need a
refresher on git, see
[this high-level](https://rogerdudler.github.io/git-guide/) git guide.

## Getting Started

Clone this repository to your computer.

```shell
git clone https://github.com/braden337/Labs.git
```

From the `master` branch, make a new orphan branch for yourself (you can use
your first name) and then delete `README.md`.

```shell
git checkout --orphan firstname
git rm -f README.md
```

Commit your changes, and push this to remote.

```shell
git add .gitignore
git commit -m "Ignore Visual Studio files"
git push origin firstname
```

Now make another new branch from the one you just created, use your first name
again but append the lab number you're working on like `-1`.

```shell
git checkout -b firstname-1
```

You don't need the `master` or `firstname` branch locally anymore, so you can
delete them.

```shell
git branch -d firstname
git branch -d master
```

## Organization

Let's use Lab 1: FizzBuzz as an example. In Visual Studio, create a new .NET
Core console app named FizzBuzz and save it at the root of this repository.

Your repository should look like this.

```shell
.gitignore
FizzBuzz/
```

## Submitting

Once you've completed the lab, push your `firstname-1` branch to remote.

```shell
git push -u origin `firstname-1`
```

Then you can create a pull request on GitHub comparing your two branches (e.g.
`firstname` compared to `firstname-1`).

Make sure you give the pull request a title that makes sense (e.g. Firstname:
Lab 1).

You can ask your peers to review the code in your pull request, give feedback
(comments in the pull request), or approve the merge into your `firstname`
branch.

Now that you've made your pull request, get things ready for the next lab. Make
a new branch from your `firstname-1` that you just finished with.

```shell
git branch -b firstname-2
```

And you can also delete the previous branch because you're done with it now.

```shell
git branch -d firstname-1
```

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
