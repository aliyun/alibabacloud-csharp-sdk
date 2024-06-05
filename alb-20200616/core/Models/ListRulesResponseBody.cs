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
        /// The forwarding rules.
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<ListRulesResponseBodyRules> Rules { get; set; }
        public class ListRulesResponseBodyRules : TeaModel {
            /// <summary>
            /// The direction to which the forwarding rule is applied. Valid values:
            /// 
            /// *   Request (default): The rule applies to client requests.
            /// *   Response: The rule applies to responses from backend servers.
            /// 
            /// > Response is not supported by basic ALB instances.
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// The ID of the listener to which the forwarding rule belongs.
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// The ID of the ALB instance to which the forwarding rule belongs.
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// The priority of the forwarding rule. Valid values: **1 to 10000**. A smaller value indicates a higher priority.
            /// 
            /// > The priority of each forwarding rule added to a listener must be unique.
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
                    /// The allowed headers for CORS requests.
                    /// </summary>
                    [NameInMap("AllowHeaders")]
                    [Validation(Required=false)]
                    public List<string> AllowHeaders { get; set; }

                    /// <summary>
                    /// The allowed HTTP methods for CORS requests.
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
                    /// The maximum cache time of dry run requests in the browser. Unit: seconds.
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
                    /// The content of the custom response. The content is up to 1 KB in size, and can contain only ASCII characters.
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// The content type.
                    /// 
                    /// Valid values: **text/plain**, **text/css**, **text/html**, **application/javascript**, and **application/json**.
                    /// </summary>
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    /// <summary>
                    /// The HTTP status code in the response. Valid values: **HTTP_2xx**, **HTTP_4xx**, and **HTTP_5xx**. **x** must be a digit.
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
                    [NameInMap("ServerGroupStickySession")]
                    [Validation(Required=false)]
                    public ListRulesResponseBodyRulesRuleActionsForwardGroupConfigServerGroupStickySession ServerGroupStickySession { get; set; }
                    public class ListRulesResponseBodyRulesRuleActionsForwardGroupConfigServerGroupStickySession : TeaModel {
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

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
                        /// The weight. Valid values: **0** to **100**.
                        /// </summary>
                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public int? Weight { get; set; }

                    }

                }

                /// <summary>
                /// The configuration of the header to be inserted.
                /// </summary>
                [NameInMap("InsertHeaderConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsInsertHeaderConfig InsertHeaderConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsInsertHeaderConfig : TeaModel {
                    /// <summary>
                    /// The key of the header. The key must be 1 to 40 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The key specified in `InsertHeader` must be unique.
                    /// 
                    /// > **Cookie** and **Host** are not supported.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The value of the header.
                    /// 
                    /// *   If **ValueType** is set to **SystemDefined**, one of the following values is supported:
                    /// 
                    ///     *   **ClientSrcPort**: the client port.
                    ///     *   **ClientSrcIp**: the client IP address.
                    ///     *   **Protocol**: the request protocol (HTTP or HTTPS).
                    ///     *   **SLBId**: the ID of the ALB instance.
                    ///     *   **SLBPort**: the listener port.
                    /// 
                    /// *   If **ValueType** is set to **UserDefined**, a custom header value is supported. The header value must be 1 to 128 characters in length, and can contain printable characters whose ASCII values are `greater than or equal to 32 and lower than 127`. You can use asterisks (\\*) and question marks (?) as wildcard characters. The header value cannot start or end with a space character.
                    /// 
                    /// *   If **ValueType** is set to **ReferenceHeader**, one of the request headers is referenced. The header value must be 1 to 128 characters in length, and can contain lowercase letters, digits, underscores (_), and hyphens (-).
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    /// <summary>
                    /// The type of the header. Valid values:
                    /// 
                    /// *   **UserDefined**: a user-defined header.
                    /// *   **ReferenceHeader**: a header that is referenced from a request header.
                    /// *   **SystemDefined**: a system-defined header.
                    /// </summary>
                    [NameInMap("ValueType")]
                    [Validation(Required=false)]
                    public string ValueType { get; set; }

                }

                /// <summary>
                /// The priority of the action. Valid values: **1 to 50000**. A smaller value indicates a higher priority. The actions of a forwarding rule are applied in descending order of priority. This parameter is not empty. The priority of each action within a forwarding rule is unique.
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
                    /// *   **${host}** (default): If ${host} is returned, no other character is appended.
                    /// 
                    /// *   Limits on a custom value:
                    /// 
                    ///     *   The hostname is 3 to 128 characters in length, and can contain lowercase letters, digits, hyphens (-), and periods (.). Asterisks (\\*) and question marks (?) can be used as wildcard characters.
                    ///     *   The hostname contains at least one period (.) but does not start or end with a period (.).
                    ///     *   The rightmost domain label contains only letters and wildcard characters. It does not contain digits or hyphens (-).
                    ///     *   The domain labels do not start or end with hyphens (-).
                    ///     *   You can use asterisks (\\*) and question marks (?) anywhere in a domain label as wildcard characters.
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// The redirect type. Valid values: **301**, **302**, **303**, **307**, and **308**.
                    /// </summary>
                    [NameInMap("HttpCode")]
                    [Validation(Required=false)]
                    public string HttpCode { get; set; }

                    /// <summary>
                    /// The path to which requests are redirected. Valid values:
                    /// 
                    /// *   **${path}** (default): You can reference \\*\\*${host}**, **${protocol}**, and**${port}**. The path can consist of **${host}**,**${protocol}**, and **${port}\\*\\*. Each variable can be used only once. The preceding variables can be used at the same time or combined with a custom value.
                    /// 
                    /// *   Limits on a custom value:
                    /// 
                    ///     *   The value is 1 to 128 characters in length.
                    ///     *   It starts with a forward slash (/) and contains letters, digits, and the following special characters: `$ - _ .+ / & ~ @ :`. It does not contain the following special characters: `" % # ; ! ( ) [ ] ^ , "`. You can use asterisks (\\*) and question marks (?) as wildcard characters.
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// The port to which requests are redirected. Valid values:
                    /// 
                    /// *   **${port}** (default): If ${port} is returned, no other character is appended.
                    /// *   Other valid values: **1 to 63335**.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    /// <summary>
                    /// The redirect protocol. Valid values:
                    /// 
                    /// *   **${protocol}** (default): If ${protocol} is returned, no other character is appended.
                    /// *   **HTTP** or **HTTPS**.
                    /// 
                    /// > HTTPS listeners support only HTTP to HTTPS redirection.
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// The query string to which requests are redirected. The query string must be 1 to 128 characters in length, and can contain printable characters, excluding uppercase letters and the following special characters: `# [ ] { } \\ | < > &`.
                    /// </summary>
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                }

                /// <summary>
                /// The configuration of the header to be removed.
                /// </summary>
                [NameInMap("RemoveHeaderConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsRemoveHeaderConfig RemoveHeaderConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsRemoveHeaderConfig : TeaModel {
                    /// <summary>
                    /// The key of the header to be removed. The key must be 1 to 40 characters in length and can contain letters, digits, underscores, and hyphens (-). The header key must be unique.
                    /// 
                    /// *   You cannot specify the following header keys for an inbound forwarding rule: `slb-id`, `slb-ip`, `x-forwarded-for`, `x-forwarded-proto`, `x-forwarded-eip`, `x-forwarded-port`, `x-forwarded-client-srcport`, `connection`, `upgrade`, `content-length`, `transfer-encoding`, `keep-alive`, `te`, `host`, `cookie`, `remoteip`, and `authority`. The preceding keys are case-insensitive.
                    /// *   You cannot specify the following header keys for an outbound forwarding rule: `connection`, `upgrade`, `content-length`, and `transfer-encoding`. The preceding keys are case-insensitive.
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
                    /// The hostname to which requests are forwarded. Valid values:
                    /// 
                    /// *   **${host}** (default): If ${host} is returned, no other character is appended.
                    /// 
                    /// *   Limits on a custom value:
                    /// 
                    ///     *   The hostname is 3 to 128 characters in length, and can contain lowercase letters, digits, hyphens (-), and periods (.). Asterisks (\\*) and question marks (?) can be used as wildcard characters.
                    ///     *   The hostname contains at least one period (.) but does not start or end with a period (.).
                    ///     *   The rightmost domain label contains only letters and wildcard characters. It does not contain digits or hyphens (-).
                    ///     *   The domain labels do not start or end with hyphens (-).
                    ///     *   You can use asterisks (\\*) and question marks (?) anywhere in a domain label as wildcard characters.
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// The path to which requests are forwarded. The path is 1 to 128 characters in length and starts with a forward slash (/). The path can contain letters, digits, asterisks (\\*), question marks (?), and the following special characters: `$ - _ . + / & ~ @ :`. The path does not contain the following special characters: `" % # ; ! ( ) [ ] ^ , "`.
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// The query string of the URL to which requests are forwarded. The query string is 1 to 128 characters in length, and can contain printable characters, excluding uppercase letters and the following special characters: `# [ ] { } \\ | < > &`.
                    /// </summary>
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                }

                /// <summary>
                /// The configuration of the action to throttle traffic.
                /// </summary>
                [NameInMap("TrafficLimitConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsTrafficLimitConfig TrafficLimitConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsTrafficLimitConfig : TeaModel {
                    /// <summary>
                    /// The QPS of each IP address. Valid values: **1 to 100000**.
                    /// 
                    /// > If you specify this parameter and **QPS**, the value of **PerIpQps** must be smaller than the value of **QPS**.
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
                /// The configuration of the action to mirror traffic.
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
                            /// The server group ID.
                            /// </summary>
                            [NameInMap("ServerGroupId")]
                            [Validation(Required=false)]
                            public string ServerGroupId { get; set; }

                            /// <summary>
                            /// The weight. Valid values: **0** to **100**.
                            /// </summary>
                            [NameInMap("Weight")]
                            [Validation(Required=false)]
                            public int? Weight { get; set; }

                        }

                    }

                    [NameInMap("TargetType")]
                    [Validation(Required=false)]
                    public string TargetType { get; set; }

                }

                /// <summary>
                /// The action. Valid values:
                /// 
                /// *   **ForwardGroup**: distributes requests to multiple vServer groups.
                /// *   **Redirect**: redirects a request.
                /// *   **FixedResponse**: returns a custom response.
                /// *   **Rewrite**: rewrites a request.
                /// *   **InsertHeader**: inserts a header.
                /// *   **RemoveHeaderConfig**: deletes a header.
                /// *   **TrafficLimitConfig**: throttles network traffic.
                /// *   **TrafficMirrorConfig**: mirrors traffic.
                /// *   **CorsConfig**: forwards requests based on CORS.
                /// 
                /// The preceding actions can be classified into two broad types:
                /// 
                /// *   **FinalType**: the last action to be performed in a forwarding rule. Each forwarding rule can contain only one FinalType action. You can specify a **ForwardGroup**, **Redirect**, or **FixedResponse** action as the FinalType action.
                /// *   **ExtType**: one or more actions to be performed before the **FinalType** action. A forwarding rule can contain one or more **ExtType** actions. To specify an ExtType action, you must specify a **FinalType** action. You can specify multiple **InsertHeader** actions or one **Rewrite** action.
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
                /// The configuration of the cookie.
                /// </summary>
                [NameInMap("CookieConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleConditionsCookieConfig CookieConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsCookieConfig : TeaModel {
                    /// <summary>
                    /// The key-value pair of the cookie.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<ListRulesResponseBodyRulesRuleConditionsCookieConfigValues> Values { get; set; }
                    public class ListRulesResponseBodyRulesRuleConditionsCookieConfigValues : TeaModel {
                        /// <summary>
                        /// The key of the cookie. The key is 1 to 100 characters in length, and can contain printable characters such as lowercase letters, asterisks (\\*), and question marks (?). The key cannot contain uppercase letters, space characters, or the following special characters: `# [ ] { } \\ | < > &`.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of the cookie. The value is 1 to 128 characters in length, and can contain printable characters such as lowercase letters, asterisks (\\*), and question marks (?). Uppercase letters, space characters, and the following special characters are not supported: `# [ ] { } \\ | < > &`.
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
                    /// The key of the header. The key must be 1 to 40 characters in length, and can contain lowercase letters, digits, hyphens (-), and underscores (_). Cookie and Host are not supported.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The values of the header.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The configurations of the hosts.
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
                /// The configurations of the paths.
                /// </summary>
                [NameInMap("PathConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleConditionsPathConfig PathConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsPathConfig : TeaModel {
                    /// <summary>
                    /// The paths.
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
                        /// They key of the query string. The key must be 1 to 100 characters in length, and can contain printable characters such as lowercase letters, asterisks (\\*), and question marks (?). The key cannot contain uppercase letters, space characters, or the following special characters: `# [ ] { } \\ | < > &`.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of the query string. The value must be 1 to 128 characters in length, and can contain printable characters such as lowercase letters, asterisks (\\*), and question marks (?). However, uppercase letters, space characters, and the following special characters are not supported: `# [ ] { } \\ | < > &`.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The configuration of the HTTP response header.
                /// </summary>
                [NameInMap("ResponseHeaderConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleConditionsResponseHeaderConfig ResponseHeaderConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsResponseHeaderConfig : TeaModel {
                    /// <summary>
                    /// The header key. The key must be 1 to 40 characters in length, and can contain lowercase letters, digits, hyphens (-), and underscores (_). Cookie and Host are not supported.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The header values.
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
                /// The configuration of the source IP addresses based on which user traffic is matched.
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
                /// *   **Host**: Requests are forwarded based on hosts.
                /// *   **Path**: Requests are forwarded based on paths.
                /// *   **Header**: Requests are forwarded based on HTTP headers.
                /// *   **QueryString**: Requests are forwarded based on query strings.
                /// *   **Method**: Requests are forwarded based on request methods.
                /// *   **Cookie**: Requests are forwarded based on cookies.
                /// *   **SourceIp**: Requests are distributed based on source IP addresses.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The forwarding rule ID.
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// The name of the forwarding rule. The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The status of the forwarding rule. Valid values:
            /// 
            /// *   **Provisioning**
            /// *   **Configuring**
            /// *   **Available**
            /// </summary>
            [NameInMap("RuleStatus")]
            [Validation(Required=false)]
            public string RuleStatus { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListRulesResponseBodyRulesTags> Tags { get; set; }
            public class ListRulesResponseBodyRulesTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

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
