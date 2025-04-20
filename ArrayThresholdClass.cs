class HelloWorld {
    
    /*
    Given a list of integers and desiredSum, find the threshold value such that if we replace all the values in the input list which are greater then threshold value with the threshold value then the sum of the list should be equal to the desired sum. Testcase 1 in = [2,1,5] desiredSum = 6 output = 3 Testcase 2 in = [2,1,5] desiredSum = 2 output = 0.67 Testcase 3 in = [2,1,5] desiredSum = 4 output = 1.5 Testcase 4 in = [2,1,5] desiredSum = 1 output = 0.33
    */
    static void Main() {
        int[] nums = [2,1,5];
        
        Console.WriteLine(FindThreshold(nums, 6));
        Console.WriteLine(FindThreshold(nums, 2));
        Console.WriteLine(FindThreshold(nums, 4));
        Console.WriteLine(FindThreshold(nums, 1));
    }
    
    static float FindThreshold(int[] nums, int desiredSum){
        if(nums == null || nums.Length == 0 || desiredSum == 0){
            return 0;
        }
        
        Array.Sort(nums);
        float n = nums.Length;
        float initialThreshold = desiredSum / n;
        
        for(int i = 0; i< n; i++){
            if(initialThreshold > nums[i]){
                float diff = initialThreshold - nums[i];
                initialThreshold = initialThreshold + (diff / (n - i - 1));
            }
            else{
                break;
            }
        }
        return initialThreshold;
    }
}