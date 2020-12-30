// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeContainerGroupMetricResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ContainerGroupId")]
        [Validation(Required=false)]
        public string ContainerGroupId { get; set; }

        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<DescribeContainerGroupMetricResponseBodyRecords> Records { get; set; }
        public class DescribeContainerGroupMetricResponseBodyRecords : TeaModel {
            [NameInMap("Network")]
            [Validation(Required=false)]
            public DescribeContainerGroupMetricResponseBodyRecordsNetwork Network { get; set; }
            public class DescribeContainerGroupMetricResponseBodyRecordsNetwork : TeaModel {
                [NameInMap("Interfaces")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupMetricResponseBodyRecordsNetworkInterfaces> Interfaces { get; set; }
                public class DescribeContainerGroupMetricResponseBodyRecordsNetworkInterfaces : TeaModel {
                    public long? RxErrors { get; set; }
                    public long? TxBytes { get; set; }
                    public string Name { get; set; }
                    public long? TxErrors { get; set; }
                    public long? RxBytes { get; set; }
                }
            };

            [NameInMap("CPU")]
            [Validation(Required=false)]
            public DescribeContainerGroupMetricResponseBodyRecordsCPU CPU { get; set; }
            public class DescribeContainerGroupMetricResponseBodyRecordsCPU : TeaModel {
                [NameInMap("UsageNanoCores")]
                [Validation(Required=false)]
                public long? UsageNanoCores { get; set; }
                [NameInMap("Limit")]
                [Validation(Required=false)]
                public long? Limit { get; set; }
                [NameInMap("UsageCoreNanoSeconds")]
                [Validation(Required=false)]
                public long? UsageCoreNanoSeconds { get; set; }
                [NameInMap("Load")]
                [Validation(Required=false)]
                public long? Load { get; set; }
            };

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            [NameInMap("Memory")]
            [Validation(Required=false)]
            public DescribeContainerGroupMetricResponseBodyRecordsMemory Memory { get; set; }
            public class DescribeContainerGroupMetricResponseBodyRecordsMemory : TeaModel {
                [NameInMap("Rss")]
                [Validation(Required=false)]
                public long? Rss { get; set; }
                [NameInMap("UsageBytes")]
                [Validation(Required=false)]
                public long? UsageBytes { get; set; }
                [NameInMap("WorkingSet")]
                [Validation(Required=false)]
                public long? WorkingSet { get; set; }
                [NameInMap("AvailableBytes")]
                [Validation(Required=false)]
                public long? AvailableBytes { get; set; }
                [NameInMap("Cache")]
                [Validation(Required=false)]
                public long? Cache { get; set; }
            };

            [NameInMap("Containers")]
            [Validation(Required=false)]
            public List<DescribeContainerGroupMetricResponseBodyRecordsContainers> Containers { get; set; }
            public class DescribeContainerGroupMetricResponseBodyRecordsContainers : TeaModel {
                [NameInMap("CPU")]
                [Validation(Required=false)]
                public DescribeContainerGroupMetricResponseBodyRecordsContainersCPU CPU { get; set; }
                public class DescribeContainerGroupMetricResponseBodyRecordsContainersCPU : TeaModel {
                    [NameInMap("UsageNanoCores")]
                    [Validation(Required=false)]
                    public long? UsageNanoCores { get; set; }
                    [NameInMap("Limit")]
                    [Validation(Required=false)]
                    public long? Limit { get; set; }
                    [NameInMap("UsageCoreNanoSeconds")]
                    [Validation(Required=false)]
                    public long? UsageCoreNanoSeconds { get; set; }
                    [NameInMap("Load")]
                    [Validation(Required=false)]
                    public long? Load { get; set; }
                };

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public DescribeContainerGroupMetricResponseBodyRecordsContainersMemory Memory { get; set; }
                public class DescribeContainerGroupMetricResponseBodyRecordsContainersMemory : TeaModel {
                    [NameInMap("Rss")]
                    [Validation(Required=false)]
                    public long? Rss { get; set; }
                    [NameInMap("UsageBytes")]
                    [Validation(Required=false)]
                    public long? UsageBytes { get; set; }
                    [NameInMap("WorkingSet")]
                    [Validation(Required=false)]
                    public long? WorkingSet { get; set; }
                    [NameInMap("AvailableBytes")]
                    [Validation(Required=false)]
                    public long? AvailableBytes { get; set; }
                    [NameInMap("Cache")]
                    [Validation(Required=false)]
                    public long? Cache { get; set; }
                };

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

    }

}
