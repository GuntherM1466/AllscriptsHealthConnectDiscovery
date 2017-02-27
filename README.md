# AllscriptsHealthConnectDiscovery

This is a sample that shows how to use the Discovery Process of Allscripts Health Connect to find the OAuth 2.0 Authorization and token Access URL , as well as the FHIR URL

The Discovery can be used in two modes:

* By processing an Allscripts Health Connect invite (invite code)
* Processing for patients with exising credentials have already accepted an invite code

In either case the discovery process returns a JSON object.

For Example
``` javascript
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
```

## Processing an Allscripts Health Connect Invite Code

This Discovery Process should be used when a Patient has not yet accepted an Invite for the desrired Hospital, Clinic or Practice.

Example:
```bash
GET http:/open.allscripts.com/patient/discover?appID=f75d68b4-97a8-489a-ac90-d05aa12616d1&redirectURI=http://localhost:2134/Home/Callback
```

## Processing for patients with exising credentials that have already accepted an invite

This Discovery Process should be used when a Patient has already accepted an Invite for the desrired Hospital, Clinic or Practice.

Example:
```bash
GET http:/open.allscripts.com/patient/discover?appID=f75d68b4-97a8-489a-ac90-d05aa12616d1&redirectURI=http://localhost:2134/Home/Callback&type=existingpatient
```
