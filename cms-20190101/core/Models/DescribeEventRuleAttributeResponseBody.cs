// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeEventRuleAttributeResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   true: The call was successful.
        /// *   false: The call failed.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The details of the event-triggered alert rule.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The type of the event. Valid values:
        /// 
        /// *   SYSTEM: system event
        /// *   CUSTOM: custom event
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The name of the event-triggered alert rule.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeEventRuleAttributeResponseBodyResult Result { get; set; }
        public class DescribeEventRuleAttributeResponseBodyResult : TeaModel {
            /// <summary>
            /// The status of the event-triggered alert rule. Valid values:
            /// 
            /// *   ENABLED: enabled
            /// *   DISABLED: disabled
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The status of the event.
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
                /// This topic provides an example on how to query the details of an event-triggered alert rule named `testRule`.
                /// </summary>
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
                /// The name of the event.
                /// </summary>
                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                /// <summary>
                /// For more information about common request parameters, see [Common parameters](~~199331~~).
                /// </summary>
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
            /// The ID of the application group.
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// The name of the cloud service.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// The event pattern. This parameter specifies the trigger conditions of an event.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The level of the event-triggered alert rule. Valid values:
            /// 
            /// *   CRITICAL: critical
            /// *   WARN: warning
            /// *   INFO: information
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// The description of the event-triggered alert rule.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
