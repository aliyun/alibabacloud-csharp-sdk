// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutEventRuleRequest : TeaModel {
        /// <summary>
        /// The operation that you want to perform. Set the value to **PutEventRule**.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EventPattern")]
        [Validation(Required=false)]
        public List<PutEventRuleRequestEventPattern> EventPattern { get; set; }
        public class PutEventRuleRequestEventPattern : TeaModel {
            /// <summary>
            /// The SQL condition that is used to filter events. If the content of an event meets the specified SQL condition, an alert is automatically triggered.
            /// 
            /// >  The syntax of SQL event filtering is consistent with the query syntax of Log Service.
            /// </summary>
            [NameInMap("CustomFilters")]
            [Validation(Required=false)]
            public string CustomFilters { get; set; }

            [NameInMap("EventTypeList")]
            [Validation(Required=false)]
            public List<string> EventTypeList { get; set; }

            [NameInMap("LevelList")]
            [Validation(Required=false)]
            public List<string> LevelList { get; set; }

            [NameInMap("NameList")]
            [Validation(Required=false)]
            public List<string> NameList { get; set; }

            /// <summary>
            /// The name of the event-triggered alert rule.
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// The description of the event-triggered alert rule.
            /// </summary>
            [NameInMap("SQLFilter")]
            [Validation(Required=false)]
            public string SQLFilter { get; set; }

            [NameInMap("StatusList")]
            [Validation(Required=false)]
            public List<string> StatusList { get; set; }

        }

        /// <summary>
        /// The type of the cloud service. Valid values of N: 1 to 50.
        /// 
        /// >  You can call the DescribeSystemEventMetaList operation to query the cloud services that support event-triggered alerts. For more information, see [DescribeSystemEventMetaList](~~114972~~).
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// The type of the event-triggered alert rule. Valid values of N: 1 to 50. Valid values:
        /// 
        /// *   StatusNotification: fault notifications
        /// *   Exception: exceptions
        /// *   Maintenance: O\&M
        /// *   \*: all types
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The number of event-triggered alert rules that were created or modified.
        /// </summary>
        [NameInMap("SilenceTime")]
        [Validation(Required=false)]
        public long? SilenceTime { get; set; }

        /// <summary>
        /// The status of the event-triggered alert rule. Valid values:
        /// 
        /// *   ENABLED: enabled
        /// *   DISABLED: disabled
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
