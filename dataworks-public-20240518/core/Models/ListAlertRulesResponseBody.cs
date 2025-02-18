// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListAlertRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListAlertRulesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListAlertRulesResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The rules.</para>
            /// </summary>
            [NameInMap("AlertRules")]
            [Validation(Required=false)]
            public List<ListAlertRulesResponseBodyPagingInfoAlertRules> AlertRules { get; set; }
            public class ListAlertRulesResponseBodyPagingInfoAlertRules : TeaModel {
                /// <summary>
                /// <para>Indicates whether the rule is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22125</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>error_test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account used by the owner of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1933790683****</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The alert triggering condition.</para>
                /// </summary>
                [NameInMap("TriggerCondition")]
                [Validation(Required=false)]
                public ListAlertRulesResponseBodyPagingInfoAlertRulesTriggerCondition TriggerCondition { get; set; }
                public class ListAlertRulesResponseBodyPagingInfoAlertRulesTriggerCondition : TeaModel {
                    /// <summary>
                    /// <para>The extended information about the rule. This parameter is required for specific types of alerts.</para>
                    /// </summary>
                    [NameInMap("Extension")]
                    [Validation(Required=false)]
                    public ListAlertRulesResponseBodyPagingInfoAlertRulesTriggerConditionExtension Extension { get; set; }
                    public class ListAlertRulesResponseBodyPagingInfoAlertRulesTriggerConditionExtension : TeaModel {
                        /// <summary>
                        /// <para>The configuration for an alert of the CycleUnfinished type.</para>
                        /// </summary>
                        [NameInMap("CycleUnfinished")]
                        [Validation(Required=false)]
                        public ListAlertRulesResponseBodyPagingInfoAlertRulesTriggerConditionExtensionCycleUnfinished CycleUnfinished { get; set; }
                        public class ListAlertRulesResponseBodyPagingInfoAlertRulesTriggerConditionExtensionCycleUnfinished : TeaModel {
                            /// <summary>
                            /// <para>The configurations of the scheduling cycle and timeout period of the instance.</para>
                            /// </summary>
                            [NameInMap("CycleAndTime")]
                            [Validation(Required=false)]
                            public List<ListAlertRulesResponseBodyPagingInfoAlertRulesTriggerConditionExtensionCycleUnfinishedCycleAndTime> CycleAndTime { get; set; }
                            public class ListAlertRulesResponseBodyPagingInfoAlertRulesTriggerConditionExtensionCycleUnfinishedCycleAndTime : TeaModel {
                                /// <summary>
                                /// <para>The ID of the scheduling cycle of the instance. Valid values: [1,288].</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("CycleId")]
                                [Validation(Required=false)]
                                public int? CycleId { get; set; }

                                /// <summary>
                                /// <para>The latest completion time of the instance within the scheduling cycle. The time is in the hh:mm format. Valid values of hh: [0,47]. Valid values of mm: [0,59].</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>01:00</para>
                                /// </summary>
                                [NameInMap("Time")]
                                [Validation(Required=false)]
                                public string Time { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The configuration for an alert of the Error type.</para>
                        /// </summary>
                        [NameInMap("Error")]
                        [Validation(Required=false)]
                        public ListAlertRulesResponseBodyPagingInfoAlertRulesTriggerConditionExtensionError Error { get; set; }
                        public class ListAlertRulesResponseBodyPagingInfoAlertRulesTriggerConditionExtensionError : TeaModel {
                            /// <summary>
                            /// <para>Indicates whether an alert is triggered if a batch synchronization task is automatically rerun upon a failure.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("AutoRerunAlertEnabled")]
                            [Validation(Required=false)]
                            public bool? AutoRerunAlertEnabled { get; set; }

                            /// <summary>
                            /// <para>The IDs of the real-time computing tasks. This parameter is required when you monitor real-time computing tasks.</para>
                            /// </summary>
                            [NameInMap("StreamTaskIds")]
                            [Validation(Required=false)]
                            public List<long?> StreamTaskIds { get; set; }

                        }

                        /// <summary>
                        /// <para>The configuration for an alert of the InstanceErrorCount type.</para>
                        /// </summary>
                        [NameInMap("InstanceErrorCount")]
                        [Validation(Required=false)]
                        public ListAlertRulesResponseBodyPagingInfoAlertRulesTriggerConditionExtensionInstanceErrorCount InstanceErrorCount { get; set; }
                        public class ListAlertRulesResponseBodyPagingInfoAlertRulesTriggerConditionExtensionInstanceErrorCount : TeaModel {
                            /// <summary>
                            /// <para>The maximum number of instances on which an error occurs. Valid values: [1,10000].</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("Count")]
                            [Validation(Required=false)]
                            public int? Count { get; set; }

                        }

                        /// <summary>
                        /// <para>The configuration for an alert of the InstanceErrorPercentage type.</para>
                        /// </summary>
                        [NameInMap("InstanceErrorPercentage")]
                        [Validation(Required=false)]
                        public ListAlertRulesResponseBodyPagingInfoAlertRulesTriggerConditionExtensionInstanceErrorPercentage InstanceErrorPercentage { get; set; }
                        public class ListAlertRulesResponseBodyPagingInfoAlertRulesTriggerConditionExtensionInstanceErrorPercentage : TeaModel {
                            /// <summary>
                            /// <para>The maximum percentage of instances on which an error occurs in the workspace to the total number of instances. Valid values: [1-100].</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("Percentage")]
                            [Validation(Required=false)]
                            public int? Percentage { get; set; }

                        }

                        /// <summary>
                        /// <para>The configuration for an alert of the InstanceTransferFluctuate type.</para>
                        /// </summary>
                        [NameInMap("InstanceTransferFluctuate")]
                        [Validation(Required=false)]
                        public ListAlertRulesResponseBodyPagingInfoAlertRulesTriggerConditionExtensionInstanceTransferFluctuate InstanceTransferFluctuate { get; set; }
                        public class ListAlertRulesResponseBodyPagingInfoAlertRulesTriggerConditionExtensionInstanceTransferFluctuate : TeaModel {
                            /// <summary>
                            /// <para>The maximum percentage of fluctuation in the number of auto triggered node instances that are generated in your workspace. Valid values: [1-100].</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("Percentage")]
                            [Validation(Required=false)]
                            public int? Percentage { get; set; }

                            /// <summary>
                            /// <para>The way in which the number of auto triggered node instances that are generated in your workspace fluctuates. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>abs: the absolute value. The number of instances increases or decreases.</description></item>
                            /// <item><description>increase: The number of instances increases.</description></item>
                            /// <item><description>decrease: The number of instances decreases.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>abs</para>
                            /// </summary>
                            [NameInMap("Trend")]
                            [Validation(Required=false)]
                            public string Trend { get; set; }

                        }

                        /// <summary>
                        /// <para>The configuration for an alert of the Timeout type.</para>
                        /// </summary>
                        [NameInMap("Timeout")]
                        [Validation(Required=false)]
                        public ListAlertRulesResponseBodyPagingInfoAlertRulesTriggerConditionExtensionTimeout Timeout { get; set; }
                        public class ListAlertRulesResponseBodyPagingInfoAlertRulesTriggerConditionExtensionTimeout : TeaModel {
                            /// <summary>
                            /// <para>The timeout period. Unit: minutes.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("TimeoutInMinutes")]
                            [Validation(Required=false)]
                            public int? TimeoutInMinutes { get; set; }

                        }

                        /// <summary>
                        /// <para>The configuration for an alert of the UnFinished type.</para>
                        /// </summary>
                        [NameInMap("UnFinished")]
                        [Validation(Required=false)]
                        public ListAlertRulesResponseBodyPagingInfoAlertRulesTriggerConditionExtensionUnFinished UnFinished { get; set; }
                        public class ListAlertRulesResponseBodyPagingInfoAlertRulesTriggerConditionExtensionUnFinished : TeaModel {
                            /// <summary>
                            /// <para>The latest completion time of the instance. The period is in the hh:mm format. Valid values of hh: [0,47]. Valid values of mm: [0,59].</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>12:00</para>
                            /// </summary>
                            [NameInMap("UnFinishedTime")]
                            [Validation(Required=false)]
                            public string UnFinishedTime { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The monitored objects.</para>
                    /// </summary>
                    [NameInMap("Target")]
                    [Validation(Required=false)]
                    public ListAlertRulesResponseBodyPagingInfoAlertRulesTriggerConditionTarget Target { get; set; }
                    public class ListAlertRulesResponseBodyPagingInfoAlertRulesTriggerConditionTarget : TeaModel {
                        /// <summary>
                        /// <para>The nodes that are not to be monitored.</para>
                        /// </summary>
                        [NameInMap("AllowTasks")]
                        [Validation(Required=false)]
                        public List<long?> AllowTasks { get; set; }

                        /// <summary>
                        /// <para>The IDs of monitored objects.</para>
                        /// </summary>
                        [NameInMap("Ids")]
                        [Validation(Required=false)]
                        public List<long?> Ids { get; set; }

                        /// <summary>
                        /// <para>The type of the monitored objects. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Task: node</description></item>
                        /// <item><description>Baseline: baseline</description></item>
                        /// <item><description>Project: workspace</description></item>
                        /// <item><description>BizProcess: workflow</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Task</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The alert type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Finished: An instance is successfully run.</description></item>
                    /// <item><description>UnFinished: An instance does not finish running before a specified point in time.</description></item>
                    /// <item><description>Error: An error occurs on an instance.</description></item>
                    /// <item><description>CycleUnfinished: An instance does not finish running as expected within a specific cycle.</description></item>
                    /// <item><description>Timeout: An instance times out.</description></item>
                    /// <item><description>InstanceTransferComplete: An instance is generated by the auto triggered node.</description></item>
                    /// <item><description>InstanceTransferFluctuate: The number of generated instances fluctuates.</description></item>
                    /// <item><description>ExhaustedError: An error persists after an instance is automatically rerun.</description></item>
                    /// <item><description>InstanceKeyword: An instance with errors contains specified keywords.</description></item>
                    /// <item><description>InstanceErrorCount: The number of instances on which an error occurs reaches a specified threshold.</description></item>
                    /// <item><description>InstanceErrorPercentage: The proportion of instances on which an error occurs in the workspace to the total number of instances reaches a specified threshold.</description></item>
                    /// <item><description>ResourceGroupPercentage: The usage rate of the resource group reaches a specified threshold.</description></item>
                    /// <item><description>ResourceGroupWaitCount: The number of instances that are waiting for resources in the resource group reaches a specified threshold.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Error</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A6C6B486-E3A2-5D52-9E76-D9380485D946</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
