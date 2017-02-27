using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestPatientApp.Models
{
    public class DiscoveryModel
    {
        public string authorization_endpoint { get; set; }
        public string issuer { get; set; }
        public string token_endpoint { get; set; }
        public string token_endpoint_auth_types_supported { get; set; }
        public string userinfo_endpoint { get; set; }
        public string check_id_endpoint { get; set; }
        public string registration_endpoint { get; set; }
        public string refresh_endpoint { get; set; }
        public string fhir_endpoint { get; set; }

    }
}