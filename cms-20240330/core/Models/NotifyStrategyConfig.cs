// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class NotifyStrategyConfig : TeaModel {
        /// <summary>
        /// <para>The list of custom notification templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("customTemplateEntries")]
        [Validation(Required=false)]
        public List<NotifyStrategyConfigCustomTemplateEntries> CustomTemplateEntries { get; set; }
        public class NotifyStrategyConfigCustomTemplateEntries : TeaModel {
            /// <summary>
            /// <para>The UUID of the notification template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>template-uuid-xxx</para>
            /// </summary>
            [NameInMap("templateUuid")]
            [Validation(Required=false)]
            public string TemplateUuid { get; set; }

        }

        /// <summary>
        /// <para>The description of the notification policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>生产环境告警通知策略</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The noise reduction settings.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("groupingSetting")]
        [Validation(Required=false)]
        public NotifyStrategyConfigGroupingSetting GroupingSetting { get; set; }
        public class NotifyStrategyConfigGroupingSetting : TeaModel {
            /// <summary>
            /// <para>The event fields by which events are grouped. Events in the same group are merged into a single notification. An empty array indicates no grouping.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;alertname&quot;]</para>
            /// </summary>
            [NameInMap("groupingKeys")]
            [Validation(Required=false)]
            public List<string> GroupingKeys { get; set; }

            /// <summary>
            /// <para>This parameter does not take effect for this operation. You do not need to set this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("periodMin")]
            [Validation(Required=false)]
            public int? PeriodMin { get; set; }

            /// <summary>
            /// <para>This parameter does not take effect for this operation. You do not need to set this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("silenceSec")]
            [Validation(Required=false)]
            public int? SilenceSec { get; set; }

            /// <summary>
            /// <para>This parameter does not take effect for this operation. You do not need to set this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("times")]
            [Validation(Required=false)]
            public int? Times { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to ignore notifications for recovery events. A value of true indicates that recovery notifications are not sent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ignoreRestoredNotification")]
        [Validation(Required=false)]
        public bool? IgnoreRestoredNotification { get; set; }

        /// <summary>
        /// <para>The list of notification channel routing settings.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("routes")]
        [Validation(Required=false)]
        public List<NotifyStrategyConfigRoutes> Routes { get; set; }
        public class NotifyStrategyConfigRoutes : TeaModel {
            /// <summary>
            /// <para>The list of notification channels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("channels")]
            [Validation(Required=false)]
            public List<NotifyStrategyConfigRoutesChannels> Channels { get; set; }
            public class NotifyStrategyConfigRoutesChannels : TeaModel {
                /// <summary>
                /// <para>The channel type. Valid values: DING, WEIXIN, FEISHU, SLACK, TEAMS, WEBHOOK, CONTACT, GROUP, DUTY, and DING_COOL_APP. Lowercase values are not supported. For email, text message, or phone call notifications, use CONTACT with enabledSubChannels.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WEBHOOK</para>
                /// </summary>
                [NameInMap("channelType")]
                [Validation(Required=false)]
                public string ChannelType { get; set; }

                /// <summary>
                /// <para>Required only for CONTACT, GROUP, or DUTY. The sub-channel types in uppercase. Valid values: EMAIL, SMS, VOICE, DING, WEIXIN, FEISHU, and WEBHOOK.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;EMAIL&quot;,&quot;SMS&quot;]</para>
                /// </summary>
                [NameInMap("enabledSubChannels")]
                [Validation(Required=false)]
                public List<string> EnabledSubChannels { get; set; }

                /// <summary>
                /// <para>The list of receiver identifiers. At least one receiver is required. Specify a webhook UUID for WEBHOOK, a robot UUID for chatbots, or a contact ID for CONTACT.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;webhook-uuid-xxx&quot;]</para>
                /// </summary>
                [NameInMap("receivers")]
                [Validation(Required=false)]
                public List<string> Receivers { get; set; }

            }

            /// <summary>
            /// <para>The digital employee name. Required when enableRca is set to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>数字员工名</para>
            /// </summary>
            [NameInMap("digitalEmployeeName")]
            [Validation(Required=false)]
            public string DigitalEmployeeName { get; set; }

            /// <summary>
            /// <para>The effective time range.</para>
            /// </summary>
            [NameInMap("effectTimeRange")]
            [Validation(Required=false)]
            public NotifyStrategyConfigRoutesEffectTimeRange EffectTimeRange { get; set; }
            public class NotifyStrategyConfigRoutesEffectTimeRange : TeaModel {
                /// <summary>
                /// <para>The effective days. Valid values: 0 to 6 (0 = Sunday, 6 = Saturday). The value 7 is not supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[0,1,2,3,4,5,6]</para>
                /// </summary>
                [NameInMap("dayInWeek")]
                [Validation(Required=false)]
                public List<int?> DayInWeek { get; set; }

                /// <summary>
                /// <para>The end time of the day in minutes. Valid values: 0 to 1439.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1439</para>
                /// </summary>
                [NameInMap("endTimeInMinute")]
                [Validation(Required=false)]
                public int? EndTimeInMinute { get; set; }

                /// <summary>
                /// <para>The start time of the day in minutes. Valid values: 0 to 1438.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("startTimeInMinute")]
                [Validation(Required=false)]
                public int? StartTimeInMinute { get; set; }

                /// <summary>
                /// <para>The IANA time zone identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Asia/Shanghai</para>
                /// </summary>
                [NameInMap("timeZone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable Root Cause Analysis (RCA).</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enableRca")]
            [Validation(Required=false)]
            public bool? EnableRca { get; set; }

            /// <summary>
            /// <para>The route-level event filter conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("filterSetting")]
            [Validation(Required=false)]
            public FilterSetting FilterSetting { get; set; }

        }

    }

}
