// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeEventRuleAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <remarks>
        /// <para>200 indicates success.</para>
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
            /// <para>The event pattern. Describes the trigger conditions of the event.</para>
            /// </summary>
            [NameInMap("EventPattern")]
            [Validation(Required=false)]
            public DescribeEventRuleAttributeResponseBodyResultEventPattern EventPattern { get; set; }
            public class DescribeEventRuleAttributeResponseBodyResultEventPattern : TeaModel {
                [NameInMap("EventTypeList")]
                [Validation(Required=false)]
                public DescribeEventRuleAttributeResponseBodyResultEventPatternEventTypeList EventTypeList { get; set; }
                public class DescribeEventRuleAttributeResponseBodyResultEventPatternEventTypeList : TeaModel {
                    [NameInMap("EventTypeList")]
                    [Validation(Required=false)]
                    public List<string> EventTypeList { get; set; }

                }

                /// <summary>
                /// <para>The filter keyword.</para>
                /// </summary>
                [NameInMap("KeywordFilterObj")]
                [Validation(Required=false)]
                public DescribeEventRuleAttributeResponseBodyResultEventPatternKeywordFilterObj KeywordFilterObj { get; set; }
                public class DescribeEventRuleAttributeResponseBodyResultEventPatternKeywordFilterObj : TeaModel {
                    [NameInMap("Keywords")]
                    [Validation(Required=false)]
                    public DescribeEventRuleAttributeResponseBodyResultEventPatternKeywordFilterObjKeywords Keywords { get; set; }
                    public class DescribeEventRuleAttributeResponseBodyResultEventPatternKeywordFilterObjKeywords : TeaModel {
                        [NameInMap("keyword")]
                        [Validation(Required=false)]
                        public List<string> Keyword { get; set; }

                    }

                    /// <summary>
                    /// <para>The condition for multiple keywords. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>OR: The relationship between multiple keywords is OR.</description></item>
                    /// <item><description>NOT: Does not contain the keyword. Matches all events that are not in the keyword list.</description></item>
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
                /// <para>Filters logs by using SQL statements. An alert is triggered if the filter conditions are met.</para>
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
            /// <item><description><para>SYSTEM: system event.</para>
            /// </description></item>
            /// <item><description><para>CUSTOM: custom event.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>The application group ID.</para>
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
            /// <item><description><para>ENABLED: enabled.</para>
            /// </description></item>
            /// <item><description><para>DISABLED: disabled.</para>
            /// </description></item>
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
        /// <para>Indicates whether the operation was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The operation was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The operation failed.</para>
        /// </description></item>
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
