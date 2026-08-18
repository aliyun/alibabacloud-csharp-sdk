// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateAlertRuleRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the alert rule is enabled.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The name of the custom rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xm_create_test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The alert notification configuration.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public CreateAlertRuleRequestNotification Notification { get; set; }
        public class CreateAlertRuleRequestNotification : TeaModel {
            /// <summary>
            /// <para>The list of alert channels.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Channels")]
            [Validation(Required=false)]
            public List<string> Channels { get; set; }

            /// <summary>
            /// <para>The alert interval, in minutes. Valid values: 5 to 10000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("IntervalInMinutes")]
            [Validation(Required=false)]
            public int? IntervalInMinutes { get; set; }

            /// <summary>
            /// <para>The maximum number of alerts within a calendar year. Valid values: 1 to 10000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Maximum")]
            [Validation(Required=false)]
            public int? Maximum { get; set; }

            /// <summary>
            /// <para>The alert recipients.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Receivers")]
            [Validation(Required=false)]
            public List<CreateAlertRuleRequestNotificationReceivers> Receivers { get; set; }
            public class CreateAlertRuleRequestNotificationReceivers : TeaModel {
                /// <summary>
                /// <para>The additional configuration required for the alert recipient. If ReceiverType is DingdingUrl, you can set {&quot;atAll&quot;:true} to @ all members.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;atAll&quot;:true}</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// <para>The alert recipient type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AliUid: Alibaba Cloud UID</description></item>
                /// <item><description>ShiftSchedule: shift schedule</description></item>
                /// <item><description>TaskOwner: node owner, applicable to custom alerting and event alerting</description></item>
                /// <item><description>Owner: owner, applicable to baseline alerting</description></item>
                /// <item><description>WebhookUrl: custom webhook URL</description></item>
                /// <item><description>DingdingUrl: DingTalk webhook URL</description></item>
                /// <item><description>FeishuUrl: Lark webhook URL</description></item>
                /// <item><description>WeixinUrl: WeCom webhook URL</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TaskOwner</para>
                /// </summary>
                [NameInMap("ReceiverType")]
                [Validation(Required=false)]
                public string ReceiverType { get; set; }

                /// <summary>
                /// <para>The values of the alert recipient.</para>
                /// </summary>
                [NameInMap("ReceiverValues")]
                [Validation(Required=false)]
                public List<string> ReceiverValues { get; set; }

            }

            /// <summary>
            /// <para>The end time of the alert silence period, in the format of HH:mm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00</para>
            /// </summary>
            [NameInMap("SilenceEndTime")]
            [Validation(Required=false)]
            public string SilenceEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the alert silence period, in the format of HH:mm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00</para>
            /// </summary>
            [NameInMap("SilenceStartTime")]
            [Validation(Required=false)]
            public string SilenceStartTime { get; set; }

        }

        /// <summary>
        /// <para>The Alibaba Cloud UID of the owner of the custom rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>279114181****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The condition that triggers the alert.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TriggerCondition")]
        [Validation(Required=false)]
        public CreateAlertRuleRequestTriggerCondition TriggerCondition { get; set; }
        public class CreateAlertRuleRequestTriggerCondition : TeaModel {
            /// <summary>
            /// <para>The extension information. This parameter is required for certain trigger condition configurations.</para>
            /// </summary>
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public CreateAlertRuleRequestTriggerConditionExtension Extension { get; set; }
            public class CreateAlertRuleRequestTriggerConditionExtension : TeaModel {
                /// <summary>
                /// <para>The cycle unfinished alert configuration.</para>
                /// </summary>
                [NameInMap("CycleUnfinished")]
                [Validation(Required=false)]
                public CreateAlertRuleRequestTriggerConditionExtensionCycleUnfinished CycleUnfinished { get; set; }
                public class CreateAlertRuleRequestTriggerConditionExtensionCycleUnfinished : TeaModel {
                    /// <summary>
                    /// <para>The list of cycle and time configurations.</para>
                    /// </summary>
                    [NameInMap("CycleAndTime")]
                    [Validation(Required=false)]
                    public List<CreateAlertRuleRequestTriggerConditionExtensionCycleUnfinishedCycleAndTime> CycleAndTime { get; set; }
                    public class CreateAlertRuleRequestTriggerConditionExtensionCycleUnfinishedCycleAndTime : TeaModel {
                        /// <summary>
                        /// <para>The cycle ID. Valid values: 1 to 288.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("CycleId")]
                        [Validation(Required=false)]
                        public int? CycleId { get; set; }

                        /// <summary>
                        /// <para>The timeout time, in the format of hh:mm. Valid values of hh: 0 to 47. Valid values of mm: 0 to 59.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>12:00</para>
                        /// </summary>
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public string Time { get; set; }

                    }

                }

                /// <summary>
                /// <para>The error alert configuration.</para>
                /// </summary>
                [NameInMap("Error")]
                [Validation(Required=false)]
                public CreateAlertRuleRequestTriggerConditionExtensionError Error { get; set; }
                public class CreateAlertRuleRequestTriggerConditionExtensionError : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to generate an alert when an offline task is automatically rerun due to failure.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("AutoRerunAlertEnabled")]
                    [Validation(Required=false)]
                    public bool? AutoRerunAlertEnabled { get; set; }

                    /// <summary>
                    /// <para>The IDs of real-time computing tasks to monitor.</para>
                    /// </summary>
                    [NameInMap("StreamTaskIds")]
                    [Validation(Required=false)]
                    public List<long?> StreamTaskIds { get; set; }

                }

                /// <summary>
                /// <para>The instance error count alert configuration.</para>
                /// </summary>
                [NameInMap("InstanceErrorCount")]
                [Validation(Required=false)]
                public CreateAlertRuleRequestTriggerConditionExtensionInstanceErrorCount InstanceErrorCount { get; set; }
                public class CreateAlertRuleRequestTriggerConditionExtensionInstanceErrorCount : TeaModel {
                    /// <summary>
                    /// <para>The number of error instances. Valid values: 1 to 10000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                }

                /// <summary>
                /// <para>The instance error percentage alert configuration.</para>
                /// </summary>
                [NameInMap("InstanceErrorPercentage")]
                [Validation(Required=false)]
                public CreateAlertRuleRequestTriggerConditionExtensionInstanceErrorPercentage InstanceErrorPercentage { get; set; }
                public class CreateAlertRuleRequestTriggerConditionExtensionInstanceErrorPercentage : TeaModel {
                    /// <summary>
                    /// <para>The percentage of error instances. Valid values: 1 to 100.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Percentage")]
                    [Validation(Required=false)]
                    public int? Percentage { get; set; }

                }

                /// <summary>
                /// <para>The instance transfer fluctuation alert configuration.</para>
                /// </summary>
                [NameInMap("InstanceTransferFluctuate")]
                [Validation(Required=false)]
                public CreateAlertRuleRequestTriggerConditionExtensionInstanceTransferFluctuate InstanceTransferFluctuate { get; set; }
                public class CreateAlertRuleRequestTriggerConditionExtensionInstanceTransferFluctuate : TeaModel {
                    /// <summary>
                    /// <para>The percentage of instance transfer fluctuation. Valid values: 1 to 100.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Percentage")]
                    [Validation(Required=false)]
                    public int? Percentage { get; set; }

                    /// <summary>
                    /// <para>The type of instance transfer fluctuation. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>abs: absolute value</description></item>
                    /// <item><description>increase: increase</description></item>
                    /// <item><description>decrease: decrease</description></item>
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
                /// <para>The timeout alert configuration.</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public CreateAlertRuleRequestTriggerConditionExtensionTimeout Timeout { get; set; }
                public class CreateAlertRuleRequestTriggerConditionExtensionTimeout : TeaModel {
                    /// <summary>
                    /// <para>The timeout duration, in minutes. Valid values: 1 to 21600.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("TimeoutInMinutes")]
                    [Validation(Required=false)]
                    public int? TimeoutInMinutes { get; set; }

                }

                /// <summary>
                /// <para>The unfinished alert configuration.</para>
                /// </summary>
                [NameInMap("UnFinished")]
                [Validation(Required=false)]
                public CreateAlertRuleRequestTriggerConditionExtensionUnFinished UnFinished { get; set; }
                public class CreateAlertRuleRequestTriggerConditionExtensionUnFinished : TeaModel {
                    /// <summary>
                    /// <para>The unfinished time, in the format of hh:mm. Valid values of hh: 0 to 47. Valid values of mm: 0 to 59.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30:00</para>
                    /// </summary>
                    [NameInMap("UnFinishedTime")]
                    [Validation(Required=false)]
                    public string UnFinishedTime { get; set; }

                }

            }

            /// <summary>
            /// <para>The monitored object.</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public CreateAlertRuleRequestTriggerConditionTarget Target { get; set; }
            public class CreateAlertRuleRequestTriggerConditionTarget : TeaModel {
                /// <summary>
                /// <para>The whitelist of monitored tasks.</para>
                /// </summary>
                [NameInMap("AllowTasks")]
                [Validation(Required=false)]
                public List<long?> AllowTasks { get; set; }

                /// <summary>
                /// <para>The list of monitored object IDs.</para>
                /// </summary>
                [NameInMap("Ids")]
                [Validation(Required=false)]
                public List<long?> Ids { get; set; }

                /// <summary>
                /// <para>The monitored object type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Task: node</description></item>
                /// <item><description>Baseline: baseline</description></item>
                /// <item><description>Project: workspace</description></item>
                /// <item><description>BizProcess: business process</description></item>
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
            /// <para>The type of alert trigger. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Finished: Instance completed.</description></item>
            /// <item><description>UnFinished: Instance not completed.</description></item>
            /// <item><description>Error: Instance error.</description></item>
            /// <item><description>CycleUnfinished: Instance cycle not completed.</description></item>
            /// <item><description>Timeout: Instance timeout.</description></item>
            /// <item><description>InstanceTransferComplete: Node-to-instance conversion completed.</description></item>
            /// <item><description>InstanceTransferFluctuate: Instance count fluctuation.</description></item>
            /// <item><description>ExhaustedError: Error persists after automatic reruns.</description></item>
            /// <item><description>InstanceKeyword: Error instance contains keyword.</description></item>
            /// <item><description>InstanceErrorCount: Number of error instances.</description></item>
            /// <item><description>InstanceErrorPercentage: Percentage of error instances.</description></item>
            /// <item><description>ResourceGroupPercentage: Resource group utilization.</description></item>
            /// <item><description>ResourceGroupWaitCount: Number of instances waiting for resources in the resource group.</description></item>
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

}
