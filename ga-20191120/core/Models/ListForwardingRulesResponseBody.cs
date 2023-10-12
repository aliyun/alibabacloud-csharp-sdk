// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListForwardingRulesResponseBody : TeaModel {
        /// <summary>
        /// The forwarding rules.
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
            /// The forwarding rule ID.
            /// </summary>
            [NameInMap("ForwardingRuleId")]
            [Validation(Required=false)]
            public string ForwardingRuleId { get; set; }

            /// <summary>
            /// The forwarding rule name.
            /// </summary>
            [NameInMap("ForwardingRuleName")]
            [Validation(Required=false)]
            public string ForwardingRuleName { get; set; }

            /// <summary>
            /// The state of the forwarding rule. Valid values:
            /// 
            /// *   **active:** The forwarding rule is normal.
            /// *   **configuring:** The forwarding rule is being modified.
            /// *   **deleting:** The forwarding rule is being deleted.
            /// </summary>
            [NameInMap("ForwardingRuleStatus")]
            [Validation(Required=false)]
            public string ForwardingRuleStatus { get; set; }

            /// <summary>
            /// The listener ID.
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// The priority of the forwarding rule.
            /// 
            /// A value between **1** and **10000** is returned. A smaller value indicates a higher priority.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// The forwarding actions.
            /// </summary>
            [NameInMap("RuleActions")]
            [Validation(Required=false)]
            public List<ListForwardingRulesResponseBodyForwardingRulesRuleActions> RuleActions { get; set; }
            public class ListForwardingRulesResponseBodyForwardingRulesRuleActions : TeaModel {
                /// <summary>
                /// The forwarding action configuration.
                /// 
                /// >  GA instances created after July 12, 2022 support all forwarding condition types and action types. We recommend that you query forwarding conditions and actions by calling the **RuleActionType** and **RuleActionValue** operations.
                /// </summary>
                [NameInMap("ForwardGroupConfig")]
                [Validation(Required=false)]
                public ListForwardingRulesResponseBodyForwardingRulesRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class ListForwardingRulesResponseBodyForwardingRulesRuleActionsForwardGroupConfig : TeaModel {
                    /// <summary>
                    /// The information about the endpoint groups.
                    /// 
                    /// >  GA instances created after July 12, 2022 support all forwarding condition types and action types. We recommend that you query forwarding conditions and actions by calling the **RuleActionType** and **RuleActionValue** operations.
                    /// </summary>
                    [NameInMap("ServerGroupTuples")]
                    [Validation(Required=false)]
                    public List<ListForwardingRulesResponseBodyForwardingRulesRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class ListForwardingRulesResponseBodyForwardingRulesRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
                        /// <summary>
                        /// The endpoint group ID.
                        /// 
                        /// >  GA instances created after July 12, 2022 support all forwarding condition types and action types. We recommend that you query forwarding conditions and actions by calling the **RuleActionType** and **RuleActionValue** operations.
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
                /// Different JSON strings are returned based on the value of the **RuleActionType** parameter.
                /// 
                /// *   If you set **RuleActionType** to **ForwardGroup**, the information about a virtual endpoint group is returned. Parameter configuration:
                /// 
                ///     *   `type:` the type of the resource that is returned. The value is `endpointgroup`.
                ///     *   `value:` the ID of the virtual endpoint group that is returned.
                /// 
                /// *   If you set **RuleActionType** to **Redirect**, the redirecting configuration is returned. Parameter configuration:
                /// 
                ///     *   `protocol:` the protocol of requests after the requests are redirected.
                ///     *   `domain:` the domain name to which requests are redirected.
                ///     *   `port:` the port to which requests are redirected.
                ///     *   `path:` the path to which requests are redirected.
                ///     *   `query:` the query string of the requests that are redirected.
                ///     *   `code:` the redirecting code.
                /// 
                /// *   If you set **RuleActionType** to **FixResponse**, the information about the fixed response that you configured is returned. Parameter configuration:
                /// 
                ///     *   `code:` the HTTP status code that is returned.
                ///     *   `type:` the type of the response content that is returned.
                ///     *   `content:` the response content that is returned.
                /// 
                /// *   If **RuleActionType** is set to **AddHeader**, the information about the HTTP header that is added is returned. Parameter configuration:
                /// 
                ///     *   `name:` the name of the HTTP header that is returned.
                ///     *   `type:` the content type of the HTTP header that is returned.
                ///     *   `value:` the content of the HTTP header that is returned.
                /// 
                /// *   If you set **RuleActionType** to **RemoveHeader**, the information about the HTTP header that is deleted is returned.
                /// 
                /// *   If you set **RuleActionType** to **Rewrite**, the rewriting configuration is returned. Parameter configuration:
                /// 
                ///     *   `domain:` the domain name to which requests are redirected.
                ///     *   `path:` the path to which requests are redirected.
                ///     *   `query:` the query string of the requests that are redirected.
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
            public List<ListForwardingRulesResponseBodyForwardingRulesRuleConditions> RuleConditions { get; set; }
            public class ListForwardingRulesResponseBodyForwardingRulesRuleConditions : TeaModel {
                /// <summary>
                /// The domain name configuration.
                /// 
                /// >  GA instances created after July 12, 2022 support all forwarding condition types and action types. We recommend that you query forwarding conditions and actions by calling the **RuleActionType** and **RuleActionValue** operations.
                /// </summary>
                [NameInMap("HostConfig")]
                [Validation(Required=false)]
                public ListForwardingRulesResponseBodyForwardingRulesRuleConditionsHostConfig HostConfig { get; set; }
                public class ListForwardingRulesResponseBodyForwardingRulesRuleConditionsHostConfig : TeaModel {
                    /// <summary>
                    /// The domain name configuration.
                    /// 
                    /// >  GA instances created after July 12, 2022 support all forwarding condition types and action types. We recommend that you query forwarding conditions and actions by calling the **RuleActionType** and **RuleActionValue** operations.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The path configuration.
                /// 
                /// >  GA instances created after July 12, 2022 support all forwarding condition types and action types. We recommend that you query forwarding conditions and actions by calling the **RuleActionType** and **RuleActionValue** operations.
                /// </summary>
                [NameInMap("PathConfig")]
                [Validation(Required=false)]
                public ListForwardingRulesResponseBodyForwardingRulesRuleConditionsPathConfig PathConfig { get; set; }
                public class ListForwardingRulesResponseBodyForwardingRulesRuleConditionsPathConfig : TeaModel {
                    /// <summary>
                    /// The path configuration.
                    /// 
                    /// >  GA instances created after July 12, 2022 support all forwarding condition types and action types. We recommend that you query forwarding conditions and actions by calling the **RuleActionType** and **RuleActionValue** operations.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// The type of the forwarding condition. Valid values:
                /// 
                /// *   **Host:** domain name.
                /// *   **Path:** path.
                /// *   **RequestHeader:** HTTP header.
                /// *   **Query:** query string.
                /// *   **Method:** HTTP method.
                /// *   **Cookie:** cookie.
                /// *   **SourceIP:** source IP address.
                /// </summary>
                [NameInMap("RuleConditionType")]
                [Validation(Required=false)]
                public string RuleConditionType { get; set; }

                /// <summary>
                /// The value of the forwarding condition type.
                /// 
                /// Different JSON strings are returned based on the value of the **RuleConditionType** parameter.
                /// 
                /// *   If you set **RuleConditionType** to **Host**, a domain name condition is returned. If multiple domain names are returned in a forwarding condition, the relationship between the domain names is OR.
                /// *   If you set **RuleConditionType** to **Path**, a path condition is returned. If multiple forwarding conditions of the path type are returned in a forwarding rule, the relationship between the forwarding conditions is OR. If multiple paths are returned in a forwarding condition, the relationship between the paths is OR.
                /// *   If you set **RuleConditionType** to **RequestHeader**, an HTTP header condition that consists of key-value pairs is returned.
                /// *   If you set **RuleConditionType** to **Query**, a query string condition that consists of key-value pairs is returned.
                /// *   If you set **RuleConditionType** to **Method**, an HTTP method condition is returned.
                /// *   If you set **RuleConditionType** to **Cookie**, a cookie condition that consists of key-value pairs is returned.
                /// *   If you set **RuleConditionType** to **SourceIP**, a source IP address condition is returned. If multiple source IP addresses are returned in a forwarding condition, the relationship between the source IP addresses is OR.
                /// </summary>
                [NameInMap("RuleConditionValue")]
                [Validation(Required=false)]
                public string RuleConditionValue { get; set; }

            }

            /// <summary>
            /// The service ID to which the managed instance belongs.
            /// 
            /// >  Valid only when the ServiceManaged parameter is True.
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// Is it a managed instance. Valid values:
            /// 
            /// - true
            /// - false
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public bool? ServiceManaged { get; set; }

            /// <summary>
            /// A list of action policies that users can execute on this managed instance.
            /// </summary>
            [NameInMap("ServiceManagedInfos")]
            [Validation(Required=false)]
            public List<ListForwardingRulesResponseBodyForwardingRulesServiceManagedInfos> ServiceManagedInfos { get; set; }
            public class ListForwardingRulesResponseBodyForwardingRulesServiceManagedInfos : TeaModel {
                /// <summary>
                /// Managed policy action name, Valid values:
                /// - Create
                /// - Update
                /// - Delete
                /// - Associate
                /// - UserUnmanaged
                /// - CreateChild
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// Sub resource type, Valid values:
                /// 
                /// - Listener
                /// - IpSet
                /// - EndpointGroup
                /// - ForwardingRule
                /// - Endpoint
                /// - EndpointGroupDestination
                /// - EndpointPolicy
                /// 
                /// >Only valid when the Action parameter is CreateChild.
                /// </summary>
                [NameInMap("ChildType")]
                [Validation(Required=false)]
                public string ChildType { get; set; }

                /// <summary>
                /// Is the managed policy action managed, Valid values:
                /// 
                /// - true: The managed policy action is managed, and users do not have permission to perform the operation specified in the Action on the managed instance.
                /// 
                /// - false: The managed policy action is not managed, and users have permission to perform the operation specified in the Action on the managed instance.
                /// </summary>
                [NameInMap("IsManaged")]
                [Validation(Required=false)]
                public bool? IsManaged { get; set; }

            }

        }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used for the next query. Valid values:
        /// 
        /// *   If **NextToken** is not returned, it indicates that no additional results exist.
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
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
