// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
int k = 3;

Rotate(nums, 3);
Console.ReadLine();
void Rotate(int[] nums, int k)
{
    int n = nums.Length;
    k = k % n; // In case k is greater than the length of the array

    Reverse(nums, 0, n - 1);
    Reverse(nums, 0, k - 1);
    Reverse(nums, k, n - 1);
}

void Reverse(int[] nums, int start, int end)
{
    while (start < end)
    {
        int temp = nums[start];
        nums[start] = nums[end];
        nums[end] = temp;
        start++;
        end--;
    }
}