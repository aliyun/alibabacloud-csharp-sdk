// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class NotifyStrategyForSNSModify : TeaModel {
        /// <summary>
        /// <para>The notification channel templates.</para>
        /// </summary>
        [NameInMap("customTemplateEntries")]
        [Validation(Required=false)]
        public List<NotifyStrategyForSNSModifyCustomTemplateEntries> CustomTemplateEntries { get; set; }
        public class NotifyStrategyForSNSModifyCustomTemplateEntries : TeaModel {
            /// <summary>
            /// <para><b>[Deprecated]</b> This parameter is deprecated and does not take effect. The actual purpose of the template is determined by the type field of the template object referenced by templateUuid.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DING</para>
            /// </summary>
            [NameInMap("targetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The UUID of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adef12efca3f-8728-1928-eeaac12ef9ad92</para>
            /// </summary>
            [NameInMap("templateUuid")]
            [Validation(Required=false)]
            public string TemplateUuid { get; set; }

        }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable incident management.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableIncidentManagement")]
        [Validation(Required=false)]
        public bool? EnableIncidentManagement { get; set; }

        /// <summary>
        /// <para>The grouping settings.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("groupingSetting")]
        [Validation(Required=false)]
        public NotifyStrategyForSNSModifyGroupingSetting GroupingSetting { get; set; }
        public class NotifyStrategyForSNSModifyGroupingSetting : TeaModel {
            /// <summary>
            /// <para>The grouping keys.</para>
            /// </summary>
            [NameInMap("groupingKeys")]
            [Validation(Required=false)]
            public List<string> GroupingKeys { get; set; }

            /// <summary>
            /// <para>The check period in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("periodMin")]
            [Validation(Required=false)]
            public int? PeriodMin { get; set; }

            /// <summary>
            /// <para>The silence duration in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("silenceSec")]
            [Validation(Required=false)]
            public int? SilenceSec { get; set; }

            /// <summary>
            /// <para>The number of times the condition is triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("times")]
            [Validation(Required=false)]
            public int? Times { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to send a notification when the alert is recovered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ignoreRestoredNotification")]
        [Validation(Required=false)]
        public bool? IgnoreRestoredNotification { get; set; }

        /// <summary>
        /// <para>The notification channel routing settings.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("routes")]
        [Validation(Required=false)]
        public List<NotifyStrategyForSNSModifyRoutes> Routes { get; set; }
        public class NotifyStrategyForSNSModifyRoutes : TeaModel {
            /// <summary>
            /// <para>The notification channels.</para>
            /// </summary>
            [NameInMap("channels")]
            [Validation(Required=false)]
            public List<NotifyStrategyForSNSModifyRoutesChannels> Channels { get; set; }
            public class NotifyStrategyForSNSModifyRoutesChannels : TeaModel {
                /// <summary>
                /// <para>The channel type.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DING</para>
                /// </summary>
                [NameInMap("channelType")]
                [Validation(Required=false)]
                public string ChannelType { get; set; }

                /// <summary>
                /// <para>The enabled notification types.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;EMAIL&quot;,&quot;SMS&quot;]</para>
                /// </summary>
                [NameInMap("enabledSubChannels")]
                [Validation(Required=false)]
                public List<string> EnabledSubChannels { get; set; }

                /// <summary>
                /// <para>The channel receivers.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;my-webhook-uuid&quot;]</para>
                /// </summary>
                [NameInMap("receivers")]
                [Validation(Required=false)]
                public List<string> Receivers { get; set; }

            }

            /// <summary>
            /// <para>The digital employee name.</para>
            /// </summary>
            [NameInMap("digitalEmployeeName")]
            [Validation(Required=false)]
            public string DigitalEmployeeName { get; set; }

            /// <summary>
            /// <para>The effective time range.</para>
            /// </summary>
            [NameInMap("effectTimeRange")]
            [Validation(Required=false)]
            public NotifyStrategyForSNSModifyRoutesEffectTimeRange EffectTimeRange { get; set; }
            public class NotifyStrategyForSNSModifyRoutesEffectTimeRange : TeaModel {
                /// <summary>
                /// <para>The effective days of the week (Monday through Sunday).</para>
                /// 
                /// <b>Example:</b>
                /// <para>[0,1,2,3,4,5,6]</para>
                /// </summary>
                [NameInMap("dayInWeek")]
                [Validation(Required=false)]
                public List<int?> DayInWeek { get; set; }

                /// <summary>
                /// <para>The end time in minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("endTimeInMinute")]
                [Validation(Required=false)]
                public int? EndTimeInMinute { get; set; }

                /// <summary>
                /// <para>The start time in minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>59</para>
                /// </summary>
                [NameInMap("startTimeInMinute")]
                [Validation(Required=false)]
                public int? StartTimeInMinute { get; set; }

                /// <summary>
                /// <para>The time zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Asia/Shanghai</para>
                /// </summary>
                [NameInMap("timeZone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable root cause analysis (RCA).</para>
            /// </summary>
            [NameInMap("enableRca")]
            [Validation(Required=false)]
            public bool? EnableRca { get; set; }

            /// <summary>
            /// <para>The route-level filter. This is different from the top-level subscription.filterSetting.</para>
            /// </summary>
            [NameInMap("filterSetting")]
            [Validation(Required=false)]
            public NotifyStrategyForSNSModifyRoutesFilterSetting FilterSetting { get; set; }
            public class NotifyStrategyForSNSModifyRoutesFilterSetting : TeaModel {
                /// <summary>
                /// <para>The subscription conditions.</para>
                /// </summary>
                [NameInMap("conditions")]
                [Validation(Required=false)]
                public List<NotifyStrategyForSNSModifyRoutesFilterSettingConditions> Conditions { get; set; }
                public class NotifyStrategyForSNSModifyRoutesFilterSettingConditions : TeaModel {
                    /// <summary>
                    /// <para>The JSON path of the field, such as labels._cms_rule_name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>subject</para>
                    /// </summary>
                    [NameInMap("field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    /// <summary>
                    /// <para>The comparison operator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>EQ</para>
                    /// </summary>
                    [NameInMap("op")]
                    [Validation(Required=false)]
                    public string Op { get; set; }

                    /// <summary>
                    /// <para>The value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Pod OOM</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>If expression is not empty, it takes precedence and relation is ignored. If expression is empty or not specified, the system uses relation (AND or OR) to perform a simple AND/OR operation on all conditions. Condition numbers correspond to the indexes of the conditions array (starting from 1). Each condition evaluates whether a single event field matches by using field (the event field path, which supports dot-separated nesting such as resource.tags.pod), op (the operator, such as CONTAIN, EQ, or IN), and value (the match value).</para>
                /// 
                /// <b>Example:</b>
                /// <para>(1 AND 2 )OR 3</para>
                /// </summary>
                [NameInMap("expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// <para>The relationship between conditions. If an expression is configured, the expression takes higher precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AND</para>
                /// </summary>
                [NameInMap("relation")]
                [Validation(Required=false)]
                public string Relation { get; set; }

            }

            /// <summary>
            /// <para><b>[Deprecated]</b> This parameter is deprecated and does not take effect. Route matching only checks filterSetting and effectTimeRange.</para>
            /// </summary>
            [NameInMap("severities")]
            [Validation(Required=false)]
            public List<string> Severities { get; set; }

        }

    }

}
