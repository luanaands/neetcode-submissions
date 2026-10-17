public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var complement = 0;
        var sum = new Dictionary<int, int>();
        for(var i = 0; i < nums.Length;i++){
            complement = target - nums[i];
            Console.WriteLine(complement);
            if(sum.ContainsKey(target - complement)){
                return [sum[target - complement], i];
            } 
            sum.TryAdd(complement,i);
        }
        return [];
    }
}
