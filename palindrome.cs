using System;

class Palindrome

    static void Main()
    {
        bool solution(string inputString) {
        int left = 0;
        int right = inputString.Length - 1;

        while (left < right)
                {
                    if (inputString[left] != inputString[right])
                    {
                        return false;
                    }

                    left++;
                    right--;
                }

                return true;
}}