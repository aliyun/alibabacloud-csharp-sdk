// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The authentication data structure.</para>
        /// </summary>
        [NameInMap("AuthParameters")]
        [Validation(Required=false)]
        public CreateConnectionRequestAuthParameters AuthParameters { get; set; }
        public class CreateConnectionRequestAuthParameters : TeaModel {
            /// <summary>
            /// <para>The data structure of the API key authentication parameters.</para>
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
            /// <para>The authentication type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BASIC: Basic authentication. This is a standard authentication method defined by the HTTP protocol. Add the Authorization header in the format of Basic followed by a space and the Base64-encoded username:password. Username and Password are required.</description></item>
            /// <item><description>API KEY: API key authentication. Add the Token header with the token value. ApiKeyName and ApiKeyValue are required.</description></item>
            /// <item><description>OAUTH: OAuth 2.0 authentication. OAuth 2.0 is an authorization framework that uses access tokens to protect resources. Clients must include an access token in their requests to access protected resources. AuthorizationEndpoint, OAuthHttpParameters, and HttpMethod are required.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BASIC_AUTH</para>
            /// </summary>
            [NameInMap("AuthorizationType")]
            [Validation(Required=false)]
            public string AuthorizationType { get; set; }

            /// <summary>
            /// <para>The data structure of the basic authentication parameters.</para>
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
            /// <para>The data structure of the OAuth authentication parameters.</para>
            /// </summary>
            [NameInMap("OAuthParameters")]
            [Validation(Required=false)]
            public CreateConnectionRequestAuthParametersOAuthParameters OAuthParameters { get; set; }
            public class CreateConnectionRequestAuthParametersOAuthParameters : TeaModel {
                /// <summary>
                /// <para>The endpoint URL for authorization. Maximum length: 127 characters.</para>
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
                public CreateConnectionRequestAuthParametersOAuthParametersClientParameters ClientParameters { get; set; }
                public class CreateConnectionRequestAuthParametersOAuthParametersClientParameters : TeaModel {
                    /// <summary>
                    /// <para>The ID of the client.</para>
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
                /// <para>The HTTP method for probing. Valid values:</para>
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
                public CreateConnectionRequestAuthParametersOAuthParametersOAuthHttpParameters OAuthHttpParameters { get; set; }
                public class CreateConnectionRequestAuthParametersOAuthParametersOAuthHttpParameters : TeaModel {
                    /// <summary>
                    /// <para>The list of structures for body request parameters.</para>
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
                    /// <para>The list of header parameters.</para>
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
                    /// <para>The structure of URI of the request path parameters.</para>
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
        /// <para>The name of the connection configuration. The length must be 2 to 127 characters.</para>
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
        /// <para>The data structure of the network configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NetworkParameters")]
        [Validation(Required=false)]
        public CreateConnectionRequestNetworkParameters NetworkParameters { get; set; }
        public class CreateConnectionRequestNetworkParameters : TeaModel {
            /// <summary>
            /// <para>The network type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PublicNetwork: public network</description></item>
            /// <item><description>PrivateNetwork: VPC
            /// <notice>If you select PrivateNetwork, VpcId, VswitcheId, and SecurityGroupId are required.</notice></description></item>
            /// </list>
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
            /// <para>The ID of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1iu4x7aeradadown1og8,vsw-bp193sqmadadlaszpeq****</para>
            /// </summary>
            [NameInMap("VswitcheId")]
            [Validation(Required=false)]
            public string VswitcheId { get; set; }

        }

        /// <summary>
        /// <para>The data source connection parameters in JSON format. This parameter is required when Type is set to a data source type, and is not required when Type is set to Http. For specific field definitions, call the GetConnectionType operation and refer to ParamsSchema in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;HostName&quot;:&quot;xxx.mysql.rds.aliyuncs.com&quot;,&quot;Port&quot;:&quot;3306&quot;,&quot;User&quot;:&quot;root&quot;,&quot;Password&quot;:&quot;xxx&quot;,&quot;DatabaseName&quot;:&quot;demo_db&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public object Parameters { get; set; }

        /// <summary>
        /// <para>The connection type. Valid values: MySQL, PostgreSQL, Elasticsearch, OSS_TABLES, SLS, OTS, MaxCompute, MongoDB, Redis, SQLServer, ClickHouse, Oracle, Hive, Iceberg, lakehouse, and Http. This parameter is required for data source connections. If you do not specify this parameter, the default value Http is used. The Http type is used for HTTP protocol targets such as API Destination. Hive and Iceberg are used for their respective data lakehouse data sources. The lakehouse type is used only for compatibility with existing connections. Other data source types are used for data connections in the integration marketplace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Http</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
