// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeMultiContainerGroupMetricResponseBody : TeaModel {
        /// <summary>
        /// The monitoring data of the elastic container instances.
        /// </summary>
        [NameInMap("MonitorDatas")]
        [Validation(Required=false)]
        public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatas> MonitorDatas { get; set; }
        public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatas : TeaModel {
            /// <summary>
            /// The ID of the elastic container instance.
            /// </summary>
            [NameInMap("ContainerGroupId")]
            [Validation(Required=false)]
            public string ContainerGroupId { get; set; }

            /// <summary>
            /// The details about monitoring data.
            /// </summary>
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecords> Records { get; set; }
            public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecords : TeaModel {
                /// <summary>
                /// The monitoring data of vCPUs.
                /// </summary>
                [NameInMap("CPU")]
                [Validation(Required=false)]
                public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsCPU CPU { get; set; }
                public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsCPU : TeaModel {
                    /// <summary>
                    /// The upper limit of vCPU usage. The calculation formula for this parameter: The number of vCPUs × 1000.
                    /// </summary>
                    [NameInMap("Limit")]
                    [Validation(Required=false)]
                    public long? Limit { get; set; }

                    /// <summary>
                    /// The average load in the last 10 seconds.
                    /// </summary>
                    [NameInMap("Load")]
                    [Validation(Required=false)]
                    public long? Load { get; set; }

                    /// <summary>
                    /// The cumulative usage of vCPUs.
                    /// </summary>
                    [NameInMap("UsageCoreNanoSeconds")]
                    [Validation(Required=false)]
                    public long? UsageCoreNanoSeconds { get; set; }

                    /// <summary>
                    /// The vCPU usage in the sampling window. Unit for the sampling window: nanoseconds.
                    /// </summary>
                    [NameInMap("UsageNanoCores")]
                    [Validation(Required=false)]
                    public long? UsageNanoCores { get; set; }

                }

                /// <summary>
                /// The monitoring data of containers.
                /// </summary>
                [NameInMap("Containers")]
                [Validation(Required=false)]
                public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsContainers> Containers { get; set; }
                public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsContainers : TeaModel {
                    /// <summary>
                    /// The vCPU monitoring data of the container.
                    /// </summary>
                    [NameInMap("CPU")]
                    [Validation(Required=false)]
                    public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsContainersCPU CPU { get; set; }
                    public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsContainersCPU : TeaModel {
                        /// <summary>
                        /// The upper limit of vCPU usage. The calculation formula for this parameter: The number of vCPUs × 1000.
                        /// </summary>
                        [NameInMap("Limit")]
                        [Validation(Required=false)]
                        public long? Limit { get; set; }

                        /// <summary>
                        /// The average load in the last 10 seconds.
                        /// </summary>
                        [NameInMap("Load")]
                        [Validation(Required=false)]
                        public long? Load { get; set; }

                        /// <summary>
                        /// The cumulative usage of vCPUs.
                        /// </summary>
                        [NameInMap("UsageCoreNanoSeconds")]
                        [Validation(Required=false)]
                        public long? UsageCoreNanoSeconds { get; set; }

                        /// <summary>
                        /// The vCPU usage in the sampling window. Unit for the sampling window: nanoseconds.
                        /// </summary>
                        [NameInMap("UsageNanoCores")]
                        [Validation(Required=false)]
                        public long? UsageNanoCores { get; set; }

                    }

                    /// <summary>
                    /// The memory monitoring data of the container.
                    /// </summary>
                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsContainersMemory Memory { get; set; }
                    public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsContainersMemory : TeaModel {
                        /// <summary>
                        /// The size of the available memory. Unit: bytes.
                        /// </summary>
                        [NameInMap("AvailableBytes")]
                        [Validation(Required=false)]
                        public long? AvailableBytes { get; set; }

                        /// <summary>
                        /// The size of the cache. Unit: bytes.
                        /// </summary>
                        [NameInMap("Cache")]
                        [Validation(Required=false)]
                        public long? Cache { get; set; }

                        /// <summary>
                        /// The size of the resident memory set, which indicates the size of the physical memory that is actually used. Unit: bytes.
                        /// </summary>
                        [NameInMap("Rss")]
                        [Validation(Required=false)]
                        public long? Rss { get; set; }

                        /// <summary>
                        /// The size of the used memory. Unit: bytes.
                        /// </summary>
                        [NameInMap("UsageBytes")]
                        [Validation(Required=false)]
                        public long? UsageBytes { get; set; }

                        /// <summary>
                        /// The usage of the working set. Unit: bytes.
                        /// </summary>
                        [NameInMap("WorkingSet")]
                        [Validation(Required=false)]
                        public long? WorkingSet { get; set; }

                    }

                    /// <summary>
                    /// The name.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// The monitoring data of disks.
                /// </summary>
                [NameInMap("Disk")]
                [Validation(Required=false)]
                public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsDisk> Disk { get; set; }
                public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsDisk : TeaModel {
                    /// <summary>
                    /// The name of the disk.
                    /// </summary>
                    [NameInMap("Device")]
                    [Validation(Required=false)]
                    public string Device { get; set; }

                    /// <summary>
                    /// The amount of data that was read from the disk. Unit: bytes.
                    /// </summary>
                    [NameInMap("ReadBytes")]
                    [Validation(Required=false)]
                    public long? ReadBytes { get; set; }

                    /// <summary>
                    /// This parameter is unavailable for public use.
                    /// </summary>
                    [NameInMap("ReadIo")]
                    [Validation(Required=false)]
                    public long? ReadIo { get; set; }

                    /// <summary>
                    /// The amount of data that was written to the disk. Unit: bytes.
                    /// </summary>
                    [NameInMap("WriteBytes")]
                    [Validation(Required=false)]
                    public long? WriteBytes { get; set; }

                    /// <summary>
                    /// This parameter is unavailable for public use.
                    /// </summary>
                    [NameInMap("WriteIo")]
                    [Validation(Required=false)]
                    public long? WriteIo { get; set; }

                }

                /// <summary>
                /// The monitoring data of file system partitions.
                /// </summary>
                [NameInMap("Filesystem")]
                [Validation(Required=false)]
                public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsFilesystem> Filesystem { get; set; }
                public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsFilesystem : TeaModel {
                    /// <summary>
                    /// The size of the available space.
                    /// </summary>
                    [NameInMap("Available")]
                    [Validation(Required=false)]
                    public long? Available { get; set; }

                    /// <summary>
                    /// The total file system space.
                    /// </summary>
                    [NameInMap("Capacity")]
                    [Validation(Required=false)]
                    public long? Capacity { get; set; }

                    /// <summary>
                    /// The name of the partition.
                    /// </summary>
                    [NameInMap("FsName")]
                    [Validation(Required=false)]
                    public string FsName { get; set; }

                    /// <summary>
                    /// The size of used space.
                    /// </summary>
                    [NameInMap("Usage")]
                    [Validation(Required=false)]
                    public long? Usage { get; set; }

                }

                /// <summary>
                /// The monitoring data of the memory.
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsMemory Memory { get; set; }
                public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsMemory : TeaModel {
                    /// <summary>
                    /// The size of the available memory. Unit: bytes.
                    /// </summary>
                    [NameInMap("AvailableBytes")]
                    [Validation(Required=false)]
                    public long? AvailableBytes { get; set; }

                    /// <summary>
                    /// The size of the cache. Unit: bytes.
                    /// </summary>
                    [NameInMap("Cache")]
                    [Validation(Required=false)]
                    public long? Cache { get; set; }

                    /// <summary>
                    /// The size of the resident memory set, which indicates the size of the physical memory that is actually used. Unit: bytes.
                    /// </summary>
                    [NameInMap("Rss")]
                    [Validation(Required=false)]
                    public long? Rss { get; set; }

                    /// <summary>
                    /// The size of the used memory. Unit: bytes.
                    /// </summary>
                    [NameInMap("UsageBytes")]
                    [Validation(Required=false)]
                    public long? UsageBytes { get; set; }

                    /// <summary>
                    /// The usage of the working set. Unit: bytes.
                    /// </summary>
                    [NameInMap("WorkingSet")]
                    [Validation(Required=false)]
                    public long? WorkingSet { get; set; }

                }

                /// <summary>
                /// The monitoring data of the network.
                /// </summary>
                [NameInMap("Network")]
                [Validation(Required=false)]
                public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsNetwork Network { get; set; }
                public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsNetwork : TeaModel {
                    /// <summary>
                    /// The monitoring data of network interface controllers (NICs).
                    /// </summary>
                    [NameInMap("Interfaces")]
                    [Validation(Required=false)]
                    public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsNetworkInterfaces> Interfaces { get; set; }
                    public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsNetworkInterfaces : TeaModel {
                        /// <summary>
                        /// The name of the NIC.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// The total number of bytes received.
                        /// </summary>
                        [NameInMap("RxBytes")]
                        [Validation(Required=false)]
                        public long? RxBytes { get; set; }

                        /// <summary>
                        /// The number of packets that fail to be received.
                        /// </summary>
                        [NameInMap("RxDrops")]
                        [Validation(Required=false)]
                        public long? RxDrops { get; set; }

                        /// <summary>
                        /// The number of receipt errors.
                        /// </summary>
                        [NameInMap("RxErrors")]
                        [Validation(Required=false)]
                        public long? RxErrors { get; set; }

                        /// <summary>
                        /// The total number of packets received.
                        /// </summary>
                        [NameInMap("RxPackets")]
                        [Validation(Required=false)]
                        public long? RxPackets { get; set; }

                        /// <summary>
                        /// The total number of bytes sent.
                        /// </summary>
                        [NameInMap("TxBytes")]
                        [Validation(Required=false)]
                        public long? TxBytes { get; set; }

                        /// <summary>
                        /// The number of packets that fail to arrive at their destination.
                        /// </summary>
                        [NameInMap("TxDrops")]
                        [Validation(Required=false)]
                        public long? TxDrops { get; set; }

                        /// <summary>
                        /// The total number of sending errors.
                        /// </summary>
                        [NameInMap("TxErrors")]
                        [Validation(Required=false)]
                        public long? TxErrors { get; set; }

                        /// <summary>
                        /// The total number of packets sent.
                        /// </summary>
                        [NameInMap("TxPackets")]
                        [Validation(Required=false)]
                        public long? TxPackets { get; set; }

                    }

                }

                /// <summary>
                /// The time when the entry of monitoring data was collected. The time follows the RFC 3339 format.
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
