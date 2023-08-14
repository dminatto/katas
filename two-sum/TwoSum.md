# Two Sum

The Two Sum problem is a classic coding interview question that involves finding two numbers in an array that add up to a specific target sum. 

## Problem Statement

Given an array of integers `nums` and an integer `target`, return indices of the two numbers such that they add up to the target sum. You may assume that each input would have exactly one solution, and you may not use the same element twice.

## Solution

The solution provided here uses a hash map (dictionary) to store the values and their corresponding indices as we traverse through the array. For each element `num` in the array, we check if `target - num` exists in the dictionary. If it does, we have found the pair that adds up to the target sum. If not, we add `num` and its index to the dictionary and continue.

## Exemples

### Example 1
    Input: nums = [2,7,11,15], target = 9
    Output: [0,1]
    Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

### Example 2
    Input: nums = [3,2,4], target = 6
    Output: [1,2]

### Example 3
    Input: nums = [3,3], target = 6
    Output: [0,1]

