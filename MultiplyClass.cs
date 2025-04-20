public class Solution {

    // TC => O(m*n*p)
    // SC => O(1)
    public int[][] Multiply(int[][] mat1, int[][] mat2) {
        if(mat1 == null || mat1.Length == 0 || mat2 == null || mat2.Length == 0){
            return new int[0][];
        }

        int m = mat1.Length;
        int n = mat1[0].Length;
        int p = mat2[0].Length;
        int[][] result = new int[m][];

        for(int i = 0; i < m; i++){
            result[i] = new int[p];
        }

        for(int i = 0; i< m; i++){
            for(int k = 0; k < n; k++){
                if(mat1[i][k] == 0)
                {
                    continue;
                }
                for(int j = 0; j < p; j++){
                    if(mat2[k][j] == 0){
                        continue;
                    }
                    result[i][j] += mat1[i][k] * mat2[k][j];
                }
            }
        }

        return result;
    }
}