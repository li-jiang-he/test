using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;
public class FileStreamOperation : MonoBehaviour {

	// Use this for initialization
    private string strPath;//路径
    private string strName;//名字
    private string strFile;//路径

	void Start () {
        string path = "";
        if (Application.platform == RuntimePlatform.Android)
        {
            path = Application.persistentDataPath;
        }
        else if (Application.platform == RuntimePlatform.WindowsPlayer)
        {
            path = Application.dataPath;
        }
        else if (Application.platform == RuntimePlatform.WindowsEditor)
        {
            path = Application.dataPath;
        }

       
	}
   
    public void InitFile(string fileName)
    {
        string path = "";
        if (Application.platform == RuntimePlatform.Android)
        {
            path = Application.persistentDataPath;
        }
        else if (Application.platform == RuntimePlatform.WindowsPlayer)
        {
            path = Application.dataPath;
        }
        else if (Application.platform == RuntimePlatform.WindowsEditor)
        {
            path = Application.dataPath;
        }

        path = Application.dataPath;
        int len = path.LastIndexOf("/");
        strFile = path.Substring(0, len + 1) + fileName;

        Debug.Log(" InitFile;" + strFile);
    }
    public void writeFile(string info)
    {
        StreamWriter sw;
        Debug.Log(" fileOperation.writeFile(sss);" + strFile);
        FileInfo t = new FileInfo(strFile);
  
            sw = t.CreateText();
      
        UnityEngine.Debug.Log("WriteLine   " + info);
        sw.WriteLine(info);
        sw.Close();
        sw.Dispose();
    }
 
    public string readFile()
    {
      
        FileInfo t = new FileInfo(strFile);
        if (!t.Exists)
        {
            return "error";
        }
        StreamReader sr = null;
        sr = File.OpenText(strFile);
        string line;
        while ((line = sr.ReadToEnd()) != null)
        {
           
            break;
        }
        sr.Close();
        sr.Dispose();
        return line;
    }
    public string[] readFileLines()
    {

        FileInfo t = new FileInfo(strFile);
        if (!t.Exists)
        {
            //return "error";
        }
        StreamReader sr = null;
        sr = File.OpenText(strFile);
        string[] arrayString = { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
        string line;
        int index = 0;
        while ((line = sr.ReadLine()) != null)
        {
            arrayString[index] = line;
      
            index++;
            if(index >15)
            break;
        }
        sr.Close();
        sr.Dispose();
        return arrayString;
    }     
	// Update is called once per frame
	void Update () {
	
	}
}
