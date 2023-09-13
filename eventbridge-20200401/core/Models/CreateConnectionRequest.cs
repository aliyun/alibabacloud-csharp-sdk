// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateConnectionRequest : TeaModel {
        /// <summary>
        /// The parameters that are configured for authentication.
        /// </summary>
        [NameInMap("AuthParameters")]
        [Validation(Required=false)]
        public CreateConnectionRequestAuthParameters AuthParameters { get; set; }
        public class CreateConnectionRequestAuthParameters : TeaModel {
            /// <summary>
            /// The parameters that are configured for API key authentication.
            /// </summary>
            [NameInMap("ApiKeyAuthParameters")]
            [Validation(Required=false)]
            public CreateConnectionRequestAuthParametersApiKeyAuthParameters ApiKeyAuthParameters { get; set; }
            public class CreateConnectionRequestAuthParametersApiKeyAuthParameters : TeaModel {
                /// <summary>
                /// The key of the API key.
                /// </summary>
                [NameInMap("ApiKeyName")]
                [Validation(Required=false)]
                public string ApiKeyName { get; set; }

                /// <summary>
                /// The value of the API key.
                /// </summary>
                [NameInMap("ApiKeyValue")]
                [Validation(Required=false)]
                public string ApiKeyValue { get; set; }

            }

            /// <summary>
            /// The authentication type. Valid values:
            /// 
            /// BASIC_AUTH: basic authentication.
            /// 
            /// Introduction: Basic authentication is a simple authentication scheme built into the HTTP protocol. When you use the HTTP protocol for communications, the authentication method that the HTTP server uses to authenticate user identities on the client is defined in the protocol. The request header is in the Authorization: Basic Base64-encoded string (Username:Password) format.
            /// 
            /// 1.  Username and Password are required.
            /// 
            /// API_KEY_AUTH: API key authentication.
            /// 
            /// Introduction: The request header is in the Token: Token value format.
            /// 
            /// *   ApiKeyName and ApiKeyValue are required.
            /// 
            /// OAUTH_AUTH: OAuth authentication.
            /// 
            /// Introduction: OAuth2.0 is an authentication mechanism. In normal cases, a system that does not use OAuth2.0 can access the resources of the server from the client. To ensure access security, access tokens are used to authenticate users in OAuth 2.0. The client must use an access token to access protected resources. This way, OAuth 2.0 protects resources from being accessed from malicious clients and improves system security.
            /// 
            /// *   AuthorizationEndpoint, OAuthHttpParameters, and HttpMethod are required.
            /// </summary>
            [NameInMap("AuthorizationType")]
            [Validation(Required=false)]
            public string AuthorizationType { get; set; }

            /// <summary>
            /// The parameters that are configured for basic authentication.
            /// </summary>
            [NameInMap("BasicAuthParameters")]
            [Validation(Required=false)]
            public CreateConnectionRequestAuthParametersBasicAuthParameters BasicAuthParameters { get; set; }
            public class CreateConnectionRequestAuthParametersBasicAuthParameters : TeaModel {
                /// <summary>
                /// The password for basic authentication.
                /// </summary>
                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// The username for basic authentication.
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// The parameters that are configured for OAuth authentication.
            /// </summary>
            [NameInMap("OAuthParameters")]
            [Validation(Required=false)]
            public CreateConnectionRequestAuthParametersOAuthParameters OAuthParameters { get; set; }
            public class CreateConnectionRequestAuthParametersOAuthParameters : TeaModel {
                /// <summary>
                /// The IP address of the authorized endpoint. The default value of a column can be up to 127 characters in length.
                /// </summary>
                [NameInMap("AuthorizationEndpoint")]
                [Validation(Required=false)]
                public string AuthorizationEndpoint { get; set; }

                /// <summary>
                /// The parameters that are configured for the client.
                /// </summary>
                [NameInMap("ClientParameters")]
                [Validation(Required=false)]
                public CreateConnectionRequestAuthParametersOAuthParametersClientParameters ClientParameters { get; set; }
                public class CreateConnectionRequestAuthParametersOAuthParametersClientParameters : TeaModel {
                    /// <summary>
                    /// The client ID.
                    /// </summary>
                    [NameInMap("ClientID")]
                    [Validation(Required=false)]
                    public string ClientID { get; set; }

                    /// <summary>
                    /// The AccessKey secret of the client.
                    /// </summary>
                    [NameInMap("ClientSecret")]
                    [Validation(Required=false)]
                    public string ClientSecret { get; set; }

                }

                /// <summary>
                /// The HTTP request method. Valid values:
                /// 
                /// *   GET
                /// *   POST
                /// *   HEAD
                /// *   DELETE
                /// *   PUT
                /// *   PATCH
                /// </summary>
                [NameInMap("HttpMethod")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }

                /// <summary>
                /// The request parameters that are configured for OAuth authentication.
                /// </summary>
                [NameInMap("OAuthHttpParameters")]
                [Validation(Required=false)]
                public CreateConnectionRequestAuthParametersOAuthParametersOAuthHttpParameters OAuthHttpParameters { get; set; }
                public class CreateConnectionRequestAuthParametersOAuthParametersOAuthHttpParameters : TeaModel {
                    /// <summary>
                    /// The parameters that are configured for the request body.
                    /// </summary>
                    [NameInMap("BodyParameters")]
                    [Validation(Required=false)]
                    public List<CreateConnectionRequestAuthParametersOAuthParametersOAuthHttpParametersBodyParameters> BodyParameters { get; set; }
                    public class CreateConnectionRequestAuthParametersOAuthParametersOAuthHttpParametersBodyParameters : TeaModel {
                        /// <summary>
                        /// Specifies whether to enable authentication.
                        /// </summary>
                        [NameInMap("IsValueSecret")]
                        [Validation(Required=false)]
                        public string IsValueSecret { get; set; }

                        /// <summary>
                        /// The key of the request body.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of the request body.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The parameters that are configured for the request header.
                    /// </summary>
                    [NameInMap("HeaderParameters")]
                    [Validation(Required=false)]
                    public List<CreateConnectionRequestAuthParametersOAuthParametersOAuthHttpParametersHeaderParameters> HeaderParameters { get; set; }
                    public class CreateConnectionRequestAuthParametersOAuthParametersOAuthHttpParametersHeaderParameters : TeaModel {
                        /// <summary>
                        /// Specifies whether to enable authentication.
                        /// </summary>
                        [NameInMap("IsValueSecret")]
                        [Validation(Required=false)]
                        public string IsValueSecret { get; set; }

                        /// <summary>
                        /// The key of the request header.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of the request header.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The parameters that are configured for the request path.
                    /// </summary>
                    [NameInMap("QueryStringParameters")]
                    [Validation(Required=false)]
                    public List<CreateConnectionRequestAuthParametersOAuthParametersOAuthHttpParametersQueryStringParameters> QueryStringParameters { get; set; }
                    public class CreateConnectionRequestAuthParametersOAuthParametersOAuthHttpParametersQueryStringParameters : TeaModel {
                        /// <summary>
                        /// Specifies whether to enable authentication.
                        /// </summary>
                        [NameInMap("IsValueSecret")]
                        [Validation(Required=false)]
                        public string IsValueSecret { get; set; }

                        /// <summary>
                        /// The key of the request path.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of the request path.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The name of the connection. The name must be 2 to 127 characters in length.
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// The description of the connection. The description can be up to 255 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The parameters that are configured for the network.
        /// </summary>
        [NameInMap("NetworkParameters")]
        [Validation(Required=false)]
        public CreateConnectionRequestNetworkParameters NetworkParameters { get; set; }
        public class CreateConnectionRequestNetworkParameters : TeaModel {
            /// <summary>
            /// The network type. Valid values:
            /// 
            /// PublicNetwork and PrivateNetwork.
            /// 
            /// *   Note: If you set this parameter to PrivateNetwork, you must configure VpcId, VswitcheId, and SecurityGroupId.
            /// </summary>
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// The ID of the security group.
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// The VPC. ID
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// The vSwitch ID.
            /// </summary>
            [NameInMap("VswitcheId")]
            [Validation(Required=false)]
            public string VswitcheId { get; set; }

        }

    }

}
