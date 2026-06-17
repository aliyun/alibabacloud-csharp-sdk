// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeEventRuleListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para>The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
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
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EventPattern")]
                [Validation(Required=false)]
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

                        }

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

                        [NameInMap("LevelList")]
                        [Validation(Required=false)]
                        public DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPatternLevelList LevelList { get; set; }
                        public class DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPatternLevelList : TeaModel {
                            [NameInMap("LevelList")]
                            [Validation(Required=false)]
                            public List<string> LevelList { get; set; }

                        }

                        [NameInMap("NameList")]
                        [Validation(Required=false)]
                        public DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPatternNameList NameList { get; set; }
                        public class DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPatternNameList : TeaModel {
                            [NameInMap("NameList")]
                            [Validation(Required=false)]
                            public List<string> NameList { get; set; }

                        }

                        [NameInMap("Product")]
                        [Validation(Required=false)]
                        public string Product { get; set; }

                        [NameInMap("SQLFilter")]
                        [Validation(Required=false)]
                        public string SQLFilter { get; set; }

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

                [NameInMap("SilenceTime")]
                [Validation(Required=false)]
                public long? SilenceTime { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>User not authorized to operate on the specified resource.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0E6D82B-16B5-422A-8136-EE5BDC01E415</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
