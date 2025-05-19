// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20180308.Models
{
    public class ListEventRulesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Datapoints")]
        [Validation(Required=false)]
        public ListEventRulesResponseBodyDatapoints Datapoints { get; set; }
        public class ListEventRulesResponseBodyDatapoints : TeaModel {
            [NameInMap("EventRule")]
            [Validation(Required=false)]
            public List<ListEventRulesResponseBodyDatapointsEventRule> EventRule { get; set; }
            public class ListEventRulesResponseBodyDatapointsEventRule : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EventPattern")]
                [Validation(Required=false)]
                public ListEventRulesResponseBodyDatapointsEventRuleEventPattern EventPattern { get; set; }
                public class ListEventRulesResponseBodyDatapointsEventRuleEventPattern : TeaModel {
                    [NameInMap("EventPattern")]
                    [Validation(Required=false)]
                    public List<ListEventRulesResponseBodyDatapointsEventRuleEventPatternEventPattern> EventPattern { get; set; }
                    public class ListEventRulesResponseBodyDatapointsEventRuleEventPatternEventPattern : TeaModel {
                        [NameInMap("EventTypeList")]
                        [Validation(Required=false)]
                        public ListEventRulesResponseBodyDatapointsEventRuleEventPatternEventPatternEventTypeList EventTypeList { get; set; }
                        public class ListEventRulesResponseBodyDatapointsEventRuleEventPatternEventPatternEventTypeList : TeaModel {
                            [NameInMap("EventTypeList")]
                            [Validation(Required=false)]
                            public List<string> EventTypeList { get; set; }

                        }

                        [NameInMap("LevelList")]
                        [Validation(Required=false)]
                        public ListEventRulesResponseBodyDatapointsEventRuleEventPatternEventPatternLevelList LevelList { get; set; }
                        public class ListEventRulesResponseBodyDatapointsEventRuleEventPatternEventPatternLevelList : TeaModel {
                            [NameInMap("LevelList")]
                            [Validation(Required=false)]
                            public List<string> LevelList { get; set; }

                        }

                        [NameInMap("NameList")]
                        [Validation(Required=false)]
                        public ListEventRulesResponseBodyDatapointsEventRuleEventPatternEventPatternNameList NameList { get; set; }
                        public class ListEventRulesResponseBodyDatapointsEventRuleEventPatternEventPatternNameList : TeaModel {
                            [NameInMap("NameList")]
                            [Validation(Required=false)]
                            public List<string> NameList { get; set; }

                        }

                        [NameInMap("Product")]
                        [Validation(Required=false)]
                        public string Product { get; set; }

                        [NameInMap("StatusList")]
                        [Validation(Required=false)]
                        public ListEventRulesResponseBodyDatapointsEventRuleEventPatternEventPatternStatusList StatusList { get; set; }
                        public class ListEventRulesResponseBodyDatapointsEventRuleEventPatternEventPatternStatusList : TeaModel {
                            [NameInMap("StatusList")]
                            [Validation(Required=false)]
                            public List<string> StatusList { get; set; }

                        }

                    }

                }

                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
