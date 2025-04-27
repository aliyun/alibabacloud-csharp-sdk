// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCInstanceHistoryEventsRequest : TeaModel {
        [NameInMap("EventPublishTime")]
        [Validation(Required=false)]
        public DescribeRCInstanceHistoryEventsRequestEventPublishTime EventPublishTime { get; set; }
        public class DescribeRCInstanceHistoryEventsRequestEventPublishTime : TeaModel {
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            [NameInMap("Start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        [NameInMap("NotBefore")]
        [Validation(Required=false)]
        public DescribeRCInstanceHistoryEventsRequestNotBefore NotBefore { get; set; }
        public class DescribeRCInstanceHistoryEventsRequestNotBefore : TeaModel {
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2017-11-30T06:32:31Z</para>
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        [NameInMap("EventCycleStatus")]
        [Validation(Required=false)]
        public string EventCycleStatus { get; set; }

        [NameInMap("EventId")]
        [Validation(Required=false)]
        public List<string> EventId { get; set; }

        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        [NameInMap("ImpactLevel")]
        [Validation(Required=false)]
        public string ImpactLevel { get; set; }

        [NameInMap("InstanceEventCycleStatus")]
        [Validation(Required=false)]
        public List<string> InstanceEventCycleStatus { get; set; }

        [NameInMap("InstanceEventType")]
        [Validation(Required=false)]
        public List<string> InstanceEventType { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeRCInstanceHistoryEventsRequestTag> Tag { get; set; }
        public class DescribeRCInstanceHistoryEventsRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
