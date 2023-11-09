// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateRuleRequest : TeaModel {
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
        /// The direction to which the forwarding rule is applied. Valid values:
        /// 
        /// *   **Request** (default): The forwarding rule is applied to the requests received by ALB.
        /// *   **Response**: The forwarding rule is applied to the responses returned by backend servers.
        /// 
        /// > Basic ALB instances do not support the **Response** value.
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   **true**: performs a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false** (default): performs a dry run and performs the actual request. If the request passes the dry run, a `2xx HTTP` status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The listener ID of the ALB instance.
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// The priority of the forwarding rule. Valid values: **1 to 10000**. A smaller value indicates a higher priority.
        /// 
        /// > The priorities of the forwarding rules created for the same listener must be unique.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// The maximum cache time of dry run requests in the browser. Unit: seconds.
        /// 
        /// Valid values: **-1** to **172800**.
        /// </summary>
        [NameInMap("RuleActions")]
        [Validation(Required=false)]
        public List<CreateRuleRequestRuleActions> RuleActions { get; set; }
        public class CreateRuleRequestRuleActions : TeaModel {
            /// <summary>
            /// The origins allowed.
            /// </summary>
            [NameInMap("CorsConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsCorsConfig CorsConfig { get; set; }
            public class CreateRuleRequestRuleActionsCorsConfig : TeaModel {
                /// <summary>
                /// Specifies whether credentials can be carried in CORS requests. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
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
            public CreateRuleRequestRuleActionsFixedResponseConfig FixedResponseConfig { get; set; }
            public class CreateRuleRequestRuleActionsFixedResponseConfig : TeaModel {
                /// <summary>
                /// The content of the custom response. The content can be up to 1 KB in size and can contain only ASCII characters.
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
                /// The HTTP status code in the response. Valid values: **HTTP\_2xx**, **HTTP\_4xx**, and **HTTP\_5xx**. **x** must be a digit.
                /// </summary>
                [NameInMap("HttpCode")]
                [Validation(Required=false)]
                public string HttpCode { get; set; }

            }

            /// <summary>
            /// The server groups to which requests are distributed. Each forwarding rule supports at most five server groups.
            /// </summary>
            [NameInMap("ForwardGroupConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
            public class CreateRuleRequestRuleActionsForwardGroupConfig : TeaModel {
                /// <summary>
                /// The configuration of session persistence for server groups.
                /// </summary>
                [NameInMap("ServerGroupStickySession")]
                [Validation(Required=false)]
                public CreateRuleRequestRuleActionsForwardGroupConfigServerGroupStickySession ServerGroupStickySession { get; set; }
                public class CreateRuleRequestRuleActionsForwardGroupConfigServerGroupStickySession : TeaModel {
                    /// <summary>
                    /// Specifies whether to enable session persistence. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false** (default)
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// The timeout period of sessions. Unit: seconds. Valid values: **1** to **86400**. Default value: **1000**.
                    /// </summary>
                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public int? Timeout { get; set; }

                }

                /// <summary>
                /// The server groups to which requests are distributed. Each forwarding rule supports at most five server groups.
                /// </summary>
                [NameInMap("ServerGroupTuples")]
                [Validation(Required=false)]
                public List<CreateRuleRequestRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                public class CreateRuleRequestRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
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
            /// The configuration of the header to be inserted.
            /// </summary>
            [NameInMap("InsertHeaderConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsInsertHeaderConfig InsertHeaderConfig { get; set; }
            public class CreateRuleRequestRuleActionsInsertHeaderConfig : TeaModel {
                /// <summary>
                /// The key of the header. The key must be 1 to 40 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). The header key specified by **InsertHeaderConfig** must be unique.
                /// 
                /// > You cannot specify the following header keys (case-insensitive): `slb-id`, `slb-ip`, `x-forwarded-for`, `x-forwarded-proto`, `x-forwarded-eip`, `x-forwarded-port`, `x-forwarded-client-srcport`, `connection`, `upgrade`, `content-length`, `transfer-encoding`, `keep-alive`, `te`, `host`, `cookie`, `remoteip`, and `authority`.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the header to be inserted.
                /// 
                /// *   If **ValueType** is set to **SystemDefined**, you can specify one of the following header values:
                /// 
                ///     *   **ClientSrcPort**: the client port.
                ///     *   **ClientSrcIp**: the client IP address.
                ///     *   **Protocol**: the request protocol (HTTP or HTTPS).
                ///     *   **SLBId**: the ID of the ALB instance.
                ///     *   **SLBPort**: the listening port.
                /// 
                /// *   If **ValueType** is set to **UserDefined**, you can specify a custom header value. The header value must be 1 to 128 characters in length, and can contain printable characters whose ASCII values are `greater than or equal to 32 and lower than 127`. You can use asterisks (\*) and question marks (?) as wildcards. The value cannot start or end with a space character.
                /// 
                /// *   If **ValueType** is set to **ReferenceHeader**, you can reference one of the request headers. The header value must be 1 to 128 characters in length, and can contain lowercase letters, digits, underscores (\_), and hyphens (-).
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// The type of header. Valid values:
                /// 
                /// *   **UserDefined**: a custom header
                /// *   **ReferenceHeader**: a header that references one of the request headers
                /// *   **SystemDefined**: a header predefined by the system
                /// </summary>
                [NameInMap("ValueType")]
                [Validation(Required=false)]
                public string ValueType { get; set; }

            }

            /// <summary>
            /// The priority of the action. Valid values: **1 to 50000**. A smaller value indicates a higher priority. The actions of a forwarding rule are applied in descending order of priority. This parameter is required. The priority of each action within a forwarding rule must be unique.
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

            /// <summary>
            /// The redirect configuration.
            /// 
            /// > When you configure the **RedirectConfig** action, you can use the default value only for the **httpCode** parameter. Do not use the default values for the other parameters.
            /// </summary>
            [NameInMap("RedirectConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsRedirectConfig RedirectConfig { get; set; }
            public class CreateRuleRequestRuleActionsRedirectConfig : TeaModel {
                /// <summary>
                /// The hostname to which requests are redirected. Valid values:
                /// 
                /// *   **${host}** (default): If you set the value to ${host}, you cannot append other characters.
                /// 
                /// *   A custom value. Make sure that the custom value meets the following requirements:
                /// 
                ///     *   The hostname must be 3 to 128 characters in length, and can contain lowercase letters, digits, and the following special characters: - . \* = ~ \_ + \ ^ ! $ & | ( ) \[ ] ?.
                ///     *   The hostname must contain at least one period (.) but cannot start or end with a period (.).
                ///     *   The rightmost domain label can contain only letters and wildcards, and cannot contain digits or hyphens (-). The leftmost `domain label` can be an asterisk (\*).
                ///     *   The domain labels cannot start or end with a hyphen (-).
                ///     *   You can use asterisks (\*) and question marks (?) anywhere in a domain label as wildcard characters.
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
                /// *   Default value: **${path}**. \*\*${host}**, **${protocol}**, and **${port}\*\* are also supported. Each variable can be specified only once. You can specify one or more of the preceding variables in each request. You can also combine them with a custom value.
                /// 
                /// *   A custom value. You must make sure that the custom value meets the following requirements:
                /// 
                ///     *   The value must be 1 to 128 characters in length, and can contain asterisks (\*) and question marks (?) as wildcards. The value is case-sensitive.
                ///     *   It must start with a forward slash (/) and can contain letters, digits, and the following special characters: `$ - _ .+ / & ~ @ :`. It cannot contain the following special characters: `" % # ; ! ( ) [ ] ^ , "`. You can use asterisks (\*) and question marks (?) as wildcard characters.
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// The port to which requests are redirected.
                /// 
                /// *   **${port}** (default): If you set the value to ${port}, you cannot add other characters to the value.
                /// *   You can also enter a port number. Valid values: **1 to 63335**.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// The redirect protocol. Valid values:
                /// 
                /// *   **${protocol}** (default): If you set the value to ${protocol}, you cannot add other characters to the value.
                /// *   **HTTP** or **HTTPS**.
                /// 
                /// > HTTPS listeners support only HTTPS to HTTPS redirects.
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// The query string of the URL to which requests are redirected.
                /// 
                /// *   Default value: **${query}**. \*\*${host}**, **${protocol}**, and **${port}\*\* are also supported. Each variable can be specified only once. You can specify one or more of the preceding variables in each request. You can also combine them with a custom value.
                /// 
                /// *   A custom value. You must make sure that the custom value meets the following requirements:
                /// 
                ///     *   The value must be 1 to 128 characters in length.
                ///     *   It can contain printable characters, except space characters, the special characters `# [ ] { } \ | < > &`, and uppercase letters.
                /// </summary>
                [NameInMap("Query")]
                [Validation(Required=false)]
                public string Query { get; set; }

            }

            [NameInMap("RemoveHeaderConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsRemoveHeaderConfig RemoveHeaderConfig { get; set; }
            public class CreateRuleRequestRuleActionsRemoveHeaderConfig : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            /// <summary>
            /// The rewrite configuration.
            /// 
            /// > If multiple actions are configured within a forwarding rule, you must set **RewriteConfig** to the value of **ForwardGroup**.
            /// </summary>
            [NameInMap("RewriteConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsRewriteConfig RewriteConfig { get; set; }
            public class CreateRuleRequestRuleActionsRewriteConfig : TeaModel {
                /// <summary>
                /// The hostname to which requests are redirected. Valid values:
                /// 
                /// *   **${host}** (default): If you set the value to ${host}, you cannot append other characters.
                /// 
                /// *   If you want to specify a custom value, make sure that the following requirements are met:
                /// 
                ///     *   The hostname must be 3 to 128 characters in length, and can contain lowercase letters, digits, and the following special characters: - . \* = ~ \_ + \ ^ ! $ & | ( ) \[ ] ?.
                ///     *   The hostname must contain at least one period (.) but cannot start or end with a period (.).
                ///     *   The rightmost domain label can contain only letters and wildcards, and cannot contain digits or hyphens (-). The leftmost `domain label` can be an asterisk (\*).
                ///     *   The domain labels cannot start or end with a hyphen (-). You can use asterisks (\*) and question marks (?) anywhere in a domain label as wildcard characters.
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// The path to which requests are redirected. Valid values:
                /// 
                /// *   Default value: **${path}**. \*\*${host}**, **${protocol}**, and **${port}\*\* are also supported. Each variable can be specified only once. You can specify one or more of the preceding variables in each request. You can also combine them with a custom value.
                /// 
                /// *   A custom value. You must make sure that the custom value meets the following requirements:
                /// 
                ///     *   The value must be 1 to 128 characters in length, and can contain asterisks (\*) and question marks (?) as wildcards. The value is case-sensitive.
                ///     *   It must start with a forward slash (/) and can contain letters, digits, and the following special characters: `$ - _ .+ / & ~ @ :`. It cannot contain the following special characters: `" % # ; ! ( ) [ ] ^ , "`. You can use asterisks (\*) and question marks (?) as wildcard characters.
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// The query string of the URL to which requests are redirected.
                /// 
                /// *   Default value: **${query}**. \*\*${host}**, **${protocol}**, and **${port}\*\* are also supported. Each variable can be specified only once. You can specify one or more of the preceding variables in each request. You can also combine them with a custom value.
                /// 
                /// *   A custom value. You must make sure that the custom value meets the following requirements:
                /// 
                ///     *   The value must be 1 to 128 characters in length.
                ///     *   It can contain printable characters, except space characters, the special characters `# [ ] { } \ | < > &`, and uppercase letters.
                /// </summary>
                [NameInMap("Query")]
                [Validation(Required=false)]
                public string Query { get; set; }

            }

            /// <summary>
            /// The action to throttle traffic.
            /// </summary>
            [NameInMap("TrafficLimitConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsTrafficLimitConfig TrafficLimitConfig { get; set; }
            public class CreateRuleRequestRuleActionsTrafficLimitConfig : TeaModel {
                /// <summary>
                /// The QPS of each IP address. Valid values: **1 to 100000**.
                /// 
                /// > If both the **QPS** and **PerIpQps** properties are specified, make sure that the value of the **QPS** property is smaller than the value of the PerIpQps property.
                /// </summary>
                [NameInMap("PerIpQps")]
                [Validation(Required=false)]
                public int? PerIpQps { get; set; }

                /// <summary>
                /// The queries per second (QPS). Valid values: **1 to 100000**.
                /// </summary>
                [NameInMap("QPS")]
                [Validation(Required=false)]
                public int? QPS { get; set; }

            }

            /// <summary>
            /// The action to mirror traffic.
            /// </summary>
            [NameInMap("TrafficMirrorConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsTrafficMirrorConfig TrafficMirrorConfig { get; set; }
            public class CreateRuleRequestRuleActionsTrafficMirrorConfig : TeaModel {
                /// <summary>
                /// The configuration of the server group to which traffic is mirrored.
                /// </summary>
                [NameInMap("MirrorGroupConfig")]
                [Validation(Required=false)]
                public CreateRuleRequestRuleActionsTrafficMirrorConfigMirrorGroupConfig MirrorGroupConfig { get; set; }
                public class CreateRuleRequestRuleActionsTrafficMirrorConfigMirrorGroupConfig : TeaModel {
                    /// <summary>
                    /// The configuration of the server group to which traffic is mirrored.
                    /// </summary>
                    [NameInMap("ServerGroupTuples")]
                    [Validation(Required=false)]
                    public List<CreateRuleRequestRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class CreateRuleRequestRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples : TeaModel {
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
                /// *   **ForwardGroupMirror**: a server group
                /// *   **SlsMirror**: Log Service
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

            /// <summary>
            /// The action type. Valid values:
            /// 
            /// *   **ForwardGroup**: forwards a request to multiple vServer groups.
            /// *   **Redirect**: redirects a request.
            /// *   **FixedResponse**: returns a custom response.
            /// *   **Rewrite**: rewrites a request.
            /// *   **InsertHeader**: inserts a header.
            /// *   **RemoveHeaderConfig**: deletes a header.
            /// *   **TrafficLimitConfig**: throttles network traffic.
            /// *   **TrafficMirrorConfig**: mirrors traffic.
            /// *   **CorsConfig**: forwards requests based on CORS.
            /// 
            /// The following action types are supported:
            /// 
            /// *   **FinalType**: the last action to be performed in a forwarding rule. Each forwarding rule can contain only one FinalType action. You can specify the **ForwardGroup**, **Redirect**, or **FixedResponse** action as the FinalType action.
            /// *   **ExtType**: the action or the actions to be performed before the **FinalType** action. A forwarding rule can contain one or more **ExtType** actions. To specify this parameter, you must also specify **FinalType**. You can specify multiple **InsertHeader** actions or one **Rewrite** action.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The configuration of the source IP-based forwarding rule.
        /// </summary>
        [NameInMap("RuleConditions")]
        [Validation(Required=false)]
        public List<CreateRuleRequestRuleConditions> RuleConditions { get; set; }
        public class CreateRuleRequestRuleConditions : TeaModel {
            /// <summary>
            /// The configurations of the cookies.
            /// </summary>
            [NameInMap("CookieConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsCookieConfig CookieConfig { get; set; }
            public class CreateRuleRequestRuleConditionsCookieConfig : TeaModel {
                /// <summary>
                /// The cookie values.
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<CreateRuleRequestRuleConditionsCookieConfigValues> Values { get; set; }
                public class CreateRuleRequestRuleConditionsCookieConfigValues : TeaModel {
                    /// <summary>
                    /// The key of the cookie.
                    /// 
                    /// *   The key must be 1 to 100 characters in length.
                    /// *   You can use asterisks (\*) and question marks (?) as wildcard characters.
                    /// *   The key can contain printable characters, except uppercase letters, space characters, and the following special characters: `; # [ ] { } \ | < > &`.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The value of the cookie.
                    /// 
                    /// *   The value must be 1 to 100 characters in length.
                    /// *   You can use asterisks (\*) and question marks (?) as wildcard characters.
                    /// *   The value can contain printable characters, except uppercase letters, space characters, and the following special characters: `; # [ ] { } \ | < > &`.
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
            public CreateRuleRequestRuleConditionsHeaderConfig HeaderConfig { get; set; }
            public class CreateRuleRequestRuleConditionsHeaderConfig : TeaModel {
                /// <summary>
                /// The key of the header.
                /// 
                /// *   The key must be 1 to 40 characters in length.
                /// *   It can contain lowercase letters, digits, hyphens (-), and underscores (\_).
                /// *   Cookie and Host are not supported.
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
            /// The configurations of the host.
            /// </summary>
            [NameInMap("HostConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsHostConfig HostConfig { get; set; }
            public class CreateRuleRequestRuleConditionsHostConfig : TeaModel {
                /// <summary>
                /// The hostname.
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
            public CreateRuleRequestRuleConditionsMethodConfig MethodConfig { get; set; }
            public class CreateRuleRequestRuleConditionsMethodConfig : TeaModel {
                /// <summary>
                /// The request methods.
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// The configurations of the URLs.
            /// </summary>
            [NameInMap("PathConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsPathConfig PathConfig { get; set; }
            public class CreateRuleRequestRuleConditionsPathConfig : TeaModel {
                /// <summary>
                /// The path.
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
            public CreateRuleRequestRuleConditionsQueryStringConfig QueryStringConfig { get; set; }
            public class CreateRuleRequestRuleConditionsQueryStringConfig : TeaModel {
                /// <summary>
                /// The query strings.
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<CreateRuleRequestRuleConditionsQueryStringConfigValues> Values { get; set; }
                public class CreateRuleRequestRuleConditionsQueryStringConfigValues : TeaModel {
                    /// <summary>
                    /// The key of the query string.
                    /// 
                    /// *   The key must be 1 to 100 characters in length.
                    /// *   You can use asterisks (\*) and question marks (?) as wildcards. The key can contain printable characters, except uppercase letters, space characters, and the following special characters: `# [ ] { } \ | < > &`.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The value of the query string.
                    /// 
                    /// *   The value must be 1 to 128 characters in length.
                    /// *   It can contain printable characters, except uppercase letters, space characters, and the following special characters: `# [ ] { } \ | < > &`. You can use asterisks (\*) and question marks (?) as wildcard characters.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("ResponseHeaderConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsResponseHeaderConfig ResponseHeaderConfig { get; set; }
            public class CreateRuleRequestRuleConditionsResponseHeaderConfig : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            [NameInMap("ResponseStatusCodeConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsResponseStatusCodeConfig ResponseStatusCodeConfig { get; set; }
            public class CreateRuleRequestRuleConditionsResponseStatusCodeConfig : TeaModel {
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// The configuration of the source IP-based forwarding rule. This parameter is required and takes effect only when **Type** is set to **SourceIP**.
            /// </summary>
            [NameInMap("SourceIpConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsSourceIpConfig SourceIpConfig { get; set; }
            public class CreateRuleRequestRuleConditionsSourceIpConfig : TeaModel {
                /// <summary>
                /// The configuration of the source IP-based forwarding rule.
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// The type of forwarding rule. Valid values:
            /// 
            /// *   **Host**: Requests are distributed based on hosts.
            /// *   **Path**: Requests are distributed based on paths.
            /// *   **Header**: Requests are distributed based on HTTP headers.
            /// *   **QueryString**: Requests are distributed based on query strings.
            /// *   **Method**: Requests are distributed based on request methods.
            /// *   **Cookie**: Requests are distributed based on cookies.
            /// *   **SourceIp**: Requests are distributed based on source IP addresses.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The name of the forwarding rule.
        /// 
        /// *   The name must be 2 to 128 characters in length.
        /// *   It can contain letters, digits, periods (.), underscores (\_), and hyphens (-). It must start with a letter.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateRuleRequestTag> Tag { get; set; }
        public class CreateRuleRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
