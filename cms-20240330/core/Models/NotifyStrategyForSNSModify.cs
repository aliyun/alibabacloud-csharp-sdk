// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class NotifyStrategyForSNSModify : TeaModel {
        [NameInMap("customTemplateEntries")]
        [Validation(Required=false)]
        public List<NotifyStrategyForSNSModifyCustomTemplateEntries> CustomTemplateEntries { get; set; }
        public class NotifyStrategyForSNSModifyCustomTemplateEntries : TeaModel {
            [NameInMap("targetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            [NameInMap("templateUuid")]
            [Validation(Required=false)]
            public string TemplateUuid { get; set; }

        }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("enableIncidentManagement")]
        [Validation(Required=false)]
        public bool? EnableIncidentManagement { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("groupingSetting")]
        [Validation(Required=false)]
        public NotifyStrategyForSNSModifyGroupingSetting GroupingSetting { get; set; }
        public class NotifyStrategyForSNSModifyGroupingSetting : TeaModel {
            [NameInMap("groupingKeys")]
            [Validation(Required=false)]
            public List<string> GroupingKeys { get; set; }

            [NameInMap("periodMin")]
            [Validation(Required=false)]
            public int? PeriodMin { get; set; }

            [NameInMap("silenceSec")]
            [Validation(Required=false)]
            public int? SilenceSec { get; set; }

            [NameInMap("times")]
            [Validation(Required=false)]
            public int? Times { get; set; }

        }

        [NameInMap("ignoreRestoredNotification")]
        [Validation(Required=false)]
        public bool? IgnoreRestoredNotification { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("routes")]
        [Validation(Required=false)]
        public List<NotifyStrategyForSNSModifyRoutes> Routes { get; set; }
        public class NotifyStrategyForSNSModifyRoutes : TeaModel {
            [NameInMap("channels")]
            [Validation(Required=false)]
            public List<NotifyStrategyForSNSModifyRoutesChannels> Channels { get; set; }
            public class NotifyStrategyForSNSModifyRoutesChannels : TeaModel {
                /// <summary>
                /// <para>The notification channel type. The value must be one of the following uppercase enum values: DING (DingTalk chatbot), WEIXIN (WeCom chatbot), FEISHU (Lark chatbot), SLACK, TEAMS, WEBHOOK (custom webhook), CONTACT (contact, requires enabledSubChannels to specify sub-channels), GROUP (contact group), DUTY (on-call schedule), or DING_COOL_APP (DingTalk Cool App). Note: Lowercase values such as EMAIL or SMS are not supported. To send email, text message, or voice notifications, set channelType to CONTACT and specify EMAIL, SMS, or VOICE in enabledSubChannels.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WEBHOOK</para>
                /// </summary>
                [NameInMap("channelType")]
                [Validation(Required=false)]
                public string ChannelType { get; set; }

                /// <summary>
                /// <para>Required only when channelType is CONTACT, GROUP, or DUTY. Valid values: EMAIL (email), SMS (text message), VOICE (voice call), DING (DingTalk work notification), WEIXIN (WeCom message), FEISHU (Lark message), and WEBHOOK. For example, to notify a contact by email and text message, set channelType to CONTACT and enabledSubChannels to [&quot;EMAIL&quot;,&quot;SMS&quot;]. This field is not required for other channelType values such as WEBHOOK or DING.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;EMAIL&quot;,&quot;SMS&quot;]</para>
                /// </summary>
                [NameInMap("enabledSubChannels")]
                [Validation(Required=false)]
                public List<string> EnabledSubChannels { get; set; }

                /// <summary>
                /// <para>The list of receiver identifiers. For the WEBHOOK type, specify the webhook UUID. For DING, WEIXIN, or FEISHU, specify the chatbot UUID. For CONTACT, specify the contact ID. For GROUP, specify the contact group ID. For DUTY, specify the on-call schedule UUID. At least one element is required.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;my-webhook-uuid&quot;]</para>
                /// </summary>
                [NameInMap("receivers")]
                [Validation(Required=false)]
                public List<string> Receivers { get; set; }

            }

            [NameInMap("digitalEmployeeName")]
            [Validation(Required=false)]
            public string DigitalEmployeeName { get; set; }

            /// <summary>
            /// <para>The effective period settings for notifications. Defines on which days and during which time range the system sends notifications.</para>
            /// </summary>
            [NameInMap("effectTimeRange")]
            [Validation(Required=false)]
            public NotifyStrategyForSNSModifyRoutesEffectTimeRange EffectTimeRange { get; set; }
            public class NotifyStrategyForSNSModifyRoutesEffectTimeRange : TeaModel {
                /// <summary>
                /// <para>The days of the week on which the setting takes effect. Array element values range from 0 to 6 (0 = Sunday, 1 = Monday, 2 = Tuesday, ... 6 = Saturday). Note: The value 7 is not supported. The maximum value is 6. Example for all days: [0,1,2,3,4,5,6]. Example for weekdays only: [1,2,3,4,5].</para>
                /// 
                /// <b>Example:</b>
                /// <para>[0,1,2,3,4,5,6]</para>
                /// </summary>
                [NameInMap("dayInWeek")]
                [Validation(Required=false)]
                public List<int?> DayInWeek { get; set; }

                /// <summary>
                /// <para>The end time of the day, expressed as the number of minutes from 00:00. Valid values: 0 to 1439 (23 × 60 + 59 = 1439, which represents 23:59).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1439</para>
                /// </summary>
                [NameInMap("endTimeInMinute")]
                [Validation(Required=false)]
                public int? EndTimeInMinute { get; set; }

                /// <summary>
                /// <para>The start time of the day, expressed as the number of minutes from 00:00. Valid values: 0 to 1439 (0 represents 00:00).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("startTimeInMinute")]
                [Validation(Required=false)]
                public int? StartTimeInMinute { get; set; }

                /// <summary>
                /// <para>The IANA time zone identifier, such as Asia/Shanghai or America/Los_Angeles.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Asia/Shanghai</para>
                /// </summary>
                [NameInMap("timeZone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

            }

            [NameInMap("enableRca")]
            [Validation(Required=false)]
            public bool? EnableRca { get; set; }

            [NameInMap("filterSetting")]
            [Validation(Required=false)]
            public NotifyStrategyForSNSModifyRoutesFilterSetting FilterSetting { get; set; }
            public class NotifyStrategyForSNSModifyRoutesFilterSetting : TeaModel {
                [NameInMap("conditions")]
                [Validation(Required=false)]
                public List<NotifyStrategyForSNSModifyRoutesFilterSettingConditions> Conditions { get; set; }
                public class NotifyStrategyForSNSModifyRoutesFilterSettingConditions : TeaModel {
                    [NameInMap("field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    [NameInMap("op")]
                    [Validation(Required=false)]
                    public string Op { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                [NameInMap("relation")]
                [Validation(Required=false)]
                public string Relation { get; set; }

            }

            [NameInMap("severities")]
            [Validation(Required=false)]
            public List<string> Severities { get; set; }

        }

    }

}
