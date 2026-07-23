// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListConnectionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The API status or POP error code. Valid values: Success: The request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of returned connection configurations.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListConnectionsResponseBodyData Data { get; set; }
        public class ListConnectionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of returned connection configurations.</para>
            /// </summary>
            [NameInMap("Connections")]
            [Validation(Required=false)]
            public List<ListConnectionsResponseBodyDataConnections> Connections { get; set; }
            public class ListConnectionsResponseBodyDataConnections : TeaModel {
                /// <summary>
                /// <para>The data structure of authentication parameters.</para>
                /// </summary>
                [NameInMap("AuthParameters")]
                [Validation(Required=false)]
                public ListConnectionsResponseBodyDataConnectionsAuthParameters AuthParameters { get; set; }
                public class ListConnectionsResponseBodyDataConnectionsAuthParameters : TeaModel {
                    /// <summary>
                    /// <para>The data structure of API key authentication parameters.</para>
                    /// </summary>
                    [NameInMap("ApiKeyAuthParameters")]
                    [Validation(Required=false)]
                    public ListConnectionsResponseBodyDataConnectionsAuthParametersApiKeyAuthParameters ApiKeyAuthParameters { get; set; }
                    public class ListConnectionsResponseBodyDataConnectionsAuthParametersApiKeyAuthParameters : TeaModel {
                        /// <summary>
                        /// <para>The key of the API key.</para>
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
                        /// <para>asdkjnqkwejooa</para>
                        /// </summary>
                        [NameInMap("ApiKeyValue")]
                        [Validation(Required=false)]
                        public string ApiKeyValue { get; set; }

                    }

                    /// <summary>
                    /// <para>The authentication type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>BASIC: BASIC_AUTH</para>
                    /// </description></item>
                    /// <item><description><para>API KEY: API_KEY_AUTH</para>
                    /// </description></item>
                    /// <item><description><para>OAUTH: OAUTH_AUTH</para>
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
                    /// <para>The data structure of basic authentication parameters.</para>
                    /// </summary>
                    [NameInMap("BasicAuthParameters")]
                    [Validation(Required=false)]
                    public ListConnectionsResponseBodyDataConnectionsAuthParametersBasicAuthParameters BasicAuthParameters { get; set; }
                    public class ListConnectionsResponseBodyDataConnectionsAuthParametersBasicAuthParameters : TeaModel {
                        /// <summary>
                        /// <para>The password used for basic authentication.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>admin</para>
                        /// </summary>
                        [NameInMap("Password")]
                        [Validation(Required=false)]
                        public string Password { get; set; }

                        /// <summary>
                        /// <para>The username used for basic authentication.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>admin</para>
                        /// </summary>
                        [NameInMap("Username")]
                        [Validation(Required=false)]
                        public string Username { get; set; }

                    }

                    /// <summary>
                    /// <para>The data structure of OAuth request parameters.</para>
                    /// </summary>
                    [NameInMap("OAuthParameters")]
                    [Validation(Required=false)]
                    public ListConnectionsResponseBodyDataConnectionsAuthParametersOAuthParameters OAuthParameters { get; set; }
                    public class ListConnectionsResponseBodyDataConnectionsAuthParametersOAuthParameters : TeaModel {
                        /// <summary>
                        /// <para>The endpoint URL for obtaining the OAuth token.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="http://localhost:8080/oauth/token">http://localhost:8080/oauth/token</a></para>
                        /// </summary>
                        [NameInMap("AuthorizationEndpoint")]
                        [Validation(Required=false)]
                        public string AuthorizationEndpoint { get; set; }

                        /// <summary>
                        /// <para>The data structure of client parameters.</para>
                        /// </summary>
                        [NameInMap("ClientParameters")]
                        [Validation(Required=false)]
                        public ListConnectionsResponseBodyDataConnectionsAuthParametersOAuthParametersClientParameters ClientParameters { get; set; }
                        public class ListConnectionsResponseBodyDataConnectionsAuthParametersOAuthParametersClientParameters : TeaModel {
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
                        /// <para>The HTTP method used for the request. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>GET</description></item>
                        /// <item><description>POST</description></item>
                        /// <item><description>HEAD</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>POST</para>
                        /// </summary>
                        [NameInMap("HttpMethod")]
                        [Validation(Required=false)]
                        public string HttpMethod { get; set; }

                        /// <summary>
                        /// <para>The request parameters used for OAuth authentication.</para>
                        /// </summary>
                        [NameInMap("OAuthHttpParameters")]
                        [Validation(Required=false)]
                        public ListConnectionsResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParameters OAuthHttpParameters { get; set; }
                        public class ListConnectionsResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParameters : TeaModel {
                            /// <summary>
                            /// <para>The list of request parameter data structures.</para>
                            /// </summary>
                            [NameInMap("BodyParameters")]
                            [Validation(Required=false)]
                            public List<ListConnectionsResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParametersBodyParameters> BodyParameters { get; set; }
                            public class ListConnectionsResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParametersBodyParameters : TeaModel {
                                /// <summary>
                                /// <para>Specifies whether the value is used for authentication.</para>
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
                            /// <para>The list of header parameters.</para>
                            /// </summary>
                            [NameInMap("HeaderParameters")]
                            [Validation(Required=false)]
                            public List<ListConnectionsResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParametersHeaderParameters> HeaderParameters { get; set; }
                            public class ListConnectionsResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParametersHeaderParameters : TeaModel {
                                /// <summary>
                                /// <para>Specifies whether the value is used for authentication.</para>
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
                                /// <para>name</para>
                                /// </summary>
                                [NameInMap("Key")]
                                [Validation(Required=false)]
                                public string Key { get; set; }

                                /// <summary>
                                /// <para>The value of the header parameter.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>demo</para>
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                            /// <summary>
                            /// <para>The data structure of query string parameters.</para>
                            /// </summary>
                            [NameInMap("QueryStringParameters")]
                            [Validation(Required=false)]
                            public List<ListConnectionsResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParametersQueryStringParameters> QueryStringParameters { get; set; }
                            public class ListConnectionsResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParametersQueryStringParameters : TeaModel {
                                /// <summary>
                                /// <para>Specifies whether the value is used for authentication.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>false</para>
                                /// </summary>
                                [NameInMap("IsValueSecret")]
                                [Validation(Required=false)]
                                public string IsValueSecret { get; set; }

                                /// <summary>
                                /// <para>The key of the query string parameter.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>name</para>
                                /// </summary>
                                [NameInMap("Key")]
                                [Validation(Required=false)]
                                public string Key { get; set; }

                                /// <summary>
                                /// <para>The value of the query string parameter.</para>
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
                /// <para>The name of the connection configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>connection-name</para>
                /// </summary>
                [NameInMap("ConnectionName")]
                [Validation(Required=false)]
                public string ConnectionName { get; set; }

                /// <summary>
                /// <para>The description of the connection configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Description of the connection configuration</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The timestamp when the data source was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1592838994234</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The ID of the connection configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1141093</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The data structure of the network configuration.</para>
                /// </summary>
                [NameInMap("NetworkParameters")]
                [Validation(Required=false)]
                public ListConnectionsResponseBodyDataConnectionsNetworkParameters NetworkParameters { get; set; }
                public class ListConnectionsResponseBodyDataConnectionsNetworkParameters : TeaModel {
                    /// <summary>
                    /// <list type="bullet">
                    /// <item><description><para>Public network: PublicNetwork</para>
                    /// </description></item>
                    /// <item><description><para>Virtual private cloud: PrivateNetwork</para>
                    /// </description></item>
                    /// </list>
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
                    /// <para>The ID of the virtual private cloud (VPC).</para>
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
                /// <para>The data source connection parameters (JSON object). This field is only returned for data source type connections and is empty for Http type. For field definitions, refer to the ParamsSchema returned by GetConnectionType.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;HostName&quot;:&quot;xxx.mysql.rds.aliyuncs.com&quot;,&quot;Port&quot;:&quot;3306&quot;,&quot;User&quot;:&quot;root&quot;,&quot;Password&quot;:&quot;xxx&quot;,&quot;DatabaseName&quot;:&quot;demo_db&quot;}</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public object Parameters { get; set; }

                /// <summary>
                /// <para>The connection type. Valid values: Http, MySQL, PostgreSQL, Elasticsearch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Http</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public float? MaxResults { get; set; }

            /// <summary>
            /// <para>If there are more results to fetch, NextToken is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public float? Total { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Common parameter. The ID of each request is unique and can be used for troubleshooting and issue locating.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E3619976-8714-5D88-BBA2-6983D798A8BB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
