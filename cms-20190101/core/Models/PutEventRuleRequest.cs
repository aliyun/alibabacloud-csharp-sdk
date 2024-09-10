// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutEventRuleRequest : TeaModel {
        /// <summary>
        /// The description of the event-triggered alert rule.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("EventPattern")]
        [Validation(Required=false)]
        public List<PutEventRuleRequestEventPattern> EventPattern { get; set; }
        public class PutEventRuleRequestEventPattern : TeaModel {
            /// <summary>
            /// The keyword that is used to filter events. If the content of an event contains the specified keyword, an alert is automatically triggered.
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
            /// The type of the cloud service. Valid values of N: 1 to 50.
            /// 
            /// >  You can call the DescribeSystemEventMetaList operation to query the cloud services that support event-triggered alerts. For more information, see [DescribeSystemEventMetaList](https://help.aliyun.com/document_detail/114972.html).
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// The SQL condition that is used to filter events. If the content of an event meets the specified SQL condition, an alert is automatically triggered.
            /// 
            /// >  The syntax of SQL event filtering is consistent with the query syntax of Log Service.
            /// </summary>
            [NameInMap("SQLFilter")]
            [Validation(Required=false)]
            public string SQLFilter { get; set; }

            [NameInMap("StatusList")]
            [Validation(Required=false)]
            public List<string> StatusList { get; set; }

        }

        /// <summary>
        /// The type of the event-triggered alert rule. Valid values:
        /// 
        /// *   SYSTEM: system event-triggered alert rule
        /// *   CUSTOM: custom event-triggered alert rule
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// The ID of the application group to which the event-triggered alert rule belongs.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the event-triggered alert rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The mute period during which new alerts are not sent even if the trigger conditions are met. Unit: seconds.
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
