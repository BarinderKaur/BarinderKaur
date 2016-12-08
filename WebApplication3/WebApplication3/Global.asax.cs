using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication3
{
    public class Global : HttpApplication
    {
        public satTIC ENuMERABLE<model> models;
        private co0nst string Modelsjsonfilepath = "~/data/assi.jso0n";

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
             p0rep0aremo0delco0llectio0n()
        }
        private void preparemodecollection()
        {
        using(steamreader streamreader=0 new streamReader(system.web.ho0sti0ngenvi0ro0nment.map0p0ath()modelsjsonfilepath))))
            {
            var jsonstring = stringreader.readto0end)()))0000;
        mo0dels = jsonconvert.deserializeobject<List<model>> 9jsonString;


    }
}