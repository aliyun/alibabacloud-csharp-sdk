// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class NotifyStrategyForSNSView : TeaModel {
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("customTemplateEntries")]
        [Validation(Required=false)]
        public List<NotifyStrategyForSNSViewCustomTemplateEntries> CustomTemplateEntries { get; set; }
        public class NotifyStrategyForSNSViewCustomTemplateEntries : TeaModel {
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

        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("enableIncidentManagement")]
        [Validation(Required=false)]
        public bool? EnableIncidentManagement { get; set; }

        [NameInMap("groupingSetting")]
        [Validation(Required=false)]
        public NotifyStrategyForSNSViewGroupingSetting GroupingSetting { get; set; }
        public class NotifyStrategyForSNSViewGroupingSetting : TeaModel {
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

        [NameInMap("incidentResponsePlanId")]
        [Validation(Required=false)]
        public string IncidentResponsePlanId { get; set; }

        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("notifyStrategyId")]
        [Validation(Required=false)]
        public string NotifyStrategyId { get; set; }

        [NameInMap("notifyStrategyName")]
        [Validation(Required=false)]
        public string NotifyStrategyName { get; set; }

        [NameInMap("routes")]
        [Validation(Required=false)]
        public List<NotifyStrategyForSNSViewRoutes> Routes { get; set; }
        public class NotifyStrategyForSNSViewRoutes : TeaModel {
            [NameInMap("channels")]
            [Validation(Required=false)]
            public List<NotifyStrategyForSNSViewRoutesChannels> Channels { get; set; }
            public class NotifyStrategyForSNSViewRoutesChannels : TeaModel {
                [NameInMap("channelType")]
                [Validation(Required=false)]
                public string ChannelType { get; set; }

                [NameInMap("enabledSubChannels")]
                [Validation(Required=false)]
                public List<string> EnabledSubChannels { get; set; }

                [NameInMap("receivers")]
                [Validation(Required=false)]
                public List<string> Receivers { get; set; }

            }

            [NameInMap("digitalEmployeeName")]
            [Validation(Required=false)]
            public string DigitalEmployeeName { get; set; }

            [NameInMap("effectTimeRange")]
            [Validation(Required=false)]
            public NotifyStrategyForSNSViewRoutesEffectTimeRange EffectTimeRange { get; set; }
            public class NotifyStrategyForSNSViewRoutesEffectTimeRange : TeaModel {
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

            [NameInMap("enableRca")]
            [Validation(Required=false)]
            public bool? EnableRca { get; set; }

            [NameInMap("filterSetting")]
            [Validation(Required=false)]
            public FilterSetting FilterSetting { get; set; }

            [NameInMap("severities")]
            [Validation(Required=false)]
            public List<string> Severities { get; set; }

        }

        [NameInMap("syncFromType")]
        [Validation(Required=false)]
        public string SyncFromType { get; set; }

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
