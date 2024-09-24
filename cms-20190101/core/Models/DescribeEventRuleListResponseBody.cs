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
        /// <para> The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The event-triggered alert rule.</para>
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
                /// <para>The description of the event-triggered alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Default group event rule.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The mode of the event-triggered alert rule.</para>
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
                        /// <para>The custom filter conditions.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ECS123</para>
                        /// </summary>
                        [NameInMap("CustomFilters")]
                        [Validation(Required=false)]
                        public string CustomFilters { get; set; }

                        /// <summary>
                        /// <para>The types of the event-triggered alert rules.</para>
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
                        /// <para>The keyword for filtering.</para>
                        /// </summary>
                        [NameInMap("KeywordFilter")]
                        [Validation(Required=false)]
                        public DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPatternKeywordFilter KeywordFilter { get; set; }
                        public class DescribeEventRuleListResponseBodyEventRulesEventRuleEventPatternEventPatternKeywordFilter : TeaModel {
                            /// <summary>
                            /// <para>The keywords that are used to match events.</para>
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
                            /// <para>The relationship between multiple keywords in a condition. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>OR: The relationship between keywords is OR.</description></item>
                            /// <item><description>NOT: The keyword is excluded. The value NOT indicates that all events that do not contain the keywords are matched.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>OR</para>
                            /// </summary>
                            [NameInMap("Relation")]
                            [Validation(Required=false)]
                            public string Relation { get; set; }

                        }

                        /// <summary>
                        /// <para>The levels of the event-triggered alerts.</para>
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
                        /// <para>The event names.</para>
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
                        /// <para>The abbreviation of the Alibaba Cloud service name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CloudMonitor</para>
                        /// </summary>
                        [NameInMap("Product")]
                        [Validation(Required=false)]
                        public string Product { get; set; }

                        /// <summary>
                        /// <para>Indicates that logs are filtered based on the specified SQL statement. If the specified conditions are met, an alert is triggered.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ycccluster1 and (i-23ij0o82612 or Executed1) or Asimulated not 222</para>
                        /// </summary>
                        [NameInMap("SQLFilter")]
                        [Validation(Required=false)]
                        public string SQLFilter { get; set; }

                    }

                }

                /// <summary>
                /// <para>The type of the event-triggered alert rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SYSTEM: system event-triggered alert rule</description></item>
                /// <item><description>CUSTOM: custom event-triggered alert rule</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM</para>
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                /// <summary>
                /// <para>The ID of the application group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7378****</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the event-triggered alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_DefaultEventRule_7378****</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The mute period during which new alert notifications are not sent even if the trigger conditions are met.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("SilenceTime")]
                [Validation(Required=false)]
                public long? SilenceTime { get; set; }

                /// <summary>
                /// <para>The status of the event-triggered alert rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ENABLED</description></item>
                /// <item><description>DISABLED</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ENABLED</para>
                /// </summary>
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
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
