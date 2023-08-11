11 - Given an array of characters chars, compress it using the following algorithm:

Begin with an empty string s. For each group of consecutive repeating characters in chars:

If the group's length is 1, append the character to s.
Otherwise, append the character followed by the group's length.

Return the compressed string.

Example 1:

Input: chars = ["a","a","b","b","c","c","c"]
Output: Return ["a","2","b","2","c","3"] or "a2b2c3"
Explanation: The groups are "aa", "bb", and "ccc". This compresses to "a2b2c3".

Example 2:

Input: chars = ["a"]
Output: Return ["a"] or "a"
Explanation: The only group is "a", which remains uncompressed since it's a single character.

Example 3:

Input: chars = ["a","b","b","b","b","b","b","b","b","b","b","b","b"]
Output: Return ["a","b","1","2"] or "ab12"
Explanation: The groups are "a" and "bbbbbbbbbbbb". This compresses to "ab12". 

Example 4:

Input: chars = ["a","a","b","b","c","c","c","a","a","a"]
Output: Return ["a","2","b","2","c","3","a","3"] or "a2b2c3a3"
Explanation: The groups are "aa", "bb", "ccc" and "aaa". This compresses to "a2b2c3a3".