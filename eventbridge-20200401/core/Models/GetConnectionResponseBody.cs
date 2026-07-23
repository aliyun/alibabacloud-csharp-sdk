// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class GetConnectionResponseBody : TeaModel {
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
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetConnectionResponseBodyData Data { get; set; }
        public class GetConnectionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of connection configuration information.</para>
            /// </summary>
            [NameInMap("Connections")]
            [Validation(Required=false)]
            public List<GetConnectionResponseBodyDataConnections> Connections { get; set; }
            public class GetConnectionResponseBodyDataConnections : TeaModel {
                /// <summary>
                /// <para>The data structure of the permission.</para>
                /// </summary>
                [NameInMap("AuthParameters")]
                [Validation(Required=false)]
                public GetConnectionResponseBodyDataConnectionsAuthParameters AuthParameters { get; set; }
                public class GetConnectionResponseBodyDataConnectionsAuthParameters : TeaModel {
                    /// <summary>
                    /// <para>The data structure of the API KEY.</para>
                    /// </summary>
                    [NameInMap("ApiKeyAuthParameters")]
                    [Validation(Required=false)]
                    public GetConnectionResponseBodyDataConnectionsAuthParametersApiKeyAuthParameters ApiKeyAuthParameters { get; set; }
                    public class GetConnectionResponseBodyDataConnectionsAuthParametersApiKeyAuthParameters : TeaModel {
                        /// <summary>
                        /// <para>The key of the API key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>key</para>
                        /// </summary>
                        [NameInMap("ApiKeyName")]
                        [Validation(Required=false)]
                        public string ApiKeyName { get; set; }

                        /// <summary>
                        /// <para>The value of the API key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>value</para>
                        /// </summary>
                        [NameInMap("ApiKeyValue")]
                        [Validation(Required=false)]
                        public string ApiKeyValue { get; set; }

                    }

                    /// <summary>
                    /// <para>The authorization type:</para>
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
                    /// <para>The data structure of Basic authentication.</para>
                    /// </summary>
                    [NameInMap("BasicAuthParameters")]
                    [Validation(Required=false)]
                    public GetConnectionResponseBodyDataConnectionsAuthParametersBasicAuthParameters BasicAuthParameters { get; set; }
                    public class GetConnectionResponseBodyDataConnectionsAuthParametersBasicAuthParameters : TeaModel {
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
                    /// <para>The data structure of OAuth request parameters.</para>
                    /// </summary>
                    [NameInMap("OAuthParameters")]
                    [Validation(Required=false)]
                    public GetConnectionResponseBodyDataConnectionsAuthParametersOAuthParameters OAuthParameters { get; set; }
                    public class GetConnectionResponseBodyDataConnectionsAuthParametersOAuthParameters : TeaModel {
                        /// <summary>
                        /// <para>The request URL for obtaining the OAuth token.</para>
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
                        public GetConnectionResponseBodyDataConnectionsAuthParametersOAuthParametersClientParameters ClientParameters { get; set; }
                        public class GetConnectionResponseBodyDataConnectionsAuthParametersOAuthParametersClientParameters : TeaModel {
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
                            /// <para>Qo57Q<del>F249</del>S74GmNPA36pZJoJK4f4****</para>
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
                        /// <para>The request parameters for OAuth authentication.</para>
                        /// </summary>
                        [NameInMap("OAuthHttpParameters")]
                        [Validation(Required=false)]
                        public GetConnectionResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParameters OAuthHttpParameters { get; set; }
                        public class GetConnectionResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParameters : TeaModel {
                            /// <summary>
                            /// <para>The list of request parameter data structures.</para>
                            /// </summary>
                            [NameInMap("BodyParameters")]
                            [Validation(Required=false)]
                            public List<GetConnectionResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParametersBodyParameters> BodyParameters { get; set; }
                            public class GetConnectionResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParametersBodyParameters : TeaModel {
                                /// <summary>
                                /// <para>Indicates whether the parameter is used for authentication.</para>
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
                                /// <para>valueDemo</para>
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
                            public List<GetConnectionResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParametersHeaderParameters> HeaderParameters { get; set; }
                            public class GetConnectionResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParametersHeaderParameters : TeaModel {
                                /// <summary>
                                /// <para>Indicates whether the parameter is used for authentication.</para>
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
                                /// <para>keyDemo</para>
                                /// </summary>
                                [NameInMap("Key")]
                                [Validation(Required=false)]
                                public string Key { get; set; }

                                /// <summary>
                                /// <para>The value of the request header parameter.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>keyDemo</para>
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                            /// <summary>
                            /// <para>The data structure of the request path parameters.</para>
                            /// </summary>
                            [NameInMap("QueryStringParameters")]
                            [Validation(Required=false)]
                            public List<GetConnectionResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParametersQueryStringParameters> QueryStringParameters { get; set; }
                            public class GetConnectionResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParametersQueryStringParameters : TeaModel {
                                /// <summary>
                                /// <para>Indicates whether the parameter is used for authentication.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>false</para>
                                /// </summary>
                                [NameInMap("IsValueSecret")]
                                [Validation(Required=false)]
                                public string IsValueSecret { get; set; }

                                /// <summary>
                                /// <para>The key of the request path parameter.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>keyDemo</para>
                                /// </summary>
                                [NameInMap("Key")]
                                [Validation(Required=false)]
                                public string Key { get; set; }

                                /// <summary>
                                /// <para>The value of the request path parameter.</para>
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
                /// <para>The name of the connection configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("ConnectionName")]
                [Validation(Required=false)]
                public string ConnectionName { get; set; }

                /// <summary>
                /// <para>The description of the connection configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1669648905</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The data source ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5668</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The data structure of the network configuration.</para>
                /// </summary>
                [NameInMap("NetworkParameters")]
                [Validation(Required=false)]
                public GetConnectionResponseBodyDataConnectionsNetworkParameters NetworkParameters { get; set; }
                public class GetConnectionResponseBodyDataConnectionsNetworkParameters : TeaModel {
                    /// <summary>
                    /// <list type="bullet">
                    /// <item><description><para>Internet: PublicNetwork</para>
                    /// </description></item>
                    /// <item><description><para>Virtual private cloud (VPC): PrivateNetwork</para>
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
                    /// <para>eb-167adad548759-security_grop/sg-bp1addad26peuh9qh9****</para>
                    /// </summary>
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>The ID of the virtual private cloud (VPC).</para>
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
                    /// <para>vsw-bp1iu4x7aeradadown****,vsw-bp193sqmadadlaszpeq****</para>
                    /// </summary>
                    [NameInMap("VswitcheId")]
                    [Validation(Required=false)]
                    public string VswitcheId { get; set; }

                }

                /// <summary>
                /// <para>The data source connection parameters (JSON object). Only returned for data source type connections. Empty for the Http type. For field definitions, refer to the ParamsSchema returned by GetConnectionType.</para>
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

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The information returned by the API request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The returned request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34AD682D-5B91-5773-8132-AA38C130****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
