using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaGithub
{
    class Carlos
    {
        #region Constructores
        public Carlos() {}
        public Carlos(String fG, String mBWFM, String fTS, int lN)
        {
            this.favoriteGroup = fG;
            this.mostBeautifulWomenForMe = mBWFM;
            this.favoriteTvShow = fTS;
            this.luckyNumber = lN;
        }
#endregion

        private String favoriteGroup;

        public String FavoriteGroup
        {
            get { return favoriteGroup; }
        }
        private String mostBeautifulWomenForMe;

        public String MostBeautifulWomenForMe
        {
            get { return mostBeautifulWomenForMe; }
        }
        private String favoriteTvShow;

        public String FavoriteTvShow
        {
            get { return favoriteTvShow; }
        }
        private int luckyNumber;

        public int LuckyNumber
        {
            get { return luckyNumber; }
        }
    }
}
