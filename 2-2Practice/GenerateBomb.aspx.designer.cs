﻿//------------------------------------------------------------------------------
// <自動產生的>
//     這段程式碼是由工具產生的。
//
//     變更這個檔案可能會導致不正確的行為，而且如果已重新產生
//     程式碼，則會遺失變更。
// </自動產生的>
//------------------------------------------------------------------------------

namespace _2_2Practice {


    public partial class GenerateBomb {

        /// <summary>
        /// form1 控制項。
        /// </summary>
        /// <remarks>
        /// 自動產生的欄位。
        /// 若要修改，請將欄位宣告從設計工具檔案移到程式碼後置檔案。
        /// </remarks>
        protected global::System.Web.UI.HtmlControls.HtmlForm form1;

        void mt_GetRowCol(ref int ir_Row, ref int ir_Col, int i_Ind) {
            ir_Row = i_Ind / 10;
            ir_Col = i_Ind % 10;
        }

        void mt_ShowMap(ref int[,] ia_2DMap) {
            for (int i_Ct = 0; i_Ct < 10; i_Ct++) {
                for (int i_Ct2 = 0; i_Ct2 < 10; i_Ct2++) {
                    if (ia_2DMap[i_Ct, i_Ct2] == -1) {
                        Response.Write("*");
                    }
                    else if (ia_2DMap[i_Ct, i_Ct2] == 0) {
                        Response.Write("&nbsp;");
                    }
                    else {
                        Response.Write(ia_2DMap[i_Ct, i_Ct2]);
                    }                    
                }
                Response.Write("<br />");
            }
        }

        void mt_AddNumber(int i_Ind, ref int[,] ia_2DMap) {
            int i_Row = i_Ind / 10;
            int i_Col = i_Ind % 10;

            if ((i_Row - 1) >= 0 && (i_Col - 1) >= 0) {
                ia_2DMap[(i_Row - 1), (i_Col - 1)]++;
            }

            if ((i_Row - 1) >= 0 && (i_Col) >= 0) {
                ia_2DMap[(i_Row - 1), i_Col]++;
            }

            if ((i_Row - 1) >= 0 && (i_Col + 1) < 10) {
                ia_2DMap[(i_Row - 1), (i_Col + 1)]++;
            }

            if ((i_Row) >= 0 && (i_Col - 1) >= 0) {
                ia_2DMap[(i_Row), (i_Col - 1)]++;
            }

            if ((i_Row) >= 0 && (i_Col + 1) < 10) {
                ia_2DMap[(i_Row), (i_Col + 1)]++;
            }

            if ((i_Row + 1) < 10 && (i_Col - 1) >= 0) {
                ia_2DMap[(i_Row + 1), (i_Col - 1)]++;
            }

            if ((i_Row + 1) < 10 && (i_Col) >= 0) {
                ia_2DMap[(i_Row + 1), (i_Col)]++;
            }

            if ((i_Row + 1) < 10 && (i_Col + 1) < 10) {
                ia_2DMap[(i_Row + 1), (i_Col + 1)]++;
            }
        }
    }
}
