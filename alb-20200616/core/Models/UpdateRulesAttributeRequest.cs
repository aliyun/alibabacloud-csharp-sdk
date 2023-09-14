// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateRulesAttributeRequest : TeaModel {
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
        /// *   **true**: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false** (default): performs a dry run and performs the actual request. If the request passes the dry run, a `2xx HTTP` status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The forwarding rules. You can specify up to 10 forwarding rules in each request.
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<UpdateRulesAttributeRequestRules> Rules { get; set; }
        public class UpdateRulesAttributeRequestRules : TeaModel {
            /// <summary>
            /// The priority of the forwarding rule. Valid values: **1 to 10000**. A lower value specifies a higher priority. You can specify priorities for up to 20 forwarding rules.
            /// 
            /// > The priority of each forwarding rule added to a listener must be unique.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// The actions of the forwarding rule.
            /// </summary>
            [NameInMap("RuleActions")]
            [Validation(Required=false)]
            public List<UpdateRulesAttributeRequestRulesRuleActions> RuleActions { get; set; }
            public class UpdateRulesAttributeRequestRulesRuleActions : TeaModel {
                /// <summary>
                /// The CORS configuration.
                /// </summary>
                [NameInMap("CorsConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsCorsConfig CorsConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsCorsConfig : TeaModel {
                    /// <summary>
                    /// Specifies whether credentials can be carried in CORS requests. Valid values:
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
                    /// The maximum cache time of preflight requests in the browser. Unit: seconds.
                    /// 
                    /// Valid values: **-1** to **172800**.
                    /// </summary>
                    [NameInMap("MaxAge")]
                    [Validation(Required=false)]
                    public long? MaxAge { get; set; }

                }

                /// <summary>
                /// The configuration of the action to return a custom response. You can specify the configurations of up to 20 actions to return a custom response.
                /// </summary>
                [NameInMap("FixedResponseConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsFixedResponseConfig FixedResponseConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsFixedResponseConfig : TeaModel {
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
                    /// The HTTP status code in the response. Valid values: **HTTP\_2xx**, **HTTP\_4xx**, and **HTTP\_5xx**. **x** must be a digit.
                    /// </summary>
                    [NameInMap("HttpCode")]
                    [Validation(Required=false)]
                    public string HttpCode { get; set; }

                }

                /// <summary>
                /// The configuration of the action to forward requests to server groups. You can specify the configurations of up to 20 actions to forward requests to server groups.
                /// </summary>
                [NameInMap("ForwardGroupConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsForwardGroupConfig : TeaModel {
                    /// <summary>
                    /// The configuration of session persistence for server groups.
                    /// </summary>
                    [NameInMap("ServerGroupStickySession")]
                    [Validation(Required=false)]
                    public UpdateRulesAttributeRequestRulesRuleActionsForwardGroupConfigServerGroupStickySession ServerGroupStickySession { get; set; }
                    public class UpdateRulesAttributeRequestRulesRuleActionsForwardGroupConfigServerGroupStickySession : TeaModel {
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
                        /// The timeout period of sessions. Unit: seconds. Valid values: **1** to **86400**.
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
                    public List<UpdateRulesAttributeRequestRulesRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class UpdateRulesAttributeRequestRulesRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
                        /// <summary>
                        /// The server group to which requests are forwarded.
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
                /// The configuration of the action to insert a header. You can specify the configurations of up to 20 actions to insert a header.
                /// </summary>
                [NameInMap("InsertHeaderConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsInsertHeaderConfig InsertHeaderConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsInsertHeaderConfig : TeaModel {
                    /// <summary>
                    /// Specifies whether to overwrite the request header. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false** (default)
                    /// </summary>
                    [NameInMap("CoverEnabled")]
                    [Validation(Required=false)]
                    public bool? CoverEnabled { get; set; }

                    /// <summary>
                    /// The key of the header to be inserted. The key must be 1 to 40 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). The key specified in `InsertHeader` must be unique.
                    /// 
                    /// > You cannot use the following header keys (case-insensitive): `slb-id`, `slb-ip`, `x-forwarded-for`, `x-forwarded-proto`, `x-forwarded-eip`, `x-forwarded-port`, `x-forwarded-client-srcport`, `connection`, `upgrade`, `content-length`, `transfer-encoding`, `keep-alive`, `te, host`, `cookie`, `remoteip`, and `authority`.
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
                    ///     *   **SLBId**: the ALB instance ID.
                    ///     *   **SLBPort**: the listener port.
                    /// 
                    /// *   If **ValueType** is set to **UserDefined**, you can specify a custom header value. The header value must be 1 to 128 characters in length, and can contain printable characters whose ASCII values are `greater than or equal to 32 and lower than 127`. You can use asterisks (\*) and question marks (?) as wildcards. The value cannot start or end with a space character.
                    /// 
                    /// *   If **ValueType** is set to **ReferenceHeader**, you can reference one of the request headers. The header value must be 1 to 128 characters in length, and can contain lowercase letters, digits, underscores (\_), and hyphens (-).
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    /// <summary>
                    /// The type of the header. Valid values:
                    /// 
                    /// *   **UserDefined**: a user-defined header
                    /// *   **ReferenceHeader**: a header that is referenced from a request header.
                    /// *   **SystemDefined**: a system-defined header.
                    /// </summary>
                    [NameInMap("ValueType")]
                    [Validation(Required=false)]
                    public string ValueType { get; set; }

                }

                /// <summary>
                /// The priority of the action. Valid values: **1** to **50000**. A lower value specifies a higher priority. The actions of a forwarding rule are applied in descending order of priority. This parameter cannot be left empty. The priority of each action within a forwarding rule must be unique. You can specify priorities for up to 20 actions.
                /// </summary>
                [NameInMap("Order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                /// <summary>
                /// The configuration of the redirect action. You can specify the configurations of up to 20 redirect actions.
                /// </summary>
                [NameInMap("RedirectConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsRedirectConfig RedirectConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsRedirectConfig : TeaModel {
                    /// <summary>
                    /// The hostname to which requests are forwarded.
                    /// 
                    /// Take note of the following rules when you specify a hostname:
                    /// 
                    /// *   The hostname must be 3 to 128 characters in length, and can contain lowercase letters, digits, and the following special characters: - . \* = ~ \_ + \ ^ ! $ & | ( ) \[ ] ?.
                    /// *   The hostname must contain at least one period (.) but cannot start or end with a period (.).
                    /// *   The rightmost domain label can contain only letters, asterisks (*), and question marks (?), and cannot contain digits or hyphens (-). The leftmost `domain label` can contain asterisks (*).
                    /// *   The domain labels cannot start or end with a hyphen (-). You can specify asterisks (∗) and question marks (?) anywhere in a domain label.
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
                    /// The path to which requests are redirected.
                    /// 
                    /// *   **${path}** (default): You can reference \*\*${host}**, **${protocol}** and **${port}\*\*. Each variable can be used only once. You can specify one or more of the preceding variables in each request. You can also combine them with a custom value.
                    /// 
                    /// *   A custom value that meets the following requirements:
                    /// 
                    ///     *   The custom value must be 1 to 128 characters in length. You can use asterisks (\*) and question marks (?) as wildcards.
                    ///     *   The custom value can contain letters, digits, and the following special characters: `$ - _ . + / & ~ @ : \" * ?`. The custom value must start with a forward slash (/) and cannot contain the following characters: `" % # ; ! ( ) [ ] ^ , "`.
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// The port to which requests are forwarded.
                    /// 
                    /// Valid values: **1** to **63335**.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    /// <summary>
                    /// The redirect protocol.
                    /// 
                    /// Valid values: **HTTP** and **HTTPS**.
                    /// 
                    /// > HTTPS listeners support only HTTP to HTTPS redirection.
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// The query string to which requests are forwarded.
                    /// 
                    /// The query string must be 1 to 128 characters in length, and can contain printable characters, excluding uppercase letters and the following special characters: `# [ ] { } \ | < > &`.
                    /// </summary>
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                }

                /// <summary>
                /// The action to remove an HTTP header. You can specify the configurations of up to 20 actions to remove an HTTP header.
                /// </summary>
                [NameInMap("RemoveHeaderConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsRemoveHeaderConfig RemoveHeaderConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsRemoveHeaderConfig : TeaModel {
                    /// <summary>
                    /// The key of the header.
                    /// 
                    /// *   The key must be 1 to 40 characters in length.
                    /// *   It can contain letters, digits, hyphens (-), and underscores (\_).
                    /// *   Cookie and Host are not supported.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                }

                /// <summary>
                /// The configuration of the rewrite action. You can specify the configurations of up to 20 rewrite actions.
                /// </summary>
                [NameInMap("RewriteConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsRewriteConfig RewriteConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsRewriteConfig : TeaModel {
                    /// <summary>
                    /// The hostname to which requests are forwarded.
                    /// 
                    /// Take note of the following rules when you specify a hostname:
                    /// 
                    /// *   The hostname must be 3 to 128 characters in length, and can contain lowercase letters, digits, and the following special characters: - . \* = ~ \_ + \ ^ ! $ & | ( ) \[ ] ?.
                    /// *   The hostname must contain at least one period (.) but cannot start or end with a period (.).
                    /// *   The rightmost domain label can contain only letters, asterisks (*), and question marks (?), and cannot contain digits or hyphens (-). The leftmost `domain label` can contain asterisks (*).
                    /// *   The domain labels cannot start or end with a hyphen (-). You can specify asterisks (∗) and question marks (?) anywhere in a domain label.
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// The path to which requests are forwarded.
                    /// 
                    /// *   **${path}** (default): You can reference \*\*${host}**, **${protocol}** and **${port}\*\*. Each variable can be used only once. You can specify one or more of the preceding variables in each request. You can also combine them with a custom value.
                    /// 
                    /// *   A custom value that meets the following requirements:
                    /// 
                    ///     *   The custom value must be 1 to 128 characters in length. You can use asterisks (\*) and question marks (?) as wildcards.
                    ///     *   The custom value can contain letters, digits, and the following special characters: `$ - _ . + / & ~ @ : \" * ?`. The custom value must start with a forward slash (/) and cannot contain the following characters: `" % # ; ! ( ) [ ] ^ , "`.
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// The query string to which requests are forwarded.
                    /// 
                    /// The query string must be 1 to 128 characters in length, and can contain printable characters, excluding uppercase letters and the following special characters: `# [ ] { } \ | < > &`.
                    /// </summary>
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                }

                /// <summary>
                /// The configuration of traffic throttling. You can add up to 20 configuration records.
                /// </summary>
                [NameInMap("TrafficLimitConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsTrafficLimitConfig TrafficLimitConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsTrafficLimitConfig : TeaModel {
                    /// <summary>
                    /// The QPS per IP address. Valid values: **1** to **100000**.
                    /// 
                    /// > If you specify this parameter and QPS, the value of PerIpQps must be smaller than the value of QPS.
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
                /// The configuration of traffic mirroring. You can add up to 20 configuration records.
                /// </summary>
                [NameInMap("TrafficMirrorConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsTrafficMirrorConfig TrafficMirrorConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsTrafficMirrorConfig : TeaModel {
                    /// <summary>
                    /// The configuration of the server group to which traffic is mirrored.
                    /// </summary>
                    [NameInMap("MirrorGroupConfig")]
                    [Validation(Required=false)]
                    public UpdateRulesAttributeRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfig MirrorGroupConfig { get; set; }
                    public class UpdateRulesAttributeRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfig : TeaModel {
                        /// <summary>
                        /// The server groups to which traffic is mirrored.
                        /// </summary>
                        [NameInMap("ServerGroupTuples")]
                        [Validation(Required=false)]
                        public List<UpdateRulesAttributeRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                        public class UpdateRulesAttributeRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples : TeaModel {
                            /// <summary>
                            /// The server group ID.
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
                /// The type of the forwarding rule. You can specify up to seven types. Valid values:
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
            /// The match conditions of the forwarding rule.
            /// </summary>
            [NameInMap("RuleConditions")]
            [Validation(Required=false)]
            public List<UpdateRulesAttributeRequestRulesRuleConditions> RuleConditions { get; set; }
            public class UpdateRulesAttributeRequestRulesRuleConditions : TeaModel {
                /// <summary>
                /// The match conditions for cookies. You can add up to 20 match conditions.
                /// </summary>
                [NameInMap("CookieConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsCookieConfig CookieConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsCookieConfig : TeaModel {
                    /// <summary>
                    /// The cookies.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<UpdateRulesAttributeRequestRulesRuleConditionsCookieConfigValues> Values { get; set; }
                    public class UpdateRulesAttributeRequestRulesRuleConditionsCookieConfigValues : TeaModel {
                        /// <summary>
                        /// The key of the cookie. The key must be 1 to 100 characters in length, and can contain printable characters such as lowercase letters, asterisks (\*), and question marks (?). However, the key cannot contain uppercase letters, space characters, or the following special characters: `# [ ] { } \ | < > &`.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of the cookie. The value must be 1 to 128 characters in length, and can contain printable characters such as lowercase letters, asterisks (\*), and question marks (?). However, the value cannot contain uppercase letters, space characters, or the following special characters: `# [ ] { } \ | < > &`.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The match conditions for HTTP headers. You can specify up to 20 match conditions.
                /// </summary>
                [NameInMap("HeaderConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsHeaderConfig HeaderConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsHeaderConfig : TeaModel {
                    /// <summary>
                    /// The key of the header. The key must be 1 to 40 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). Cookie and Host are not supported.
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
                /// The match conditions for hostnames. You can specify up to 20 match conditions.
                /// </summary>
                [NameInMap("HostConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsHostConfig HostConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsHostConfig : TeaModel {
                    /// <summary>
                    /// The hostnames.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The match conditions for HTTP request methods. Valid values of N: **1** to **20**.
                /// </summary>
                [NameInMap("MethodConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsMethodConfig MethodConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsMethodConfig : TeaModel {
                    /// <summary>
                    /// The HTTP request methods.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The match conditions for query strings. You can specify up to 20 match conditions.
                /// </summary>
                [NameInMap("PathConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsPathConfig PathConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsPathConfig : TeaModel {
                    /// <summary>
                    /// The paths.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The match conditions for query strings. You can specify up to 20 match conditions.
                /// </summary>
                [NameInMap("QueryStringConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsQueryStringConfig QueryStringConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsQueryStringConfig : TeaModel {
                    /// <summary>
                    /// The key-value pairs of the query strings.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<UpdateRulesAttributeRequestRulesRuleConditionsQueryStringConfigValues> Values { get; set; }
                    public class UpdateRulesAttributeRequestRulesRuleConditionsQueryStringConfigValues : TeaModel {
                        /// <summary>
                        /// They key of the query string.
                        /// 
                        /// The key must be 1 to 100 characters in length, and can contain printable characters such as lowercase letters, asterisks (\*), and question marks (?). The key cannot contain uppercase letters, space characters, or the following special characters: `# [ ] { } \ | < > &`.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of the query string.
                        /// 
                        /// The value must be 1 to 128 characters in length, and can contain printable characters such as lowercase letters, asterisks (\*), and question marks (?). However, uppercase letters, space characters, and the following special characters are not supported: `# [ ] { } \ | < > &`.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The configuration of the HTTP response header. You can specify the configurations of up to 20 HTTP response header.
                /// </summary>
                [NameInMap("ResponseHeaderConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsResponseHeaderConfig ResponseHeaderConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsResponseHeaderConfig : TeaModel {
                    /// <summary>
                    /// The key of the header.
                    /// 
                    /// *   The key must be 1 to 40 characters in length.
                    /// *   It can contain letters, digits, hyphens (-), and underscores (\_).
                    /// *   Cookie and Host are not supported.
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
                /// The match conditions for response status codes. This parameter is required and takes effect when **Type** is set to **ResponseStatusCode**. You can specify up to 20 match conditions.
                /// </summary>
                [NameInMap("ResponseStatusCodeConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsResponseStatusCodeConfig ResponseStatusCodeConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsResponseStatusCodeConfig : TeaModel {
                    /// <summary>
                    /// The match conditions.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The configuration of the source IP addresses based on which user traffic is matched. You can specify up to 20 configuration records.
                /// </summary>
                [NameInMap("SourceIpConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsSourceIpConfig SourceIpConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsSourceIpConfig : TeaModel {
                    /// <summary>
                    /// The source IP addresses based on which user traffic is matched.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The type of action specified in the forwarding rule. You can specify up to 11 types of actions. Valid values:
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
                /// *   **FinalType**: the last action to be performed in a forwarding rule. Each forwarding rule can contain only one FinalType action. You can specify a **ForwardGroup**, **Redirect**, or **FixedResponse** action as the FinalType action.
                /// *   **ExtType**: the action or the actions to be performed before the **FinalType** action. A forwarding rule can contain one or more **ExtType** actions. To specify an ExtType action, you must specify a **FinalType** action. You can specify multiple **InsertHeader** actions or one **Rewrite** action.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The forwarding rule ID. You can specify up to 20 IDs.
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// The name of the forwarding rule. The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (\_), and hyphens (-). The name must start with a letter. You can specify names for up to 20 forwarding rules.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

    }

}
