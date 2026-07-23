// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class UpdateConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The data structure of the authentication parameters.</para>
        /// </summary>
        [NameInMap("AuthParameters")]
        [Validation(Required=false)]
        public UpdateConnectionRequestAuthParameters AuthParameters { get; set; }
        public class UpdateConnectionRequestAuthParameters : TeaModel {
            /// <summary>
            /// <para>The data structure of API Key authentication.</para>
            /// </summary>
            [NameInMap("ApiKeyAuthParameters")]
            [Validation(Required=false)]
            public UpdateConnectionRequestAuthParametersApiKeyAuthParameters ApiKeyAuthParameters { get; set; }
            public class UpdateConnectionRequestAuthParametersApiKeyAuthParameters : TeaModel {
                /// <summary>
                /// <para>The key of the API Key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("ApiKeyName")]
                [Validation(Required=false)]
                public string ApiKeyName { get; set; }

                /// <summary>
                /// <para>The value of the API Key.</para>
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
            /// <item><description><para>BASIC: BASIC_AUTH. This authorization method is the basic authentication method implemented by browsers in compliance with the HTTP protocol. During communication using the HTTP protocol, the HTTP protocol defines basic authentication that allows the HTTP server to authenticate the user identity of the client. Add Authorization: Basic followed by one space and the Base64-encoded value of <c>username:password</c> to the request header in a fixed format. Username and Password are required.</para>
            /// </description></item>
            /// <item><description><para>API KEY: API_KEY_AUTH. Add Token: TokenValue to the request header in a fixed format. ApiKeyName and ApiKeyValue are required.</para>
            /// </description></item>
            /// <item><description><para>OAUTH: OAUTH_AUTH. OAuth 2.0 is an authorization mechanism. In normal cases, in a system that does not use an authorization mechanism such as OAuth 2.0, the client can directly access resources on the resource server. To ensure secure data access for users, the Access Token mechanism is added between the client and the resource server. The client must carry an Access Token to access protected resources. Therefore, OAuth 2.0 prevents resources from being accessed by malicious clients, thereby improving the security of the system. AuthorizationEndpoint, OAuthHttpParameters, and HttpMethod are required.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BASIC_AUTH</para>
            /// </summary>
            [NameInMap("AuthorizationType")]
            [Validation(Required=false)]
            public string AuthorizationType { get; set; }

            /// <summary>
            /// <para>The data structure of Basic authentication.</para>
            /// </summary>
            [NameInMap("BasicAuthParameters")]
            [Validation(Required=false)]
            public UpdateConnectionRequestAuthParametersBasicAuthParameters BasicAuthParameters { get; set; }
            public class UpdateConnectionRequestAuthParametersBasicAuthParameters : TeaModel {
                /// <summary>
                /// <para>The password for Basic authentication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// <para>The username for Basic authentication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <para>The data structure of the OAuth authentication parameters.</para>
            /// </summary>
            [NameInMap("OAuthParameters")]
            [Validation(Required=false)]
            public UpdateConnectionRequestAuthParametersOAuthParameters OAuthParameters { get; set; }
            public class UpdateConnectionRequestAuthParametersOAuthParameters : TeaModel {
                /// <summary>
                /// <para>The request URL for obtaining the OAuth token. The maximum length is 127 characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://localhost:8080/oauth/token">http://localhost:8080/oauth/token</a></para>
                /// </summary>
                [NameInMap("AuthorizationEndpoint")]
                [Validation(Required=false)]
                public string AuthorizationEndpoint { get; set; }

                /// <summary>
                /// <para>The data structure of the client parameters.</para>
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
                    /// <para>The client secret of the application.</para>
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
                /// <para>The request parameters for OAuth authentication.</para>
                /// </summary>
                [NameInMap("OAuthHttpParameters")]
                [Validation(Required=false)]
                public UpdateConnectionRequestAuthParametersOAuthParametersOAuthHttpParameters OAuthHttpParameters { get; set; }
                public class UpdateConnectionRequestAuthParametersOAuthParametersOAuthHttpParameters : TeaModel {
                    /// <summary>
                    /// <para>The list of data structures for body request parameters.</para>
                    /// </summary>
                    [NameInMap("BodyParameters")]
                    [Validation(Required=false)]
                    public List<UpdateConnectionRequestAuthParametersOAuthParametersOAuthHttpParametersBodyParameters> BodyParameters { get; set; }
                    public class UpdateConnectionRequestAuthParametersOAuthParametersOAuthHttpParametersBodyParameters : TeaModel {
                        /// <summary>
                        /// <para>Specifies whether the parameter is used for authentication.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("IsValueSecret")]
                        [Validation(Required=false)]
                        public string IsValueSecret { get; set; }

                        /// <summary>
                        /// <para>The key of the body request parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>name</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the body request parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>demo</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of request header parameters.</para>
                    /// </summary>
                    [NameInMap("HeaderParameters")]
                    [Validation(Required=false)]
                    public List<UpdateConnectionRequestAuthParametersOAuthParametersOAuthHttpParametersHeaderParameters> HeaderParameters { get; set; }
                    public class UpdateConnectionRequestAuthParametersOAuthParametersOAuthHttpParametersHeaderParameters : TeaModel {
                        /// <summary>
                        /// <para>Specifies whether the parameter is used for authentication.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("IsValueSecret")]
                        [Validation(Required=false)]
                        public string IsValueSecret { get; set; }

                        /// <summary>
                        /// <para>The key of the request header parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>name</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the request header parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>demo</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The data structure of request query parameters.</para>
                    /// </summary>
                    [NameInMap("QueryStringParameters")]
                    [Validation(Required=false)]
                    public List<UpdateConnectionRequestAuthParametersOAuthParametersOAuthHttpParametersQueryStringParameters> QueryStringParameters { get; set; }
                    public class UpdateConnectionRequestAuthParametersOAuthParametersOAuthHttpParametersQueryStringParameters : TeaModel {
                        /// <summary>
                        /// <para>Specifies whether the parameter is used for authentication.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("IsValueSecret")]
                        [Validation(Required=false)]
                        public string IsValueSecret { get; set; }

                        /// <summary>
                        /// <para>The key of the request query parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>name</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the request query parameter.</para>
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
        /// <para>The name of the connection to be updated. The maximum length is 127 characters. The minimum length is 2 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connection-name</para>
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// <para>The description. The maximum length is 255 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Description of the connection configuration</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The data structure of the network configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NetworkParameters")]
        [Validation(Required=false)]
        public UpdateConnectionRequestNetworkParameters NetworkParameters { get; set; }
        public class UpdateConnectionRequestNetworkParameters : TeaModel {
            /// <summary>
            /// <list type="bullet">
            /// <item><description><para>Public network: PublicNetwork</para>
            /// </description></item>
            /// <item><description><para>Virtual Private Cloud (VPC): PrivateNetwork</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>When you select PrivateNetwork, VpcId, VswitcheId, and SecurityGroupId are required.</para>
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
            /// <para>The ID of the security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eb-167adad548759-security_grop/sg-bp1addad26peuh9qh9rtyb</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the VPC.</para>
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

        /// <summary>
        /// <para>The data source connection parameters (JSON object). For specific field definitions, call the GetConnectionType API and refer to the ParamsSchema in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;HostName&quot;:&quot;xxx.mysql.rds.aliyuncs.com&quot;,&quot;Port&quot;:&quot;3306&quot;,&quot;User&quot;:&quot;root&quot;,&quot;Password&quot;:&quot;xxx&quot;,&quot;DatabaseName&quot;:&quot;demo_db&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public object Parameters { get; set; }

        /// <summary>
        /// <para>The connection type. Valid values: MySQL, PostgreSQL, Elasticsearch, and Http.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Http</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
