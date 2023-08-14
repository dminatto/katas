/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
const twoSum = (nums, target) => {

    const n = nums.length;
    for(let i = 0; i < n; i++) {
        for(let j = i + 1; j < n; j++) {
            if((nums[i] + nums[j]) === target) {
                return [i,j];
            }
        
        }
    }
};

console.log(twoSum([2,7,11,15], 9));
console.log(twoSum([3,2,4], 6));
console.log(twoSum([3,3], 6));