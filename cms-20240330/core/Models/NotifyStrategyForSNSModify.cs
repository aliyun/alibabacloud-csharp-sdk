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
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("channelType")]
                [Validation(Required=false)]
                public string ChannelType { get; set; }

                [NameInMap("enabledSubChannels")]
                [Validation(Required=false)]
                public List<string> EnabledSubChannels { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("receivers")]
                [Validation(Required=false)]
                public List<string> Receivers { get; set; }

            }

            [NameInMap("effectTimeRange")]
            [Validation(Required=false)]
            public NotifyStrategyForSNSModifyRoutesEffectTimeRange EffectTimeRange { get; set; }
            public class NotifyStrategyForSNSModifyRoutesEffectTimeRange : TeaModel {
                [NameInMap("dayInWeek")]
                [Validation(Required=false)]
                public List<int?> DayInWeek { get; set; }

                [NameInMap("endTimeInMinute")]
                [Validation(Required=false)]
                public int? EndTimeInMinute { get; set; }

                [NameInMap("startTimeInMinute")]
                [Validation(Required=false)]
                public int? StartTimeInMinute { get; set; }

                [NameInMap("timeZone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

            }

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
