// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeEventRuleListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("EventRules")]
        [Validation(Required=false)]
        public DescribeEventRuleListResponseBodyEventRules EventRules { get; set; }
        public class DescribeEventRuleListResponseBodyEventRules : TeaModel {
            [NameInMap("EventRule")]
            [Validation(Required=false)]
            public List<DescribeEventRuleListResponseBodyEventRulesEventRule> EventRule { get; set; }
            public class DescribeEventRuleListResponseBodyEventRulesEventRule : TeaModel {
                public string Description { get; set; }
                public DescribeEventRuleListResponseBodyEventRulesEventRuleEventPattern EventPattern { get; set; }
                public class DescribeEventRuleListResponseBodyEventRulesEventRuleEventPattern : TeaModel {
                    [NameInMap("EventPattern")]
                    [Validation(Required=false)]
                    public List<DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPattern> EventPattern { get; set; }
                    public class DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPattern : TeaModel {
                        [NameInMap("CustomFilters")]
                        [Validation(Required=false)]
                        public string CustomFilters { get; set; }

                        [NameInMap("EventTypeList")]
                        [Validation(Required=false)]
                        public DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPatternEventTypeList EventTypeList { get; set; }
                        public class DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPatternEventTypeList : TeaModel {
                            [NameInMap("EventTypeList")]
                            [Validation(Required=false)]
                            public List<string> EventTypeList { get; set; }
                        };

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
                        };

                        [NameInMap("LevelList")]
                        [Validation(Required=false)]
                        public DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPatternLevelList LevelList { get; set; }
                        public class DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPatternLevelList : TeaModel {
                            [NameInMap("LevelList")]
                            [Validation(Required=false)]
                            public List<string> LevelList { get; set; }
                        };

                        [NameInMap("NameList")]
                        [Validation(Required=false)]
                        public DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPatternNameList NameList { get; set; }
                        public class DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPatternNameList : TeaModel {
                            [NameInMap("NameList")]
                            [Validation(Required=false)]
                            public List<string> NameList { get; set; }
                        };

                        [NameInMap("Product")]
                        [Validation(Required=false)]
                        public string Product { get; set; }

                        [NameInMap("SQLFilter")]
                        [Validation(Required=false)]
                        public string SQLFilter { get; set; }

                    }

                }
                public string EventType { get; set; }
                public string GroupId { get; set; }
                public string Name { get; set; }
                public long? SilenceTime { get; set; }
                public string State { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
