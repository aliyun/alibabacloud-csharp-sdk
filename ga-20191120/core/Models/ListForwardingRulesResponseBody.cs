// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListForwardingRulesResponseBody : TeaModel {
        /// <summary>
        /// The information about the forwarding rules.
        /// </summary>
        [NameInMap("ForwardingRules")]
        [Validation(Required=false)]
        public List<ListForwardingRulesResponseBodyForwardingRules> ForwardingRules { get; set; }
        public class ListForwardingRulesResponseBodyForwardingRules : TeaModel {
            /// <summary>
            /// The direction in which the forwarding rule takes effect.
            /// 
            /// By default, **request** is returned, which indicates that the forwarding rule takes effect on requests.
            /// </summary>
            [NameInMap("ForwardingRuleDirection")]
            [Validation(Required=false)]
            public string ForwardingRuleDirection { get; set; }

            /// <summary>
            /// The ID of the forwarding rule.
            /// </summary>
            [NameInMap("ForwardingRuleId")]
            [Validation(Required=false)]
            public string ForwardingRuleId { get; set; }

            /// <summary>
            /// The name of the forwarding rule.
            /// </summary>
            [NameInMap("ForwardingRuleName")]
            [Validation(Required=false)]
            public string ForwardingRuleName { get; set; }

            /// <summary>
            /// The state of the forwarding rule.
            /// 
            /// *   **active**: The forwarding rule is normal.
            /// *   **configuring**: The forwarding rule is being modified.
            /// *   **deleting**: The forwarding rule is being deleted.
            /// </summary>
            [NameInMap("ForwardingRuleStatus")]
            [Validation(Required=false)]
            public string ForwardingRuleStatus { get; set; }

            /// <summary>
            /// The ID of the listener.
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// The priority of the forwarding rule.
            /// 
            /// Valid values: **1** to **10000**. A lower value indicates a higher priority.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// The forwarding action.
            /// </summary>
            [NameInMap("RuleActions")]
            [Validation(Required=false)]
            public List<ListForwardingRulesResponseBodyForwardingRulesRuleActions> RuleActions { get; set; }
            public class ListForwardingRulesResponseBodyForwardingRulesRuleActions : TeaModel {
                /// <summary>
                /// The configuration of the forwarding action.
                /// </summary>
                [NameInMap("ForwardGroupConfig")]
                [Validation(Required=false)]
                public ListForwardingRulesResponseBodyForwardingRulesRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class ListForwardingRulesResponseBodyForwardingRulesRuleActionsForwardGroupConfig : TeaModel {
                    /// <summary>
                    /// The information about the endpoint group.
                    /// </summary>
                    [NameInMap("ServerGroupTuples")]
                    [Validation(Required=false)]
                    public List<ListForwardingRulesResponseBodyForwardingRulesRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class ListForwardingRulesResponseBodyForwardingRulesRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
                        /// <summary>
                        /// The ID of the endpoint group.
                        /// </summary>
                        [NameInMap("EndpointGroupId")]
                        [Validation(Required=false)]
                        public string EndpointGroupId { get; set; }

                    }

                }

                /// <summary>
                /// The forwarding priority. 
                /// 
                /// >  This parameter does not take effect.
                /// </summary>
                [NameInMap("Order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                /// <summary>
                /// The type of the forwarding action. Valid values: 
                /// 
                /// - **ForwardGroup**: forwards a request.
                /// - **Redirect**: redirects a request.
                /// - **FixResponse**: returns a fixed response.
                /// - **Rewrite**: rewrites a request.
                /// - **AddHeader**: adds a header to a request.
                /// - **RemoveHeaderConfig**: deletes the header of a request.
                /// </summary>
                [NameInMap("RuleActionType")]
                [Validation(Required=false)]
                public string RuleActionType { get; set; }

                /// <summary>
                /// The value of the forwarding action type. 
                /// 
                /// Different JSON strings are returned based on the **RuleActionType** parameter.  
                /// 
                /// - If **RuleActionType** is set to **ForwardGroup**, the information about a virtual endpoint group is returned. The following list describes the parameters:   - `type`: the type of the resource that is returned. The value is `endpointgroup`.
                ///   - `value`: the ID of the virtual endpoint group that is returned.
                /// - If **RuleActionType** is set to **Redirect**, the redirecting configuration is returned. The following list describes the parameters:   - `protocol`: the protocol of requests after the requests are redirected.
                ///   - `domain`: the domain name to which requests are redirected.
                ///   - `port`: the port to which requests are redirected.
                ///   - `path`: the path to which requests are redirected.
                ///   - `query`: the query string of the requests that are redirected.
                ///   - `code`: the redirecting code.
                /// - If **RuleActionType** is set to **FixResponse**, the information about the fixed response that you configured is returned. The following list describes the parameters:   - `code`: the HTTP status code that is returned.
                ///   - `type`: the type of the response content that is returned.
                ///   - `content`: the response content that is returned.
                /// - If **RuleActionType** is set to **AddHeader**, the information about the HTTP header that is added is returned. The following list describes the parameters:   - `name`: the name of the HTTP header that is returned.
                ///   - `type`: the content type of the HTTP header that is returned.
                ///   - `value`: the content of the HTTP header that is returned.
                /// - If **RuleActionType** is set to **RemoveHeader**, the information about the HTTP header that is deleted is returned.
                /// - If **RuleActionType** is set to **Rewrite**, the rewriting configuration is returned. The following list describes the parameters:   - `domain`: the domain name to which requests are redirected.
                ///   - `path`: the path to which requests are redirected.
                ///   - `query`: the query string of the requests that are redirected.
                /// </summary>
                [NameInMap("RuleActionValue")]
                [Validation(Required=false)]
                public string RuleActionValue { get; set; }

            }

            /// <summary>
            /// The forwarding conditions.
            /// </summary>
            [NameInMap("RuleConditions")]
            [Validation(Required=false)]
            public List<ListForwardingRulesResponseBodyForwardingRulesRuleConditions> RuleConditions { get; set; }
            public class ListForwardingRulesResponseBodyForwardingRulesRuleConditions : TeaModel {
                /// <summary>
                /// The configuration of the domain name.
                /// </summary>
                [NameInMap("HostConfig")]
                [Validation(Required=false)]
                public ListForwardingRulesResponseBodyForwardingRulesRuleConditionsHostConfig HostConfig { get; set; }
                public class ListForwardingRulesResponseBodyForwardingRulesRuleConditionsHostConfig : TeaModel {
                    /// <summary>
                    /// The domain name.
                    /// 
                    /// The domain name must be 3 to 128 characters in length, and can contain letters, digits, hyphens (-), and periods (.). Supported wildcard characters are asterisks (\*) and question marks (?).
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The configuration of the path.
                /// </summary>
                [NameInMap("PathConfig")]
                [Validation(Required=false)]
                public ListForwardingRulesResponseBodyForwardingRulesRuleConditionsPathConfig PathConfig { get; set; }
                public class ListForwardingRulesResponseBodyForwardingRulesRuleConditionsPathConfig : TeaModel {
                    /// <summary>
                    /// The path.
                    /// 
                    /// The path must be 1 to 128 characters in length and must start with a forward slash (/). The path can contain only letters, digits, and the following special characters: $ - \_ . + / & ~ @ : \". Supported wildcard characters are asterisks (\*) and question marks (?).
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The type of the forwarding condition.
                /// 
                /// *   **Host**: domain name
                /// *   **Path**: path
                /// *   **RequestHeader**: HTTP header
                /// *   **Query**: query string
                /// *   **Method**: HTTP method
                /// *   **Cookie**: cookie
                /// *   **SourceIP**: source IP address
                /// </summary>
                [NameInMap("RuleConditionType")]
                [Validation(Required=false)]
                public string RuleConditionType { get; set; }

                /// <summary>
                /// The value of the forwarding condition type.
                /// 
                /// Different JSON strings are returned based on the **RuleConditionType** parameter.
                /// 
                /// *   If **RuleConditionType** is set to **Host**, a domain name condition is returned. If multiple domain names are returned in a forwarding condition, the relationship between the domain names is OR.
                /// *   If **RuleConditionType** is set to **Path**, a path condition is returned. If multiple forwarding conditions whose types are path are returned in a forwarding rule, the relationship between the forwarding conditions is OR. If multiple paths are returned in a forwarding condition, the relationship between the paths is OR.
                /// *   If **RuleConditionType** is set to **RequestHeader**, an HTTP header condition that consists of key-value pairs is returned.
                /// *   If **RuleConditionType** is set to **Query**, a query string condition that consists of key-value pairs is returned.
                /// *   If **RuleConditionType** is set to **Method**, an HTTP method condition is returned.
                /// *   If **RuleConditionType** is set to **Cookie**, a cookie condition that consists of key-value pairs is returned.
                /// *   If **RuleConditionType** is set to **SourceIP**, a source IP address condition is returned. If multiple source IP addresses are returned in a forwarding condition, the relationship between the source IP addresses is OR.
                /// </summary>
                [NameInMap("RuleConditionValue")]
                [Validation(Required=false)]
                public string RuleConditionValue { get; set; }

            }

        }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that determines the start point of the next query. Valid values:
        /// 
        /// *   If **NextToken** was not returned, it indicates that no additional results exist.
        /// *   If **NextToken** is returned, the value indicates the token that is used for the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
