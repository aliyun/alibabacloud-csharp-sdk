// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class NotificationStrategy : TeaModel {
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EscalationSetting")]
        [Validation(Required=false)]
        public NotificationStrategyEscalationSetting EscalationSetting { get; set; }
        public class NotificationStrategyEscalationSetting : TeaModel {
            [NameInMap("AutoResolveMin")]
            [Validation(Required=false)]
            public long? AutoResolveMin { get; set; }

            [NameInMap("CustomChannels")]
            [Validation(Required=false)]
            public List<NotificationStrategyEscalationSettingCustomChannels> CustomChannels { get; set; }
            public class NotificationStrategyEscalationSettingCustomChannels : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("ChannelType")]
                [Validation(Required=false)]
                public string ChannelType { get; set; }

                [NameInMap("Severities")]
                [Validation(Required=false)]
                public List<string> Severities { get; set; }

                [NameInMap("TemplateUuid")]
                [Validation(Required=false)]
                public string TemplateUuid { get; set; }

            }

            [NameInMap("EscalationLevel")]
            [Validation(Required=false)]
            public string EscalationLevel { get; set; }

            [NameInMap("EscalationUuid")]
            [Validation(Required=false)]
            public string EscalationUuid { get; set; }

            [NameInMap("Range")]
            [Validation(Required=false)]
            public string Range { get; set; }

            [NameInMap("RetriggerMin")]
            [Validation(Required=false)]
            public long? RetriggerMin { get; set; }

        }

        [NameInMap("FilterSetting")]
        [Validation(Required=false)]
        public NotificationStrategyFilterSetting FilterSetting { get; set; }
        public class NotificationStrategyFilterSetting : TeaModel {
            [NameInMap("BlackList")]
            [Validation(Required=false)]
            public List<List<NotificationStrategyFilterSettingBlackList>> BlackList { get; set; }
            public class NotificationStrategyFilterSettingBlackList : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Field")]
                [Validation(Required=false)]
                public string Field { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Op")]
                [Validation(Required=false)]
                public string Op { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("WhiteList")]
            [Validation(Required=false)]
            public List<List<NotificationStrategyFilterSettingWhiteList>> WhiteList { get; set; }
            public class NotificationStrategyFilterSettingWhiteList : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Field")]
                [Validation(Required=false)]
                public string Field { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Op")]
                [Validation(Required=false)]
                public string Op { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("GroupingSetting")]
        [Validation(Required=false)]
        public NotificationStrategyGroupingSetting GroupingSetting { get; set; }
        public class NotificationStrategyGroupingSetting : TeaModel {
            [NameInMap("EnableRawAlertDispatching")]
            [Validation(Required=false)]
            public bool? EnableRawAlertDispatching { get; set; }

            [NameInMap("GroupingItems")]
            [Validation(Required=false)]
            public List<NotificationStrategyGroupingSettingGroupingItems> GroupingItems { get; set; }
            public class NotificationStrategyGroupingSettingGroupingItems : TeaModel {
                [NameInMap("Keys")]
                [Validation(Required=false)]
                public List<string> Keys { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("PeriodMin")]
            [Validation(Required=false)]
            public int? PeriodMin { get; set; }

            [NameInMap("SilenceSec")]
            [Validation(Required=false)]
            public int? SilenceSec { get; set; }

            [NameInMap("Times")]
            [Validation(Required=false)]
            public int? Times { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        [NameInMap("PushingSetting")]
        [Validation(Required=false)]
        public NotificationStrategyPushingSetting PushingSetting { get; set; }
        public class NotificationStrategyPushingSetting : TeaModel {
            [NameInMap("PushingDataFormat")]
            [Validation(Required=false)]
            public string PushingDataFormat { get; set; }

            [NameInMap("Range")]
            [Validation(Required=false)]
            public string Range { get; set; }

            [NameInMap("TargetUuids")]
            [Validation(Required=false)]
            public List<string> TargetUuids { get; set; }

            [NameInMap("TemplateUuid")]
            [Validation(Required=false)]
            public string TemplateUuid { get; set; }

        }

        [NameInMap("RouteSetting")]
        [Validation(Required=false)]
        public NotificationStrategyRouteSetting RouteSetting { get; set; }
        public class NotificationStrategyRouteSetting : TeaModel {
            [NameInMap("Routes")]
            [Validation(Required=false)]
            public List<NotificationStrategyRouteSettingRoutes> Routes { get; set; }
            public class NotificationStrategyRouteSettingRoutes : TeaModel {
                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<NotificationStrategyRouteSettingRoutesConditions> Conditions { get; set; }
                public class NotificationStrategyRouteSettingRoutesConditions : TeaModel {
                    [NameInMap("Field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    [NameInMap("Op")]
                    [Validation(Required=false)]
                    public string Op { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("EscalationUuid")]
                [Validation(Required=false)]
                public string EscalationUuid { get; set; }

            }

        }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
