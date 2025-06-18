// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class UpdateConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The parameters that are configured for authentication.</para>
        /// </summary>
        [NameInMap("AuthParameters")]
        [Validation(Required=false)]
        public UpdateConnectionRequestAuthParameters AuthParameters { get; set; }
        public class UpdateConnectionRequestAuthParameters : TeaModel {
            /// <summary>
            /// <para>The parameters configured for API key authentication.</para>
            /// </summary>
            [NameInMap("ApiKeyAuthParameters")]
            [Validation(Required=false)]
            public UpdateConnectionRequestAuthParametersApiKeyAuthParameters ApiKeyAuthParameters { get; set; }
            public class UpdateConnectionRequestAuthParametersApiKeyAuthParameters : TeaModel {
                /// <summary>
                /// <para>The key of the API key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("ApiKeyName")]
                [Validation(Required=false)]
                public string ApiKeyName { get; set; }

                /// <summary>
                /// <para>The value of the API key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("ApiKeyValue")]
                [Validation(Required=false)]
                public string ApiKeyValue { get; set; }

            }

            /// <summary>
            /// <para>The authentication type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BASIC: basic authentication. Basic authentication is a simple authentication scheme built into the HTTP protocol. When you use the HTTP protocol for communications, the authentication method that the HTTP server uses to authenticate user identities on the client is defined in the protocol. The request header is in the Authorization: Basic Base64-encoded string (<c>Username:Password</c>) format. If you use this authentication method, you must configure Username and Password.</description></item>
            /// <item><description>API_KEY_AUTH: API key authentication. The request header is in the Token: Token value format. If you use this authentication method, you must configure ApiKeyName and ApiKeyValue.</description></item>
            /// <item><description>OAUTH_AUTH: OAuth authentication. OAuth2.0 is an authentication mechanism. In normal cases, a system that does not use OAuth2.0 can access the resources of the server from the client. To ensure access security, access tokens are used to authenticate users in OAuth 2.0. The client must use an access token to access protected resources. This way, OAuth 2.0 protects resources from being accessed from malicious clients and improves system security. If you use this authentication method, you must configure AuthorizationEndpoint, OAuthHttpParameters, and HttpMethod.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BASIC_AUTH</para>
            /// </summary>
            [NameInMap("AuthorizationType")]
            [Validation(Required=false)]
            public string AuthorizationType { get; set; }

            /// <summary>
            /// <para>The parameters that are configured for basic authentication.</para>
            /// </summary>
            [NameInMap("BasicAuthParameters")]
            [Validation(Required=false)]
            public UpdateConnectionRequestAuthParametersBasicAuthParameters BasicAuthParameters { get; set; }
            public class UpdateConnectionRequestAuthParametersBasicAuthParameters : TeaModel {
                /// <summary>
                /// <para>The password for basic authentication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// <para>The username for basic authentication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <para>The parameters that are configured for OAuth authentication.</para>
            /// </summary>
            [NameInMap("OAuthParameters")]
            [Validation(Required=false)]
            public UpdateConnectionRequestAuthParametersOAuthParameters OAuthParameters { get; set; }
            public class UpdateConnectionRequestAuthParametersOAuthParameters : TeaModel {
                /// <summary>
                /// <para>The endpoint that is used to obtain the OAuth token. The endpoint can be up to 127 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://localhost:8080/oauth/token">http://localhost:8080/oauth/token</a></para>
                /// </summary>
                [NameInMap("AuthorizationEndpoint")]
                [Validation(Required=false)]
                public string AuthorizationEndpoint { get; set; }

                /// <summary>
                /// <para>The parameters that are configured for the client.</para>
                /// </summary>
                [NameInMap("ClientParameters")]
                [Validation(Required=false)]
                public UpdateConnectionRequestAuthParametersOAuthParametersClientParameters ClientParameters { get; set; }
                public class UpdateConnectionRequestAuthParametersOAuthParametersClientParameters : TeaModel {
                    /// <summary>
                    /// <para>The client ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ClientID</para>
                    /// </summary>
                    [NameInMap("ClientID")]
                    [Validation(Required=false)]
                    public string ClientID { get; set; }

                    /// <summary>
                    /// <para>The AccessKey secret of the client.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ClientSecret</para>
                    /// </summary>
                    [NameInMap("ClientSecret")]
                    [Validation(Required=false)]
                    public string ClientSecret { get; set; }

                }

                /// <summary>
                /// <para>The HTTP request method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>GET</description></item>
                /// <item><description>POST</description></item>
                /// <item><description>HEAD</description></item>
                /// <item><description>DELETE</description></item>
                /// <item><description>PUT</description></item>
                /// <item><description>PATCH</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>POST</para>
                /// </summary>
                [NameInMap("HttpMethod")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }

                /// <summary>
                /// <para>The request parameters of OAuth authentication.</para>
                /// </summary>
                [NameInMap("OAuthHttpParameters")]
                [Validation(Required=false)]
                public UpdateConnectionRequestAuthParametersOAuthParametersOAuthHttpParameters OAuthHttpParameters { get; set; }
                public class UpdateConnectionRequestAuthParametersOAuthParametersOAuthHttpParameters : TeaModel {
                    /// <summary>
                    /// <para>The parameters that are configured for the request body.</para>
                    /// </summary>
                    [NameInMap("BodyParameters")]
                    [Validation(Required=false)]
                    public List<UpdateConnectionRequestAuthParametersOAuthParametersOAuthHttpParametersBodyParameters> BodyParameters { get; set; }
                    public class UpdateConnectionRequestAuthParametersOAuthParametersOAuthHttpParametersBodyParameters : TeaModel {
                        /// <summary>
                        /// <para>Specifies whether to enable authentication.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("IsValueSecret")]
                        [Validation(Required=false)]
                        public string IsValueSecret { get; set; }

                        /// <summary>
                        /// <para>The key of the request body.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>name</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the request body.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>demo</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The parameters that are configured for the request header.</para>
                    /// </summary>
                    [NameInMap("HeaderParameters")]
                    [Validation(Required=false)]
                    public List<UpdateConnectionRequestAuthParametersOAuthParametersOAuthHttpParametersHeaderParameters> HeaderParameters { get; set; }
                    public class UpdateConnectionRequestAuthParametersOAuthParametersOAuthHttpParametersHeaderParameters : TeaModel {
                        /// <summary>
                        /// <para>Specifies whether to enable authentication.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("IsValueSecret")]
                        [Validation(Required=false)]
                        public string IsValueSecret { get; set; }

                        /// <summary>
                        /// <para>The key of the request header.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>name</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the request header.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>demo</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The parameters that are configured for the request path.</para>
                    /// </summary>
                    [NameInMap("QueryStringParameters")]
                    [Validation(Required=false)]
                    public List<UpdateConnectionRequestAuthParametersOAuthParametersOAuthHttpParametersQueryStringParameters> QueryStringParameters { get; set; }
                    public class UpdateConnectionRequestAuthParametersOAuthParametersOAuthHttpParametersQueryStringParameters : TeaModel {
                        /// <summary>
                        /// <para>Specifies whether to enable authentication.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("IsValueSecret")]
                        [Validation(Required=false)]
                        public string IsValueSecret { get; set; }

                        /// <summary>
                        /// <para>The key of the request path.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>name</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the request path.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>demo</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The name of the connection that you want to update. The name must be 2 to 127 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connection-name</para>
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// <para>The description of the connection. The description can be up to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The description of the connection.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The parameters that are configured for the network.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NetworkParameters")]
        [Validation(Required=false)]
        public UpdateConnectionRequestNetworkParameters NetworkParameters { get; set; }
        public class UpdateConnectionRequestNetworkParameters : TeaModel {
            /// <summary>
            /// <list type="bullet">
            /// <item><description>PublicNetwork: the Internet.</description></item>
            /// <item><description>PrivateNetwork: virtual private cloud (VPC).</description></item>
            /// </list>
            /// <remarks>
            /// <para> If you set this parameter to PrivateNetwork, you must also configure VpcId, VswitchId, and SecurityGroupId.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PublicNetwork</para>
            /// </summary>
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// <para>The security group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eb-167adad548759-security_grop/sg-bp1addad26peuh9qh9rtyb</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eb-test/vpc-bp1symadadwnwgmqud</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1iu4x7aeradadown1og8,vsw-bp193sqmadadlaszpeqbt2c</para>
            /// </summary>
            [NameInMap("VswitcheId")]
            [Validation(Required=false)]
            public string VswitcheId { get; set; }

        }

    }

}
