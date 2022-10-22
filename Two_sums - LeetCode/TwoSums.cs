
int[] nums = new int[] { 3, 2, 3 };
int target = 6;
TwoSum(nums, target);

int[] TwoSum(int[] nums, int target)
{
    var res = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums.Length >= 3)
        {
            if (i < target)
            {
                var complement = target - nums[i];
                if (complement < target)
                {
                    for (int s = 0; s < nums.Length; s++)
                    {
                        if (complement == nums[s])
                        {
                            res[0] = i;
                            res[1] = s;
                        }

                    }
                }
            }
        }
        else if (nums.Length <= 2)
        {
            return res = new int[] { 0, 1 };
        }

    }
    return res;
}


