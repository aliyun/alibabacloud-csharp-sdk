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
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// The direction to which the forwarding rule is applied. You can specify only one direction. Valid values:
        /// 
        /// *   **Request** (default): The forwarding rule is applied to the client requests received by ALB.
        /// *   **Response**: The forwarding rule is applied to the responses returned by backend servers.
        /// 
        /// > Basic ALB instances do not support the **Response** value.
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<CreateRulesRequestRules> Rules { get; set; }
        public class CreateRulesRequestRules : TeaModel {
            /// <summary>
            /// The ID of the forwarding rule.
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// The server group to which requests are distributed.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("RuleActions")]
            [Validation(Required=false)]
            public List<CreateRulesRequestRulesRuleActions> RuleActions { get; set; }
            public class CreateRulesRequestRulesRuleActions : TeaModel {
                [NameInMap("CorsConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsCorsConfig CorsConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsCorsConfig : TeaModel {
                    /// <summary>
                    /// The key of the header.
                    /// 
                    /// *   The key must be 1 to 40 characters in length.
                    /// *   It can contain letters, digits, hyphens (-), and underscores (\_).
                    /// *   You cannot set Cookie or Host.
                    /// </summary>
                    [NameInMap("AllowCredentials")]
                    [Validation(Required=false)]
                    public string AllowCredentials { get; set; }

                    [NameInMap("AllowHeaders")]
                    [Validation(Required=false)]
                    public List<string> AllowHeaders { get; set; }

                    [NameInMap("AllowMethods")]
                    [Validation(Required=false)]
                    public List<string> AllowMethods { get; set; }

                    [NameInMap("AllowOrigin")]
                    [Validation(Required=false)]
                    public List<string> AllowOrigin { get; set; }

                    [NameInMap("ExposeHeaders")]
                    [Validation(Required=false)]
                    public List<string> ExposeHeaders { get; set; }

                    /// <summary>
                    /// The value of the header. The header values within a forwarding rule must be unique.
                    /// 
                    /// *   The value must be 1 to 128 characters in length.
                    /// *   It can contain printable characters whose ASCII values are `greater than or equal to 32 and lower than 127`. You can use asterisks (\*) and question marks (?) as wildcard characters.
                    /// *   The value cannot start or end with a space character.
                    /// </summary>
                    [NameInMap("MaxAge")]
                    [Validation(Required=false)]
                    public long? MaxAge { get; set; }

                }

                [NameInMap("FixedResponseConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsFixedResponseConfig FixedResponseConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsFixedResponseConfig : TeaModel {
                    /// <summary>
                    /// The weight of the server group. A larger value indicates a higher weight. A server group with a higher weight receives more requests. Valid values: **1 to 100**. Default value: **100**.
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// Specifies whether to enable session persistence. Valid values:
                    /// 
                    /// *   **true**: enables session persistence.
                    /// *   **false** (default): disables session persistence.
                    /// </summary>
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    /// <summary>
                    /// The timeout period of sessions. Unit: seconds. Valid values: **1 to 86400**.
                    /// </summary>
                    [NameInMap("HttpCode")]
                    [Validation(Required=false)]
                    public string HttpCode { get; set; }

                }

                [NameInMap("ForwardGroupConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsForwardGroupConfig : TeaModel {
                    [NameInMap("ServerGroupStickySession")]
                    [Validation(Required=false)]
                    public CreateRulesRequestRulesRuleActionsForwardGroupConfigServerGroupStickySession ServerGroupStickySession { get; set; }
                    public class CreateRulesRequestRulesRuleActionsForwardGroupConfigServerGroupStickySession : TeaModel {
                        /// <summary>
                        /// The type of header. Valid values:
                        /// 
                        /// *   **UserDefined**: a custom header.
                        /// *   **ReferenceHeader**: a header that is referenced from one of the request headers.
                        /// *   **SystemDefined**: a header predefined by the system.
                        /// </summary>
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        /// <summary>
                        /// The priority of the action within the forwarding rule. Valid values: **1 to 50000**. A lower value indicates a higher priority. The actions of a forwarding rule are applied in descending order of priority. This parameter is required. The priority of each action within a forwarding rule must be unique. You can specify priorities for at most 20 actions.
                        /// </summary>
                        [NameInMap("Timeout")]
                        [Validation(Required=false)]
                        public int? Timeout { get; set; }

                    }

                    [NameInMap("ServerGroupTuples")]
                    [Validation(Required=false)]
                    public List<CreateRulesRequestRulesRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class CreateRulesRequestRulesRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
                        /// <summary>
                        /// The name of the header to insert. The name must be 1 to 40 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). The header names specified by **InsertHeaderConfig** must be unique.
                        /// 
                        /// >  You cannot set the name of the header to any of the following values (case-insensitive): `slb-id`, `slb-ip`, `x-forwarded-for`, `x-forwarded-proto`, `x-forwarded-eip`, `x-forwarded-port`, `x-forwarded-client-srcport`, `connection`, `upgrade`, `content-length`, `transfer-encoding`, `keep-alive`, `te`, `host`, `cookie`, `remoteip`, and `authority`.
                        /// </summary>
                        [NameInMap("ServerGroupId")]
                        [Validation(Required=false)]
                        public string ServerGroupId { get; set; }

                        /// <summary>
                        /// The value of the header to insert.
                        /// 
                        /// *   If **ValueType** is set to **SystemDefined**, you can set one of the following header values:
                        /// 
                        ///     *   **ClientSrcPort**: the client port.
                        ///     *   **ClientSrcIp**: the client IP address.
                        ///     *   **Protocol**: the request protocol (HTTP or HTTPS).
                        ///     *   **SLBId**: the ID of the ALB instance.
                        ///     *   **SLBPort**: the listening port.
                        /// 
                        /// *   If **ValueType** is set to **UserDefined**, you can specify a custom header value. The header value must be 1 to 128 characters in length and can contain printable characters whose ASCII character values are `greater than or equal to 32 and lower than 127`. You can use asterisks (\*) and question marks (?) as wildcards. The value cannot start or end with a space character.
                        /// 
                        /// *   If **ValueType** is set to **ReferenceHeader**, you can reference one of the request headers. The header value must be 1 to 128 characters in length, and can contain lowercase letters, digits, underscores (\_), and hyphens (-).
                        /// </summary>
                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public int? Weight { get; set; }

                    }

                }

                [NameInMap("InsertHeaderConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsInsertHeaderConfig InsertHeaderConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsInsertHeaderConfig : TeaModel {
                    /// <summary>
                    /// The hostname to which requests are distributed. Valid values:
                    /// 
                    /// *   **${host}** (default): If you set the value to ${host}, you cannot append other characters.
                    /// 
                    /// *   If you want to specify a custom value, make sure that the following requirements are met:
                    /// 
                    ///     *   The hostname must be 3 to 128 characters in length, and can contain lowercase letters, digits, hyphens (-), and periods (.). You can use asterisks (\*) and question marks (?) as wildcard characters.
                    ///     *   The hostname must contain at least one period (.) but cannot start or end with a period (.).
                    ///     *   The rightmost domain label can contain only letters and wildcard characters. It cannot contain digits or hyphens (-).
                    ///     *   The domain labels cannot start or end with a hyphen (-).
                    ///     *   You can use asterisks (\*) and question marks (?) as wildcards anywhere in a domain label.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The HTTP status code that indicates the redirect type. Valid values: **301**, **302**, **303**, **307**, and **308**.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    /// <summary>
                    /// The path to which requests are redirected. Valid values:
                    /// 
                    /// *   Default value: **${path}**. **${host}**, **${protocol}**, and **${port}** are also supported. Each variable cannot be specified more than once. You can specify one or more of the preceding variables in each request. You can also combine them with the following characters.
                    /// 
                    /// *   If you want to specify a custom value, make sure that the following requirements are met:
                    /// 
                    ///     *   The value is 1 to 128 characters in length.
                    ///     *   It must start with a forward slash (/) and can contain letters, digits, and the following special characters: `$ - _ .+ / & ~ @ :`. It cannot contain the following special characters: `" % # ; ! ( ) [ ]^ , "`. You can use asterisks (\*) and question marks (?) as wildcards.
                    ///     *   The value is case-sensitive.
                    /// </summary>
                    [NameInMap("ValueType")]
                    [Validation(Required=false)]
                    public string ValueType { get; set; }

                }

                /// <summary>
                /// The port to which requests are redirected.
                /// 
                /// *   **${port}** (default): If you set the value to ${port}, you cannot append other characters.
                /// *   You can also enter a port number. Valid values: **1 to 63335**.
                /// </summary>
                [NameInMap("Order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                [NameInMap("RedirectConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsRedirectConfig RedirectConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsRedirectConfig : TeaModel {
                    /// <summary>
                    /// The redirect protocol. Valid values:
                    /// 
                    /// *   **${protocol}** (default): If you set the value to ${protocol}, you cannot append other characters.
                    /// *   You can set the protocol to **HTTP** or **HTTPS**.
                    /// 
                    /// >  HTTPS listeners do not support HTTPS-to-HTTP redirects.
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// The query string of the URL to which requests are redirected.
                    /// 
                    /// *   Default value: **${query}**. **${host}**, **${protocol}**, and **${port}** are also supported. Each variable cannot be specified more than once. You can specify one or more of the preceding variables in each request. You can also combine them with the following characters.
                    /// 
                    /// *   If you want to specify a custom value, make sure that the following requirements are met:
                    /// 
                    ///     *   The value is 1 to 128 characters in length.
                    ///     *   It can contain printable characters, except space characters, the special characters `# [ ] { } \ | < > &`, and uppercase letters.
                    /// </summary>
                    [NameInMap("HttpCode")]
                    [Validation(Required=false)]
                    public string HttpCode { get; set; }

                    /// <summary>
                    /// The hostname to which requests are redirected. Valid values:
                    /// 
                    /// *   **${host}** (default): If you set the value to ${host}, you cannot append other characters.
                    /// 
                    /// *   If you want to specify a custom value, make sure that the following requirements are met:
                    /// 
                    ///     *   The hostname must be 3 to 128 characters in length, and can contain lowercase letters, digits, hyphens (-), and periods (.). You can use asterisks (\*) and question marks (?) as wildcard characters.
                    ///     *   The hostname must contain at least one period (.) but cannot start or end with a period (.).
                    ///     *   The rightmost domain label can contain only letters and wildcard characters. It cannot contain digits or hyphens (-).
                    ///     *   The domain labels cannot start or end with a hyphen (-). You can use an asterisk (\*) and question mark (?) as wildcards anywhere in a domain label.
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// The path to which requests are redirected. Valid values:
                    /// 
                    /// *   Default value: **${path}**. **${host}**, **${protocol}**, and **${port}** are also supported. Each variable cannot be specified more than once. You can specify one or more of the preceding variables in each request. You can also combine them with the following characters.
                    /// 
                    /// *   If you want to specify a custom value, make sure that the following requirements are met:
                    /// 
                    ///     *   The value is 1 to 128 characters in length.
                    ///     *   It must start with a forward slash (/) and can contain letters, digits, and the following special characters: `$ - _ .+ / & ~ @ :`. It cannot contain the following special characters: `" % # ; ! ( ) [ ]^ , "`. You can use asterisks (\*) and question marks (?) as wildcards.
                    ///     *   The value is case-sensitive.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    /// <summary>
                    /// The query string of the URL to which requests are redirected.
                    /// 
                    /// *   Default value: **${query}**. **${host}**, **${protocol}**, and **${port}** are also supported. Each variable cannot be specified more than once. You can specify one or more of the preceding variables in each request. You can also combine them with the following characters.
                    /// 
                    /// *   If you want to specify a custom value, make sure that the following requirements are met:
                    /// 
                    ///     *   The value is 1 to 128 characters in length.
                    ///     *   It can contain printable characters, except space characters, the special characters `# [ ] { } \ | < > &`, and uppercase letters.
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// The action type. You can specify at most 11 types of action. Valid values:
                    /// 
                    /// *   **ForwardGroup**: forwards a request to multiple vServer groups.
                    /// *   **Redirect**: redirects a request.
                    /// *   **FixedResponse**: returns a custom response.
                    /// *   **Rewrite**: rewrites a request.
                    /// *   **InsertHeader**: inserts a header.
                    /// *   **RemoveHeaderConfig**: deletes a header.
                    /// *   **TrafficLimitConfig**: throttles network traffic.
                    /// *   **TrafficMirrorConfig**: mirrors network traffic.
                    /// *   **CORS**: enables cross-origin resource sharing (CORS).
                    /// 
                    /// You can specify the last action and the actions that you want to perform before the last action:
                    /// 
                    /// *   **FinalType**: the last action to be performed in a forwarding rule. Each forwarding rule can contain only one FinalType action. You can specify a **ForwardGroup**, **Redirect**, or **FixedResponse** action as the FinalType action.
                    /// *   **ExtType**: the action to be performed before the FinalType action. A forwarding rule can contain one or more ExtType actions. To specify this parameter, you must also specify FinalType. You can specify multiple **InsertHeader** actions or one **Rewrite** action.
                    /// </summary>
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                }

                [NameInMap("RemoveHeaderConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsRemoveHeaderConfig RemoveHeaderConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsRemoveHeaderConfig : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                }

                [NameInMap("RewriteConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsRewriteConfig RewriteConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsRewriteConfig : TeaModel {
                    /// <summary>
                    /// Queries per second (QPS). Valid values: **1 to 100000**.
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// The QPS of each IP address. Valid values: **1 to 100000**.
                    /// 
                    /// >  If **QPS** and PerIpQps are configured at the same time, the value of the **PerIpQps** parameter must be smaller than that of the **QPS** parameter.
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// The type of destination to which network traffic is mirrored. Valid values:
                    /// 
                    /// *   **ForwardGroupMirror**: a server group.
                    /// *   **SlsMirror**: Log Service.
                    /// </summary>
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                }

                [NameInMap("TrafficLimitConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsTrafficLimitConfig TrafficLimitConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsTrafficLimitConfig : TeaModel {
                    /// <summary>
                    /// The allowed HTTP methods for CORS requests. Valid values:
                    /// 
                    /// *   **GET**
                    /// *   **POST**
                    /// *   **PUT**
                    /// *   **DELETE**
                    /// *   **HEAD**
                    /// *   **OPTIONS**
                    /// *   **PATCH**
                    /// </summary>
                    [NameInMap("PerIpQps")]
                    [Validation(Required=false)]
                    public int? PerIpQps { get; set; }

                    /// <summary>
                    /// The origin site that is allowed to access. You can specify an asterisk (`*`) or one or more values. The value cannot be an asterisk (`*`).
                    /// 
                    /// *   The value must start with `http://` or `https://` and include a valid domain name or top-level wildcard domain name, such as `*.test.abc.example.com`.
                    /// *   You can choose to include a port number from **1** to **65535** in each value based on your business requirement.
                    /// </summary>
                    [NameInMap("QPS")]
                    [Validation(Required=false)]
                    public int? QPS { get; set; }

                }

                [NameInMap("TrafficMirrorConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsTrafficMirrorConfig TrafficMirrorConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsTrafficMirrorConfig : TeaModel {
                    [NameInMap("MirrorGroupConfig")]
                    [Validation(Required=false)]
                    public CreateRulesRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfig MirrorGroupConfig { get; set; }
                    public class CreateRulesRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfig : TeaModel {
                        [NameInMap("ServerGroupTuples")]
                        [Validation(Required=false)]
                        public List<CreateRulesRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                        public class CreateRulesRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples : TeaModel {
                            /// <summary>
                            /// The headers that are allowed to expose. You can specify an asterisk (`*`) or one or more values. Separate multiple values with commas (,). The value must be 1 to 32 characters in length, and can contain letters and digits. The value cannot start or end with an underscore (\_) or hyphen (-).
                            /// </summary>
                            [NameInMap("ServerGroupId")]
                            [Validation(Required=false)]
                            public string ServerGroupId { get; set; }

                        }

                    }

                    /// <summary>
                    /// The allowed headers for CORS requests. You can specify an asterisk (`*`) or one or more values. Separate multiple values with commas (,). The value must be 1 to 32 characters in length, and can contain letters and digits. The value cannot start or end with an underscore (\_) or hyphen (-).
                    /// </summary>
                    [NameInMap("TargetType")]
                    [Validation(Required=false)]
                    public string TargetType { get; set; }

                }

                /// <summary>
                /// The ID of the vServer group.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("RuleConditions")]
            [Validation(Required=false)]
            public List<CreateRulesRequestRulesRuleConditions> RuleConditions { get; set; }
            public class CreateRulesRequestRulesRuleConditions : TeaModel {
                [NameInMap("CookieConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsCookieConfig CookieConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsCookieConfig : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<CreateRulesRequestRulesRuleConditionsCookieConfigValues> Values { get; set; }
                    public class CreateRulesRequestRulesRuleConditionsCookieConfigValues : TeaModel {
                        /// <summary>
                        /// The hostname. A forwarding rule can contain only one unique hostname.
                        /// 
                        /// *   The hostname must be 3 to 128 characters in length, and can contain lowercase letters, digits, hyphens (-), periods (.), asterisks (\*), and question marks (?).
                        /// *   The hostname must contain at least one period (.) but cannot start or end with a period (.).
                        /// *   The rightmost domain label can contain only letters and wildcard characters. It cannot contain digits or hyphens (-).
                        /// *   The domain labels do not start or end with hyphens (-). You can use an asterisk (\*) and question mark (?) as wildcards anywhere in a domain label.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The request methods. Valid values: **HEAD**, **GET**, **POST**, **OPTIONS**, **PUT**, **PATCH**, and **DELETE**.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("HeaderConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsHeaderConfig HeaderConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsHeaderConfig : TeaModel {
                    /// <summary>
                    /// The path to which requests are forwarded. Limits:
                    /// 
                    /// *   The path must be 1 to 128 characters in length.
                    /// *   It must start with a forward slash (/) and can contain letters, digits, and the following special characters: `$ - _ .+ / & ~ @ :`. It cannot contain the following special characters: `" % # ; ! ( ) [ ]^ , "`. You can use asterisks (\*) and question marks (?) as wildcards.
                    /// *   The value is case-sensitive.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                [NameInMap("HostConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsHostConfig HostConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsHostConfig : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                [NameInMap("MethodConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsMethodConfig MethodConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsMethodConfig : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                [NameInMap("PathConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsPathConfig PathConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsPathConfig : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                [NameInMap("QueryStringConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsQueryStringConfig QueryStringConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsQueryStringConfig : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<CreateRulesRequestRulesRuleConditionsQueryStringConfigValues> Values { get; set; }
                    public class CreateRulesRequestRulesRuleConditionsQueryStringConfigValues : TeaModel {
                        /// <summary>
                        /// The type of forwarding rule. You can specify at most seven types. Valid values:
                        /// 
                        /// *   **Host**: Requests are forwarded based on hosts.
                        /// *   **Path**: Requests are forwarded based on paths.
                        /// *   **Header**: Requests are forwarded based on HTTP headers.
                        /// *   **QueryString**: Requests are forwarded based on query strings.
                        /// *   **Method**: Requests are forwarded based on request methods.
                        /// *   **Cookie**: Requests are forwarded based on cookies.
                        /// *   **SourceIp**: Requests are forwarded based on source IP addresses.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The IP addresses or CIDR blocks.
                        /// 
                        /// You can specify at most five values for **SourceIp**.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("ResponseHeaderConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsResponseHeaderConfig ResponseHeaderConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsResponseHeaderConfig : TeaModel {
                    /// <summary>
                    /// The name of the forwarding rule. You can name at most 20 forwarding rules.
                    /// 
                    /// *   The name must be 2 to 128 characters in length.
                    /// *   It can contain letters, digits, periods (.), underscores (\_), and hyphens (-). It must start with a letter.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                [NameInMap("ResponseStatusCodeConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsResponseStatusCodeConfig ResponseStatusCodeConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsResponseStatusCodeConfig : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                [NameInMap("SourceIpConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsSourceIpConfig SourceIpConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsSourceIpConfig : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The ID of the asynchronous task.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The list of forwarding rules.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<CreateRulesRequestRulesTag> Tag { get; set; }
            public class CreateRulesRequestRulesTag : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
