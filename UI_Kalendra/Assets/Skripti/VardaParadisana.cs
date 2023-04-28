using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Nepieciešams, lai strādātu ar UI elementiem
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour
{
	private string teksts;
	string teksts2;
	//lauks, kurā ievada tekstu
	public GameObject ievadesLauks;
	public GameObject ievadesLauks2;
	//text objekts, kurā attēlos tekstu pēc pogas nospiešanas
	public GameObject tekstaAttelosana;

	//masīvs ar iespējamajiem teksta sākumiem
	private string[] varianti = {"Goblini sauc ", "Goblins: ",
		"Goblins  ", "Uzredzēšanos "};
   
    //mainīgais uzglabās random skaitli
    int nejausais;


	public void NolasitTekstu()
	{
		teksts = ievadesLauks.GetComponent<Text>().text;
		teksts2 = ievadesLauks2.GetComponent<Text>().text;

		nejausais = Random.Range(0, varianti.Length);
		tekstaAttelosana.GetComponent<Text>().text =
			varianti[nejausais] + "" +teksts+ " ir " + teksts2+" gadu vecs!";

	}
}