// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeEventRuleListResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The event-triggered alert rule.
        /// </summary>
        [NameInMap("EventRules")]
        [Validation(Required=false)]
        public DescribeEventRuleListResponseBodyEventRules EventRules { get; set; }
        public class DescribeEventRuleListResponseBodyEventRules : TeaModel {
            [NameInMap("EventRule")]
            [Validation(Required=false)]
            public List<DescribeEventRuleListResponseBodyEventRulesEventRule> EventRule { get; set; }
            public class DescribeEventRuleListResponseBodyEventRulesEventRule : TeaModel {
                /// <summary>
                /// The description of the event-triggered alert rule.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The mode of the event-triggered alert rule.
                /// </summary>
                [NameInMap("EventPattern")]
                [Validation(Required=false)]
                public DescribeEventRuleListResponseBodyEventRulesEventRuleEventPattern EventPattern { get; set; }
                public class DescribeEventRuleListResponseBodyEventRulesEventRuleEventPattern : TeaModel {
                    [NameInMap("EventPattern")]
                    [Validation(Required=false)]
                    public List<DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPattern> EventPattern { get; set; }
                    public class DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPattern : TeaModel {
                        /// <summary>
                        /// The custom filter conditions.
                        /// </summary>
                        [NameInMap("CustomFilters")]
                        [Validation(Required=false)]
                        public string CustomFilters { get; set; }

                        /// <summary>
                        /// The types of the event-triggered alert rules.
                        /// </summary>
                        [NameInMap("EventTypeList")]
                        [Validation(Required=false)]
                        public DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPatternEventTypeList EventTypeList { get; set; }
                        public class DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPatternEventTypeList : TeaModel {
                            [NameInMap("EventTypeList")]
                            [Validation(Required=false)]
                            public List<string> EventTypeList { get; set; }

                        }

                        /// <summary>
                        /// The keyword for filtering.
                        /// </summary>
                        [NameInMap("KeywordFilter")]
                        [Validation(Required=false)]
                        public DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPatternKeywordFilter KeywordFilter { get; set; }
                        public class DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPatternKeywordFilter : TeaModel {
                            /// <summary>
                            /// The keywords that are used to match events.
                            /// </summary>
                            [NameInMap("Keywords")]
                            [Validation(Required=false)]
                            public DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPatternKeywordFilterKeywords Keywords { get; set; }
                            public class DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPatternKeywordFilterKeywords : TeaModel {
                                [NameInMap("Keywords")]
                                [Validation(Required=false)]
                                public List<string> Keywords { get; set; }

                            }

                            /// <summary>
                            /// The relationship between multiple keywords in a condition. Valid values:
                            /// 
                            /// *   OR: The relationship between keywords is OR.
                            /// *   NOT: The keyword is excluded. The value NOT indicates that all events that do not contain the keywords are matched.
                            /// </summary>
                            [NameInMap("Relation")]
                            [Validation(Required=false)]
                            public string Relation { get; set; }

                        }

                        /// <summary>
                        /// The levels of the event-triggered alerts.
                        /// </summary>
                        [NameInMap("LevelList")]
                        [Validation(Required=false)]
                        public DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPatternLevelList LevelList { get; set; }
                        public class DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPatternLevelList : TeaModel {
                            [NameInMap("LevelList")]
                            [Validation(Required=false)]
                            public List<string> LevelList { get; set; }

                        }

                        /// <summary>
                        /// The event names.
                        /// </summary>
                        [NameInMap("NameList")]
                        [Validation(Required=false)]
                        public DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPatternNameList NameList { get; set; }
                        public class DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPatternNameList : TeaModel {
                            [NameInMap("NameList")]
                            [Validation(Required=false)]
                            public List<string> NameList { get; set; }

                        }

                        /// <summary>
                        /// The abbreviation of the Alibaba Cloud service name.
                        /// </summary>
                        [NameInMap("Product")]
                        [Validation(Required=false)]
                        public string Product { get; set; }

                        /// <summary>
                        /// Indicates that logs are filtered based on the specified SQL statement. If the specified conditions are met, an alert is triggered.
                        /// </summary>
                        [NameInMap("SQLFilter")]
                        [Validation(Required=false)]
                        public string SQLFilter { get; set; }

                    }

                }

                /// <summary>
                /// The type of the event-triggered alert rule. Valid values:
                /// 
                /// *   SYSTEM: system event-triggered alert rule
                /// *   CUSTOM: custom event-triggered alert rule
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                /// <summary>
                /// The ID of the application group.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The name of the event-triggered alert rule.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The mute period during which new alert notifications are not sent even if the trigger conditions are met.
                /// </summary>
                [NameInMap("SilenceTime")]
                [Validation(Required=false)]
                public long? SilenceTime { get; set; }

                /// <summary>
                /// The status of the event-triggered alert rule. Valid values:
                /// 
                /// *   ENABLED
                /// *   DISABLED
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
