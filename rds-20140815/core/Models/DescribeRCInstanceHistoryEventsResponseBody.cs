// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCInstanceHistoryEventsResponseBody : TeaModel {
        [NameInMap("InstanceSystemEventSet")]
        [Validation(Required=false)]
        public List<DescribeRCInstanceHistoryEventsResponseBodyInstanceSystemEventSet> InstanceSystemEventSet { get; set; }
        public class DescribeRCInstanceHistoryEventsResponseBodyInstanceSystemEventSet : TeaModel {
            [NameInMap("EventCycleStatus")]
            [Validation(Required=false)]
            public DescribeRCInstanceHistoryEventsResponseBodyInstanceSystemEventSetEventCycleStatus EventCycleStatus { get; set; }
            public class DescribeRCInstanceHistoryEventsResponseBodyInstanceSystemEventSetEventCycleStatus : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("EventFinishTime")]
            [Validation(Required=false)]
            public string EventFinishTime { get; set; }

            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            [NameInMap("EventPublishTime")]
            [Validation(Required=false)]
            public string EventPublishTime { get; set; }

            [NameInMap("EventType")]
            [Validation(Required=false)]
            public DescribeRCInstanceHistoryEventsResponseBodyInstanceSystemEventSetEventType EventType { get; set; }
            public class DescribeRCInstanceHistoryEventsResponseBodyInstanceSystemEventSetEventType : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("ExtendedAttribute")]
            [Validation(Required=false)]
            public DescribeRCInstanceHistoryEventsResponseBodyInstanceSystemEventSetExtendedAttribute ExtendedAttribute { get; set; }
            public class DescribeRCInstanceHistoryEventsResponseBodyInstanceSystemEventSetExtendedAttribute : TeaModel {
                [NameInMap("CanAccept")]
                [Validation(Required=false)]
                public string CanAccept { get; set; }

                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Device")]
                [Validation(Required=false)]
                public string Device { get; set; }

                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                [NameInMap("HostId")]
                [Validation(Required=false)]
                public string HostId { get; set; }

                [NameInMap("HostType")]
                [Validation(Required=false)]
                public string HostType { get; set; }

                [NameInMap("InactiveDisks")]
                [Validation(Required=false)]
                public List<DescribeRCInstanceHistoryEventsResponseBodyInstanceSystemEventSetExtendedAttributeInactiveDisks> InactiveDisks { get; set; }
                public class DescribeRCInstanceHistoryEventsResponseBodyInstanceSystemEventSetExtendedAttributeInactiveDisks : TeaModel {
                    [NameInMap("CreationTime")]
                    [Validation(Required=false)]
                    public string CreationTime { get; set; }

                    [NameInMap("DeviceCategory")]
                    [Validation(Required=false)]
                    public string DeviceCategory { get; set; }

                    [NameInMap("DeviceSize")]
                    [Validation(Required=false)]
                    public string DeviceSize { get; set; }

                    [NameInMap("DeviceType")]
                    [Validation(Required=false)]
                    public string DeviceType { get; set; }

                    [NameInMap("ReleaseTime")]
                    [Validation(Required=false)]
                    public string ReleaseTime { get; set; }

                }

                [NameInMap("MigrationOptions")]
                [Validation(Required=false)]
                public List<string> MigrationOptions { get; set; }

                [NameInMap("OnlineRepairPolicy")]
                [Validation(Required=false)]
                public string OnlineRepairPolicy { get; set; }

                [NameInMap("PunishDomain")]
                [Validation(Required=false)]
                public string PunishDomain { get; set; }

                [NameInMap("PunishType")]
                [Validation(Required=false)]
                public string PunishType { get; set; }

                [NameInMap("PunishUrl")]
                [Validation(Required=false)]
                public string PunishUrl { get; set; }

                [NameInMap("Rack")]
                [Validation(Required=false)]
                public string Rack { get; set; }

                [NameInMap("ResponseResult")]
                [Validation(Required=false)]
                public string ResponseResult { get; set; }

            }

            [NameInMap("ImpactLevel")]
            [Validation(Required=false)]
            public string ImpactLevel { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("NotBefore")]
            [Validation(Required=false)]
            public string NotBefore { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("ReasonCode")]
            [Validation(Required=false)]
            public string ReasonCode { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
