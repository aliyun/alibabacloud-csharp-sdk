// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class NotifyStrategyForView : TeaModel {
        [NameInMap("autoRecoverSeconds")]
        [Validation(Required=false)]
        public int? AutoRecoverSeconds { get; set; }

        /// <summary>
        /// <para>Create Time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Notification channel template.</para>
        /// </summary>
        [NameInMap("customTemplateEntries")]
        [Validation(Required=false)]
        public List<NotifyStrategyForViewCustomTemplateEntries> CustomTemplateEntries { get; set; }
        public class NotifyStrategyForViewCustomTemplateEntries : TeaModel {
            /// <summary>
            /// <para>Notification type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SMS</para>
            /// </summary>
            [NameInMap("targetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>Template UUID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123-12-312-312-31-23</para>
            /// </summary>
            [NameInMap("templateUuid")]
            [Validation(Required=false)]
            public string TemplateUuid { get; set; }

        }

        /// <summary>
        /// <para>Description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Whether enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("filterSetting")]
        [Validation(Required=false)]
        public FilterSetting FilterSetting { get; set; }

        /// <summary>
        /// <para>Grouping Setting.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("groupingSetting")]
        [Validation(Required=false)]
        public NotifyStrategyForViewGroupingSetting GroupingSetting { get; set; }
        public class NotifyStrategyForViewGroupingSetting : TeaModel {
            /// <summary>
            /// <para>Grouping Keys</para>
            /// </summary>
            [NameInMap("groupingKeys")]
            [Validation(Required=false)]
            public List<string> GroupingKeys { get; set; }

            /// <summary>
            /// <para>Check interval in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("periodMin")]
            [Validation(Required=false)]
            public int? PeriodMin { get; set; }

            /// <summary>
            /// <para>Silence duration in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("silenceSec")]
            [Validation(Required=false)]
            public int? SilenceSec { get; set; }

            /// <summary>
            /// <para>Trigger count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("times")]
            [Validation(Required=false)]
            public int? Times { get; set; }

        }

        /// <summary>
        /// <para>Whether to notify on recovery.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ignoreRestoredNotification")]
        [Validation(Required=false)]
        public bool? IgnoreRestoredNotification { get; set; }

        [NameInMap("incidentEscalationPolicies")]
        [Validation(Required=false)]
        public List<object> IncidentEscalationPolicies { get; set; }

        /// <summary>
        /// <para>UUID</para>
        /// 
        /// <b>Example:</b>
        /// <para>12312-31-23-123-1-23123</para>
        /// </summary>
        [NameInMap("notifyStrategyId")]
        [Validation(Required=false)]
        public string NotifyStrategyId { get; set; }

        /// <summary>
        /// <para>Name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test policy.</para>
        /// </summary>
        [NameInMap("notifyStrategyName")]
        [Validation(Required=false)]
        public string NotifyStrategyName { get; set; }

        [NameInMap("pushingSetting")]
        [Validation(Required=false)]
        public NotifyStrategyForViewPushingSetting PushingSetting { get; set; }
        public class NotifyStrategyForViewPushingSetting : TeaModel {
            [NameInMap("alertActionIds")]
            [Validation(Required=false)]
            public List<string> AlertActionIds { get; set; }

            [NameInMap("restoreActionIds")]
            [Validation(Required=false)]
            public List<string> RestoreActionIds { get; set; }

            [NameInMap("templateUuid")]
            [Validation(Required=false)]
            public string TemplateUuid { get; set; }

        }

        [NameInMap("receiverNames")]
        [Validation(Required=false)]
        public List<string> ReceiverNames { get; set; }

        [NameInMap("repeatNotifySetting")]
        [Validation(Required=false)]
        public NotifyStrategyForViewRepeatNotifySetting RepeatNotifySetting { get; set; }
        public class NotifyStrategyForViewRepeatNotifySetting : TeaModel {
            [NameInMap("endIncidentState")]
            [Validation(Required=false)]
            public string EndIncidentState { get; set; }

            [NameInMap("repeatInterval")]
            [Validation(Required=false)]
            public int? RepeatInterval { get; set; }

        }

        /// <summary>
        /// <para>Notification channel routing configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("routes")]
        [Validation(Required=false)]
        public List<NotifyStrategyForViewRoutes> Routes { get; set; }
        public class NotifyStrategyForViewRoutes : TeaModel {
            /// <summary>
            /// <para>Notification channel.</para>
            /// </summary>
            [NameInMap("channels")]
            [Validation(Required=false)]
            public List<NotifyStrategyForViewRoutesChannels> Channels { get; set; }
            public class NotifyStrategyForViewRoutesChannels : TeaModel {
                /// <summary>
                /// <para>Channel type.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CONTACT</para>
                /// </summary>
                [NameInMap("channelType")]
                [Validation(Required=false)]
                public string ChannelType { get; set; }

                /// <summary>
                /// <para>Enabled notification types.</para>
                /// </summary>
                [NameInMap("enabledSubChannels")]
                [Validation(Required=false)]
                public List<string> EnabledSubChannels { get; set; }

                /// <summary>
                /// <para>Channel recipient.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("receivers")]
                [Validation(Required=false)]
                public List<string> Receivers { get; set; }

            }

            [NameInMap("digitalEmployeeName")]
            [Validation(Required=false)]
            public string DigitalEmployeeName { get; set; }

            /// <summary>
            /// <para>Field.</para>
            /// </summary>
            [NameInMap("effectTimeRange")]
            [Validation(Required=false)]
            public NotifyStrategyForViewRoutesEffectTimeRange EffectTimeRange { get; set; }
            public class NotifyStrategyForViewRoutesEffectTimeRange : TeaModel {
                /// <summary>
                /// <para>Effective days (Monday to Sunday).</para>
                /// </summary>
                [NameInMap("dayInWeek")]
                [Validation(Required=false)]
                public List<int?> DayInWeek { get; set; }

                /// <summary>
                /// <para>End time (in minutes).</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("endTimeInMinute")]
                [Validation(Required=false)]
                public int? EndTimeInMinute { get; set; }

                /// <summary>
                /// <para>Start time (in minutes).</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("startTimeInMinute")]
                [Validation(Required=false)]
                public int? StartTimeInMinute { get; set; }

                /// <summary>
                /// <para>Time Zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>+08:00</para>
                /// </summary>
                [NameInMap("timeZone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

            }

            [NameInMap("enableRca")]
            [Validation(Required=false)]
            public bool? EnableRca { get; set; }

            /// <summary>
            /// <para>Routing settings.</para>
            /// </summary>
            [NameInMap("filterSetting")]
            [Validation(Required=false)]
            public FilterSetting FilterSetting { get; set; }

            /// <summary>
            /// <para>Severity level list.</para>
            /// </summary>
            [NameInMap("severities")]
            [Validation(Required=false)]
            public List<string> Severities { get; set; }

        }

        [NameInMap("syncFromType")]
        [Validation(Required=false)]
        public string SyncFromType { get; set; }

        /// <summary>
        /// <para>Update Time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-05-30T02:29:09Z</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>User ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123123****</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>workspace</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

        [NameInMap("workspaceFilterSetting")]
        [Validation(Required=false)]
        public WorkspaceFilterSetting WorkspaceFilterSetting { get; set; }

    }

}
