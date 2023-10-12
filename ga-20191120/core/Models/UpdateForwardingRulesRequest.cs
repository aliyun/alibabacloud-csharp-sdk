// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateForwardingRulesRequest : TeaModel {
        /// <summary>
        /// The GA instance ID.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The configurations of the forwarding rule.
        /// </summary>
        [NameInMap("ForwardingRules")]
        [Validation(Required=false)]
        public List<UpdateForwardingRulesRequestForwardingRules> ForwardingRules { get; set; }
        public class UpdateForwardingRulesRequestForwardingRules : TeaModel {
            /// <summary>
            /// The forwarding rule ID.
            /// </summary>
            [NameInMap("ForwardingRuleId")]
            [Validation(Required=false)]
            public string ForwardingRuleId { get; set; }

            /// <summary>
            /// The forwarding rule name.
            /// 
            /// The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (\_), and hyphens (-). The name must start with a letter.
            /// </summary>
            [NameInMap("ForwardingRuleName")]
            [Validation(Required=false)]
            public string ForwardingRuleName { get; set; }

            /// <summary>
            /// The priority of the forwarding rule. Valid values: **1** to **10000**. A smaller value indicates a higher priority.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// The configurations of the forwarding action.
            /// </summary>
            [NameInMap("RuleActions")]
            [Validation(Required=false)]
            public List<UpdateForwardingRulesRequestForwardingRulesRuleActions> RuleActions { get; set; }
            public class UpdateForwardingRulesRequestForwardingRulesRuleActions : TeaModel {
                /// <summary>
                /// The forwarding configurations.
                /// 
                /// >  We recommend that you use **RuleActionType** and **RuleActionValue** rather than this parameter to configure forwarding actions.
                /// </summary>
                [NameInMap("ForwardGroupConfig")]
                [Validation(Required=false)]
                public UpdateForwardingRulesRequestForwardingRulesRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class UpdateForwardingRulesRequestForwardingRulesRuleActionsForwardGroupConfig : TeaModel {
                    /// <summary>
                    /// The configurations of an endpoint group.
                    /// 
                    /// >  We recommend that you use **RuleActionType** and **RuleActionValue** rather than this parameter to configure forwarding actions.
                    /// </summary>
                    [NameInMap("ServerGroupTuples")]
                    [Validation(Required=false)]
                    public List<UpdateForwardingRulesRequestForwardingRulesRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class UpdateForwardingRulesRequestForwardingRulesRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
                        /// <summary>
                        /// The ID of an endpoint group.
                        /// 
                        /// >  We recommend that you use **RuleActionType** and **RuleActionValue** rather than this parameter to configure forwarding actions.
                        /// </summary>
                        [NameInMap("EndpointGroupId")]
                        [Validation(Required=false)]
                        public string EndpointGroupId { get; set; }

                    }

                }

                /// <summary>
                /// The forwarding priority.
                /// 
                /// >  This parameter does not take effect. Ignore this parameter.
                /// </summary>
                [NameInMap("Order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                /// <summary>
                /// The type of the forwarding action. Valid values:
                /// 
                /// *   **ForwardGroup:** forwards a request.
                /// *   **Redirect:** redirects a request.
                /// *   **FixResponse:** returns a fixed response.
                /// *   **Rewrite:** rewrites a request.
                /// *   **AddHeader:** adds a header to a request.
                /// *   **RemoveHeaderConfig:** deletes the header of a request.
                /// </summary>
                [NameInMap("RuleActionType")]
                [Validation(Required=false)]
                public string RuleActionType { get; set; }

                /// <summary>
                /// The value of the forwarding action type.
                /// 
                /// You must specify different JSON strings based on the value of the **RuleActionType** parameter.
                /// 
                /// A forwarding rule can contain only one forwarding action whose type is **ForwardGroup**, **Redirect**, or **FixResponse**. You must specify a forwarding action whose type is **Rewrite**, **AddHeader**, or **RemoveHeader** before a forwarding action whose type is **ForwardGroup**.
                /// 
                /// *   If you set **RuleActionType** to **ForwardGroup**, this parameter specifies the information of a virtual endpoint group. You can forward requests to only one virtual endpoint group. Example: `{"type":"endpointgroup", "value":"epg-bp1enpdcrqhl78g6r****"}`.
                /// 
                ///     *   `type:` set this parameter to `endpointgroup`.
                ///     *   `value:` set this parameter to the ID of a virtual endpoint group.
                /// 
                /// *   If you set **RuleActionType** to **Redirect**, this parameter specifies redirecting configurations. You cannot leave all of the following parameters empty or configure all of these parameters to use the default values for a forwarding action whose type is **Redirect**: `protocol`, `domain`, `port`, `path`, and `query`. Example: `{"protocol":"HTTP", "domain":"www.example.com", "port":"80", "path":"/a","query":"value1", "code":"301" }`.
                /// 
                ///     *   `protocol:` the protocol of requests after the requests are redirected. Valid values: `${protocol}` (default), `HTTP`, and `HTTPS`.
                ///     *   `domain:` the domain name to which requests are redirected. Default value: `${host}`. You can also enter a domain name. The domain name must be 3 to 128 characters in length, and can contain only letters, digits, and the following special characters: `. - ? = ~ _ - + / ^ * ! $ & | ( ) [ ]`.
                ///     *   `port:` the port to which requests are redirected. Default value: `${port}`. You can enter a port number that ranges from 1 to 63335.
                ///     *   `path:` the path to which requests are redirected. Default value: `${path}`. The path must be 1 to 128 characters in length. To use a regular expression, the path can contain letters, digits, and the following special characters: `. - _ / = ? ~ ^ * $ : ( ) [ ] + |`. The path must start with a tilde (~). If you do not want to use a regular expression, the path can contain letters, digits, and the following special characters: `. - _ / = ? :`. The path must start with a forward slash (/).
                ///     *   `query:` the query string of the requests to be redirected. Default value: `${query}`. You can also specify a query string. The query string must be 1 to 128 characters in length, and can contain printable characters whose ASCII values are `greater than or equal to 32 and smaller than 127`. The query string cannot contain uppercase letters, space characters, or the following special characters: `[ ] { } < > # | &`.
                ///     *   `code:` the redirecting code. Valid values: `301`, `302`, `303`, `307`, and `308`.
                /// 
                /// *   If you set **RuleActionType** to **FixResponse**, this parameter specifies a fixed response. Example: `{"code":"200", "type":"text/plain", "content":"dssacav" }`.
                /// 
                ///     *   `code:` the HTTP response status code. The response status code must be one of the following numeric strings: `2xx`, `4xx`, and `5xx`. The letter `x` indicates a number from 0 to 9.
                ///     *   `type:` the type of the response content. Valid values: **text/plain**, **text/css**, **text/html**, **application/javascript**, and **application/json**.
                ///     *   `content:` the response content. The response content cannot exceed 1,000 characters in length and does not support Chinese characters.
                /// 
                /// *   If you set **RuleActionType** to **AddHeader**, this parameter specifies an HTTP header to be added. If a forwarding rule contains a forwarding action whose type is **AddHeader**, you must specify another forwarding action whose type is **ForwardGroup**. Example: `[{"name":"header1","type":"userdefined", "value":"value"}]`.
                /// 
                ///     *   `name:` the name of the HTTP header. The name must be 1 to 40 characters in length, and can contain letters, digits, hyphens (-), and underscores (\_). The name of the HTTP header specified by **AddHeader** must be unique and cannot be the same as the name of the HTTP header specified by **RemoveHeader**.
                ///     *   `type:` the content type of the HTTP header. Valid values: `user-defined`, `ref`, and `system-defined`.
                ///     *   `value:` the content of the HTTP header. You cannot leave this parameter empty. If you set `type` to `user-defined`, the content must be 1 to 128 characters in length, and can contain printable characters whose ASCII values are `greater than or equal to 32 and smaller than 127`. The content can contain letters, digits, hyphens (-), and underscores (\_). The content cannot start or end with a space character. If you set `type` to `ref`, the content must be 1 to 128 characters in length, and can contain letters, digits, hyphens (-), and underscores (\_). The content cannot start or end with a space character. If you set `type` to `system-defined`, only `ClientSrcIp` is supported.**
                /// 
                /// *   If you set **RuleActionType** to **RemoveHeader**, this parameter specifies an HTTP header to be removed. If a forwarding rule contains a forwarding action whose type is **RemoveHeader**, you must specify another forwarding action whose type is **ForwardGroup**. The header must be 1 to 40 characters in length, and can contain letters, digits, hyphens (-), and underscores (\_). Example: `["header1"]`.
                /// 
                /// *   If you set **RuleActionType** to **Rewrite**, this parameter specifies the rewriting configuration. If a forwarding rule contains a forwarding action whose type is **Rewrite**, you must specify another forwarding action whose type is **ForwardGroup**. Example: `{"domain":"value1", "path":"value2", "query":"value3"}`.
                /// 
                ///     *   `domain:` the domain name to which requests are redirected. Default value: `${host}`. You can also enter a domain name. The domain name must be 3 to 128 characters in length, and can contain only lowercase letters, digits, and the following special characters: `. - ? = ~ _ - + / ^ * ! $ & | ( ) [ ]`.
                ///     *   `path:` the path to which requests are redirected. Default value: `${path}`. The path must be 1 to 128 characters in length. To use a regular expression, the path can contain letters, digits, and the following special characters: `. - _ / = ? ~ ^ * $ : ( ) [ ] + |`. The path must start with a tilde (~). If you do not want to use a regular expression, the path can contain letters, digits, and the following special characters: `. - _ / = ? :`. The path must start with a forward slash (/).
                ///     *   `query:` the query string of the requests to be redirected. Default value: `${query}`. You can also specify a query string. The query string must be 1 to 128 characters in length, and can contain printable characters whose ASCII values are `greater than or equal to 32 and smaller than 127`. The query string cannot contain uppercase letters, space characters, or the following special characters: `[ ] { } < > # | &`.
                /// </summary>
                [NameInMap("RuleActionValue")]
                [Validation(Required=false)]
                public string RuleActionValue { get; set; }

            }

            /// <summary>
            /// The conditions that trigger the forwarding rule.
            /// </summary>
            [NameInMap("RuleConditions")]
            [Validation(Required=false)]
            public List<UpdateForwardingRulesRequestForwardingRulesRuleConditions> RuleConditions { get; set; }
            public class UpdateForwardingRulesRequestForwardingRulesRuleConditions : TeaModel {
                /// <summary>
                /// The configurations of the domain name.
                /// 
                /// >  We recommend that you use **RuleConditionType** and **RuleConditionValue** rather than this parameter to configure forwarding conditions.
                /// </summary>
                [NameInMap("HostConfig")]
                [Validation(Required=false)]
                public UpdateForwardingRulesRequestForwardingRulesRuleConditionsHostConfig HostConfig { get; set; }
                public class UpdateForwardingRulesRequestForwardingRulesRuleConditionsHostConfig : TeaModel {
                    /// <summary>
                    /// The domain name configuration.
                    /// 
                    /// >  We recommend that you use **RuleConditionType** and **RuleConditionValue** rather than this parameter to configure forwarding conditions.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The configurations of the path.
                /// 
                /// >  We recommend that you use **RuleConditionType** and **RuleConditionValue** rather than this parameter to configure forwarding conditions.
                /// </summary>
                [NameInMap("PathConfig")]
                [Validation(Required=false)]
                public UpdateForwardingRulesRequestForwardingRulesRuleConditionsPathConfig PathConfig { get; set; }
                public class UpdateForwardingRulesRequestForwardingRulesRuleConditionsPathConfig : TeaModel {
                    /// <summary>
                    /// The path configuration.
                    /// 
                    /// >  We recommend that you use **RuleConditionType** and **RuleConditionValue** rather than this parameter to configure forwarding conditions.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The type of the forwarding condition. Valid values:
                /// 
                /// *   **Host:** Requests are forwarded based on domain names.
                /// *   **Path:** Requests are forwarded based on paths.
                /// *   **RequestHeader:** Requests are forwarded based on HTTP headers.
                /// *   **Query:** Requests are forwarded based on query strings.
                /// *   **Method:** Requests are forwarded based on HTTP methods.
                /// *   **Cookie:** Requests are forwarded based on cookies.
                /// *   **SourceIP:** Requests are forwarded based on source IP address.
                /// </summary>
                [NameInMap("RuleConditionType")]
                [Validation(Required=false)]
                public string RuleConditionType { get; set; }

                /// <summary>
                /// The value of the forwarding condition type. You must specify different JSON strings based on the value of the **RuleConditionType** parameter.
                /// 
                /// *   If you set **RuleConditionType** to **Host**, this parameter specifies a domain name condition. A forwarding rule can contain only one forwarding condition of the host type. You can specify multiple domain names in a forwarding condition. The relationship between multiple domain names is OR. The domain name must be 3 to 128 characters in length and can contain letters, digits, hyphens (-), and periods (.). Supported wildcard characters are asterisks (\*) and question marks (?). Example: `["www.example.com", "www.aliyun.com"]`.
                /// 
                /// *   If **RuleConditionType** is set to **Path**, this parameter specifies a path condition. A forwarding rule can contain multiple forwarding conditions of the path type. The relationship between multiple path conditions is OR. You can specify multiple paths in a forwarding condition. The relationship between multiple paths is OR. The path must be 1 to 128 characters in length, and must start with a forward slash (/). The path can contain letters, digits, and the following special characters: $ - \_ . + / & ~ @ : \". Supported wildcard characters are asterisks (\*) and question marks (?). Example: `["/a", "/b/"]`.
                /// 
                /// *   If you set **RuleConditionType** to **RequestHeader**, this parameter specifies an HTTP header condition that consists of key-value pairs. The header values in a forwarding condition must be unique. Example: `[{"header1":["value1","value2"]}]`.
                /// 
                ///     *   Key: The key of an HTTP header must be 1 to 40 characters in length, and can contain letters, digits, hyphens (-), and underscores (\_).
                ///     *   Value: The value of an HTTP header must be 1 to 128 characters in length, and can contain printable characters whose ASCII values are `greater than or equal to 32 and smaller than 127`. The value cannot start or end with a space character.
                /// 
                /// *   If you set **RuleConditionType** to **Query**, this parameter specifies a query string condition that consists of key-value pairs. Example: `[{"query1":["value1"]}, {"query2":["value2"]}]`.
                /// 
                ///     *   Key: The key of an HTTP header must be 1 to 100 characters in length, and can contain printable characters whose ASCII values are `greater than or equal to 32 and smaller than 127`. The key cannot contain uppercase letters, space characters, or the following special characters: `[ ] { } < > \ ; / ? : @ & = + , $ % | " ^ ~`.
                ///     *   Value: The value of an HTTP header must be 1 to 128 characters in length, and can contain printable characters whose ASCII values are `greater than or equal to 32 and smaller than 127`. The value cannot contain uppercase letters, space characters, or the following special characters: `[ ] { } < > \ ; / ? : @ & = + , $ % | " ^ ~`.
                /// 
                /// *   If you set **RuleConditionType** to **Method**, this parameter specifies an HTTP method condition. Valid values: **HEAD**, **GET**, **POST**, **OPTIONS**, **PUT**, **PATCH**, and **DELETE**. Example: `["GET", "OPTIONS", "POST"]`.
                /// 
                /// *   If you set **RuleConditionType** to **Cookie**, this parameter specifies a cookie condition that consists of key-value pairs. Example: `[{"cookie1":["value1"]}, {"cookie2":["value2"]}]`.
                /// 
                ///     *   Key: The key of a cookie must be 1 to 100 characters in length, and can contain printable characters whose ASCII values are `greater than or equal to 32 and smaller than 127`. The key cannot contain uppercase letters, space characters, or the following special characters: `# [ ] { } \ | < > &`.
                ///     *   Value: The value of a cookie must be 1 to 128 characters in length, and can contain printable characters whose ASCII values are `greater than or equal to 32 and lower than 127`. The value cannot contain uppercase letters, space characters, or the following special characters: `# [ ] { } \ | < > &`.
                /// 
                /// *   If you set **RuleConditionType** to **SourceIP**, this parameter specifies a source IP address condition. You can specify IP addresses, such as 1.1.XX.XX/32. You can also specify CIDR blocks, such as 2.2.XX.XX/24. A forwarding rule can contain only one forwarding condition whose type is source IP address. You can specify multiple source IP addresses in a forwarding condition. The relationship between multiple source IP addresses is OR. Example: `["1.1.XX.XX/32", "2.2.XX.XX/24"]`.
                /// </summary>
                [NameInMap("RuleConditionValue")]
                [Validation(Required=false)]
                public string RuleConditionValue { get; set; }

            }

            /// <summary>
            /// The direction in which the rule takes effect. You do not need to configure this parameter.
            /// 
            /// By default, this parameter is set to **request**, which indicates that the rule takes effect on requests.
            /// </summary>
            [NameInMap("RuleDirection")]
            [Validation(Required=false)]
            public string RuleDirection { get; set; }

        }

        /// <summary>
        /// The listener ID.
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// The region ID of the GA instance. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
