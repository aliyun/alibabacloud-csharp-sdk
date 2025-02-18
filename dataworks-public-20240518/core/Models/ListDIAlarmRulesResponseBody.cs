// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDIAlarmRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDIAlarmRulesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDIAlarmRulesResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The alert rules.</para>
            /// </summary>
            [NameInMap("DIJobAlarmRules")]
            [Validation(Required=false)]
            public List<ListDIAlarmRulesResponseBodyPagingInfoDIJobAlarmRules> DIJobAlarmRules { get; set; }
            public class ListDIAlarmRulesResponseBodyPagingInfoDIJobAlarmRules : TeaModel {
                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>This parameter is deprecated. Use the Id parameter instead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>72402</para>
                /// </summary>
                [NameInMap("DIAlarmRuleId")]
                [Validation(Required=false)]
                [Obsolete]
                public long? DIAlarmRuleId { get; set; }

                /// <summary>
                /// <para>The ID of the synchronization task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32594</para>
                /// </summary>
                [NameInMap("DIJobId")]
                [Validation(Required=false)]
                public long? DIJobId { get; set; }

                /// <summary>
                /// <para>The description of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule descrition</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether the alert rule is enabled. Valid values: True and False.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The ID of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>72402</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The metric type in the alert rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Heartbeat</description></item>
                /// <item><description>FailoverCount</description></item>
                /// <item><description>Delay</description></item>
                /// <item><description>DdlReport</description></item>
                /// <item><description>ResourceUtilization</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Heartbeat</para>
                /// </summary>
                [NameInMap("MetricType")]
                [Validation(Required=false)]
                public string MetricType { get; set; }

                /// <summary>
                /// <para>The name of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The alert notification method and recipient settings.</para>
                /// </summary>
                [NameInMap("NotificationSettings")]
                [Validation(Required=false)]
                public ListDIAlarmRulesResponseBodyPagingInfoDIJobAlarmRulesNotificationSettings NotificationSettings { get; set; }
                public class ListDIAlarmRulesResponseBodyPagingInfoDIJobAlarmRulesNotificationSettings : TeaModel {
                    /// <term><b>Obsolete</b></term>
                    /// 
                    /// <summary>
                    /// <para>This parameter is deprecated and replaced by the MuteInterval parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("InhibitionInterval")]
                    [Validation(Required=false)]
                    [Obsolete]
                    public long? InhibitionInterval { get; set; }

                    /// <summary>
                    /// <para>The duration of the alert suppression interval. Unit: minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("MuteInterval")]
                    [Validation(Required=false)]
                    public long? MuteInterval { get; set; }

                    /// <summary>
                    /// <para>The alert notification methods.</para>
                    /// </summary>
                    [NameInMap("NotificationChannels")]
                    [Validation(Required=false)]
                    public List<ListDIAlarmRulesResponseBodyPagingInfoDIJobAlarmRulesNotificationSettingsNotificationChannels> NotificationChannels { get; set; }
                    public class ListDIAlarmRulesResponseBodyPagingInfoDIJobAlarmRulesNotificationSettingsNotificationChannels : TeaModel {
                        /// <summary>
                        /// <para>The alert notification methods.</para>
                        /// </summary>
                        [NameInMap("Channels")]
                        [Validation(Required=false)]
                        public List<string> Channels { get; set; }

                        /// <summary>
                        /// <para>The severity level. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Warning</description></item>
                        /// <item><description>Critical</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Critical</para>
                        /// </summary>
                        [NameInMap("Severity")]
                        [Validation(Required=false)]
                        public string Severity { get; set; }

                    }

                    /// <summary>
                    /// <para>The settings of alert notification recipients.</para>
                    /// </summary>
                    [NameInMap("NotificationReceivers")]
                    [Validation(Required=false)]
                    public List<ListDIAlarmRulesResponseBodyPagingInfoDIJobAlarmRulesNotificationSettingsNotificationReceivers> NotificationReceivers { get; set; }
                    public class ListDIAlarmRulesResponseBodyPagingInfoDIJobAlarmRulesNotificationSettingsNotificationReceivers : TeaModel {
                        /// <summary>
                        /// <para>The recipient type. Valid values: AliyunUid, DingToken, FeishuToken, and WebHookUrl.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DingToken</para>
                        /// </summary>
                        [NameInMap("ReceiverType")]
                        [Validation(Required=false)]
                        public string ReceiverType { get; set; }

                        /// <summary>
                        /// <para>The recipient.</para>
                        /// <list type="bullet">
                        /// <item><description>If the value of the ReceiverType parameter is AliyunUid, the value of this parameter is the Alibaba Cloud account ID of a user.</description></item>
                        /// <item><description>If the value of the ReceiverType parameter is DingToken, the value of this parameter is the token of a DingTalk chatbot.</description></item>
                        /// </list>
                        /// </summary>
                        [NameInMap("ReceiverValues")]
                        [Validation(Required=false)]
                        public List<string> ReceiverValues { get; set; }

                    }

                }

                /// <summary>
                /// <para>The conditions that are used to trigger the alert rule.</para>
                /// </summary>
                [NameInMap("TriggerConditions")]
                [Validation(Required=false)]
                public List<ListDIAlarmRulesResponseBodyPagingInfoDIJobAlarmRulesTriggerConditions> TriggerConditions { get; set; }
                public class ListDIAlarmRulesResponseBodyPagingInfoDIJobAlarmRulesTriggerConditions : TeaModel {
                    /// <term><b>Obsolete</b></term>
                    /// 
                    /// <summary>
                    /// <para>This parameter is deprecated and replaced by the DdlTypes parameter.</para>
                    /// </summary>
                    [NameInMap("DdlReportTags")]
                    [Validation(Required=false)]
                    [Obsolete]
                    public List<string> DdlReportTags { get; set; }

                    /// <summary>
                    /// <para>The types of DDL operations for which the alert rule takes effect. This parameter is returned only if the MetricType parameter is set to DdlReport.</para>
                    /// </summary>
                    [NameInMap("DdlTypes")]
                    [Validation(Required=false)]
                    public List<string> DdlTypes { get; set; }

                    /// <summary>
                    /// <para>The time interval for alert calculation. Unit: minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public long? Duration { get; set; }

                    /// <summary>
                    /// <para>The severity level. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Warning</description></item>
                    /// <item><description>Critical</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Critical</para>
                    /// </summary>
                    [NameInMap("Severity")]
                    [Validation(Required=false)]
                    public string Severity { get; set; }

                    /// <summary>
                    /// <para>The alert threshold.</para>
                    /// <list type="bullet">
                    /// <item><description>If the alert rule is for task status, no threshold is used.</description></item>
                    /// <item><description>If the alert rule is for failovers, the threshold is the number of failovers.</description></item>
                    /// <item><description>If the alert rule is for latency, the threshold is the latency duration, in seconds.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public long? Threshold { get; set; }

                }

            }

            /// <summary>
            /// <para>The page number. Pages start from page 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use the ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74C2FECD-5B3A-554A-BCF5-351A36DE9815</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
