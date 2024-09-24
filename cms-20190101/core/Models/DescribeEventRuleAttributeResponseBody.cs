// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeEventRuleAttributeResponseBody : TeaModel {
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
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The alert does not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AA3F210-C03D-4C86-8DB6-21C84FF692A1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the event-triggered alert rule.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeEventRuleAttributeResponseBodyResult Result { get; set; }
        public class DescribeEventRuleAttributeResponseBodyResult : TeaModel {
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
            /// <para>The event pattern. This parameter describes the trigger conditions of an event.</para>
            /// </summary>
            [NameInMap("EventPattern")]
            [Validation(Required=false)]
            public DescribeEventRuleAttributeResponseBodyResultEventPattern EventPattern { get; set; }
            public class DescribeEventRuleAttributeResponseBodyResultEventPattern : TeaModel {
                /// <summary>
                /// <para>The types of the event-triggered alert rules.</para>
                /// </summary>
                [NameInMap("EventTypeList")]
                [Validation(Required=false)]
                public DescribeEventRuleAttributeResponseBodyResultEventPatternEventTypeList EventTypeList { get; set; }
                public class DescribeEventRuleAttributeResponseBodyResultEventPatternEventTypeList : TeaModel {
                    [NameInMap("EventTypeList")]
                    [Validation(Required=false)]
                    public List<string> EventTypeList { get; set; }

                }

                /// <summary>
                /// <para>The keyword for filtering.</para>
                /// </summary>
                [NameInMap("KeywordFilterObj")]
                [Validation(Required=false)]
                public DescribeEventRuleAttributeResponseBodyResultEventPatternKeywordFilterObj KeywordFilterObj { get; set; }
                public class DescribeEventRuleAttributeResponseBodyResultEventPatternKeywordFilterObj : TeaModel {
                    /// <summary>
                    /// <para>The keywords that are used to match events.</para>
                    /// </summary>
                    [NameInMap("Keywords")]
                    [Validation(Required=false)]
                    public DescribeEventRuleAttributeResponseBodyResultEventPatternKeywordFilterObjKeywords Keywords { get; set; }
                    public class DescribeEventRuleAttributeResponseBodyResultEventPatternKeywordFilterObjKeywords : TeaModel {
                        [NameInMap("keyword")]
                        [Validation(Required=false)]
                        public List<string> Keyword { get; set; }

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

                [NameInMap("LevelList")]
                [Validation(Required=false)]
                public DescribeEventRuleAttributeResponseBodyResultEventPatternLevelList LevelList { get; set; }
                public class DescribeEventRuleAttributeResponseBodyResultEventPatternLevelList : TeaModel {
                    [NameInMap("LevelList")]
                    [Validation(Required=false)]
                    public List<string> LevelList { get; set; }

                }

                [NameInMap("NameList")]
                [Validation(Required=false)]
                public DescribeEventRuleAttributeResponseBodyResultEventPatternNameList NameList { get; set; }
                public class DescribeEventRuleAttributeResponseBodyResultEventPatternNameList : TeaModel {
                    [NameInMap("NameList")]
                    [Validation(Required=false)]
                    public List<string> NameList { get; set; }

                }

                /// <summary>
                /// <para>The name of the cloud service.</para>
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

                [NameInMap("StatusList")]
                [Validation(Required=false)]
                public DescribeEventRuleAttributeResponseBodyResultEventPatternStatusList StatusList { get; set; }
                public class DescribeEventRuleAttributeResponseBodyResultEventPatternStatusList : TeaModel {
                    [NameInMap("StatusList")]
                    [Validation(Required=false)]
                    public List<string> StatusList { get; set; }

                }

            }

            /// <summary>
            /// <para>The event type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SYSTEM: system event</description></item>
            /// <item><description>CUSTOM: custom event</description></item>
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
            /// <para>3607****</para>
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

    }

}
