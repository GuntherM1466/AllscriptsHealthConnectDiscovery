# AllscriptsHealthConnectDiscovery

This is a sample that shows how to use the Discovery Process of Follow My Health and Allscripts Health Connect to find the OAuth 2.0 Authorization and token Access URL , as well as the FHIR URL

The discovery process returns a JSON object.

For Example
``` javascript
[{
	"authorization_endpoint": "http//pro171.fmh.open.allscripts.com/authorization/connect/authorize",
	"patient_authorization_endpoint": "https://muauthentication-uat.followmyhealth.com/api/authorize?acr_values=FhirApiID:e9a5eab3-b766-4b86-a0d2-8634311fce2c",
	"issuer": "http://pro171.open.allscripts.com",
	"token_endpoint": "http//pro171.fmh.open.allscripts.com/authorization/connect/token",
	"patient_token_endpoint": "https://muauthentication-uat.followmyhealth.com/api/access",
	"token_endpoint_auth_types_supported": null,
	"userinfo_endpoint": "https://pro171.open.allscripts.com/authorization/connect/userinfo",
	"check_id_endpoint": "",
	"registration_endpoint": "",
	"refresh_endpoint": "https://pro171.open.allscripts.com/authorization/connect/refresh",
	"fhir_endpoint": "https://pro171.open.allscripts.com/FHIR",
	"org_name": "Azure FHIR Sandbox Professional  17.1"
}]```

The data is returned as a post, because it can be very long (too long to send as a query string parameter).
The data is retuned in the Form parameter html_encoded_json_disocvery_data.
The JSon is base64 endcoded, then URL encoded

e.g.

``` javascript
html_encoded_json_disocvery_data=WwB7ACIAYQB1AHQAaABvAHIAaQB6AGEAdABpAG8AbgBfAGUAbgBkAHAAbwBpAG4AdAAiADoAIgBoAHQAdABwAC8ALwBwAHIAbwAxADcAMQAuAGYAbQBoAC4AbwBwAGUAbgAuAGEAbABsAHMAYwByAGkAcAB0AHMALgBjAG8AbQAvAGEAdQB0AGgAbwByAGkAegBhAHQAaQBvAG4ALwBjAG8AbgBuAGUAYwB0AC8AYQB1AHQAaABvAHIAaQB6AGUAIgAsACIAcABhAHQAaQBlAG4AdABfAGEAdQB0AGgAbwByAGkAegBhAHQAaQBvAG4AXwBlAG4AZABwAG8AaQBuAHQAIgA6ACIAaAB0AHQAcABzADoALwAvAG0AdQBhAHUAdABoAGUAbgB0AGkAYwBhAHQAaQBvAG4ALQB1AGEAdAAuAGYAbwBsAGwAbwB3AG0AeQBoAGUAYQBsAHQAaAAuAGMAbwBtAC8AYQBwAGkALwBhAHUAdABoAG8AcgBpAHoAZQA%252fAGEAYwByAF8AdgBhAGwAdQBlAHMAPQBGAGgAaQByAEEAcABpAEkARAA6AGUAOQBhADUAZQBhAGIAMwAtAGIANwA2ADYALQA0AGIAOAA2AC0AYQAwAGQAMgAtADgANgAzADQAMwAxADEAZgBjAGUAMgBjACIALAAiAGkAcwBzAHUAZQByACIAOgAiAGgAdAB0AHAAOgAvAC8AcAByAG8AMQA3ADEALgBvAHAAZQBuAC4AYQBsAGwAcwBjAHIAaQBwAHQAcwAuAGMAbwBtACIALAAiAHQAbwBrAGUAbgBfAGUAbgBkAHAAbwBpAG4AdAAiADoAIgBoAHQAdABwAC8ALwBwAHIAbwAxADcAMQAuAGYAbQBoAC4AbwBwAGUAbgAuAGEAbABsAHMAYwByAGkAcAB0AHMALgBjAG8AbQAvAGEAdQB0AGgAbwByAGkAegBhAHQAaQBvAG4ALwBjAG8AbgBuAGUAYwB0AC8AdABvAGsAZQBuACIALAAiAHAAYQB0AGkAZQBuAHQAXwB0AG8AawBlAG4AXwBlAG4AZABwAG8AaQBuAHQAIgA6ACIAaAB0AHQAcABzADoALwAvAG0AdQBhAHUAdABoAGUAbgB0AGkAYwBhAHQAaQBvAG4ALQB1AGEAdAAuAGYAbwBsAGwAbwB3AG0AeQBoAGUAYQBsAHQAaAAuAGMAbwBtAC8AYQBwAGkALwBhAGMAYwBlAHMAcwAiACwAIgB0AG8AawBlAG4AXwBlAG4AZABwAG8AaQBuAHQAXwBhAHUAdABoAF8AdAB5AHAAZQBzAF8AcwB1AHAAcABvAHIAdABlAGQAIgA6AG4AdQBsAGwALAAiAHUAcwBlAHIAaQBuAGYAbwBfAGUAbgBkAHAAbwBpAG4AdAAiADoAIgBoAHQAdABwAHMAOgAvAC8AcAByAG8AMQA3ADEALgBvAHAAZQBuAC4AYQBsAGwAcwBjAHIAaQBwAHQAcwAuAGMAbwBtAC8AYQB1AHQAaABvAHIAaQB6AGEAdABpAG8AbgAvAGMAbwBuAG4AZQBjAHQALwB1AHMAZQByAGkAbgBmAG8AIgAsACIAYwBoAGUAYwBrAF8AaQBkAF8AZQBuAGQAcABvAGkAbgB0ACIAOgAiACIALAAiAHIAZQBnAGkAcwB0AHIAYQB0AGkAbwBuAF8AZQBuAGQAcABvAGkAbgB0ACIAOgAiACIALAAiAHIAZQBmAHIAZQBzAGgAXwBlAG4AZABwAG8AaQBuAHQAIgA6ACIAaAB0AHQAcABzADoALwAvAHAAcgBvADEANwAxAC4AbwBwAGUAbgAuAGEAbABsAHMAYwByAGkAcAB0AHMALgBjAG8AbQAvAGEAdQB0AGgAbwByAGkAegBhAHQAaQBvAG4ALwBjAG8AbgBuAGUAYwB0AC8AcgBlAGYAcgBlAHMAaAAiACwAIgBmAGgAaQByAF8AZQBuAGQAcABvAGkAbgB0ACIAOgAiAGgAdAB0AHAAcwA6AC8ALwBwAHIAbwAxADcAMQAuAG8AcABlAG4ALgBhAGwAbABzAGMAcgBpAHAAdABzAC4AYwBvAG0ALwBGAEgASQBSACIALAAiAG8AcgBnAF8AbgBhAG0AZQAiADoAIgBBAHoAdQByAGUAIABGAEgASQBSACAAUwBhAG4AZABiAG8AeAAgAFAAcgBvAGYAZQBzAHMAaQBvAG4AYQBsACAAIAAxADcALgAxACIAfQBdAA%253d%253d
```

The above data corresponds to the Json object in this example.

The difference between the authorization_endpoint and the patient_authorization_endpoint is that the patient_authorization_endpoint will take you to a Login screen where patients can log in, while authorization_endpoint that can be used by Providers as well as Patients

## Connecting to the Allscripts Health Connect Discovery Process

Example:
```bash
GET http:/open.allscripts.com/patient/discover?appID=f75d68b4-97a8-489a-ac90-d05aa12616d1&redirectURI=http://localhost:2134/Home/Callback
```

The AppID is the OAuth 2.0 client_id