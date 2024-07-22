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
        /// The forwarding rules. You can specify at most 10 forwarding rules in each call.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<UpdateRulesAttributeRequestRules> Rules { get; set; }
        public class UpdateRulesAttributeRequestRules : TeaModel {
            /// <summary>
            /// The priority of the forwarding rule. Valid values: **1 to 10000**. A smaller value specifies a higher priority. You can specify at most 20 rule priorities.
            /// 
            /// >  The priority of each forwarding rule within a listener must be unique.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// The action of the forwarding rule.
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
                    /// The trusted headers of CORS requests.
                    /// </summary>
                    [NameInMap("AllowHeaders")]
                    [Validation(Required=false)]
                    public List<string> AllowHeaders { get; set; }

                    /// <summary>
                    /// The trusted HTTP methods of CORS requests.
                    /// </summary>
                    [NameInMap("AllowMethods")]
                    [Validation(Required=false)]
                    public List<string> AllowMethods { get; set; }

                    /// <summary>
                    /// The trusted origins. You can specify one or more values, or only an asterisk (`*`).
                    /// 
                    /// *   The value must start with `http://` or `https://`, and be followed by a valid domain name, including top-level wildcard domain names. Example: `http://*.test.abc.example.com`.
                    /// *   You can specify ports for a single value. Valid values: **1** to **65535**.
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
                /// The configuration of the action to return a custom response. You can specify at most 20 custom responses.
                /// </summary>
                [NameInMap("FixedResponseConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsFixedResponseConfig FixedResponseConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsFixedResponseConfig : TeaModel {
                    /// <summary>
                    /// The content of the response. The content can be up to 1 KB in size, and can contain only ASCII characters.
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// The content format of the response.
                    /// 
                    /// Valid values: **text/plain**, **text/css**, **text/html**, **application/javascript**, and **application/json**.
                    /// </summary>
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    /// <summary>
                    /// The HTTP status code in responses. Valid values: **2xx**, **4xx**, **5xx**. The value must be a numeric string. **x** must be a digit.
                    /// </summary>
                    [NameInMap("HttpCode")]
                    [Validation(Required=false)]
                    public string HttpCode { get; set; }

                }

                /// <summary>
                /// The configuration of the action to forward requests to server groups. You can specify at most 20 actions.
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
                        /// *   If the number of destination server groups is 1, the default weight of the server group is **100**, unless you specify a weight.
                        /// *   If the number of destination server groups is larger than 1, you must specify a weight.
                        /// </summary>
                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public int? Weight { get; set; }

                    }

                }

                /// <summary>
                /// The configuration of the action to insert a header. You can specify at most 20 actions.
                /// </summary>
                [NameInMap("InsertHeaderConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsInsertHeaderConfig InsertHeaderConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsInsertHeaderConfig : TeaModel {
                    /// <summary>
                    /// Specifies whether to overwrite the header in the request. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false** (default)
                    /// </summary>
                    [NameInMap("CoverEnabled")]
                    [Validation(Required=false)]
                    public bool? CoverEnabled { get; set; }

                    /// <summary>
                    /// The key of the header. The header key must be 1 to 40 characters in length, and can contain lowercase letters, digits, underscores (_), and hyphens (-). The key specified in `InsertHeader` must be unique.
                    /// 
                    /// >  The following header keys are not supported: `slb-id`, `slb-ip`, `x-forwarded-for`, `x-forwarded-proto`, `x-forwarded-eip`, `x-forwarded-port`, `x-forwarded-client-srcport`, `connection`, `upgrade`, `content-length`, `transfer-encoding`, `keep-alive`, `te, host`, `cookie`, `remoteip`, and `authority`. Header keys are not case-sensitive.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The value of the header.
                    /// 
                    /// *   If **ValueType** is set to **SystemDefined**, you can set the Value parameter to one of the following values:
                    /// 
                    ///     *   **ClientSrcPort**: the client port.
                    ///     *   **ClientSrcIp**: the IP address of the client.
                    ///     *   **Protocol**: the request protocol (HTTP or HTTPS).
                    ///     *   **SLBId**: the ID of the ALB instance.
                    ///     *   **SLBPort**: the listener port of the ALB instance.
                    /// 
                    /// *   If **ValueType** is set to **UserDefined**, you can specify a custom header value. The header value must be 1 to 128 characters in length, and can contain wildcard characters, such as asterisks (\\*) and question marks (?), and printable characters whose ASCII values are `larger than or equal to 32 and smaller than 127`. The header value cannot start or end with a space character.
                    /// 
                    /// *   If **ValueType** is set to **ReferenceHeader**, you can reference a value from request headers. The value must be 1 to 128 characters in length, and can contain lowercase letters, digits, hyphens (-), and underscores (_).
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    /// <summary>
                    /// The type of header. Valid values:
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
                /// The priority of the action. Valid values: **1** to **50000**. A lower value indicates a higher priority. The actions of a forwarding rule are applied in descending order of priority. This parameter cannot be left empty. The priority of each action within a forwarding rule must be unique. You can specify at most 20 forwarding rule priorities.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("Order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                /// <summary>
                /// The configuration of the redirect action. You can specify at most 20 redirect actions.
                /// </summary>
                [NameInMap("RedirectConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsRedirectConfig RedirectConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsRedirectConfig : TeaModel {
                    /// <summary>
                    /// The hostname to which requests are redirected.
                    /// 
                    /// The hostname must meet the following requirements:
                    /// 
                    /// *   The hostname must be 3 to 128 characters in length, and can contain lowercase letters, digits, and the following special characters: - . \\* = ~ _ + \\ ^ ! $ & | ( ) [ ] ?.
                    /// *   The hostname must contain at least one period (.) but cannot start or end with a period (.).
                    /// *   The rightmost domain label can contain only letters, asterisks (*), and question marks (?), and cannot contain digits or hyphens (-). The leftmost `domain label` can contain asterisks (*).
                    /// *   The domain labels cannot start or end with a hyphen (-). You can specify asterisks (∗) and question marks (?) anywhere in a domain label.
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
                    /// The path to which requests are redirected.
                    /// 
                    /// *   **${path}** (default): You can reference \\*\\*${host}**, **${protocol}** and **${port}\\*\\*. Each variable can be used only once. The preceding variables can be used at the same time or combined with a custom value.
                    /// 
                    /// *   The path must meet the following requirements:
                    /// 
                    ///     *   The path must be 1 to 128 characters in length. You can use asterisks (\\*) and question marks (?) as wildcard characters.
                    ///     *   The path can contain letters, digits, and the following special characters: `$ - _ . + / & ~ @ : \\" * ?`. It must start with a forward slash (/) and cannot contain the following characters: `" % # ; ! ( ) [ ] ^ , "`.
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
                    /// The protocol of the destination to which requests are forwarded. Valid values:
                    /// 
                    /// Valid values: **HTTP** and **HTTPS**.
                    /// 
                    /// >  HTTPS listeners supports only HTTPS redirects.
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// The query string to which requests are redirected.
                    /// 
                    /// The query string must be 1 to 128 characters in length, and can contain printable characters, excluding uppercase letters and the following special characters: `# [ ] { } \\ | < > &`.
                    /// </summary>
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                }

                /// <summary>
                /// The configuration of the HTTP header to be removed. You can remove at most 20 HTTP headers.
                /// </summary>
                [NameInMap("RemoveHeaderConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsRemoveHeaderConfig RemoveHeaderConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsRemoveHeaderConfig : TeaModel {
                    /// <summary>
                    /// The key of the response header.
                    /// 
                    /// *   The header key must be 1 to 40 characters in length.
                    /// *   The header key can contain lowercase letters, digits, hyphens (-), and underscores (_).
                    /// *   Cookie and Host are not supported.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                }

                /// <summary>
                /// The configuration of the rewrite action. You can specify at most 20 actions.
                /// </summary>
                [NameInMap("RewriteConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsRewriteConfig RewriteConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsRewriteConfig : TeaModel {
                    /// <summary>
                    /// The hostname of the destination to which requests are forwarded.
                    /// 
                    /// The hostname must meet the following requirements:
                    /// 
                    /// *   The hostname must be 3 to 128 characters in length, and can contain lowercase letters, digits, and the following special characters: - . \\* = ~ _ + \\ ^ ! $ & | ( ) [ ] ?.
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
                    /// *   **${path}** (default): You can reference \\*\\*${host}**, **${protocol}** and **${port}\\*\\*. Each variable can be used only once. The preceding variables can be used at the same time or combined with a custom value.
                    /// 
                    /// *   The path must meet the following requirements:
                    /// 
                    ///     *   The path must be 1 to 128 characters in length. You can use asterisks (\\*) and question marks (?) as wildcard characters.
                    ///     *   The custom value can contain letters, digits, and the following special characters: `$ - _ . + / & ~ @ : \\" * ?`. The custom value must start with a forward slash (/) and cannot contain the following characters: `" % # ; ! ( ) [ ] ^ , "`.
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// The query string of the URL to which requests are forwarded.
                    /// 
                    /// The query string must be 1 to 128 characters in length, and can contain printable characters, excluding uppercase letters and the following special characters: `# [ ] { } \\ | < > &`.
                    /// </summary>
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                }

                /// <summary>
                /// The configuration of traffic throttling. You can specify at most 20 throttling actions.
                /// </summary>
                [NameInMap("TrafficLimitConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsTrafficLimitConfig TrafficLimitConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsTrafficLimitConfig : TeaModel {
                    /// <summary>
                    /// The number of requests per IP address. Valid values: **1** to **1000000**.
                    /// 
                    /// >  If both the QPS and PerIpQps properties are specified, make sure that the value of the QPS property is smaller than the value of the PerIpQps property.
                    /// </summary>
                    [NameInMap("PerIpQps")]
                    [Validation(Required=false)]
                    public int? PerIpQps { get; set; }

                    /// <summary>
                    /// The number of queries per second (QPS). Valid values: **1** to **1000000**.
                    /// </summary>
                    [NameInMap("QPS")]
                    [Validation(Required=false)]
                    public int? QPS { get; set; }

                }

                /// <summary>
                /// The configuration of traffic mirroring. You can specify at most 20 traffic mirroring configurations.
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
                        /// The server group to which traffic is mirrored.
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
                    /// The type of the destination to which network traffic is mirrored. Valid values:
                    /// 
                    /// *   **ForwardGroupMirror**: a server group
                    /// </summary>
                    [NameInMap("TargetType")]
                    [Validation(Required=false)]
                    public string TargetType { get; set; }

                }

                /// <summary>
                /// The type of action. You can specify at most 11 types of action. Valid values:
                /// 
                /// *   **ForwardGroup**: forwards a request to multiple vServer groups.
                /// *   **Redirect**: redirects requests.
                /// *   **FixedResponse**: returns a fixed response.
                /// *   **Rewrite**: rewrites requests.
                /// *   **InsertHeader**: inserts a header.
                /// *   **RemoveHeaderConfig**: deletes a header.
                /// *   **TrafficLimit**: throttles traffic.
                /// *   **TrafficMirror**: mirrors network traffic.
                /// *   **Cors**: enables cross-origin resource sharing (CORS).
                /// 
                /// The preceding actions can be classified into two types:
                /// 
                /// *   **FinalType**: Each forwarding rule can contain only one FinalType action, which is performed at the end. You can specify only one of **ForwardGroup**, **Redirect**, and **FixedResponse**.
                /// *   **ExtType**: Each forwarding rule can contain one or more **ExtType** actions, which are performed before the **FinalType** action. If you want to specify an ExtType action, you must also specify a **FinalType** action. You can specify multiple **InsertHeader** actions or one **Rewrite** action.
                /// 
                /// This parameter is required.
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
                /// The configuration of the cookie. You can specify at most 20 conditions.
                /// </summary>
                [NameInMap("CookieConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsCookieConfig CookieConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsCookieConfig : TeaModel {
                    /// <summary>
                    /// The key-value pairs of cookies.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<UpdateRulesAttributeRequestRulesRuleConditionsCookieConfigValues> Values { get; set; }
                    public class UpdateRulesAttributeRequestRulesRuleConditionsCookieConfigValues : TeaModel {
                        /// <summary>
                        /// The cookie key, which must be 1 to 100 characters in length, and can contain lowercase letters, asterisks (\\*), question marks (?), and printable characters. It cannot contain space characters or the following special characters: `# [ ] { } \\ | < > &`.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The cookie value, which must be 1 to 128 characters in length, and can contain lowercase letters, asterisks (\\*), question marks (?), and printable characters. It cannot contain space characters or the following special characters: `# [ ] { } \\ | < > &`.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The configuration of the HTTP header. You can specify at most 20 HTTP headers.
                /// </summary>
                [NameInMap("HeaderConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsHeaderConfig HeaderConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsHeaderConfig : TeaModel {
                    /// <summary>
                    /// The key of the header. The key must be 1 to 40 characters in length. The header key can contain lowercase letters, digits, hyphens (-), and underscores (_). Cookie and Host are not supported.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The HTTP header values.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The match conditions for hostnames. You can specify at most 20 conditions.
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
                /// The configuration of the HTTP request method. Valid values of N: **1** to **20**.
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
                /// The match conditions for query strings. You can specify at most 20 conditions.
                /// </summary>
                [NameInMap("PathConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsPathConfig PathConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsPathConfig : TeaModel {
                    /// <summary>
                    /// The paths to which requests are forwarded.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The match conditions for query strings. You can specify at most 20 conditions.
                /// </summary>
                [NameInMap("QueryStringConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsQueryStringConfig QueryStringConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsQueryStringConfig : TeaModel {
                    /// <summary>
                    /// The key-value pairs of query strings.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<UpdateRulesAttributeRequestRulesRuleConditionsQueryStringConfigValues> Values { get; set; }
                    public class UpdateRulesAttributeRequestRulesRuleConditionsQueryStringConfigValues : TeaModel {
                        /// <summary>
                        /// The key of the query string.
                        /// 
                        /// The key must be 1 to 100 characters in length, and can contain lowercase letters, printable ASCII characters, asterisks (\\*), and question marks (?). It cannot contain space characters or the following special characters: `# [ ] { } \\ | < > &`.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of the query string.
                        /// 
                        /// The value must be 1 to 128 characters in length, and can contain lowercase letters, printable ASCII characters, asterisks (\\*), and question marks (?). It cannot contain space characters or the following special characters: `# [ ] { } \\ | < > &`.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The HTTP response headers. You can specify at most 20 HTTP response headers.
                /// </summary>
                [NameInMap("ResponseHeaderConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsResponseHeaderConfig ResponseHeaderConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsResponseHeaderConfig : TeaModel {
                    /// <summary>
                    /// The key of the response header.
                    /// 
                    /// *   The header key must be 1 to 40 characters in length.
                    /// *   The header key can contain lowercase letters, digits, hyphens (-), and underscores (_).
                    /// *   Cookie and Host are not supported.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The value of the response header.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The match conditions for response status codes. This parameter is required and valid when **Type** is set to **ResponseStatusCode**. You can specify at most 20 conditions.
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
                /// Traffic matching based on source IP addresses. You can specify at most 20 match conditions based on IP addresses.
                /// </summary>
                [NameInMap("SourceIpConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsSourceIpConfig SourceIpConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsSourceIpConfig : TeaModel {
                    /// <summary>
                    /// Traffic matching based on source IP addresses.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The type of the forwarding rule. You can specify at most seven types of forwarding rule. Valid values:
                /// 
                /// *   **Host**: Responses are forwarded based on hosts.
                /// *   **Path**: Responses are forwarded based on URLs.
                /// *   **Header**: Responses are forwarded based on HTTP headers.
                /// *   **QueryString**: Responses are forwarded based on query strings.
                /// *   **Method**: Responses are forwarded based on request methods.
                /// *   **Cookie**: Responses are forwarded based on cookies.
                /// *   **SourceIp**: Responses are forwarded based on source IP addresses.
                /// *   **ResponseHeader**: Responses are forwarded based on HTTP response headers.
                /// *   **ResponseStatusCode**: Response are forwarded based on response status codes.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The ID of the forwarding rule. You can specify at most 20 rule IDs.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// The name of the forwarding rule. The name must be 2 to 128 letters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter. You can specify at most 20 rule names.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

    }

}
