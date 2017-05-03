# AllscriptsHealthConnectDiscovery

This is a sample that shows how to use the Discovery Process of Follow My Health and Allscripts Health Connect to find the OAuth 2.0 Authorization and token Access URL , as well as the FHIR URL

The discovery process returns a JSON object.

For Example
``` javascript
[
	{
	authorization_endpoint: "https://tw171.open.allscripts.com/authorization/connect/authorize",
	issuer: "https://tw171.open.allscripts.com",
	token_endpoint: "https://tw171.open.allscripts.com/authorization/connect/token",
	token_endpoint_auth_types_supported: null,
	userinfo_endpoint: "https://tw171.open.allscripts.com/authorization/connect/userinfo",
	check_id_endpoint: "",
	registration_endpoint: null,
	refresh_endpoint: "https://tw171.open.allscripts.com/authorization/connect/refresh",
	fhir_endpoint: "https://tw171.open.allscripts.com/fhir"
	}
]
```

## Connecting to the Allscripts Health Connect Discovery Process

Example:
```bash
GET http:/open.allscripts.com/patient/discover?appID=f75d68b4-97a8-489a-ac90-d05aa12616d1&redirectURI=http://localhost:2134/Home/Callback
```

The AppID is the OAuth 2.0 client_id