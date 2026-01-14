// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListForwardingRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The forwarding rules.</para>
        /// </summary>
        [NameInMap("ForwardingRules")]
        [Validation(Required=false)]
        public List<ListForwardingRulesResponseBodyForwardingRules> ForwardingRules { get; set; }
        public class ListForwardingRulesResponseBodyForwardingRules : TeaModel {
            /// <summary>
            /// <para>The direction in which the forwarding rule takes effect.</para>
            /// <para>By default, <b>request</b> is returned, which indicates that the forwarding rule takes effect on requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>request</para>
            /// </summary>
            [NameInMap("ForwardingRuleDirection")]
            [Validation(Required=false)]
            public string ForwardingRuleDirection { get; set; }

            /// <summary>
            /// <para>The forwarding rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>frule-bp19a3t3yzr21q3****</para>
            /// </summary>
            [NameInMap("ForwardingRuleId")]
            [Validation(Required=false)]
            public string ForwardingRuleId { get; set; }

            /// <summary>
            /// <para>The forwarding rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>auto_named_rule</para>
            /// </summary>
            [NameInMap("ForwardingRuleName")]
            [Validation(Required=false)]
            public string ForwardingRuleName { get; set; }

            /// <summary>
            /// <para>The state of the forwarding rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>active:</b> The forwarding rule is normal.</description></item>
            /// <item><description><b>configuring:</b> The forwarding rule is being modified.</description></item>
            /// <item><description><b>deleting:</b> The forwarding rule is being deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("ForwardingRuleStatus")]
            [Validation(Required=false)]
            public string ForwardingRuleStatus { get; set; }

            /// <summary>
            /// <para>The listener ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lsr-bp1s0vzbi5bxlx5****</para>
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// <para>The priority of the forwarding rule.</para>
            /// <para>A value between <b>1</b> and <b>10000</b> is returned. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The forwarding actions.</para>
            /// </summary>
            [NameInMap("RuleActions")]
            [Validation(Required=false)]
            public List<ListForwardingRulesResponseBodyForwardingRulesRuleActions> RuleActions { get; set; }
            public class ListForwardingRulesResponseBodyForwardingRulesRuleActions : TeaModel {
                /// <summary>
                /// <para>The forwarding action configuration.</para>
                /// <remarks>
                /// <para> GA instances created after July 12, 2022 support all forwarding condition types and action types. We recommend that you query forwarding conditions and actions by calling the <b>RuleActionType</b> and <b>RuleActionValue</b> operations.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("ForwardGroupConfig")]
                [Validation(Required=false)]
                public ListForwardingRulesResponseBodyForwardingRulesRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class ListForwardingRulesResponseBodyForwardingRulesRuleActionsForwardGroupConfig : TeaModel {
                    /// <summary>
                    /// <para>The information about the endpoint groups.</para>
                    /// <remarks>
                    /// <para> GA instances created after July 12, 2022 support all forwarding condition types and action types. We recommend that you query forwarding conditions and actions by calling the <b>RuleActionType</b> and <b>RuleActionValue</b> operations.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("ServerGroupTuples")]
                    [Validation(Required=false)]
                    public List<ListForwardingRulesResponseBodyForwardingRulesRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class ListForwardingRulesResponseBodyForwardingRulesRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
                        /// <summary>
                        /// <para>The endpoint group ID.</para>
                        /// <remarks>
                        /// <para> GA instances created after July 12, 2022 support all forwarding condition types and action types. We recommend that you query forwarding conditions and actions by calling the <b>RuleActionType</b> and <b>RuleActionValue</b> operations.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>epg-bp1enpdcrqhl78g6r****</para>
                        /// </summary>
                        [NameInMap("EndpointGroupId")]
                        [Validation(Required=false)]
                        public string EndpointGroupId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The forwarding priority.</para>
                /// <remarks>
                /// <para> This parameter does not take effect.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                /// <summary>
                /// <para>The type of the forwarding action. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ForwardGroup</b>: forwards a request.</description></item>
                /// <item><description><b>Redirect</b>: redirects a request.</description></item>
                /// <item><description><b>FixResponse</b>: returns a fixed response.</description></item>
                /// <item><description><b>Rewrite</b>: rewrites a request.</description></item>
                /// <item><description><b>AddHeader</b>: adds a header to a request.</description></item>
                /// <item><description><b>RemoveHeaderConfig</b>: deletes the header from a request.</description></item>
                /// <item><description><b>Drop</b>: drops a request.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ForwardGroup</para>
                /// </summary>
                [NameInMap("RuleActionType")]
                [Validation(Required=false)]
                public string RuleActionType { get; set; }

                /// <summary>
                /// <para>The value of the forwarding action.</para>
                /// <para>Different JSON strings are returned based on the value of <b>RuleActionType</b>.</para>
                /// <list type="bullet">
                /// <item><description><para>If you set <b>RuleActionType</b> to <b>ForwardGroup</b>, the information about a virtual endpoint group is returned. The following section describes the parameters:</para>
                /// <list type="bullet">
                /// <item><description><c>type</c>: <c>endpointgroup</c> is returned.</description></item>
                /// <item><description><c>value</c>: the ID of the virtual endpoint group.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If you set <b>RuleActionType</b> to <b>Redirect</b>, the redirecting configuration is returned. The following section describes the parameters:</para>
                /// <list type="bullet">
                /// <item><description><c>protocol</c>: the protocol of requests after the requests are redirected.</description></item>
                /// <item><description><c>domain</c>: the domain name to which requests are redirected.</description></item>
                /// <item><description><c>port</c>: the port to which requests are redirected.</description></item>
                /// <item><description><c>path</c>: the path to which requests are redirected.</description></item>
                /// <item><description><c>query</c>: the query string of the requests that are redirected.</description></item>
                /// <item><description><c>code</c>: the redirecting code.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If you set <b>RuleActionType</b> to <b>FixResponse</b>, the information about the fixed response that you configured is returned. The following section describes the parameters:</para>
                /// <list type="bullet">
                /// <item><description><c>code</c>: the HTTP status code.</description></item>
                /// <item><description><c>type</c>: the content type of the response.</description></item>
                /// <item><description><c>content</c>: the content of the response.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>RuleActionType</b> is set to <b>AddHeader</b>, the information about the HTTP header that is added is returned. The following section describes the parameters:</para>
                /// <list type="bullet">
                /// <item><description><c>name</c>: the name of the HTTP header.</description></item>
                /// <item><description><c>type</c>: the content type of the HTTP header.</description></item>
                /// <item><description><c>value</c>: the content of the HTTP header.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If you set <b>RuleActionType</b> to <b>RemoveHeader</b>, the information about the HTTP header that is deleted is returned.</para>
                /// </description></item>
                /// <item><description><para>If you set <b>RuleActionType</b> to <b>Rewrite</b>, the rewriting configuration is returned. The following section describes the parameters:</para>
                /// <list type="bullet">
                /// <item><description><c>domain</c>: the domain name to which requests are redirected.</description></item>
                /// <item><description><c>path</c>: the path to which requests are redirected.</description></item>
                /// <item><description><c>query</c>: the query string of the requests that are redirected.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If you set <b>RuleActionType</b> to <b>Drop</b>, an empty string is returned.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;type&quot;:&quot;endpointgroup&quot;, &quot;value&quot;:&quot;epg-bp1enpdcrqhl78g6r****&quot;}]</para>
                /// </summary>
                [NameInMap("RuleActionValue")]
                [Validation(Required=false)]
                public string RuleActionValue { get; set; }

            }

            /// <summary>
            /// <para>The conditions that trigger the forwarding rule.</para>
            /// </summary>
            [NameInMap("RuleConditions")]
            [Validation(Required=false)]
            public List<ListForwardingRulesResponseBodyForwardingRulesRuleConditions> RuleConditions { get; set; }
            public class ListForwardingRulesResponseBodyForwardingRulesRuleConditions : TeaModel {
                /// <summary>
                /// <para>The domain name configuration.</para>
                /// <remarks>
                /// <para> GA instances created after July 12, 2022 support all forwarding condition types and action types. We recommend that you query forwarding conditions and actions by calling the <b>RuleActionType</b> and <b>RuleActionValue</b> operations.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("HostConfig")]
                [Validation(Required=false)]
                public ListForwardingRulesResponseBodyForwardingRulesRuleConditionsHostConfig HostConfig { get; set; }
                public class ListForwardingRulesResponseBodyForwardingRulesRuleConditionsHostConfig : TeaModel {
                    /// <summary>
                    /// <para>The domain name configuration.</para>
                    /// <remarks>
                    /// <para> GA instances created after July 12, 2022 support all forwarding condition types and action types. We recommend that you query forwarding conditions and actions by calling the <b>RuleActionType</b> and <b>RuleActionValue</b> operations.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The path configuration.</para>
                /// <remarks>
                /// <para> GA instances created after July 12, 2022 support all forwarding condition types and action types. We recommend that you query forwarding conditions and actions by calling the <b>RuleActionType</b> and <b>RuleActionValue</b> operations.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("PathConfig")]
                [Validation(Required=false)]
                public ListForwardingRulesResponseBodyForwardingRulesRuleConditionsPathConfig PathConfig { get; set; }
                public class ListForwardingRulesResponseBodyForwardingRulesRuleConditionsPathConfig : TeaModel {
                    /// <summary>
                    /// <para>The path configuration.</para>
                    /// <remarks>
                    /// <para> GA instances created after July 12, 2022 support all forwarding condition types and action types. We recommend that you query forwarding conditions and actions by calling the <b>RuleActionType</b> and <b>RuleActionValue</b> operations.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The type of the forwarding condition. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Host:</b> domain name.</description></item>
                /// <item><description><b>Path:</b> path.</description></item>
                /// <item><description><b>RequestHeader:</b> HTTP header.</description></item>
                /// <item><description><b>Query:</b> query string.</description></item>
                /// <item><description><b>Method:</b> HTTP method.</description></item>
                /// <item><description><b>Cookie:</b> cookie.</description></item>
                /// <item><description><b>SourceIP:</b> source IP address.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Host</para>
                /// </summary>
                [NameInMap("RuleConditionType")]
                [Validation(Required=false)]
                public string RuleConditionType { get; set; }

                /// <summary>
                /// <para>The value of the forwarding condition type.</para>
                /// <para>Different JSON strings are returned based on the value of the <b>RuleConditionType</b> parameter.</para>
                /// <list type="bullet">
                /// <item><description>If you set <b>RuleConditionType</b> to <b>Host</b>, a domain name condition is returned. If multiple domain names are returned in a forwarding condition, the relationship between the domain names is OR.</description></item>
                /// <item><description>If you set <b>RuleConditionType</b> to <b>Path</b>, a path condition is returned. If multiple forwarding conditions of the path type are returned in a forwarding rule, the relationship between the forwarding conditions is OR. If multiple paths are returned in a forwarding condition, the relationship between the paths is OR.</description></item>
                /// <item><description>If you set <b>RuleConditionType</b> to <b>RequestHeader</b>, an HTTP header condition that consists of key-value pairs is returned.</description></item>
                /// <item><description>If you set <b>RuleConditionType</b> to <b>Query</b>, a query string condition that consists of key-value pairs is returned.</description></item>
                /// <item><description>If you set <b>RuleConditionType</b> to <b>Method</b>, an HTTP method condition is returned.</description></item>
                /// <item><description>If you set <b>RuleConditionType</b> to <b>Cookie</b>, a cookie condition that consists of key-value pairs is returned.</description></item>
                /// <item><description>If you set <b>RuleConditionType</b> to <b>SourceIP</b>, a source IP address condition is returned. If multiple source IP addresses are returned in a forwarding condition, the relationship between the source IP addresses is OR.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;<a href="http://www.example.com">www.example.com</a>&quot;, &quot;<a href="http://www.aliyun.com%22%5D">www.aliyun.com&quot;]</a></para>
                /// </summary>
                [NameInMap("RuleConditionValue")]
                [Validation(Required=false)]
                public string RuleConditionValue { get; set; }

            }

            /// <summary>
            /// <para>The ID of the service that manages the instance.</para>
            /// <remarks>
            /// <para> This parameter is returned only if the value of <b>ServiceManaged</b> is <b>true</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ALB</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>Indicates whether the GA instance is managed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The GA instance is managed.</description></item>
            /// <item><description><b>false</b>: The GA instance is not managed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public bool? ServiceManaged { get; set; }

            /// <summary>
            /// <para>The actions that you can perform on the managed instance.</para>
            /// <remarks>
            /// <para> This parameter takes effect only if <b>ServiceManaged</b> is set to <b>True</b>.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>You can perform only specific actions on the managed instance.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ServiceManagedInfos")]
            [Validation(Required=false)]
            public List<ListForwardingRulesResponseBodyForwardingRulesServiceManagedInfos> ServiceManagedInfos { get; set; }
            public class ListForwardingRulesResponseBodyForwardingRulesServiceManagedInfos : TeaModel {
                /// <summary>
                /// <para>The name of the action that you can perform on the managed instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Create</b>: Create an instance.</description></item>
                /// <item><description><b>Update</b>: Update the current instance.</description></item>
                /// <item><description><b>Delete</b>: Delete the current instance.</description></item>
                /// <item><description><b>Associate</b>: Reference the current instance.</description></item>
                /// <item><description><b>UserUnmanaged</b>: Unmanage the instance.</description></item>
                /// <item><description><b>CreateChild</b>: Create a child resource on the current instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Update</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The type of the child resource. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Listener</b>: listener.</description></item>
                /// <item><description><b>IpSet</b>: acceleration region.</description></item>
                /// <item><description><b>EndpointGroup</b>: endpoint group.</description></item>
                /// <item><description><b>ForwardingRule</b>: forwarding rule.</description></item>
                /// <item><description><b>Endpoint</b>: endpoint.</description></item>
                /// <item><description><b>EndpointGroupDestination</b>: the protocol mapping of an endpoint group associated with a custom routing listener.</description></item>
                /// <item><description><b>EndpointPolicy</b>: the traffic policy of an endpoint associated with a custom routing listener.</description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is returned only if the value of <b>Action</b> is <b>CreateChild</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Listener</para>
                /// </summary>
                [NameInMap("ChildType")]
                [Validation(Required=false)]
                public string ChildType { get; set; }

                /// <summary>
                /// <para>Indicates whether the specified actions are managed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The specified actions are managed, and users cannot perform the specified actions on the managed instance.</description></item>
                /// <item><description><b>false</b>: The specified actions are not managed, and users can perform the specified actions on the managed instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsManaged")]
                [Validation(Required=false)]
                public bool? IsManaged { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is not returned, it indicates that no additional results exist.</description></item>
        /// <item><description>If <b>NextToken</b> is returned, the value indicates the token that is used for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CFC67ED9-4AB1-431F-B6E3-A752B7B8CCD4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
