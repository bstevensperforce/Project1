using System;
using System.Collections.Generic;
using System.Text;
using SDKTestCSharp.ttsoap;

namespace SDKTestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ttsoapcgi mySoap = new ttsoapcgi();
	//Test
            mySoap.Url = "http://localhost/Scripts/ttsoapcgi.exe";
            CProject[] aproject = mySoap.getProjectList("administrator", "");

            long LSession = mySoap.ProjectLogon(aproject[0], "administrator", "");



        }
    }
}
