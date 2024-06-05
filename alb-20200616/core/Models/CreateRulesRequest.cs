// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateRulesRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// > If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   **true**: performs a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false** (default): performs a dry run and sends the request. If the request passes the dry run, a `2xx HTTP` status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The listener ID of the ALB instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// The forwarding rules. You can specify at most 10 forwarding rules in each call.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<CreateRulesRequestRules> Rules { get; set; }
        public class CreateRulesRequestRules : TeaModel {
            /// <summary>
            /// The direction to which the forwarding rule is applied. You can specify only one direction. Valid values:
            /// 
            /// *   **Request** (default): The forwarding rule is applied to the client requests received by ALB.
            /// *   **Response**: The forwarding rule is applied to the responses returned by backend servers.
            /// 
            /// >  Basic ALB instances do not support forwarding rules of the **Response** type.
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// The priority of the forwarding rule. Valid values: **1** to **10000**. A lower value specifies a higher priority. You can specify priorities for at most 10 forwarding rules.
            /// 
            /// >  The priority of each forwarding rule added to a listener must be unique.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// The actions of the forwarding rule.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("RuleActions")]
            [Validation(Required=false)]
            public List<CreateRulesRequestRulesRuleActions> RuleActions { get; set; }
            public class CreateRulesRequestRulesRuleActions : TeaModel {
                /// <summary>
                /// The CORS configuration.
                /// </summary>
                [NameInMap("CorsConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsCorsConfig CorsConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsCorsConfig : TeaModel {
                    /// <summary>
                    /// Specifies whether to allow credentials to be carried in CORS requests. Valid values:
                    /// 
                    /// *   **on**: allows credentials to be carried in CORS requests.
                    /// *   **off**: does not allow credentials to be carried in CORS requests.
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
                    /// The maximum cache time of preflight requests in the browser. Unit: seconds.
                    /// 
                    /// Valid values: **-1** to **172800**.
                    /// </summary>
                    [NameInMap("MaxAge")]
                    [Validation(Required=false)]
                    public long? MaxAge { get; set; }

                }

                /// <summary>
                /// The configuration of the custom response. You can specify at most 20 responses.
                /// </summary>
                [NameInMap("FixedResponseConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsFixedResponseConfig FixedResponseConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsFixedResponseConfig : TeaModel {
                    /// <summary>
                    /// The content of the custom response. The content can be up to 1 KB in size and can contain only ASCII characters.
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// The format of the content. Valid values:
                    /// 
                    /// *   **text/plain**
                    /// *   **text/css**
                    /// *   **text/html**
                    /// *   **application/javascript**
                    /// *   **application/json**
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
                /// The configuration of the server group. You can add at most 20 server groups.
                /// </summary>
                [NameInMap("ForwardGroupConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsForwardGroupConfig : TeaModel {
                    /// <summary>
                    /// The configuration of session persistence for server groups.
                    /// </summary>
                    [NameInMap("ServerGroupStickySession")]
                    [Validation(Required=false)]
                    public CreateRulesRequestRulesRuleActionsForwardGroupConfigServerGroupStickySession ServerGroupStickySession { get; set; }
                    public class CreateRulesRequestRulesRuleActionsForwardGroupConfigServerGroupStickySession : TeaModel {
                        /// <summary>
                        /// Specifies whether to enable session persistence. Valid values:
                        /// 
                        /// *   **true**: enables session persistence.
                        /// *   **false** (default): disables session persistence.
                        /// </summary>
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        /// <summary>
                        /// The timeout period of sessions. Unit: seconds. Valid values: **1 to 86400**.
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
                    public List<CreateRulesRequestRulesRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class CreateRulesRequestRulesRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
                        /// <summary>
                        /// The server group to which requests are distributed.
                        /// </summary>
                        [NameInMap("ServerGroupId")]
                        [Validation(Required=false)]
                        public string ServerGroupId { get; set; }

                        /// <summary>
                        /// The weight of the server group. A larger value specifies a higher weight. A server group with a higher weight receives more requests. Valid values: **0** to **100**.
                        /// 
                        /// *   If only one destination server group exists and you do not specify a weight, the default value **100** is used.
                        /// *   If more than one destination server group exists, you must specify weights.
                        /// </summary>
                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public int? Weight { get; set; }

                    }

                }

                /// <summary>
                /// The configuration of the header to be inserted. You can specify at most 20 headers.
                /// </summary>
                [NameInMap("InsertHeaderConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsInsertHeaderConfig InsertHeaderConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsInsertHeaderConfig : TeaModel {
                    /// <summary>
                    /// The key of the header. The key must be 1 to 40 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The header key specified by **InsertHeaderConfig** must be unique.
                    /// 
                    /// >  You cannot specify the following header keys: `slb-id`, `slb-ip`, `x-forwarded-for`, `x-forwarded-proto`, `x-forwarded-eip`, `x-forwarded-port`, `x-forwarded-client-srcport`, `connection`, `upgrade`, `content-length`, `transfer-encoding`, `keep-alive`, `te`, `host`, `cookie`, `remoteip`, and `authority`. The header keys are case-insensitive.
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
                    /// *   If **ValueType** is set to **UserDefined**, a custom header value is supported. The header value must be 1 to 128 characters in length, and can contain printable characters whose ASCII values are `greater than or equal to 32 and smaller than 127`. You can use asterisks (\\*) and question marks (?) as wildcard characters. The header value cannot start or end with a space character.
                    /// 
                    /// *   If **ValueType** is set to **ReferenceHeader**, you can reference one of the request headers. The header value must be 1 to 128 characters in length, and can contain lowercase letters, digits, underscores (_), and hyphens (-).
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    /// <summary>
                    /// The type of the header. Valid values:
                    /// 
                    /// *   **UserDefined**: a custom header
                    /// *   **ReferenceHeader**: a header that references one of the request headers
                    /// *   **SystemDefined**: a system-defined header
                    /// </summary>
                    [NameInMap("ValueType")]
                    [Validation(Required=false)]
                    public string ValueType { get; set; }

                }

                /// <summary>
                /// The priority of the action. Valid values: **1 to 50000**. A lower value indicates a higher priority. The actions of a forwarding rule are applied in descending order of priority. This parameter is required. The priority of each action within a forwarding rule must be unique. You can specify priorities for at most 20 actions.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("Order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                /// <summary>
                /// The redirect configuration. You can specify at most 20 redirects.
                /// </summary>
                [NameInMap("RedirectConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsRedirectConfig RedirectConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsRedirectConfig : TeaModel {
                    /// <summary>
                    /// The hostname to which requests are redirected. Valid values:
                    /// 
                    /// *   **${host}** (default): If ${host} is returned, no other character is appended.
                    /// 
                    /// *   Limits on the value:
                    /// 
                    ///     *   The hostname must be 3 to 128 characters in length, and can contain lowercase letters, digits, hyphens (-), and periods (.). Asterisks (\\*) and question marks (?) can be used as wildcards.
                    ///     *   The hostname contains at least one period (.) but does not start or end with a period (.).
                    ///     *   The rightmost domain label can contain only letters and wildcard characters. It does not contain digits or hyphens (-).
                    ///     *   The domain labels do not start or end with hyphens (-).
                    ///     *   You can use asterisks (\\*) and question marks (?) as wildcards anywhere in a domain label.
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// The HTTP status code that indicates the redirect type. Valid values: **301**, **302**, **303**, **307**, and **308**.
                    /// </summary>
                    [NameInMap("HttpCode")]
                    [Validation(Required=false)]
                    public string HttpCode { get; set; }

                    /// <summary>
                    /// The path to which requests are redirected. Valid values:
                    /// 
                    /// *   Default value: **${path}**. **${host}**, **${protocol}**, and **${port}** are also supported. Each variable can be specified only once. You can specify one or more of the preceding variables in each request. You can also combine them with a custom value.
                    /// 
                    /// *   Limits on the value:
                    /// 
                    ///     *   The path must be 1 to 128 characters in length.
                    ///     *   It must start with a forward slash (/) and can contain letters, digits, and the following special characters: `$ - _ .+ / & ~ @ :`. It cannot contain the following special characters: `" % # ; ! ( ) [ ]^ , "`. You can use asterisks (\\*) and question marks (?) as wildcard characters.
                    ///     *   The path is case-sensitive.
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// The port to which requests are distributed.
                    /// 
                    /// *   **${port}** (default): If you set the value to ${port}, you cannot add other characters to the value.
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
                    /// >  HTTPS listeners support only HTTPS to HTTPS redirects.
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// The query string of the URL to which requests are redirected.
                    /// 
                    /// *   Default value: **${query}**. **${host}**, **${protocol}**, and **${port}** are also supported. Each variable can be specified only once. The preceding variables can be used at the same time or combined with a custom value.
                    /// 
                    /// *   Limits on the value:
                    /// 
                    ///     *   The query string must be 1 to 128 characters in length.
                    ///     *   It can contain printable characters, except space characters, the special characters `# [ ] { } \\ | < > &`, and uppercase letters.
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
                public CreateRulesRequestRulesRuleActionsRemoveHeaderConfig RemoveHeaderConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsRemoveHeaderConfig : TeaModel {
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
                /// The rewrite configuration. You can specify at most 20 rewrites.
                /// </summary>
                [NameInMap("RewriteConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsRewriteConfig RewriteConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsRewriteConfig : TeaModel {
                    /// <summary>
                    /// The hostname to which requests are redirected. Valid values:
                    /// 
                    /// *   **${host}** (default): If you set the value to ${host}, you cannot append other characters.
                    /// 
                    /// *   A custom value that meets the following requirements:
                    /// 
                    ///     *   The hostname must be 3 to 128 characters in length, and can contain lowercase letters, digits, hyphens (-), and periods (.). You can use asterisks (\\*) and question marks (?) as wildcard characters.
                    ///     *   The hostname contains at least one period (.) but does not start or end with a period (.).
                    ///     *   The rightmost domain label can contain only letters and wildcard characters. It does not contain digits or hyphens (-).
                    ///     *   The domain labels do not start or end with hyphens (-). You can use asterisks (\\*) and question marks (?) anywhere in a domain label as wildcard characters.
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// The path to which requests are redirected. Valid values:
                    /// 
                    /// *   Default value: **${path}**. **${host}**, **${protocol}**, and **${port}** are also supported. Each variable can be specified only once. You can specify one or more of the preceding variables in each request. You can also combine them with a custom value.
                    /// 
                    /// *   Limits on the value:
                    /// 
                    ///     *   The path must be 1 to 128 characters in length.
                    ///     *   It must start with a forward slash (/) and can contain letters, digits, and the following special characters: `$ - _ .+ / & ~ @ :`. It cannot contain the following special characters: `" % # ; ! ( ) [ ]^ , "`. You can use asterisks (\\*) and question marks (?) as wildcard characters.
                    ///     *   The path is case-sensitive.
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// The query string of the URL to which requests are redirected.
                    /// 
                    /// *   Default value: **${query}**. **${host}**, **${protocol}**, and **${port}** are also supported. Each variable can be specified only once. The preceding variables can be used at the same time or combined with a custom value.
                    /// 
                    /// *   Limits on the value:
                    /// 
                    ///     *   The query string must be 1 to 128 characters in length.
                    ///     *   It can contain printable characters, except space characters, the special characters `# [ ] { } \\ | < > &`, and uppercase letters.
                    /// </summary>
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                }

                /// <summary>
                /// The configuration of traffic throttling. You can add at most 20 configuration records.
                /// </summary>
                [NameInMap("TrafficLimitConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsTrafficLimitConfig TrafficLimitConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsTrafficLimitConfig : TeaModel {
                    /// <summary>
                    /// The QPS of each IP address. Value range: **1 to 1000000**.
                    /// 
                    /// >  If **QPS** and PerIpQps are specified, the value of **PerIpQps** must be smaller than the value of **QPS**.
                    /// </summary>
                    [NameInMap("PerIpQps")]
                    [Validation(Required=false)]
                    public int? PerIpQps { get; set; }

                    /// <summary>
                    /// The queries per second (QPS). Value range: **1 to 1000000**.
                    /// </summary>
                    [NameInMap("QPS")]
                    [Validation(Required=false)]
                    public int? QPS { get; set; }

                }

                /// <summary>
                /// The configuration of traffic mirroring. You can add at most 20 traffic mirrors.
                /// </summary>
                [NameInMap("TrafficMirrorConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsTrafficMirrorConfig TrafficMirrorConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsTrafficMirrorConfig : TeaModel {
                    /// <summary>
                    /// The configuration of the server group to which traffic is mirrored.
                    /// </summary>
                    [NameInMap("MirrorGroupConfig")]
                    [Validation(Required=false)]
                    public CreateRulesRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfig MirrorGroupConfig { get; set; }
                    public class CreateRulesRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfig : TeaModel {
                        /// <summary>
                        /// The server group to which traffic is mirrored.
                        /// </summary>
                        [NameInMap("ServerGroupTuples")]
                        [Validation(Required=false)]
                        public List<CreateRulesRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                        public class CreateRulesRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples : TeaModel {
                            /// <summary>
                            /// The ID of the server group.
                            /// </summary>
                            [NameInMap("ServerGroupId")]
                            [Validation(Required=false)]
                            public string ServerGroupId { get; set; }

                        }

                    }

                    /// <summary>
                    /// The type of destination to which network traffic is mirrored. Valid values:
                    /// 
                    /// *   **ForwardGroupMirror**: a server group.
                    /// </summary>
                    [NameInMap("TargetType")]
                    [Validation(Required=false)]
                    public string TargetType { get; set; }

                }

                /// <summary>
                /// The action type. You can specify at most 11 types of actions. Valid values:
                /// 
                /// *   **ForwardGroup**: distributes requests to multiple vServer groups.
                /// *   **Redirect**: redirects a request.
                /// *   **FixedResponse**: returns a custom response.
                /// *   **Rewrite**: rewrites a request.
                /// *   **InsertHeader**: inserts a header.
                /// *   **RemoveHeaderConfig:** deletes the header of a request.
                /// *   **TrafficLimit**: throttles traffic.
                /// *   **trafficMirror**: mirrors network traffic.
                /// *   **Cors**: enables cross-origin resource sharing (CORS).
                /// 
                /// The following action types are supported:
                /// 
                /// *   **FinalType**: the last action to be performed in a forwarding rule. Each forwarding rule can contain only one FinalType action. You can specify a **ForwardGroup**, **Redirect**, or **FixedResponse** action as the FinalType action.
                /// *   **ExtType**: one or more actions to be performed before the **FinalType** action. A forwarding rule can contain one or more **ExtType** actions. To specify an ExtType action, you must specify a **FinalType** action. You can specify multiple **InsertHeader** actions or one **Rewrite** action.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The conditions of the forwarding rule.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("RuleConditions")]
            [Validation(Required=false)]
            public List<CreateRulesRequestRulesRuleConditions> RuleConditions { get; set; }
            public class CreateRulesRequestRulesRuleConditions : TeaModel {
                /// <summary>
                /// The configurations of the cookies. You can add at most 20 cookies.
                /// </summary>
                [NameInMap("CookieConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsCookieConfig CookieConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsCookieConfig : TeaModel {
                    /// <summary>
                    /// The key-value pairs of cookies.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<CreateRulesRequestRulesRuleConditionsCookieConfigValues> Values { get; set; }
                    public class CreateRulesRequestRulesRuleConditionsCookieConfigValues : TeaModel {
                        /// <summary>
                        /// The key of the cookie.
                        /// 
                        /// *   The key must be 1 to 100 characters in length.
                        /// *   You can use asterisks (\\*) and question marks (?) as wildcard characters.
                        /// *   It can contain printable characters, except uppercase letters, space characters, and the following special characters: `; # [ ] { } \\ | < > &`.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of the cookie.
                        /// 
                        /// *   The value must be 1 to 100 characters in length.
                        /// *   You can use asterisks (\\*) and question marks (?) as wildcard characters.
                        /// *   It can contain printable characters, except uppercase letters, space characters, and the following special characters: `; # [ ] { } \\ | < > &`.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The configuration of the header. You can add at most 20 headers.
                /// </summary>
                [NameInMap("HeaderConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsHeaderConfig HeaderConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsHeaderConfig : TeaModel {
                    /// <summary>
                    /// The key of the header.
                    /// 
                    /// *   The key must be 1 to 40 characters in length.
                    /// *   It can contain lowercase letters, digits, hyphens (-), and underscores (_).
                    /// *   You cannot specify Cookie or Host.
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
                /// The configurations of the hosts. You can specify up to 20 resources.
                /// </summary>
                [NameInMap("HostConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsHostConfig HostConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsHostConfig : TeaModel {
                    /// <summary>
                    /// The hostnames.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The configurations of the request methods. You can specify at most 20 request methods.
                /// </summary>
                [NameInMap("MethodConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsMethodConfig MethodConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsMethodConfig : TeaModel {
                    /// <summary>
                    /// The request methods.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The configurations of the paths. You can specify at most 20 paths.
                /// </summary>
                [NameInMap("PathConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsPathConfig PathConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsPathConfig : TeaModel {
                    /// <summary>
                    /// The paths.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The configuration of the query conditions. You can specify at most 20 query conditions.
                /// </summary>
                [NameInMap("QueryStringConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsQueryStringConfig QueryStringConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsQueryStringConfig : TeaModel {
                    /// <summary>
                    /// The configurations of the query string.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<CreateRulesRequestRulesRuleConditionsQueryStringConfigValues> Values { get; set; }
                    public class CreateRulesRequestRulesRuleConditionsQueryStringConfigValues : TeaModel {
                        /// <summary>
                        /// They key of the query string.
                        /// 
                        /// *   It must be 1 to 100 characters in length.
                        /// *   You can use asterisks (\\*) and question marks (?) as wildcards. The key can contain printable characters, excluding uppercase letters, space characters, and the following special characters: `# [ ] { } \\ | < > &`.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of the query string.
                        /// 
                        /// *   The value must be 1 to 128 characters in length.
                        /// *   It can contain printable characters, excluding uppercase letters, space characters, and the following special characters: `# [ ] { } \\ | < > &`. You can use asterisks (\\*) and question marks (?) as wildcards.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The configuration of the header. You can add at most 20 headers.
                /// </summary>
                [NameInMap("ResponseHeaderConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsResponseHeaderConfig ResponseHeaderConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsResponseHeaderConfig : TeaModel {
                    /// <summary>
                    /// The key of the header.
                    /// 
                    /// *   The key must be 1 to 40 characters in length.
                    /// *   It can contain lowercase letters, digits, hyphens (-), and underscores (_).
                    /// *   You cannot specify Cookie or Host.
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
                /// The configurations of the response status codes.
                /// </summary>
                [NameInMap("ResponseStatusCodeConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsResponseStatusCodeConfig ResponseStatusCodeConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsResponseStatusCodeConfig : TeaModel {
                    /// <summary>
                    /// The response status codes.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The configuration of the source IP addresses based on which user traffic is matched. This parameter is required and takes effect only when **Type** is set to **SourceIP**. You can specify at most five values for **SourceIp**.
                /// </summary>
                [NameInMap("SourceIpConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsSourceIpConfig SourceIpConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsSourceIpConfig : TeaModel {
                    /// <summary>
                    /// The configuration of the source IP addresses based on which user traffic is matched.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The type of forwarding rule. You can specify at most seven types. Valid values:
                /// 
                /// *   **Host**: Responses are forwarded based on hosts.
                /// *   **Path**: Responses are forwarded based on paths.
                /// *   **Header**: Responses are forwarded based on HTTP headers.
                /// *   **QueryString**: Responses are forwarded based on query strings.
                /// *   **Method**: Responses are forwarded based on request methods.
                /// *   **Cookie**: Responses are forwarded based on cookies.
                /// *   **SourceIp:**: Responses are forwarded based on source IP addresses.
                /// *   **ResponseHeader**: Responses are forwarded based on HTTP response headers.
                /// *   **ResponseStatusCode**: Responses are forwarded based on response status codes.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The name of the forwarding rule. You can name at most 20 forwarding rules.
            /// 
            /// *   The name must be 2 to 128 characters in length.
            /// *   It can contain letters, digits, periods (.), underscores (_), and hyphens (-). It must start with a letter.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The tag that you want to add.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<CreateRulesRequestRulesTag> Tag { get; set; }
            public class CreateRulesRequestRulesTag : TeaModel {
                /// <summary>
                /// The key of the tag. The tag key can be up to 128 characters in length, and cannot start with acs: or aliyun. It cannot contain http:// or https://.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the tag. The tag value can be up to 128 characters in length, and cannot start with acs: or aliyun. It cannot contain http:// or https://.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
