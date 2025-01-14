// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateAlertRuleRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the rule.</para>
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
        /// <para>105412</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>collection_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The configuration for the alert notification.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public UpdateAlertRuleRequestNotification Notification { get; set; }
        public class UpdateAlertRuleRequestNotification : TeaModel {
            /// <summary>
            /// <para>The alert notification channels.</para>
            /// </summary>
            [NameInMap("Channels")]
            [Validation(Required=false)]
            public List<string> Channels { get; set; }

            /// <summary>
            /// <para>The interval at which an alert notification is sent. Unit: minutes. Valid values: [5,10000].</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("IntervalInMinutes")]
            [Validation(Required=false)]
            public int? IntervalInMinutes { get; set; }

            /// <summary>
            /// <para>The maximum number of times an alert notification can be sent within a calendar day. Valid values: [1, 10000].</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Maximum")]
            [Validation(Required=false)]
            public int? Maximum { get; set; }

            /// <summary>
            /// <para>The alert recipients.</para>
            /// </summary>
            [NameInMap("Receivers")]
            [Validation(Required=false)]
            public List<UpdateAlertRuleRequestNotificationReceivers> Receivers { get; set; }
            public class UpdateAlertRuleRequestNotificationReceivers : TeaModel {
                /// <summary>
                /// <para>The additional configuration of the alert recipient. If the ReceiverType parameter is set to DingdingUrl, you can set this parameter to {&quot;atAll&quot;:true} to remind all members in a DingTalk group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;atAll&quot;:true}</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// <para>The type of the alert recipient. Valid valves:</para>
                /// <list type="bullet">
                /// <item><description>AliUid: Alibaba Cloud account ID.</description></item>
                /// <item><description>Shift Schedules: the personnel in a shift schedule.</description></item>
                /// <item><description>TaskOwner: the task owner. The task owner can receive custom alerts and event alerts.</description></item>
                /// <item><description>Owner: the baseline owner. The baseline owner can receive baseline alerts.</description></item>
                /// <item><description>WebhookUrl: URL of a custom webhook.</description></item>
                /// <item><description>DingdingUrl: DingTalk webhook URL.</description></item>
                /// <item><description>FeishuUrl: Lark webhook URL.</description></item>
                /// <item><description>WeixinUrl: WeCom webhook URL.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TaskOwner</para>
                /// </summary>
                [NameInMap("ReceiverType")]
                [Validation(Required=false)]
                public string ReceiverType { get; set; }

                /// <summary>
                /// <para>The alert recipients.</para>
                /// </summary>
                [NameInMap("ReceiverValues")]
                [Validation(Required=false)]
                public List<string> ReceiverValues { get; set; }

            }

            /// <summary>
            /// <para>The end time for silence. The time is in the HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00:00</para>
            /// </summary>
            [NameInMap("SilenceEndTime")]
            [Validation(Required=false)]
            public string SilenceEndTime { get; set; }

            /// <summary>
            /// <para>The start time for silence. The time is in the HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00:00</para>
            /// </summary>
            [NameInMap("SilenceStartTime")]
            [Validation(Required=false)]
            public string SilenceStartTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account used by the owner of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>193379****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The alert triggering condition.</para>
        /// </summary>
        [NameInMap("TriggerCondition")]
        [Validation(Required=false)]
        public UpdateAlertRuleRequestTriggerCondition TriggerCondition { get; set; }
        public class UpdateAlertRuleRequestTriggerCondition : TeaModel {
            /// <summary>
            /// <para>The extended information about the rule. This parameter is required for specific types of alerts.</para>
            /// </summary>
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public UpdateAlertRuleRequestTriggerConditionExtension Extension { get; set; }
            public class UpdateAlertRuleRequestTriggerConditionExtension : TeaModel {
                /// <summary>
                /// <para>The configuration for an alert of the CycleUnfinished type.</para>
                /// </summary>
                [NameInMap("CycleUnfinished")]
                [Validation(Required=false)]
                public UpdateAlertRuleRequestTriggerConditionExtensionCycleUnfinished CycleUnfinished { get; set; }
                public class UpdateAlertRuleRequestTriggerConditionExtensionCycleUnfinished : TeaModel {
                    /// <summary>
                    /// <para>The configurations of the scheduling cycle and timeout period of the instance.</para>
                    /// </summary>
                    [NameInMap("CycleAndTime")]
                    [Validation(Required=false)]
                    public List<UpdateAlertRuleRequestTriggerConditionExtensionCycleUnfinishedCycleAndTime> CycleAndTime { get; set; }
                    public class UpdateAlertRuleRequestTriggerConditionExtensionCycleUnfinishedCycleAndTime : TeaModel {
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
                public UpdateAlertRuleRequestTriggerConditionExtensionError Error { get; set; }
                public class UpdateAlertRuleRequestTriggerConditionExtensionError : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to trigger an alert if a batch synchronization task is automatically rerun upon a failure.</para>
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
                public UpdateAlertRuleRequestTriggerConditionExtensionInstanceErrorCount InstanceErrorCount { get; set; }
                public class UpdateAlertRuleRequestTriggerConditionExtensionInstanceErrorCount : TeaModel {
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
                public UpdateAlertRuleRequestTriggerConditionExtensionInstanceErrorPercentage InstanceErrorPercentage { get; set; }
                public class UpdateAlertRuleRequestTriggerConditionExtensionInstanceErrorPercentage : TeaModel {
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
                public UpdateAlertRuleRequestTriggerConditionExtensionInstanceTransferFluctuate InstanceTransferFluctuate { get; set; }
                public class UpdateAlertRuleRequestTriggerConditionExtensionInstanceTransferFluctuate : TeaModel {
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
                public UpdateAlertRuleRequestTriggerConditionExtensionTimeout Timeout { get; set; }
                public class UpdateAlertRuleRequestTriggerConditionExtensionTimeout : TeaModel {
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
                public UpdateAlertRuleRequestTriggerConditionExtensionUnFinished UnFinished { get; set; }
                public class UpdateAlertRuleRequestTriggerConditionExtensionUnFinished : TeaModel {
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
            public UpdateAlertRuleRequestTriggerConditionTarget Target { get; set; }
            public class UpdateAlertRuleRequestTriggerConditionTarget : TeaModel {
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
                /// <item><description>project: workspace</description></item>
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
            /// <para>ERROR</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
