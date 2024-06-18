// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListRulesResponseBody : TeaModel {
        /// <summary>
        /// The maximum number of entries returned.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If **NextToken** is empty, no next page exists.
        /// *   If a value is returned for **NextToken**, the value is the token that determines the start point of the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details about the forwarding rule.
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<ListRulesResponseBodyRules> Rules { get; set; }
        public class ListRulesResponseBodyRules : TeaModel {
            /// <summary>
            /// The direction to which the forwarding rule is applied. Valid values:
            /// 
            /// *   Request (default): The forwarding rule is applied to requests. The forwarding action is performed on packets that are forwarded from clients to ALB.
            /// *   Responses: The forwarding rule is applied to responses. The forwarding action is performed on packets that are returned from backend servers to ALB.
            /// 
            /// >  Basic ALB instances support only the Response direction.
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// The ID of the listener that is associated with the forwarding rule.
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// The ID of the Application Load Balancer (ALB) instance that is associated with the forwarding rule.
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// The priority of the forwarding rule. Valid values: **1 to 10000**. A smaller value indicates a higher priority.
            /// 
            /// >  The priority of each forwarding rule added to a listener must be unique.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// The action of the forwarding rule.
            /// </summary>
            [NameInMap("RuleActions")]
            [Validation(Required=false)]
            public List<ListRulesResponseBodyRulesRuleActions> RuleActions { get; set; }
            public class ListRulesResponseBodyRulesRuleActions : TeaModel {
                /// <summary>
                /// The CORS configuration.
                /// </summary>
                [NameInMap("CorsConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsCorsConfig CorsConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsCorsConfig : TeaModel {
                    /// <summary>
                    /// Indicates whether credentials can be carried in CORS requests. Valid values:
                    /// 
                    /// *   **on**
                    /// *   **off**
                    /// </summary>
                    [NameInMap("AllowCredentials")]
                    [Validation(Required=false)]
                    public string AllowCredentials { get; set; }

                    /// <summary>
                    /// The allowed headers of CORS requests.
                    /// </summary>
                    [NameInMap("AllowHeaders")]
                    [Validation(Required=false)]
                    public List<string> AllowHeaders { get; set; }

                    /// <summary>
                    /// The allowed HTTP methods of CORS requests.
                    /// </summary>
                    [NameInMap("AllowMethods")]
                    [Validation(Required=false)]
                    public List<string> AllowMethods { get; set; }

                    /// <summary>
                    /// The allowed origins of CORS requests.
                    /// </summary>
                    [NameInMap("AllowOrigin")]
                    [Validation(Required=false)]
                    public List<string> AllowOrigin { get; set; }

                    /// <summary>
                    /// The headers that can be exposed.
                    /// </summary>
                    [NameInMap("ExposeHeaders")]
                    [Validation(Required=false)]
                    public List<string> ExposeHeaders { get; set; }

                    /// <summary>
                    /// The maximum cache time of dry runs in the browser. Unit: seconds.
                    /// 
                    /// Valid values: **-1** to **172800**.
                    /// </summary>
                    [NameInMap("MaxAge")]
                    [Validation(Required=false)]
                    public long? MaxAge { get; set; }

                }

                /// <summary>
                /// The configuration of the custom response.
                /// </summary>
                [NameInMap("FixedResponseConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsFixedResponseConfig FixedResponseConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsFixedResponseConfig : TeaModel {
                    /// <summary>
                    /// The content of the custom response. The content can be up to 1 KB in size, and can contain only ASCII characters.
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// The format of the response.
                    /// 
                    /// Valid values: **text/plain**, **text/css**, **text/html**, **application/javascript**, and **application/json**.
                    /// </summary>
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    /// <summary>
                    /// The HTTP status code in responses. Valid values: **HTTP_2xx**, **HTTP_4xx**, and **HTTP_5xx**. **x** is a digit.
                    /// </summary>
                    [NameInMap("HttpCode")]
                    [Validation(Required=false)]
                    public string HttpCode { get; set; }

                }

                /// <summary>
                /// The configurations of the server groups.
                /// </summary>
                [NameInMap("ForwardGroupConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsForwardGroupConfig : TeaModel {
                    /// <summary>
                    /// The session persistence configurations of the server group.
                    /// </summary>
                    [NameInMap("ServerGroupStickySession")]
                    [Validation(Required=false)]
                    public ListRulesResponseBodyRulesRuleActionsForwardGroupConfigServerGroupStickySession ServerGroupStickySession { get; set; }
                    public class ListRulesResponseBodyRulesRuleActionsForwardGroupConfigServerGroupStickySession : TeaModel {
                        /// <summary>
                        /// If the value of N in ServerGroupTuple.N is larger than 1, you can enable or disable session persistence for server groups.
                        /// </summary>
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        /// <summary>
                        /// If Enabled is set to True, you can specify a session persistence timeout period.
                        /// </summary>
                        [NameInMap("Timeout")]
                        [Validation(Required=false)]
                        public int? Timeout { get; set; }

                    }

                    /// <summary>
                    /// The server groups to which requests are forwarded.
                    /// </summary>
                    [NameInMap("ServerGroupTuples")]
                    [Validation(Required=false)]
                    public List<ListRulesResponseBodyRulesRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class ListRulesResponseBodyRulesRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
                        /// <summary>
                        /// The server group to which requests are forwarded.
                        /// </summary>
                        [NameInMap("ServerGroupId")]
                        [Validation(Required=false)]
                        public string ServerGroupId { get; set; }

                        /// <summary>
                        /// The weight of the server group. Valid values: **0** to **100**.
                        /// </summary>
                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public int? Weight { get; set; }

                    }

                }

                /// <summary>
                /// The key of the header to be inserted.
                /// </summary>
                [NameInMap("InsertHeaderConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsInsertHeaderConfig InsertHeaderConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsInsertHeaderConfig : TeaModel {
                    /// <summary>
                    /// The key of the header. The header key must be 1 to 40 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The header key specified in `InsertHeader` must be unique.
                    /// 
                    /// >  **Cookie** and **Host** are not supported.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The value of the header to be inserted.
                    /// 
                    /// *   If **ValueType** is set to **SystemDefined**, you can set the Value parameter to one of the following values:
                    /// 
                    ///     *   **ClientSrcPort**: the client port.
                    ///     *   **ClientSrcIp**: the IP address of the client.
                    ///     *   **Protocol**: the request protocol (HTTP or HTTPS).
                    ///     *   **SLBId**: the ID of the ALB instance.
                    ///     *   **SLBPort**: the listener port.
                    /// 
                    /// *   If **ValueType** is set to **UserDefined**, you can specify a custom header value. The header value must be 1 to 128 characters in length, and can contain wildcard characters, such as asterisks (\\*) and question marks (?), and printable characters whose ASCII values are `larger than or equal to 32 and smaller than 127`. The header value cannot start or end with a space character.
                    /// 
                    /// *   If **ValueType** is set to **ReferenceHeader**, you can reference a value from a request header. The header value must be 1 to 128 characters in length, and can contain lowercase letters, digits, hyphens (-), and underscores (_).
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    /// <summary>
                    /// The type of the header value. Valid values:
                    /// 
                    /// *   **UserDefined**: a user-defined header value.
                    /// *   **ReferenceHeader**: a header value that is referenced from a request header.
                    /// *   **SystemDefined:** a system-defined header value.
                    /// </summary>
                    [NameInMap("ValueType")]
                    [Validation(Required=false)]
                    public string ValueType { get; set; }

                }

                /// <summary>
                /// The priority of the action. Valid values: **1 to 50000**. A smaller value indicates a higher priority. The actions of a forwarding rule are applied in descending order of priority. This parameter cannot empty. The priority of each action within a forwarding rule must be unique.
                /// </summary>
                [NameInMap("Order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                /// <summary>
                /// The configuration of the redirect action.
                /// </summary>
                [NameInMap("RedirectConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsRedirectConfig RedirectConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsRedirectConfig : TeaModel {
                    /// <summary>
                    /// The hostname to which requests are redirected. Valid values:
                    /// 
                    /// *   **${host}** (default): If ${host} is returned, no other characters are appended.
                    /// 
                    /// *   A custom value. Make sure that the custom value meets the following requirements:
                    /// 
                    ///     *   The hostname must be 3 to 128 characters in length, and can contain lowercase letters, digits, hyphens (-), periods (.), asterisks (\\*), and question marks (?).
                    ///     *   The hostname must contain at least one period (.) but cannot start or end with a period (.).
                    ///     *   The rightmost domain label can contain only letters and wildcard characters. It cannot contain digits or hyphens (-).
                    ///     *   The domain labels cannot start or end with a hyphen (-).
                    ///     *   You can use asterisks (\\*) and question marks (?) anywhere in a domain label as wildcard characters.
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// The forwarding method. Valid values: **301**, **302**, **303**, **307**, and **308**.
                    /// </summary>
                    [NameInMap("HttpCode")]
                    [Validation(Required=false)]
                    public string HttpCode { get; set; }

                    /// <summary>
                    /// The URL to which requests are redirected. Valid values:
                    /// 
                    /// *   **${path}** (default): You can reference \\*\\*${host}**, **${protocol}**, and**${port}**. The URL can consist of **${host}**,**${protocol}**, and **${port}\\*\\*. Each variable can be used only once. The preceding variables can be used at the same time or combined with a custom value.
                    /// 
                    /// *   A custom value. Make sure that the custom value meets the following requirements:
                    /// 
                    ///     *   The URL must be 1 to 128 characters in length.
                    ///     *   It must start with a forward slash (/) and can contain letters, digits, and the following special characters: `$ - _ .+ / & ~ @ :`. It cannot contain the following special characters: `" % # ; ! ( ) [ ] ^ , "`. You can use asterisks (\\*) and question marks (?) as wildcard characters.
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// The port to which requests are redirected. Valid values:
                    /// 
                    /// *   **${port}** (default): If ${port} is returned, no other characters are appended.
                    /// *   Other valid values: **1 to 63335**.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    /// <summary>
                    /// The redirect protocol. Valid values:
                    /// 
                    /// *   **${protocol}** (default): If ${protocol} is returned, no other characters are appended.
                    /// *   **HTTP** or **HTTPS**
                    /// 
                    /// >  HTTPS listeners supports only HTTPS redirects.
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// The query string of the URL to which requests are redirected. The query string must be 1 to 128 characters in length, and can contain printable characters, excluding uppercase letters and the following special characters: `# [ ] { } \\ | < > &`.
                    /// </summary>
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                }

                /// <summary>
                /// The HTTP header to be removed.
                /// </summary>
                [NameInMap("RemoveHeaderConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsRemoveHeaderConfig RemoveHeaderConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsRemoveHeaderConfig : TeaModel {
                    /// <summary>
                    /// The key of the header to be removed. The header key must be 1 to 40 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The header keys specified in RemoveHeader must be unique.
                    /// 
                    /// *   If Direction is set to Request, the specified headers are removed from requests. The following header keys are not supported (not case-sensitive): `slb-id`, `slb-ip`, `x-forwarded-for`, `x-forwarded-proto`, `x-forwarded-eip`, `x-forwarded-port`, `x-forwarded-client-srcport`, `connection`, `upgrade`, `content-length`, `transfer-encoding`, `keep-alive`, `te`, `host`, `cookie`, `remoteip`, and `authority`.
                    /// *   If Direction is set to Response, the specified headers are removed from responses. The following header keys are not supported (not case-sensitive): `connection`, `upgrade`, `content-length`, and `transfer-encoding`.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                }

                /// <summary>
                /// The configuration of the rewrite action.
                /// </summary>
                [NameInMap("RewriteConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsRewriteConfig RewriteConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsRewriteConfig : TeaModel {
                    /// <summary>
                    /// The hostname to which requests are redirected. Valid values:
                    /// 
                    /// *   **${host}** (default): If ${host} is returned, no other characters are appended.
                    /// 
                    /// *   A custom value. Make sure that the custom value meets the following requirements:
                    /// 
                    ///     *   The hostname must be 3 to 128 characters in length, and can contain lowercase letters, digits, hyphens (-), periods (.), asterisks (\\*), and question marks (?).
                    ///     *   The hostname must contain at least one period (.) but cannot start or end with a period (.).
                    ///     *   The rightmost domain label can contain only letters and wildcard characters. It cannot contain digits or hyphens (-).
                    ///     *   The domain labels cannot start or end with a hyphen (-).
                    ///     *   You can use asterisks (\\*) and question marks (?) anywhere in a domain label as wildcard characters.
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// The URL to which requests are redirected. The URL must be 1 to 128 characters in length, and can contain letters, digits, asterisks (\\*), question marks (?), and the following special characters: `$ - _ . + / & ~ @ :`. It must start with a forward slash (/) and does not contain the following special characters: `" % # ; ! ( ) [ ] ^ , "`.
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// The query string of the URL to which requests are redirected. The query string must be 1 to 128 characters in length, and can contain printable characters, excluding uppercase letters and the following special characters: `# [ ] { } \\ | < > &`.
                    /// </summary>
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                }

                /// <summary>
                /// The configuration of traffic throttling.
                /// </summary>
                [NameInMap("TrafficLimitConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsTrafficLimitConfig TrafficLimitConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsTrafficLimitConfig : TeaModel {
                    /// <summary>
                    /// The number of requests per IP address. Valid values: **1 to 100000**.
                    /// 
                    /// >  If both the **QPS** and **PerIpQps** parameters are specified, the value of the **QPS** parameter is smaller than the value of the PerIpQps parameter.
                    /// </summary>
                    [NameInMap("PerIpQps")]
                    [Validation(Required=false)]
                    public int? PerIpQps { get; set; }

                    /// <summary>
                    /// The number of queries per second (QPS). Valid values: **1** to **100000**.
                    /// </summary>
                    [NameInMap("QPS")]
                    [Validation(Required=false)]
                    public int? QPS { get; set; }

                }

                /// <summary>
                /// The configuration of traffic mirroring.
                /// </summary>
                [NameInMap("TrafficMirrorConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsTrafficMirrorConfig TrafficMirrorConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsTrafficMirrorConfig : TeaModel {
                    /// <summary>
                    /// The configuration of the server group to which traffic is mirrored.
                    /// </summary>
                    [NameInMap("MirrorGroupConfig")]
                    [Validation(Required=false)]
                    public ListRulesResponseBodyRulesRuleActionsTrafficMirrorConfigMirrorGroupConfig MirrorGroupConfig { get; set; }
                    public class ListRulesResponseBodyRulesRuleActionsTrafficMirrorConfigMirrorGroupConfig : TeaModel {
                        /// <summary>
                        /// The server group to which traffic is mirrored.
                        /// </summary>
                        [NameInMap("ServerGroupTuples")]
                        [Validation(Required=false)]
                        public List<ListRulesResponseBodyRulesRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                        public class ListRulesResponseBodyRulesRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples : TeaModel {
                            /// <summary>
                            /// The ID of the server group.
                            /// </summary>
                            [NameInMap("ServerGroupId")]
                            [Validation(Required=false)]
                            public string ServerGroupId { get; set; }

                            /// <summary>
                            /// The weight of the server group. Valid values: **0** to **100**.
                            /// </summary>
                            [NameInMap("Weight")]
                            [Validation(Required=false)]
                            public int? Weight { get; set; }

                        }

                    }

                    /// <summary>
                    /// The destination to which traffic is mirrored. The destination can be a server group.
                    /// </summary>
                    [NameInMap("TargetType")]
                    [Validation(Required=false)]
                    public string TargetType { get; set; }

                }

                /// <summary>
                /// The action. Valid values:
                /// 
                /// *   **ForwardGroup**: distributes requests to multiple vServer groups.
                /// *   **Redirect**: redirects requests.
                /// *   **FixedResponse**: returns a custom response.
                /// *   **Rewrite**: rewrites requests.
                /// *   **InsertHeader**: inserts headers.
                /// *   **RemoveHeaderConfig**: removes headers.
                /// *   **TrafficLimitConfig**: throttles network traffic.
                /// *   **TrafficMirrorConfig**: mirrors network traffic.
                /// *   **CorsConfig**: forwards requests based on CORS.
                /// 
                /// The preceding actions can be classified into two broad types:
                /// 
                /// *   **FinalType**: Each forwarding rule can contain only one FinalType action, which is performed at the end. You can specify only one of **ForwardGroup**, **Redirect**, and **FixedResponse**.
                /// *   **ExtType**: Each forwarding rule can contain one or more **ExtType** actions, which are performed before the **FinalType** action. If you want to specify an ExtType action, you must also specify a **FinalType** action. You can specify multiple **InsertHeader** actions or one **Rewrite** action.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The conditions of the forwarding rule.
            /// </summary>
            [NameInMap("RuleConditions")]
            [Validation(Required=false)]
            public List<ListRulesResponseBodyRulesRuleConditions> RuleConditions { get; set; }
            public class ListRulesResponseBodyRulesRuleConditions : TeaModel {
                /// <summary>
                /// The key-value pairs of the cookie.
                /// </summary>
                [NameInMap("CookieConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleConditionsCookieConfig CookieConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsCookieConfig : TeaModel {
                    /// <summary>
                    /// The cookie value.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<ListRulesResponseBodyRulesRuleConditionsCookieConfigValues> Values { get; set; }
                    public class ListRulesResponseBodyRulesRuleConditionsCookieConfigValues : TeaModel {
                        /// <summary>
                        /// The cookie key. The cookie key must be 1 to 100 characters in length, and can contain lowercase letters, printable ASCII characters, asterisks (\\*), and question marks (?). It cannot contain space characters or the following special characters: `# [ ] { } \\ | < > &`.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The cookie value. The cookie value must be 1 to 128 characters in length, and can contain lowercase letters, printable ASCII characters, asterisks (\\*), and question marks (?). It cannot contain space characters or the following special characters: `# [ ] { } \\ | < > &`.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The configuration of the header.
                /// </summary>
                [NameInMap("HeaderConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleConditionsHeaderConfig HeaderConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsHeaderConfig : TeaModel {
                    /// <summary>
                    /// The key of the header. The header key must be 1 to 40 characters in length. It can contain letters, digits, hyphens (-), and underscores (_). Cookie and Host are not supported.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The value of the header.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The configuration of the hosts.
                /// </summary>
                [NameInMap("HostConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleConditionsHostConfig HostConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsHostConfig : TeaModel {
                    /// <summary>
                    /// The hostnames.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The configurations of the request methods.
                /// </summary>
                [NameInMap("MethodConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleConditionsMethodConfig MethodConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsMethodConfig : TeaModel {
                    /// <summary>
                    /// The request methods.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The configurations of the forwarding URLs.
                /// </summary>
                [NameInMap("PathConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleConditionsPathConfig PathConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsPathConfig : TeaModel {
                    /// <summary>
                    /// The URLs to which requests are forwarded.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The configurations of the query strings.
                /// </summary>
                [NameInMap("QueryStringConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleConditionsQueryStringConfig QueryStringConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsQueryStringConfig : TeaModel {
                    /// <summary>
                    /// The query string.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<ListRulesResponseBodyRulesRuleConditionsQueryStringConfigValues> Values { get; set; }
                    public class ListRulesResponseBodyRulesRuleConditionsQueryStringConfigValues : TeaModel {
                        /// <summary>
                        /// They key of the query string. The key must be 1 to 100 characters in length, and can contain lowercase letters, printable ASCII characters, asterisks (\\*), and question marks (?). It cannot contain space characters or the following special characters: `# [ ] { } \\ | < > &`.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of the query string. The value must be 1 to 128 characters in length, and can contain lowercase letters, printable ASCII characters, asterisks (\\*), and question marks (?). It cannot contain space characters or the following special characters: `# [ ] { } \\ | < > &`.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The HTTP header in responses.
                /// </summary>
                [NameInMap("ResponseHeaderConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleConditionsResponseHeaderConfig ResponseHeaderConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsResponseHeaderConfig : TeaModel {
                    /// <summary>
                    /// The key of the HTTP header. The header key must be 1 to 40 characters in length, It can contain letters, digits, hyphens (-), and underscores (_). Cookie and Host are not supported.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The values of the HTTP header.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The configurations of the response status codes.
                /// </summary>
                [NameInMap("ResponseStatusCodeConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleConditionsResponseStatusCodeConfig ResponseStatusCodeConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsResponseStatusCodeConfig : TeaModel {
                    /// <summary>
                    /// The response status codes.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// Traffic matching based on source IP addresses.
                /// </summary>
                [NameInMap("SourceIpConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleConditionsSourceIpConfig SourceIpConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsSourceIpConfig : TeaModel {
                    /// <summary>
                    /// The source IP addresses.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The type of forwarding rule. Valid values:
                /// 
                /// *   **Host**: Responses are forwarded based on hosts.
                /// *   **Path**: Responses are forwarded based on URLs.
                /// *   **Header**: Responses are forwarded based on HTTP headers.
                /// *   **QueryString**: Responses are forwarded based on query strings.
                /// *   **Method**: Responses are forwarded based on request methods.
                /// *   **Cookie**: Responses are forwarded based on cookies.
                /// *   **SourceIp**: Responses are forwarded based on source IP addresses.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The ID of the forwarding rule.
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// The name of the forwarding rule. The name must be 2 to 128 letters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The status of the forwarding rule. Valid values:
            /// 
            /// *   **Provisioning**: The forwarding rule is being created.
            /// *   **Configuring**: The forwarding rule is being modified.
            /// *   **Available**: The forwarding rule is available.
            /// </summary>
            [NameInMap("RuleStatus")]
            [Validation(Required=false)]
            public string RuleStatus { get; set; }

            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListRulesResponseBodyRulesTags> Tags { get; set; }
            public class ListRulesResponseBodyRulesTags : TeaModel {
                /// <summary>
                /// The tag key. The tag key can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http:// or https://.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value. The tag value can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http:// or https://.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
