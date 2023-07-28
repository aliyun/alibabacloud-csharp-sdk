// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeEventRuleListResponseBody : TeaModel {
        /// <summary>
        /// The prefix in the name of the event-triggered alert rule.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// Pages start from page 1. Default value: 1.
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
                /// The filter keyword.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the application group.
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
                        /// The ID of the request.
                        /// </summary>
                        [NameInMap("CustomFilters")]
                        [Validation(Required=false)]
                        public string CustomFilters { get; set; }

                        /// <summary>
                        /// The keywords that are used to match events.
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
                        /// Queries event-triggered alert rules.
                        /// </summary>
                        [NameInMap("KeywordFilter")]
                        [Validation(Required=false)]
                        public DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPatternKeywordFilter KeywordFilter { get; set; }
                        public class DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPatternKeywordFilter : TeaModel {
                            [NameInMap("Keywords")]
                            [Validation(Required=false)]
                            public DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPatternKeywordFilterKeywords Keywords { get; set; }
                            public class DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPatternKeywordFilterKeywords : TeaModel {
                                [NameInMap("Keywords")]
                                [Validation(Required=false)]
                                public List<string> Keywords { get; set; }

                            }

                            [NameInMap("Relation")]
                            [Validation(Required=false)]
                            public string Relation { get; set; }

                        }

                        /// <summary>
                        /// The type of the event-triggered alert rule.
                        /// 
                        /// `*` indicates all types of alert rules.
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
                        /// Indicates that logs are filtered based on the specified SQL statement. If the specified conditions are met, an alert is triggered.
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
                        /// The ID of the application group.
                        /// </summary>
                        [NameInMap("Product")]
                        [Validation(Required=false)]
                        public string Product { get; set; }

                        [NameInMap("SQLFilter")]
                        [Validation(Required=false)]
                        public string SQLFilter { get; set; }

                    }

                }

                /// <summary>
                /// The mode of the event-triggered alert rule.
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                /// <summary>
                /// The number of entries to return on each page.
                /// 
                /// A minimum of one entry can be returned on each page. Default value: 10.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The relationship between multiple keywords in a condition. Valid values:
                /// 
                /// *   OR: The relationship between keywords is OR.
                /// *   NOT: The keyword is excluded. The value NOT indicates that all events that do not contain the keywords are matched.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("SilenceTime")]
                [Validation(Required=false)]
                public long? SilenceTime { get; set; }

                /// <summary>
                /// The level of the event. Valid values:
                /// 
                /// *   CRITICAL: critical
                /// *   WARN: warning
                /// *   INFO: information
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        /// <summary>
        /// The event-triggered alert rules.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The name of the event-triggered alert rule.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The list of event names.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
