// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeMultiContainerGroupMetricResponseBody : TeaModel {
        /// <summary>
        /// <para>The monitoring data of the elastic container instances.</para>
        /// </summary>
        [NameInMap("MonitorDatas")]
        [Validation(Required=false)]
        public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatas> MonitorDatas { get; set; }
        public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatas : TeaModel {
            /// <summary>
            /// <para>The ID of the elastic container instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eci-bp15oolgorelvhfb****</para>
            /// </summary>
            [NameInMap("ContainerGroupId")]
            [Validation(Required=false)]
            public string ContainerGroupId { get; set; }

            /// <summary>
            /// <para>The details about monitoring data.</para>
            /// </summary>
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecords> Records { get; set; }
            public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecords : TeaModel {
                /// <summary>
                /// <para>The monitoring data of vCPUs.</para>
                /// </summary>
                [NameInMap("CPU")]
                [Validation(Required=false)]
                public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsCPU CPU { get; set; }
                public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsCPU : TeaModel {
                    /// <summary>
                    /// <para>The upper limit of vCPU usage. The calculation formula for this parameter: The number of vCPUs × 1000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("Limit")]
                    [Validation(Required=false)]
                    public long? Limit { get; set; }

                    /// <summary>
                    /// <para>The average load in the last 10 seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Load")]
                    [Validation(Required=false)]
                    public long? Load { get; set; }

                    /// <summary>
                    /// <para>The cumulative usage of vCPUs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>70769883</para>
                    /// </summary>
                    [NameInMap("UsageCoreNanoSeconds")]
                    [Validation(Required=false)]
                    public long? UsageCoreNanoSeconds { get; set; }

                    /// <summary>
                    /// <para>The vCPU usage in the sampling window. Unit for the sampling window: nanoseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("UsageNanoCores")]
                    [Validation(Required=false)]
                    public long? UsageNanoCores { get; set; }

                }

                /// <summary>
                /// <para>The monitoring data of containers.</para>
                /// </summary>
                [NameInMap("Containers")]
                [Validation(Required=false)]
                public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsContainers> Containers { get; set; }
                public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsContainers : TeaModel {
                    /// <summary>
                    /// <para>The vCPU monitoring data of the container.</para>
                    /// </summary>
                    [NameInMap("CPU")]
                    [Validation(Required=false)]
                    public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsContainersCPU CPU { get; set; }
                    public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsContainersCPU : TeaModel {
                        /// <summary>
                        /// <para>The upper limit of vCPU usage. The calculation formula for this parameter: The number of vCPUs × 1000.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>321234</para>
                        /// </summary>
                        [NameInMap("Limit")]
                        [Validation(Required=false)]
                        public long? Limit { get; set; }

                        /// <summary>
                        /// <para>The average load in the last 10 seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>12341</para>
                        /// </summary>
                        [NameInMap("Load")]
                        [Validation(Required=false)]
                        public long? Load { get; set; }

                        /// <summary>
                        /// <para>The cumulative usage of vCPUs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>40876694</para>
                        /// </summary>
                        [NameInMap("UsageCoreNanoSeconds")]
                        [Validation(Required=false)]
                        public long? UsageCoreNanoSeconds { get; set; }

                        /// <summary>
                        /// <para>The vCPU usage in the sampling window. Unit for the sampling window: nanoseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("UsageNanoCores")]
                        [Validation(Required=false)]
                        public long? UsageNanoCores { get; set; }

                    }

                    /// <summary>
                    /// <para>The memory monitoring data of the container.</para>
                    /// </summary>
                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsContainersMemory Memory { get; set; }
                    public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsContainersMemory : TeaModel {
                        /// <summary>
                        /// <para>The size of the available memory. Unit: bytes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4285091840</para>
                        /// </summary>
                        [NameInMap("AvailableBytes")]
                        [Validation(Required=false)]
                        public long? AvailableBytes { get; set; }

                        /// <summary>
                        /// <para>The size of the cache. Unit: bytes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>9289728</para>
                        /// </summary>
                        [NameInMap("Cache")]
                        [Validation(Required=false)]
                        public long? Cache { get; set; }

                        /// <summary>
                        /// <para>The size of the resident memory set, which indicates the size of the physical memory that is actually used. Unit: bytes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>9289728</para>
                        /// </summary>
                        [NameInMap("Rss")]
                        [Validation(Required=false)]
                        public long? Rss { get; set; }

                        /// <summary>
                        /// <para>The size of the used memory. Unit: bytes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>9289728</para>
                        /// </summary>
                        [NameInMap("UsageBytes")]
                        [Validation(Required=false)]
                        public long? UsageBytes { get; set; }

                        /// <summary>
                        /// <para>The usage of the working set. Unit: bytes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>9289728</para>
                        /// </summary>
                        [NameInMap("WorkingSet")]
                        [Validation(Required=false)]
                        public long? WorkingSet { get; set; }

                    }

                    /// <summary>
                    /// <para>The name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The monitoring data of disks.</para>
                /// </summary>
                [NameInMap("Disk")]
                [Validation(Required=false)]
                public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsDisk> Disk { get; set; }
                public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsDisk : TeaModel {
                    /// <summary>
                    /// <para>The name of the disk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/dev/vda</para>
                    /// </summary>
                    [NameInMap("Device")]
                    [Validation(Required=false)]
                    public string Device { get; set; }

                    /// <summary>
                    /// <para>The amount of data that was read from the disk. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>210714112</para>
                    /// </summary>
                    [NameInMap("ReadBytes")]
                    [Validation(Required=false)]
                    public long? ReadBytes { get; set; }

                    /// <summary>
                    /// <para>This parameter is unavailable for public use.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("ReadIo")]
                    [Validation(Required=false)]
                    public long? ReadIo { get; set; }

                    /// <summary>
                    /// <para>The amount of data that was written to the disk. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1375109120</para>
                    /// </summary>
                    [NameInMap("WriteBytes")]
                    [Validation(Required=false)]
                    public long? WriteBytes { get; set; }

                    /// <summary>
                    /// <para>This parameter is unavailable for public use.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("WriteIo")]
                    [Validation(Required=false)]
                    public long? WriteIo { get; set; }

                }

                /// <summary>
                /// <para>The monitoring data of file system partitions.</para>
                /// </summary>
                [NameInMap("Filesystem")]
                [Validation(Required=false)]
                public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsFilesystem> Filesystem { get; set; }
                public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsFilesystem : TeaModel {
                    /// <summary>
                    /// <para>The size of the available space.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>35319836672</para>
                    /// </summary>
                    [NameInMap("Available")]
                    [Validation(Required=false)]
                    public long? Available { get; set; }

                    /// <summary>
                    /// <para>The total file system space.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>41610981376</para>
                    /// </summary>
                    [NameInMap("Capacity")]
                    [Validation(Required=false)]
                    public long? Capacity { get; set; }

                    /// <summary>
                    /// <para>The name of the partition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/dev/root</para>
                    /// </summary>
                    [NameInMap("FsName")]
                    [Validation(Required=false)]
                    public string FsName { get; set; }

                    /// <summary>
                    /// <para>The size of used space.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4368744448</para>
                    /// </summary>
                    [NameInMap("Usage")]
                    [Validation(Required=false)]
                    public long? Usage { get; set; }

                }

                /// <summary>
                /// <para>The monitoring data of the memory.</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsMemory Memory { get; set; }
                public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsMemory : TeaModel {
                    /// <summary>
                    /// <para>The size of the available memory. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4289445888</para>
                    /// </summary>
                    [NameInMap("AvailableBytes")]
                    [Validation(Required=false)]
                    public long? AvailableBytes { get; set; }

                    /// <summary>
                    /// <para>The size of the cache. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7028736</para>
                    /// </summary>
                    [NameInMap("Cache")]
                    [Validation(Required=false)]
                    public long? Cache { get; set; }

                    /// <summary>
                    /// <para>The size of the resident memory set, which indicates the size of the physical memory that is actually used. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1593344</para>
                    /// </summary>
                    [NameInMap("Rss")]
                    [Validation(Required=false)]
                    public long? Rss { get; set; }

                    /// <summary>
                    /// <para>The size of the used memory. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>11153408</para>
                    /// </summary>
                    [NameInMap("UsageBytes")]
                    [Validation(Required=false)]
                    public long? UsageBytes { get; set; }

                    /// <summary>
                    /// <para>The usage of the working set. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5521408</para>
                    /// </summary>
                    [NameInMap("WorkingSet")]
                    [Validation(Required=false)]
                    public long? WorkingSet { get; set; }

                }

                /// <summary>
                /// <para>The monitoring data of the network.</para>
                /// </summary>
                [NameInMap("Network")]
                [Validation(Required=false)]
                public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsNetwork Network { get; set; }
                public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsNetwork : TeaModel {
                    /// <summary>
                    /// <para>The monitoring data of network interface controllers (NICs).</para>
                    /// </summary>
                    [NameInMap("Interfaces")]
                    [Validation(Required=false)]
                    public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsNetworkInterfaces> Interfaces { get; set; }
                    public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsNetworkInterfaces : TeaModel {
                        /// <summary>
                        /// <para>The name of the NIC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>eth0</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The total number of bytes received.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>505001954</para>
                        /// </summary>
                        [NameInMap("RxBytes")]
                        [Validation(Required=false)]
                        public long? RxBytes { get; set; }

                        /// <summary>
                        /// <para>The number of packets that fail to be received.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("RxDrops")]
                        [Validation(Required=false)]
                        public long? RxDrops { get; set; }

                        /// <summary>
                        /// <para>The number of receipt errors.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("RxErrors")]
                        [Validation(Required=false)]
                        public long? RxErrors { get; set; }

                        /// <summary>
                        /// <para>The total number of packets received.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4800583</para>
                        /// </summary>
                        [NameInMap("RxPackets")]
                        [Validation(Required=false)]
                        public long? RxPackets { get; set; }

                        /// <summary>
                        /// <para>The total number of bytes sent.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1381805699</para>
                        /// </summary>
                        [NameInMap("TxBytes")]
                        [Validation(Required=false)]
                        public long? TxBytes { get; set; }

                        /// <summary>
                        /// <para>The number of packets that fail to arrive at their destination.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("TxDrops")]
                        [Validation(Required=false)]
                        public long? TxDrops { get; set; }

                        /// <summary>
                        /// <para>The total number of sending errors.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("TxErrors")]
                        [Validation(Required=false)]
                        public long? TxErrors { get; set; }

                        /// <summary>
                        /// <para>The total number of packets sent.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5158427</para>
                        /// </summary>
                        [NameInMap("TxPackets")]
                        [Validation(Required=false)]
                        public long? TxPackets { get; set; }

                    }

                }

                /// <summary>
                /// <para>The time when the entry of monitoring data was collected. The time follows the RFC 3339 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-12-19T02:31:54Z</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B8756BA0-6452-419C-9727-37A6209C85E0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
