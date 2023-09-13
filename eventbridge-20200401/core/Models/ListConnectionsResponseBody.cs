// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListConnectionsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The value Success indicates that the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information about the connections returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListConnectionsResponseBodyData Data { get; set; }
        public class ListConnectionsResponseBodyData : TeaModel {
            /// <summary>
            /// The value of the key in the request path.
            /// </summary>
            [NameInMap("Connections")]
            [Validation(Required=false)]
            public List<ListConnectionsResponseBodyDataConnections> Connections { get; set; }
            public class ListConnectionsResponseBodyDataConnections : TeaModel {
                /// <summary>
                /// The parameters that are configured for authentication.
                /// </summary>
                [NameInMap("AuthParameters")]
                [Validation(Required=false)]
                public ListConnectionsResponseBodyDataConnectionsAuthParameters AuthParameters { get; set; }
                public class ListConnectionsResponseBodyDataConnectionsAuthParameters : TeaModel {
                    /// <summary>
                    /// The parameters that are configured for API key authentication.
                    /// </summary>
                    [NameInMap("ApiKeyAuthParameters")]
                    [Validation(Required=false)]
                    public ListConnectionsResponseBodyDataConnectionsAuthParametersApiKeyAuthParameters ApiKeyAuthParameters { get; set; }
                    public class ListConnectionsResponseBodyDataConnectionsAuthParametersApiKeyAuthParameters : TeaModel {
                        /// <summary>
                        /// The API key.
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
                    /// - BASIC_AUTH: basic authentication.
                    /// 
                    /// - API_KEY_AUTH: API key authentication.
                    /// 
                    /// - OAUTH_AUTH: OAuth authentication.
                    /// </summary>
                    [NameInMap("AuthorizationType")]
                    [Validation(Required=false)]
                    public string AuthorizationType { get; set; }

                    /// <summary>
                    /// The parameters that are configured for basic authentication.
                    /// </summary>
                    [NameInMap("BasicAuthParameters")]
                    [Validation(Required=false)]
                    public ListConnectionsResponseBodyDataConnectionsAuthParametersBasicAuthParameters BasicAuthParameters { get; set; }
                    public class ListConnectionsResponseBodyDataConnectionsAuthParametersBasicAuthParameters : TeaModel {
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
                    public ListConnectionsResponseBodyDataConnectionsAuthParametersOAuthParameters OAuthParameters { get; set; }
                    public class ListConnectionsResponseBodyDataConnectionsAuthParametersOAuthParameters : TeaModel {
                        /// <summary>
                        /// The endpoint that is used to obtain the OAuth token.
                        /// </summary>
                        [NameInMap("AuthorizationEndpoint")]
                        [Validation(Required=false)]
                        public string AuthorizationEndpoint { get; set; }

                        /// <summary>
                        /// The parameters that are configured for the client.
                        /// </summary>
                        [NameInMap("ClientParameters")]
                        [Validation(Required=false)]
                        public ListConnectionsResponseBodyDataConnectionsAuthParametersOAuthParametersClientParameters ClientParameters { get; set; }
                        public class ListConnectionsResponseBodyDataConnectionsAuthParametersOAuthParametersClientParameters : TeaModel {
                            /// <summary>
                            /// The client ID.
                            /// </summary>
                            [NameInMap("ClientID")]
                            [Validation(Required=false)]
                            public string ClientID { get; set; }

                            /// <summary>
                            /// The client key secret of the application.
                            /// </summary>
                            [NameInMap("ClientSecret")]
                            [Validation(Required=false)]
                            public string ClientSecret { get; set; }

                        }

                        /// <summary>
                        /// The HTTP request method. Valid values:
                        /// 
                        /// - GET
                        /// 
                        /// - POST
                        /// 
                        /// - HEAD
                        /// </summary>
                        [NameInMap("HttpMethod")]
                        [Validation(Required=false)]
                        public string HttpMethod { get; set; }

                        /// <summary>
                        /// The request parameters for OAuth authentication.
                        /// </summary>
                        [NameInMap("OAuthHttpParameters")]
                        [Validation(Required=false)]
                        public ListConnectionsResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParameters OAuthHttpParameters { get; set; }
                        public class ListConnectionsResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParameters : TeaModel {
                            /// <summary>
                            /// The parameters that are configured for the request.
                            /// </summary>
                            [NameInMap("BodyParameters")]
                            [Validation(Required=false)]
                            public List<ListConnectionsResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParametersBodyParameters> BodyParameters { get; set; }
                            public class ListConnectionsResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParametersBodyParameters : TeaModel {
                                /// <summary>
                                /// Indicates whether authentication is enabled.
                                /// </summary>
                                [NameInMap("IsValueSecret")]
                                [Validation(Required=false)]
                                public string IsValueSecret { get; set; }

                                /// <summary>
                                /// The key in the request body.
                                /// </summary>
                                [NameInMap("Key")]
                                [Validation(Required=false)]
                                public string Key { get; set; }

                                /// <summary>
                                /// The value of the key in the request body.
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
                            public List<ListConnectionsResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParametersHeaderParameters> HeaderParameters { get; set; }
                            public class ListConnectionsResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParametersHeaderParameters : TeaModel {
                                /// <summary>
                                /// Indicates whether authentication is enabled.
                                /// </summary>
                                [NameInMap("IsValueSecret")]
                                [Validation(Required=false)]
                                public string IsValueSecret { get; set; }

                                /// <summary>
                                /// The key in the request header.
                                /// </summary>
                                [NameInMap("Key")]
                                [Validation(Required=false)]
                                public string Key { get; set; }

                                /// <summary>
                                /// The value of the key in the request header.
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
                            public List<ListConnectionsResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParametersQueryStringParameters> QueryStringParameters { get; set; }
                            public class ListConnectionsResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParametersQueryStringParameters : TeaModel {
                                /// <summary>
                                /// Indicates whether authentication is enabled.
                                /// </summary>
                                [NameInMap("IsValueSecret")]
                                [Validation(Required=false)]
                                public string IsValueSecret { get; set; }

                                /// <summary>
                                /// The key in the request path.
                                /// </summary>
                                [NameInMap("Key")]
                                [Validation(Required=false)]
                                public string Key { get; set; }

                                /// <summary>
                                /// The value of the key in the request path.
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                        }

                    }

                }

                /// <summary>
                /// The connection name.
                /// </summary>
                [NameInMap("ConnectionName")]
                [Validation(Required=false)]
                public string ConnectionName { get; set; }

                /// <summary>
                /// The connection description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The time when the connection was created.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// The connection ID.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("NetworkParameters")]
                [Validation(Required=false)]
                public ListConnectionsResponseBodyDataConnectionsNetworkParameters NetworkParameters { get; set; }
                public class ListConnectionsResponseBodyDataConnectionsNetworkParameters : TeaModel {
                    /// <summary>
                    /// The network type. Valid values:PublicNetwork and PrivateNetwork.
                    /// </summary>
                    [NameInMap("NetworkType")]
                    [Validation(Required=false)]
                    public string NetworkType { get; set; }

                    /// <summary>
                    /// The security group ID.
                    /// </summary>
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// The virtual private cloud (VPC) ID.
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

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public float? MaxResults { get; set; }

            /// <summary>
            /// If excess return values exist, this parameter is returned.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public float? Total { get; set; }

        }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use the ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
