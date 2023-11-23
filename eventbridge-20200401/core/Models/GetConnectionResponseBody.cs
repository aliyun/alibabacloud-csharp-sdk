// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class GetConnectionResponseBody : TeaModel {
        /// <summary>
        /// The returned response code. The value Success indicates that the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetConnectionResponseBodyData Data { get; set; }
        public class GetConnectionResponseBodyData : TeaModel {
            /// <summary>
            /// The queried connections.
            /// </summary>
            [NameInMap("Connections")]
            [Validation(Required=false)]
            public List<GetConnectionResponseBodyDataConnections> Connections { get; set; }
            public class GetConnectionResponseBodyDataConnections : TeaModel {
                /// <summary>
                /// The authentication methods.
                /// </summary>
                [NameInMap("AuthParameters")]
                [Validation(Required=false)]
                public GetConnectionResponseBodyDataConnectionsAuthParameters AuthParameters { get; set; }
                public class GetConnectionResponseBodyDataConnectionsAuthParameters : TeaModel {
                    /// <summary>
                    /// The information about API key authentication.
                    /// </summary>
                    [NameInMap("ApiKeyAuthParameters")]
                    [Validation(Required=false)]
                    public GetConnectionResponseBodyDataConnectionsAuthParametersApiKeyAuthParameters ApiKeyAuthParameters { get; set; }
                    public class GetConnectionResponseBodyDataConnectionsAuthParametersApiKeyAuthParameters : TeaModel {
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
                    /// The authentication method. Valid values:
                    /// 
                    /// *   BASIC_AUTH: basic authentication.
                    /// *   API_KEY_AUTH: API key authentication.
                    /// *   OAUTH_AUTH: OAuth authentication.
                    /// </summary>
                    [NameInMap("AuthorizationType")]
                    [Validation(Required=false)]
                    public string AuthorizationType { get; set; }

                    /// <summary>
                    /// The information about basic authentication.
                    /// </summary>
                    [NameInMap("BasicAuthParameters")]
                    [Validation(Required=false)]
                    public GetConnectionResponseBodyDataConnectionsAuthParametersBasicAuthParameters BasicAuthParameters { get; set; }
                    public class GetConnectionResponseBodyDataConnectionsAuthParametersBasicAuthParameters : TeaModel {
                        /// <summary>
                        /// The password of basic authentication.
                        /// </summary>
                        [NameInMap("Password")]
                        [Validation(Required=false)]
                        public string Password { get; set; }

                        /// <summary>
                        /// The username of basic authentication.
                        /// </summary>
                        [NameInMap("Username")]
                        [Validation(Required=false)]
                        public string Username { get; set; }

                    }

                    /// <summary>
                    /// The information about OAuth authentication.
                    /// </summary>
                    [NameInMap("OAuthParameters")]
                    [Validation(Required=false)]
                    public GetConnectionResponseBodyDataConnectionsAuthParametersOAuthParameters OAuthParameters { get; set; }
                    public class GetConnectionResponseBodyDataConnectionsAuthParametersOAuthParameters : TeaModel {
                        /// <summary>
                        /// The endpoint that is used to obtain the OAuth token.
                        /// </summary>
                        [NameInMap("AuthorizationEndpoint")]
                        [Validation(Required=false)]
                        public string AuthorizationEndpoint { get; set; }

                        /// <summary>
                        /// The information about the client.
                        /// </summary>
                        [NameInMap("ClientParameters")]
                        [Validation(Required=false)]
                        public GetConnectionResponseBodyDataConnectionsAuthParametersOAuthParametersClientParameters ClientParameters { get; set; }
                        public class GetConnectionResponseBodyDataConnectionsAuthParametersOAuthParametersClientParameters : TeaModel {
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
                        /// </summary>
                        [NameInMap("HttpMethod")]
                        [Validation(Required=false)]
                        public string HttpMethod { get; set; }

                        /// <summary>
                        /// The request parameters of OAuth authentication.
                        /// </summary>
                        [NameInMap("OAuthHttpParameters")]
                        [Validation(Required=false)]
                        public GetConnectionResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParameters OAuthHttpParameters { get; set; }
                        public class GetConnectionResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParameters : TeaModel {
                            /// <summary>
                            /// The information about the request body.
                            /// </summary>
                            [NameInMap("BodyParameters")]
                            [Validation(Required=false)]
                            public List<GetConnectionResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParametersBodyParameters> BodyParameters { get; set; }
                            public class GetConnectionResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParametersBodyParameters : TeaModel {
                                /// <summary>
                                /// Indicates whether authentication is enabled.
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
                            /// The information about the request header.
                            /// </summary>
                            [NameInMap("HeaderParameters")]
                            [Validation(Required=false)]
                            public List<GetConnectionResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParametersHeaderParameters> HeaderParameters { get; set; }
                            public class GetConnectionResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParametersHeaderParameters : TeaModel {
                                /// <summary>
                                /// Indicates whether authentication is enabled.
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
                            /// The information about the request path.
                            /// </summary>
                            [NameInMap("QueryStringParameters")]
                            [Validation(Required=false)]
                            public List<GetConnectionResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParametersQueryStringParameters> QueryStringParameters { get; set; }
                            public class GetConnectionResponseBodyDataConnectionsAuthParametersOAuthParametersOAuthHttpParametersQueryStringParameters : TeaModel {
                                /// <summary>
                                /// Indicates whether authentication is enabled.
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
                /// The data source ID.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The information about the network.
                /// </summary>
                [NameInMap("NetworkParameters")]
                [Validation(Required=false)]
                public GetConnectionResponseBodyDataConnectionsNetworkParameters NetworkParameters { get; set; }
                public class GetConnectionResponseBodyDataConnectionsNetworkParameters : TeaModel {
                    /// <summary>
                    /// *   PublicNetwork: the Internet.
                    /// *   PrivateNetwork: virtual private cloud (VPC).
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
                    /// The VPC ID.
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

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The returned request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
