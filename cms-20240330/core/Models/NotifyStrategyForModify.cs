// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class NotifyStrategyForModify : TeaModel {
        [NameInMap("autoRecoverSeconds")]
        [Validation(Required=false)]
        public int? AutoRecoverSeconds { get; set; }

        /// <summary>
        /// <para>Notification channel template.</para>
        /// </summary>
        [NameInMap("customTemplateEntries")]
        [Validation(Required=false)]
        public List<NotifyStrategyForModifyCustomTemplateEntries> CustomTemplateEntries { get; set; }
        public class NotifyStrategyForModifyCustomTemplateEntries : TeaModel {
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
            /// <para>123123-12-31-231-23-12-3123</para>
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

        [NameInMap("enableIncidentManagement")]
        [Validation(Required=false)]
        public bool? EnableIncidentManagement { get; set; }

        [NameInMap("escalationId")]
        [Validation(Required=false)]
        public List<string> EscalationId { get; set; }

        [NameInMap("filterSetting")]
        [Validation(Required=false)]
        public FilterSetting FilterSetting { get; set; }

        /// <summary>
        /// <para>Grouping settings.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("groupingSetting")]
        [Validation(Required=false)]
        public NotifyStrategyForModifyGroupingSetting GroupingSetting { get; set; }
        public class NotifyStrategyForModifyGroupingSetting : TeaModel {
            /// <summary>
            /// <para>Grouping keys.</para>
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
            /// <para>1</para>
            /// </summary>
            [NameInMap("times")]
            [Validation(Required=false)]
            public int? Times { get; set; }

        }

        /// <summary>
        /// <para>Whether to notify on recovery.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ignoreRestoredNotification")]
        [Validation(Required=false)]
        public bool? IgnoreRestoredNotification { get; set; }

        /// <summary>
        /// <para>Name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Policy name.</para>
        /// </summary>
        [NameInMap("notifyStrategyName")]
        [Validation(Required=false)]
        public string NotifyStrategyName { get; set; }

        [NameInMap("pushingSetting")]
        [Validation(Required=false)]
        public NotifyStrategyForModifyPushingSetting PushingSetting { get; set; }
        public class NotifyStrategyForModifyPushingSetting : TeaModel {
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

        [NameInMap("repeatNotifySetting")]
        [Validation(Required=false)]
        public NotifyStrategyForModifyRepeatNotifySetting RepeatNotifySetting { get; set; }
        public class NotifyStrategyForModifyRepeatNotifySetting : TeaModel {
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
        public List<NotifyStrategyForModifyRoutes> Routes { get; set; }
        public class NotifyStrategyForModifyRoutes : TeaModel {
            /// <summary>
            /// <para>Notification channel.</para>
            /// </summary>
            [NameInMap("channels")]
            [Validation(Required=false)]
            public List<NotifyStrategyForModifyRoutesChannels> Channels { get; set; }
            public class NotifyStrategyForModifyRoutesChannels : TeaModel {
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
            /// <para>Valid time range.</para>
            /// </summary>
            [NameInMap("effectTimeRange")]
            [Validation(Required=false)]
            public NotifyStrategyForModifyRoutesEffectTimeRange EffectTimeRange { get; set; }
            public class NotifyStrategyForModifyRoutesEffectTimeRange : TeaModel {
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
                /// <para>30</para>
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
            /// <para>Routing conditions.</para>
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

        [NameInMap("workspaceFilterSetting")]
        [Validation(Required=false)]
        public WorkspaceFilterSetting WorkspaceFilterSetting { get; set; }

    }

}
