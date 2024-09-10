// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeEventRuleAttributeResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The error message.
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
        /// The details of the event-triggered alert rule.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeEventRuleAttributeResponseBodyResult Result { get; set; }
        public class DescribeEventRuleAttributeResponseBodyResult : TeaModel {
            /// <summary>
            /// The description of the event-triggered alert rule.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The event pattern. This parameter describes the trigger conditions of an event.
            /// </summary>
            [NameInMap("EventPattern")]
            [Validation(Required=false)]
            public DescribeEventRuleAttributeResponseBodyResultEventPattern EventPattern { get; set; }
            public class DescribeEventRuleAttributeResponseBodyResultEventPattern : TeaModel {
                /// <summary>
                /// The types of the event-triggered alert rules.
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
                /// The keyword for filtering.
                /// </summary>
                [NameInMap("KeywordFilterObj")]
                [Validation(Required=false)]
                public DescribeEventRuleAttributeResponseBodyResultEventPatternKeywordFilterObj KeywordFilterObj { get; set; }
                public class DescribeEventRuleAttributeResponseBodyResultEventPatternKeywordFilterObj : TeaModel {
                    /// <summary>
                    /// The keywords that are used to match events.
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
                    /// The relationship between multiple keywords in a condition. Valid values:
                    /// 
                    /// *   OR: The relationship between keywords is OR.
                    /// *   NOT: The keyword is excluded. The value NOT indicates that all events that do not contain the keywords are matched.
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
                /// The name of the cloud service.
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
            /// The event type. Valid values:
            /// 
            /// *   SYSTEM: system event
            /// *   CUSTOM: custom event
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
            /// The status of the event-triggered alert rule. Valid values:
            /// 
            /// *   ENABLED
            /// *   DISABLED
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
