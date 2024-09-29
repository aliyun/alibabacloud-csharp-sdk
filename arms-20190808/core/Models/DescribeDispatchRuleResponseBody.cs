// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeDispatchRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The struct returned.</para>
        /// </summary>
        [NameInMap("DispatchRule")]
        [Validation(Required=false)]
        public DescribeDispatchRuleResponseBodyDispatchRule DispatchRule { get; set; }
        public class DescribeDispatchRuleResponseBodyDispatchRule : TeaModel {
            /// <summary>
            /// <para>Alarm handling method.</para>
            /// <para>CREATE_ALERT: Generate an alert.</para>
            /// <para>DISCARD_ALERT: Discard the alarm event, that is, no alarm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE_ALERT</para>
            /// </summary>
            [NameInMap("DispatchType")]
            [Validation(Required=false)]
            public string DispatchType { get; set; }

            /// <summary>
            /// <para>The information about groups.</para>
            /// </summary>
            [NameInMap("GroupRules")]
            [Validation(Required=false)]
            public List<DescribeDispatchRuleResponseBodyDispatchRuleGroupRules> GroupRules { get; set; }
            public class DescribeDispatchRuleResponseBodyDispatchRuleGroupRules : TeaModel {
                /// <summary>
                /// <para>The ID of the group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                /// <summary>
                /// <para>The grouping interval.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("GroupInterval")]
                [Validation(Required=false)]
                public long? GroupInterval { get; set; }

                /// <summary>
                /// <para>The waiting time for grouping.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("GroupWaitTime")]
                [Validation(Required=false)]
                public long? GroupWaitTime { get; set; }

                /// <summary>
                /// <para>The grouping fields.</para>
                /// </summary>
                [NameInMap("GroupingFields")]
                [Validation(Required=false)]
                public List<string> GroupingFields { get; set; }

                /// <summary>
                /// <para>The time interval at which a notification is resent for a long-lasting unresolved alert. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("RepeatInterval")]
                [Validation(Required=false)]
                public long? RepeatInterval { get; set; }

            }

            /// <summary>
            /// <para>Whether to send recovered alerts.
            /// true: send.
            /// false: do not send.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsRecover")]
            [Validation(Required=false)]
            public bool? IsRecover { get; set; }

            /// <summary>
            /// <para>The information about the dispatch rule.</para>
            /// </summary>
            [NameInMap("LabelMatchExpressionGrid")]
            [Validation(Required=false)]
            public DescribeDispatchRuleResponseBodyDispatchRuleLabelMatchExpressionGrid LabelMatchExpressionGrid { get; set; }
            public class DescribeDispatchRuleResponseBodyDispatchRuleLabelMatchExpressionGrid : TeaModel {
                /// <summary>
                /// <para>The collection of dispatch rules.</para>
                /// </summary>
                [NameInMap("LabelMatchExpressionGroups")]
                [Validation(Required=false)]
                public List<DescribeDispatchRuleResponseBodyDispatchRuleLabelMatchExpressionGridLabelMatchExpressionGroups> LabelMatchExpressionGroups { get; set; }
                public class DescribeDispatchRuleResponseBodyDispatchRuleLabelMatchExpressionGridLabelMatchExpressionGroups : TeaModel {
                    /// <summary>
                    /// <para>The collection of conditions of the dispatch rule.</para>
                    /// </summary>
                    [NameInMap("LabelMatchExpressions")]
                    [Validation(Required=false)]
                    public List<DescribeDispatchRuleResponseBodyDispatchRuleLabelMatchExpressionGridLabelMatchExpressionGroupsLabelMatchExpressions> LabelMatchExpressions { get; set; }
                    public class DescribeDispatchRuleResponseBodyDispatchRuleLabelMatchExpressionGridLabelMatchExpressionGroupsLabelMatchExpressions : TeaModel {
                        /// <summary>
                        /// <para>The key of the tag of the dispatch rule. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>_aliyun_arms_userid</c>: user ID</description></item>
                        /// <item><description><c>_aliyun_arms_involvedObject_kind</c>: type of the associated object</description></item>
                        /// <item><description><c>_aliyun_arms_involvedObject_id</c>: ID of the associated object</description></item>
                        /// <item><description><c>_aliyun_arms_involvedObject_name</c>: name of the associated object</description></item>
                        /// <item><description><c>_aliyun_arms_alert_name</c>: alert name</description></item>
                        /// <item><description><c>_aliyun_arms_alert_rule_id</c>: alert rule ID</description></item>
                        /// <item><description><c>_aliyun_arms_alert_type</c>: alert type</description></item>
                        /// <item><description><c>_aliyun_arms_alert_level</c>: alert severity</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>_aliyun_arms_involvedObject_kind</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The operator used in the dispatch rule. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>eq</c>: equals to.</description></item>
                        /// <item><description><c>re</c>: matches a regular expression.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>eq</para>
                        /// </summary>
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        /// <summary>
                        /// <para>The value of the tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>app</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The name of the dispatch policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Prometheus Alert</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The collection of notification methods.</para>
            /// </summary>
            [NameInMap("NotifyRules")]
            [Validation(Required=false)]
            public List<DescribeDispatchRuleResponseBodyDispatchRuleNotifyRules> NotifyRules { get; set; }
            public class DescribeDispatchRuleResponseBodyDispatchRuleNotifyRules : TeaModel {
                /// <summary>
                /// <para>The notification method Array.</para>
                /// </summary>
                [NameInMap("NotifyChannels")]
                [Validation(Required=false)]
                public List<string> NotifyChannels { get; set; }

                /// <summary>
                /// <para>The collection of alert contacts.</para>
                /// </summary>
                [NameInMap("NotifyObjects")]
                [Validation(Required=false)]
                public List<DescribeDispatchRuleResponseBodyDispatchRuleNotifyRulesNotifyObjects> NotifyObjects { get; set; }
                public class DescribeDispatchRuleResponseBodyDispatchRuleNotifyRulesNotifyObjects : TeaModel {
                    /// <summary>
                    /// <para>The name of the contact or contact group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>JohnDoe</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The ID of the contact or contact group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("NotifyObjectId")]
                    [Validation(Required=false)]
                    public string NotifyObjectId { get; set; }

                    /// <summary>
                    /// <para>The type of the alert contact. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>CONTACT</c>: contact</description></item>
                    /// <item><description><c>CONTACT_GROUP</c>: contact group</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONTACT</para>
                    /// </summary>
                    [NameInMap("NotifyType")]
                    [Validation(Required=false)]
                    public string NotifyType { get; set; }

                }

            }

            /// <summary>
            /// <para>The ID of the dispatch rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10282</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <para>Indicates whether the dispatch policy is enabled. Valid values: </para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: enabled</description></item>
            /// <item><description><c>false</c>: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34ED024E-9E31-434A-9E4E-D9D15C3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
