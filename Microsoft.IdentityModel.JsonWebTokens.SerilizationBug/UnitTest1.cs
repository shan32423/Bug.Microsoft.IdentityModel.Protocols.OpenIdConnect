using Microsoft.IdentityModel.Protocols.OpenIdConnect;
namespace Tests.Bugs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IssuerIsNullForJsonConfiguration()
        {
            string jsonString = @"
                {
                  ""authorization_endpoint"": ""https://test/protocol/openid-connect/auth"",
                  ""grant_types_supported"": [
                    ""client_credentials"",
                    ""refresh_token"",
                    ""implicit""
                  ],
                  ""id_token_signing_alg_values_supported"": [
                    ""RS256""
                  ],
                  ""issuer"": ""https://test"",
                  ""jwks_uri"": ""https://test/protocol/openid-connect/certs"",
                  ""response_types_supported"": [
                    ""code"",
                    ""id_token""
                  ],
                  ""token_endpoint"": ""https://test/protocol/openid-connect/token""
                }";

            var config = new OpenIdConnectConfiguration(jsonString);
            Assert.IsNotNull(config.JwksUri, "JwksUri should not be null");
            Assert.IsNotNull(config.Issuer, "Issuer should not be null");
        }

        [TestMethod]
        public void IssuerIsNotNullForJsonConfiguration()
        {
            string jsonString = @"
                {
                  ""authorization_endpoint"": ""https://test/protocol/openid-connect/auth"",
                  ""grant_types_supported"": [
                    ""client_credentials"",
                    ""refresh_token"",
                    ""implicit""
                  ],
                  ""id_token_signing_alg_values_supported"": [
                    ""RS256""
                  ],
                  ""jwks_uri"": ""https://test/protocol/openid-connect/certs"",
                  ""issuer"": ""https://test"",
                  ""response_types_supported"": [
                    ""code"",
                    ""id_token""
                  ],
                  ""token_endpoint"": ""https://test/protocol/openid-connect/token""
                }";

            var config = new OpenIdConnectConfiguration(jsonString);
            Assert.IsNotNull(config.Issuer, "Issuer should not be null");
            Assert.IsNotNull(config.JwksUri, "JwksUri should not be null");
        }
    }
}