// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetAlertRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the custom alert rule.</para>
        /// </summary>
        [NameInMap("AlertRule")]
        [Validation(Required=false)]
        public GetAlertRuleResponseBodyAlertRule AlertRule { get; set; }
        public class GetAlertRuleResponseBodyAlertRule : TeaModel {
            /// <summary>
            /// <para>Indicates whether the alert rule is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The ID of the custom alert rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16035</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the custom alert rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>error_rule</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The alert notification configuration.</para>
            /// </summary>
            [NameInMap("Notification")]
            [Validation(Required=false)]
            public GetAlertRuleResponseBodyAlertRuleNotification Notification { get; set; }
            public class GetAlertRuleResponseBodyAlertRuleNotification : TeaModel {
                /// <summary>
                /// <para>The list of alert channels.</para>
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
                /// <para>The maximum number of alerts within a calendar day. Valid values: 1 to 10000.</para>
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
                public List<GetAlertRuleResponseBodyAlertRuleNotificationReceivers> Receivers { get; set; }
                public class GetAlertRuleResponseBodyAlertRuleNotificationReceivers : TeaModel {
                    /// <summary>
                    /// <para>The additional configuration required by the alert recipient. If ReceiverType is DingdingUrl, you can set {&quot;atAll&quot;:true} to @ all members.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;atAll&quot;:true}</para>
                    /// </summary>
                    [NameInMap("Extension")]
                    [Validation(Required=false)]
                    public string Extension { get; set; }

                    /// <summary>
                    /// <para>The type of the alert recipient. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>AliUid: Alibaba Cloud UID.</description></item>
                    /// <item><description>ShiftSchedule: shift schedule.</description></item>
                    /// <item><description>TaskOwner: node owner. Applicable to custom alerting and event alerting.</description></item>
                    /// <item><description>Owner: owner. Applicable to baseline alerting.</description></item>
                    /// <item><description>WebhookUrl: custom webhook URL.</description></item>
                    /// <item><description>DingdingUrl: DingTalk webhook URL.</description></item>
                    /// <item><description>FeishuUrl: Lark webhook URL.</description></item>
                    /// <item><description>WeixinUrl: WeChat webhook URL.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>WebhookUrl</para>
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
                /// <para>The end time of the mute period. Format: HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("SilenceEndTime")]
                [Validation(Required=false)]
                public string SilenceEndTime { get; set; }

                /// <summary>
                /// <para>The start time of the mute period. Format: HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("SilenceStartTime")]
                [Validation(Required=false)]
                public string SilenceStartTime { get; set; }

            }

            /// <summary>
            /// <para>The Alibaba Cloud UID of the owner of the custom alert rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>279961421580845157</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The condition that triggers the alert.</para>
            /// </summary>
            [NameInMap("TriggerCondition")]
            [Validation(Required=false)]
            public GetAlertRuleResponseBodyAlertRuleTriggerCondition TriggerCondition { get; set; }
            public class GetAlertRuleResponseBodyAlertRuleTriggerCondition : TeaModel {
                /// <summary>
                /// <para>The extension information. Required for certain trigger conditions.</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public GetAlertRuleResponseBodyAlertRuleTriggerConditionExtension Extension { get; set; }
                public class GetAlertRuleResponseBodyAlertRuleTriggerConditionExtension : TeaModel {
                    /// <summary>
                    /// <para>The cycle-not-completed alert configuration.</para>
                    /// </summary>
                    [NameInMap("CycleUnfinished")]
                    [Validation(Required=false)]
                    public GetAlertRuleResponseBodyAlertRuleTriggerConditionExtensionCycleUnfinished CycleUnfinished { get; set; }
                    public class GetAlertRuleResponseBodyAlertRuleTriggerConditionExtensionCycleUnfinished : TeaModel {
                        /// <summary>
                        /// <para>The list of cycle and time configurations.</para>
                        /// </summary>
                        [NameInMap("CycleAndTime")]
                        [Validation(Required=false)]
                        public List<GetAlertRuleResponseBodyAlertRuleTriggerConditionExtensionCycleUnfinishedCycleAndTime> CycleAndTime { get; set; }
                        public class GetAlertRuleResponseBodyAlertRuleTriggerConditionExtensionCycleUnfinishedCycleAndTime : TeaModel {
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
                            /// <para>The timeout time. Format: hh:mm. Valid values of hh: 0 to 47. Valid values of mm: 0 to 59.</para>
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
                    public GetAlertRuleResponseBodyAlertRuleTriggerConditionExtensionError Error { get; set; }
                    public class GetAlertRuleResponseBodyAlertRuleTriggerConditionExtensionError : TeaModel {
                        /// <summary>
                        /// <para>Specifies whether to generate an alert when a batch task is automatically rerun due to a failure.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("AutoRerunAlertEnabled")]
                        [Validation(Required=false)]
                        public bool? AutoRerunAlertEnabled { get; set; }

                        /// <summary>
                        /// <para>The IDs of real-time computing nodes to monitor.</para>
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
                    public GetAlertRuleResponseBodyAlertRuleTriggerConditionExtensionInstanceErrorCount InstanceErrorCount { get; set; }
                    public class GetAlertRuleResponseBodyAlertRuleTriggerConditionExtensionInstanceErrorCount : TeaModel {
                        /// <summary>
                        /// <para>The number of failed instances. Valid values: 1 to 10000.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
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
                    public GetAlertRuleResponseBodyAlertRuleTriggerConditionExtensionInstanceErrorPercentage InstanceErrorPercentage { get; set; }
                    public class GetAlertRuleResponseBodyAlertRuleTriggerConditionExtensionInstanceErrorPercentage : TeaModel {
                        /// <summary>
                        /// <para>The percentage of failed instances. Valid values: 1 to 100.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Percentage")]
                        [Validation(Required=false)]
                        public int? Percentage { get; set; }

                    }

                    /// <summary>
                    /// <para>The instance count fluctuation alert configuration.</para>
                    /// </summary>
                    [NameInMap("InstanceTransferFluctuate")]
                    [Validation(Required=false)]
                    public GetAlertRuleResponseBodyAlertRuleTriggerConditionExtensionInstanceTransferFluctuate InstanceTransferFluctuate { get; set; }
                    public class GetAlertRuleResponseBodyAlertRuleTriggerConditionExtensionInstanceTransferFluctuate : TeaModel {
                        /// <summary>
                        /// <para>The fluctuation percentage. Valid values: 1 to 100.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Percentage")]
                        [Validation(Required=false)]
                        public int? Percentage { get; set; }

                        /// <summary>
                        /// <para>The fluctuation type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>abs: absolute value.</description></item>
                        /// <item><description>increase: increase.</description></item>
                        /// <item><description>decrease: decrease.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
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
                    public GetAlertRuleResponseBodyAlertRuleTriggerConditionExtensionTimeout Timeout { get; set; }
                    public class GetAlertRuleResponseBodyAlertRuleTriggerConditionExtensionTimeout : TeaModel {
                        /// <summary>
                        /// <para>The timeout duration, in minutes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("TimeoutInMinutes")]
                        [Validation(Required=false)]
                        public int? TimeoutInMinutes { get; set; }

                    }

                    /// <summary>
                    /// <para>The not-completed alert configuration.</para>
                    /// </summary>
                    [NameInMap("UnFinished")]
                    [Validation(Required=false)]
                    public GetAlertRuleResponseBodyAlertRuleTriggerConditionExtensionUnFinished UnFinished { get; set; }
                    public class GetAlertRuleResponseBodyAlertRuleTriggerConditionExtensionUnFinished : TeaModel {
                        /// <summary>
                        /// <para>The not-completed time. Format: hh:mm. Valid values of hh: 0 to 47. Valid values of mm: 0 to 59.</para>
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
                /// <para>The monitored object.</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public GetAlertRuleResponseBodyAlertRuleTriggerConditionTarget Target { get; set; }
                public class GetAlertRuleResponseBodyAlertRuleTriggerConditionTarget : TeaModel {
                    /// <summary>
                    /// <para>The whitelist of monitored nodes.</para>
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
                    /// <item><description>Task: node.</description></item>
                    /// <item><description>Baseline: baseline.</description></item>
                    /// <item><description>Project: workspace.</description></item>
                    /// <item><description>BizProcess: business process flow.</description></item>
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
                /// <para>The type of the alert trigger. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Finished: instance completed.</description></item>
                /// <item><description>UnFinished: instance not completed.</description></item>
                /// <item><description>Error: instance failed.</description></item>
                /// <item><description>CycleUnfinished: instance cycle not completed.</description></item>
                /// <item><description>Timeout: instance timed out.</description></item>
                /// <item><description>InstanceTransferComplete: node-to-instance conversion completed.</description></item>
                /// <item><description>InstanceTransferFluctuate: instance count fluctuation.</description></item>
                /// <item><description>ExhaustedError: instance still failed after automatic reruns.</description></item>
                /// <item><description>InstanceKeyword: failed instance contains keyword.</description></item>
                /// <item><description>InstanceErrorCount: number of failed instances.</description></item>
                /// <item><description>InstanceErrorPercentage: percentage of failed instances.</description></item>
                /// <item><description>ResourceGroupPercentage: schedule resource utilization.</description></item>
                /// <item><description>ResourceGroupWaitCount: number of instances waiting for schedule resources.</description></item>
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
        /// <para>The request ID, which is used to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8abcb91f-d266-4073-b907-2ed****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
