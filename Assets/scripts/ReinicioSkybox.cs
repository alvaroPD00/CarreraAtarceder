using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReinicioSkybox : MonoBehaviour
{
    [Header("Material del Skybox (tipo Procedural)")]
    public Material skyboxMaterial; // Material que debe estar asignado en RenderSettings

    [Header("Parámetros para el Skybox")]
    [Range(0f, 1f)] public float sunSize = 0.04f;
    [Range(0.0f, 5.0f)] public float atmosphereThickness = 1.0f;
    [Range(0.0f, 8.0f)] public float exposure = 1.3f;

    private void OnEnable()
    {
        ReiniciarSkybox();
    }

    private void ReiniciarSkybox()
    {
        if (skyboxMaterial == null)
        {
            Debug.LogError("ReinicioSkybox: No se asignó ningún material en el Inspector.");
            return;
        }

        RenderSettings.skybox = skyboxMaterial;

        Material activo = RenderSettings.skybox;

        activo.SetFloat("_SunSize", sunSize);
        activo.SetFloat("_AtmosphereThickness", atmosphereThickness);
        activo.SetFloat("_Exposure", exposure);

        DynamicGI.UpdateEnvironment();

        Debug.Log("Skybox reiniciado con valores definidos desde el Inspector.");
    }



}
