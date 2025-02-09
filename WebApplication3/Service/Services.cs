using System;
using System.Collections.Generic;
using WebApplication3.Model;

namespace WebApplication3.Service
{
    public static class Services
    {
        public static APiReponse GetMoview(dynamic? searchbyTittle = null)
        {
            List<Moview> m = new List<Moview>();
            Moview? moview = null;
            moview = new Moview
            {
                MovId = 901,
                MovDateRel = new DateTime(1958, 08, 24),
                MovLang = "Englis",
                MovRelCountry = "UK",
                MovTime = 128,
                MovTittle = "Vertigo",
                MovYear = 1958
            };
            m.Add(moview);
            moview = new Moview
            {
                MovId = 902,
                MovDateRel = new DateTime(1962, 02, 19),
                MovLang = "Englis",
                MovRelCountry = "SW",
                MovTime = 100,
                MovTittle = "The Innocents",
                MovYear = 1961
            };
            m.Add(moview);
            moview = new Moview
            {
                MovId = 903,
                MovDateRel = new DateTime(1962, 12, 11),
                MovLang = "Englis",
                MovRelCountry = "UK",
                MovTime = 216,
                MovTittle = "Lawrence of Arabia",
                MovYear = 1962
            };
            m.Add(moview);
            moview = new Moview
            {
                MovId = 904,
                MovDateRel = new DateTime(1979, 03, 08),
                MovLang = "Englis",
                MovRelCountry = "UK",
                MovTime = 216,
                MovTittle = "The Deer Hunter",
                MovYear = 1978
            };
            m.Add(moview);
            moview = new Moview
            {
                MovId = 905,
                MovDateRel = new DateTime(1985, 01, 07),
                MovLang = "Englis",
                MovRelCountry = "UK",
                MovTime = 216,
                MovTittle = "Blade Runner",
                MovYear = 1978
            };
            m.Add(moview);
            APiReponse api = new APiReponse();
            api.moview = m;
            if (searchbyTittle != null)
            {
                m = m.Where(x => x.MovTittle.ToLower().Contains(searchbyTittle.ToLower())).ToList();
                var moviewCast = GetMoviewCast(0, m.Select(x => x.MovId).FirstOrDefault());
                var actorlist = GetActor().actor.Where(x=>x.ActId==moviewCast.Select(x=>x.ActId).FirstOrDefault()).ToList();
                var movDir = GetMoviewDir(moviewCast.Select(x => x.Movid).FirstOrDefault());
                var dirList = GetDirector().dire.Where(x=>x.Dirid== movDir.Select(x => x.Dirid).FirstOrDefault());
                api.actor = actorlist;
                api.moview = m;
                api.dire = dirList.ToList();
            }


            return api;
        }
        public static APiReponse GetActor(string? searchbyTittle = null)
        {
            List<Actor> m = new List<Actor>();
            Actor? actor = null;
            actor = new Actor
            {
                ActId = 101,
                ActFName = "c",
                ACtLname = "Stewart",
                Actgenger = 'M'
            };
            m.Add(actor);
            actor = new Actor
            {
                ActId = 102,
                ActFName = "Deborah",
                ACtLname = "Kerr",
                Actgenger = 'F'
            };
            m.Add(actor);
            actor = new Actor
            {
                ActId = 103,
                ActFName = "Peter",
                ACtLname = "OToole",
                Actgenger = 'M'
            };
            m.Add(actor);
            actor = new Actor
            {
                ActId = 104,
                ActFName = "Robert",
                ACtLname = "De Niro",
                Actgenger = 'M'
            };
            m.Add(actor);
            actor = new Actor
            {
                ActId = 105,
                ActFName = "F. Murray  ",
                ACtLname = "Abraham",
                Actgenger = 'M'
            };
            m.Add(actor);
            APiReponse api = new APiReponse();
            api.actor = m;
            if (searchbyTittle != null)
            {
                 m = m.Where(x => x.ActFName.ToLower().Contains(searchbyTittle.ToLower())).ToList();
                if(m.Count()==0)
                    m = m.Where(x => x.ACtLname.ToLower().Contains(searchbyTittle.ToLower())).ToList();

                var moviewCast = GetMoviewCast(m.Select(x => x.ActId).FirstOrDefault()).ToList();
                //var actorlist = mo().actor.Where(x => x.ActId == moviewCast.Select(x => x.ActId).FirstOrDefault()).ToList();
                var movDir = GetMoviewDir(moviewCast.Select(x => x.Movid).FirstOrDefault());
                var dirList = GetDirector().dire.Where(x=>x.Dirid== movDir.Select(x => x.Dirid).FirstOrDefault());
                var moviewlist = GetMoview().moview.Where(x=>x.MovId==movDir.Select(x=>x.MovId).FirstOrDefault()).ToList();
                 api.actor = m;
                api.dire = dirList.ToList();
                api.moview = moviewlist;
            }

            return api;
        }
        public static APiReponse GetDirector(string? searchbyTittle = null)
        {
            List<Director> m = new List<Director>();
            Director? dir = null;
            dir = new Director
            {
                Dirid = 201,
                DirFname = "Alfred",
                DirLname = "Hitchcock",
            };
            m.Add(dir);
            dir = new Director
            {
                Dirid = 202,
                DirFname = "Jack",
                DirLname = "Clayton",
            };
            m.Add(dir);
            dir = new Director
            {
                Dirid = 203,
                DirFname = "David",
                DirLname = "Lean",
            };
            m.Add(dir);
            dir = new Director
            {
                Dirid = 204,
                DirFname = "Michael",
                DirLname = "Cimino",
            };
            m.Add(dir);
            dir = new Director
            {
                Dirid = 205,
                DirFname = "Milos",
                DirLname = "Forman",
            };
            m.Add(dir);
            APiReponse api = new APiReponse();
            api.dire = m;
            if (searchbyTittle != null)
            {
              
                m = m.Where(x => x.DirFname.ToLower().Contains(searchbyTittle.ToLower())).ToList();
                if (m.Count == 0)
                    m = m.Where(x => x.DirLname.ToLower().Contains(searchbyTittle.ToLower())).ToList();

                //var actorlist = mo().actor.Where(x => x.ActId == moviewCast.Select(x => x.ActId).FirstOrDefault()).ToList();
                var movDir = GetMoviewDir(0,m.Select(x => x.Dirid).FirstOrDefault());
               // var dirList = GetDirector().dire.Where(x => x.Dirid == movDir.Select(x => x.Dirid).FirstOrDefault());
                var moviewlist = GetMoview().moview.Where(x => x.MovId == movDir.Select(x => x.MovId).FirstOrDefault()).ToList();
               var movCast=GetMoviewCast().Where(x=>x.Movid==movDir.Select(x=>x.MovId).FirstOrDefault()).ToList();
                var actor = GetActor().actor.Where(x => x.ActId == movCast.Select(x => x.ActId).FirstOrDefault()).ToList();
                
                api.dire = m;
                api.actor =actor;
                api.moview = moviewlist;


            }
            return api;
        }
        public static List<MovieCast> GetMoviewCast(int actid = 0, int MovId = 0)
        {
            List<MovieCast> m = new List<MovieCast>();
            MovieCast? mc = null;
            mc = new MovieCast
            {
                Movid = 901,
                ActId = 101,
                Role = "John Scottie Ferguson",
            };
            m.Add(mc);
            mc = new MovieCast
            {
                Movid = 902,
                ActId = 102,
                Role = "Miss Giddens",
            };
            m.Add(mc);
            mc = new MovieCast
            {
                Movid = 903,
                ActId = 103,
                Role = "T.E. Lawrence",
            };
            m.Add(mc);
            mc = new MovieCast
            {
                Movid = 904,
                ActId = 104,
                Role = "Michael",
            };
            m.Add(mc);
            mc = new MovieCast
            {
                Movid = 905,
                ActId = 105,
                Role = "Antonio Salieri",
            };
            m.Add(mc);
            if (MovId > 0)
            {
                m = m.Where(x => x.Movid == MovId).ToList();
            }
            if (actid > 0)
            {
                m = m.Where(x => x.ActId == actid).ToList();
            }
            return m;
        }
        public static List<MovieDirection> GetMoviewDir(int movId = 0, int dirId = 0)
        {
            List<MovieDirection> dir = new List<MovieDirection>();
            MovieDirection? md = null;
            md = new MovieDirection
            {
                MovId = 901,
                Dirid = 201
            };
            dir.Add(md);
            md = new MovieDirection
            {
                MovId = 902,
                Dirid = 202
            };
            dir.Add(md);
            md = new MovieDirection
            {
                MovId = 903,
                Dirid = 203
            };
            dir.Add(md);
            md = new MovieDirection
            {
                MovId = 904,
                Dirid = 204
            };
            dir.Add(md);
            md = new MovieDirection
            {
                MovId = 905,
                Dirid = 205
            };
            dir.Add(md);
            if (movId > 0)
            {
                dir = dir.Where(x => x.MovId == movId).ToList();
            }
            if (dirId > 0)
            {
                dir = dir.Where(x => x.Dirid == dirId).ToList();
            }
            return dir;
        }

        //public static T getList<T>(string kyename)
        //{


        //    var moviewList = GetMoview(kyename);
        //    if (moviewList.Count() > 0)
        //        return (T)Convert.ChangeType(moviewList, typeof(T));
        //    else 
        //    {   
        //        var actorlist = GetActor(kyename);
        //        if (actorlist!=null && actorlist.Count() > 0)
        //            return (T)Convert.ChangeType(actorlist, typeof(T));
        //        else
        //        {
        //            var direlist = GetActor(kyename);
        //            if (direlist.Count() > 0)
        //                return (T)Convert.ChangeType(direlist, typeof(T));
        //        }
        //    }


        //    return (T)Convert.ChangeType(null, typeof(T));
        //}

    }

}
