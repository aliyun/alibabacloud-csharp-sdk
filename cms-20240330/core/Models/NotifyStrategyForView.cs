// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class NotifyStrategyForView : TeaModel {
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("customTemplateEntries")]
        [Validation(Required=false)]
        public List<NotifyStrategyForViewCustomTemplateEntries> CustomTemplateEntries { get; set; }
        public class NotifyStrategyForViewCustomTemplateEntries : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("targetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("templateUuid")]
            [Validation(Required=false)]
            public string TemplateUuid { get; set; }

        }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("groupingSetting")]
        [Validation(Required=false)]
        public NotifyStrategyForViewGroupingSetting GroupingSetting { get; set; }
        public class NotifyStrategyForViewGroupingSetting : TeaModel {
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

        [NameInMap("notifyStrategyId")]
        [Validation(Required=false)]
        public string NotifyStrategyId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("notifyStrategyName")]
        [Validation(Required=false)]
        public string NotifyStrategyName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("routes")]
        [Validation(Required=false)]
        public List<NotifyStrategyForViewRoutes> Routes { get; set; }
        public class NotifyStrategyForViewRoutes : TeaModel {
            [NameInMap("channels")]
            [Validation(Required=false)]
            public List<NotifyStrategyForViewRoutesChannels> Channels { get; set; }
            public class NotifyStrategyForViewRoutesChannels : TeaModel {
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
            public NotifyStrategyForViewRoutesEffectTimeRange EffectTimeRange { get; set; }
            public class NotifyStrategyForViewRoutesEffectTimeRange : TeaModel {
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
            public FilterSetting FilterSetting { get; set; }

            [NameInMap("severities")]
            [Validation(Required=false)]
            public List<string> Severities { get; set; }

        }

        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
