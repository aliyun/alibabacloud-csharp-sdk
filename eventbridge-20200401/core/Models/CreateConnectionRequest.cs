// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The authentication configuration.</para>
        /// </summary>
        [NameInMap("AuthParameters")]
        [Validation(Required=false)]
        public CreateConnectionRequestAuthParameters AuthParameters { get; set; }
        public class CreateConnectionRequestAuthParameters : TeaModel {
            /// <summary>
            /// <para>The API key authentication configuration.</para>
            /// </summary>
            [NameInMap("ApiKeyAuthParameters")]
            [Validation(Required=false)]
            public CreateConnectionRequestAuthParametersApiKeyAuthParameters ApiKeyAuthParameters { get; set; }
            public class CreateConnectionRequestAuthParametersApiKeyAuthParameters : TeaModel {
                /// <summary>
                /// <para>The key name of the API key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Token</para>
                /// </summary>
                [NameInMap("ApiKeyName")]
                [Validation(Required=false)]
                public string ApiKeyName { get; set; }

                /// <summary>
                /// <para>The value of the API key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>adkjnakddh****</para>
                /// </summary>
                [NameInMap("ApiKeyValue")]
                [Validation(Required=false)]
                public string ApiKeyValue { get; set; }

            }

            /// <summary>
            /// <para>The authentication type:</para>
            /// <list type="bullet">
            /// <item><description><para>BASIC: BASIC_AUTH. This authorization method is a basic authorization method implemented by browsers in compliance with the HTTP protocol. During HTTP communication, the HTTP protocol defines a basic authentication method that allows an HTTP server to authenticate clients. Add <c>Authorization: Basic Base64Encoded(username:password)</c> in the fixed format to the request header. Username and Password are required.</para>
            /// </description></item>
            /// <item><description><para>API KEY: API_KEY_AUTH. Add <c>Token: TokenValue</c> in the fixed format to the request header. ApiKeyName and ApiKeyValue are required.</para>
            /// </description></item>
            /// <item><description><para>OAUTH: OAUTH_AUTH. OAuth 2.0 is an authorization mechanism. In a system that does not use an authorization mechanism such as OAuth 2.0, the client can directly access resources on the resource server. To ensure secure data access, an Access Token mechanism is added. The client must carry an Access Token to access protected resources. OAuth 2.0 prevents resources from being accessed by malicious clients, which improves system security. AuthorizationEndpoint, OAuthHttpParameters, and HttpMethod are required.</para>
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
            /// <para>The basic authentication configuration.</para>
            /// </summary>
            [NameInMap("BasicAuthParameters")]
            [Validation(Required=false)]
            public CreateConnectionRequestAuthParametersBasicAuthParameters BasicAuthParameters { get; set; }
            public class CreateConnectionRequestAuthParametersBasicAuthParameters : TeaModel {
                /// <summary>
                /// <para>The password for basic authentication.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
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
            /// <para>The OAuth authentication configuration.</para>
            /// </summary>
            [NameInMap("OAuthParameters")]
            [Validation(Required=false)]
            public CreateConnectionRequestAuthParametersOAuthParameters OAuthParameters { get; set; }
            public class CreateConnectionRequestAuthParametersOAuthParameters : TeaModel {
                /// <summary>
                /// <para>The authorization endpoint URL. Maximum length: 127 characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://localhost:8080/oauth/token">http://localhost:8080/oauth/token</a></para>
                /// </summary>
                [NameInMap("AuthorizationEndpoint")]
                [Validation(Required=false)]
                public string AuthorizationEndpoint { get; set; }

                /// <summary>
                /// <para>The client parameter configuration.</para>
                /// </summary>
                [NameInMap("ClientParameters")]
                [Validation(Required=false)]
                public CreateConnectionRequestAuthParametersOAuthParametersClientParameters ClientParameters { get; set; }
                public class CreateConnectionRequestAuthParametersOAuthParametersClientParameters : TeaModel {
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
                    /// <para>Qo57Q<del>F249</del>S74GmNPA36pZJoJK4f4LY****</para>
                    /// </summary>
                    [NameInMap("ClientSecret")]
                    [Validation(Required=false)]
                    public string ClientSecret { get; set; }

                }

                /// <summary>
                /// <para>The HTTP method. Valid values:</para>
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
                /// <para>The OAuth authentication request parameters.</para>
                /// </summary>
                [NameInMap("OAuthHttpParameters")]
                [Validation(Required=false)]
                public CreateConnectionRequestAuthParametersOAuthParametersOAuthHttpParameters OAuthHttpParameters { get; set; }
                public class CreateConnectionRequestAuthParametersOAuthParametersOAuthHttpParameters : TeaModel {
                    /// <summary>
                    /// <para>The list of body request parameter configurations.</para>
                    /// </summary>
                    [NameInMap("BodyParameters")]
                    [Validation(Required=false)]
                    public List<CreateConnectionRequestAuthParametersOAuthParametersOAuthHttpParametersBodyParameters> BodyParameters { get; set; }
                    public class CreateConnectionRequestAuthParametersOAuthParametersOAuthHttpParametersBodyParameters : TeaModel {
                        /// <summary>
                        /// <para>Specifies whether the value is a secret.</para>
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
                        /// <para>keyDemo</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the body request parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>keyValue</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of header parameter configurations.</para>
                    /// </summary>
                    [NameInMap("HeaderParameters")]
                    [Validation(Required=false)]
                    public List<CreateConnectionRequestAuthParametersOAuthParametersOAuthHttpParametersHeaderParameters> HeaderParameters { get; set; }
                    public class CreateConnectionRequestAuthParametersOAuthParametersOAuthHttpParametersHeaderParameters : TeaModel {
                        /// <summary>
                        /// <para>Specifies whether the value is a secret.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("IsValueSecret")]
                        [Validation(Required=false)]
                        public string IsValueSecret { get; set; }

                        /// <summary>
                        /// <para>The key of the header parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>keyDemo</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the header parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>keyValue</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The structure of the URI of the request path parameters.</para>
                    /// </summary>
                    [NameInMap("QueryStringParameters")]
                    [Validation(Required=false)]
                    public List<CreateConnectionRequestAuthParametersOAuthParametersOAuthHttpParametersQueryStringParameters> QueryStringParameters { get; set; }
                    public class CreateConnectionRequestAuthParametersOAuthParametersOAuthHttpParametersQueryStringParameters : TeaModel {
                        /// <summary>
                        /// <para>Specifies whether the value is a secret.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("IsValueSecret")]
                        [Validation(Required=false)]
                        public string IsValueSecret { get; set; }

                        /// <summary>
                        /// <para>The key of the URI of the request path parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>keyDemo</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the URI of the request path parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>valueDemo</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The connection configuration name. Maximum length: 127 characters. Minimum length: 2 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connection-name</para>
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// <para>The description of the connection configuration. Maximum length: 255 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The network configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NetworkParameters")]
        [Validation(Required=false)]
        public CreateConnectionRequestNetworkParameters NetworkParameters { get; set; }
        public class CreateConnectionRequestNetworkParameters : TeaModel {
            /// <summary>
            /// <list type="bullet">
            /// <item><description><para>Public network: PublicNetwork</para>
            /// </description></item>
            /// <item><description><para>Virtual private cloud (VPC): PrivateNetwork</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: If you select PrivateNetwork, VpcId, VswitcheId, and SecurityGroupId are required.</para>
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
            /// <para>eb-167adad548759-security_grop/sg-bp1addad26peuh9qh9****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eb-test/vpc-bp1symadadwnwg****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1iu4x7aeradadown1og8,vsw-bp193sqmadadlaszpeq****</para>
            /// </summary>
            [NameInMap("VswitcheId")]
            [Validation(Required=false)]
            public string VswitcheId { get; set; }

        }

        /// <summary>
        /// <para>The data source connection parameters (JSON object). This parameter is required when Type is set to a data source type. This parameter is not required for the Http type. For specific field definitions, call the GetConnectionType operation and refer to ParamsSchema in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;HostName&quot;:&quot;xxx.mysql.rds.aliyuncs.com&quot;,&quot;Port&quot;:&quot;3306&quot;,&quot;User&quot;:&quot;root&quot;,&quot;Password&quot;:&quot;xxx&quot;,&quot;DatabaseName&quot;:&quot;demo_db&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public object Parameters { get; set; }

        /// <summary>
        /// <para>The connection type. Valid values: MySQL, PostgreSQL, Elasticsearch, and Http. This parameter is required for data source connections. If this parameter is not specified, the default value Http is used. The Http type is used for HTTP protocol targets such as API Destination. Data source types are used for data connections in the integration marketplace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Http</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
