using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour
{
    [SerializeField] InputField adresse;
    [SerializeField] ToggleGroup genre;
    [SerializeField] InputField secteur;
    [SerializeField] InputField fonction;
    [SerializeField] InputField organisme;
    [SerializeField] InputField siteWeb;
    [SerializeField] InputField objetDeLaVisite;
    [SerializeField] Dropdown choix;
    [SerializeField] string filename;

    List<InputEntry> entries = new List<InputEntry>();

    private void Start()
    {
        entries = FileHandler.ReadListFromJSON<InputEntry>(filename);
    }

    public void AddNameToList()
    {
        entries.Add(new InputEntry(adresse.text));
        adresse.text = "";

        Toggle toggle = genre.ActiveToggles().FirstOrDefault();
        string toggleSelectedName = toggle.GetComponentInChildren<Text>().text;
        entries.Add(new InputEntry(toggleSelectedName));

        entries.Add(new InputEntry(secteur.text));
        secteur.text = "";

        entries.Add(new InputEntry(fonction.text));
        fonction.text = "";

        entries.Add(new InputEntry(organisme.text));
        organisme.text = "";
        
        entries.Add(new InputEntry(siteWeb.text));
        siteWeb.text = "";

        entries.Add(new InputEntry(objetDeLaVisite.text));
        siteWeb.text = "";

        int index = choix.value;
        string choixSelectedValue = choix.options[index].text;
        entries.Add(new InputEntry(choixSelectedValue));

        FileHandler.SaveToJSON<InputEntry>(entries, filename);
    }
}