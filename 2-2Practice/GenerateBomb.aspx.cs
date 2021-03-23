using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2Practice
{
    public partial class GenerateBomb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] ia_Bomb = new int[10] { 0, 7, 13, 28, 44, 62, 74, 75, 87, 90 };
            int i_Row = -1;
            int i_Col = -1;
            int[,] ia_2DMap = new int[10, 10];

            for (int i_Ct = 0; i_Ct < ia_Bomb.Length; i_Ct++)
            {
                mt_GetRowCol(ref i_Row, ref i_Col, ia_Bomb[i_Ct]);
                ia_2DMap[i_Row, i_Col] = -1;
            }


            for (int i_Ct = 0; i_Ct < ia_Bomb.Length; i_Ct++)
            {
                mt_AddNumber(ia_Bomb[i_Ct], ref ia_2DMap);
            }
            mt_ShowMap(ref ia_2DMap);
            }
        }
    }