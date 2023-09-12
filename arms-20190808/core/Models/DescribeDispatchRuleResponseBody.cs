// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeDispatchRuleResponseBody : TeaModel {
        /// <summary>
        /// The struct returned.
        /// </summary>
        [NameInMap("DispatchRule")]
        [Validation(Required=false)]
        public DescribeDispatchRuleResponseBodyDispatchRule DispatchRule { get; set; }
        public class DescribeDispatchRuleResponseBodyDispatchRule : TeaModel {
            /// <summary>
            /// Alarm handling method.
            /// 
            /// CREATE_ALERT: Generate an alert.
            /// 
            /// DISCARD_ALERT: Discard the alarm event, that is, no alarm.
            /// </summary>
            [NameInMap("DispatchType")]
            [Validation(Required=false)]
            public string DispatchType { get; set; }

            /// <summary>
            /// The information about groups.
            /// </summary>
            [NameInMap("GroupRules")]
            [Validation(Required=false)]
            public List<DescribeDispatchRuleResponseBodyDispatchRuleGroupRules> GroupRules { get; set; }
            public class DescribeDispatchRuleResponseBodyDispatchRuleGroupRules : TeaModel {
                /// <summary>
                /// The ID of the group.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                /// <summary>
                /// The grouping interval.
                /// </summary>
                [NameInMap("GroupInterval")]
                [Validation(Required=false)]
                public long? GroupInterval { get; set; }

                /// <summary>
                /// The waiting time for grouping.
                /// </summary>
                [NameInMap("GroupWaitTime")]
                [Validation(Required=false)]
                public long? GroupWaitTime { get; set; }

                /// <summary>
                /// The grouping fields.
                /// </summary>
                [NameInMap("GroupingFields")]
                [Validation(Required=false)]
                public List<string> GroupingFields { get; set; }

                /// <summary>
                /// The time interval at which a notification is resent for a long-lasting unresolved alert. Unit: seconds.
                /// </summary>
                [NameInMap("RepeatInterval")]
                [Validation(Required=false)]
                public long? RepeatInterval { get; set; }

            }

            /// <summary>
            /// Whether to send recovered alerts.
            /// true: send.
            /// false: do not send.
            /// </summary>
            [NameInMap("IsRecover")]
            [Validation(Required=false)]
            public bool? IsRecover { get; set; }

            /// <summary>
            /// The information about the dispatch rule.
            /// </summary>
            [NameInMap("LabelMatchExpressionGrid")]
            [Validation(Required=false)]
            public DescribeDispatchRuleResponseBodyDispatchRuleLabelMatchExpressionGrid LabelMatchExpressionGrid { get; set; }
            public class DescribeDispatchRuleResponseBodyDispatchRuleLabelMatchExpressionGrid : TeaModel {
                /// <summary>
                /// The collection of dispatch rules.
                /// </summary>
                [NameInMap("LabelMatchExpressionGroups")]
                [Validation(Required=false)]
                public List<DescribeDispatchRuleResponseBodyDispatchRuleLabelMatchExpressionGridLabelMatchExpressionGroups> LabelMatchExpressionGroups { get; set; }
                public class DescribeDispatchRuleResponseBodyDispatchRuleLabelMatchExpressionGridLabelMatchExpressionGroups : TeaModel {
                    /// <summary>
                    /// The collection of conditions of the dispatch rule.
                    /// </summary>
                    [NameInMap("LabelMatchExpressions")]
                    [Validation(Required=false)]
                    public List<DescribeDispatchRuleResponseBodyDispatchRuleLabelMatchExpressionGridLabelMatchExpressionGroupsLabelMatchExpressions> LabelMatchExpressions { get; set; }
                    public class DescribeDispatchRuleResponseBodyDispatchRuleLabelMatchExpressionGridLabelMatchExpressionGroupsLabelMatchExpressions : TeaModel {
                        /// <summary>
                        /// The key of the tag of the dispatch rule. Valid values:
                        /// 
                        /// *   `_aliyun_arms_userid`: user ID
                        /// *   `_aliyun_arms_involvedObject_kind`: type of the associated object
                        /// *   `_aliyun_arms_involvedObject_id`: ID of the associated object
                        /// *   `_aliyun_arms_involvedObject_name`: name of the associated object
                        /// *   `_aliyun_arms_alert_name`: alert name
                        /// *   `_aliyun_arms_alert_rule_id`: alert rule ID
                        /// *   `_aliyun_arms_alert_type`: alert type
                        /// *   `_aliyun_arms_alert_level`: alert severity
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The operator used in the dispatch rule. Valid values:
                        /// 
                        /// *   `eq`: equals to.
                        /// *   `re`: matches a regular expression.
                        /// </summary>
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        /// <summary>
                        /// The value of the tag.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

            /// <summary>
            /// The name of the dispatch policy.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The collection of notification methods.
            /// </summary>
            [NameInMap("NotifyRules")]
            [Validation(Required=false)]
            public List<DescribeDispatchRuleResponseBodyDispatchRuleNotifyRules> NotifyRules { get; set; }
            public class DescribeDispatchRuleResponseBodyDispatchRuleNotifyRules : TeaModel {
                /// <summary>
                /// The notification method Array.
                /// </summary>
                [NameInMap("NotifyChannels")]
                [Validation(Required=false)]
                public List<string> NotifyChannels { get; set; }

                /// <summary>
                /// The collection of alert contacts.
                /// </summary>
                [NameInMap("NotifyObjects")]
                [Validation(Required=false)]
                public List<DescribeDispatchRuleResponseBodyDispatchRuleNotifyRulesNotifyObjects> NotifyObjects { get; set; }
                public class DescribeDispatchRuleResponseBodyDispatchRuleNotifyRulesNotifyObjects : TeaModel {
                    /// <summary>
                    /// The name of the contact or contact group.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The ID of the contact or contact group.
                    /// </summary>
                    [NameInMap("NotifyObjectId")]
                    [Validation(Required=false)]
                    public string NotifyObjectId { get; set; }

                    /// <summary>
                    /// The type of the alert contact. Valid values:
                    /// 
                    /// - `CONTACT`: contact
                    /// - `CONTACT_GROUP`: contact group
                    /// </summary>
                    [NameInMap("NotifyType")]
                    [Validation(Required=false)]
                    public string NotifyType { get; set; }

                }

            }

            /// <summary>
            /// The ID of the dispatch rule.
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// Indicates whether the dispatch policy is enabled. Valid values: 
            /// 
            /// - `true`: enabled
            /// - `false`: disabled
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
