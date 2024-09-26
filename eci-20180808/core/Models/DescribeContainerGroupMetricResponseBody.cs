// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeContainerGroupMetricResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eci-bp1dqpye03ke5s6p****</para>
        /// </summary>
        [NameInMap("ContainerGroupId")]
        [Validation(Required=false)]
        public string ContainerGroupId { get; set; }

        /// <summary>
        /// <para>The monitoring data of the elastic container instance.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<DescribeContainerGroupMetricResponseBodyRecords> Records { get; set; }
        public class DescribeContainerGroupMetricResponseBodyRecords : TeaModel {
            /// <summary>
            /// <para>The monitoring data of vCPUs.</para>
            /// </summary>
            [NameInMap("CPU")]
            [Validation(Required=false)]
            public DescribeContainerGroupMetricResponseBodyRecordsCPU CPU { get; set; }
            public class DescribeContainerGroupMetricResponseBodyRecordsCPU : TeaModel {
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
            public List<DescribeContainerGroupMetricResponseBodyRecordsContainers> Containers { get; set; }
            public class DescribeContainerGroupMetricResponseBodyRecordsContainers : TeaModel {
                /// <summary>
                /// <para>The vCPU monitoring data of the container.</para>
                /// </summary>
                [NameInMap("CPU")]
                [Validation(Required=false)]
                public DescribeContainerGroupMetricResponseBodyRecordsContainersCPU CPU { get; set; }
                public class DescribeContainerGroupMetricResponseBodyRecordsContainersCPU : TeaModel {
                    /// <summary>
                    /// <para>The upper limit of vCPU usage. The calculation formula for this parameter: The number of vCPUs × 1000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1024</para>
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
                public DescribeContainerGroupMetricResponseBodyRecordsContainersMemory Memory { get; set; }
                public class DescribeContainerGroupMetricResponseBodyRecordsContainersMemory : TeaModel {
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
                /// <para>The name of the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>u1</para>
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
            public List<DescribeContainerGroupMetricResponseBodyRecordsDisk> Disk { get; set; }
            public class DescribeContainerGroupMetricResponseBodyRecordsDisk : TeaModel {
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
                [NameInMap("ReadIO")]
                [Validation(Required=false)]
                public long? ReadIO { get; set; }

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
                [NameInMap("WriteIO")]
                [Validation(Required=false)]
                public long? WriteIO { get; set; }

            }

            /// <summary>
            /// <para>The monitoring data of file system partitions.</para>
            /// </summary>
            [NameInMap("Filesystem")]
            [Validation(Required=false)]
            public List<DescribeContainerGroupMetricResponseBodyRecordsFilesystem> Filesystem { get; set; }
            public class DescribeContainerGroupMetricResponseBodyRecordsFilesystem : TeaModel {
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
                /// <para>The type of the partition. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>System</description></item>
                /// <item><description>Volume</description></item>
                /// <item><description>Other</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>System</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

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
            public DescribeContainerGroupMetricResponseBodyRecordsMemory Memory { get; set; }
            public class DescribeContainerGroupMetricResponseBodyRecordsMemory : TeaModel {
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
            /// <para>The monitoring data of the network.</para>
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public DescribeContainerGroupMetricResponseBodyRecordsNetwork Network { get; set; }
            public class DescribeContainerGroupMetricResponseBodyRecordsNetwork : TeaModel {
                /// <summary>
                /// <para>The monitoring data of network interface controllers (NICs).</para>
                /// </summary>
                [NameInMap("Interfaces")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupMetricResponseBodyRecordsNetworkInterfaces> Interfaces { get; set; }
                public class DescribeContainerGroupMetricResponseBodyRecordsNetworkInterfaces : TeaModel {
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
                    /// <para>The number of bytes received by the NIC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>505001954</para>
                    /// </summary>
                    [NameInMap("RxBytes")]
                    [Validation(Required=false)]
                    public long? RxBytes { get; set; }

                    /// <summary>
                    /// <para>The number of received packets dropped on the NIC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("RxDrops")]
                    [Validation(Required=false)]
                    public long? RxDrops { get; set; }

                    /// <summary>
                    /// <para>The number of received packet errors on the NIC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("RxErrors")]
                    [Validation(Required=false)]
                    public long? RxErrors { get; set; }

                    /// <summary>
                    /// <para>The number of packets received by the NIC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4800583</para>
                    /// </summary>
                    [NameInMap("RxPackets")]
                    [Validation(Required=false)]
                    public long? RxPackets { get; set; }

                    /// <summary>
                    /// <para>The number of bytes transmitted by the NIC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1381805699</para>
                    /// </summary>
                    [NameInMap("TxBytes")]
                    [Validation(Required=false)]
                    public long? TxBytes { get; set; }

                    /// <summary>
                    /// <para>The number of transmitted packets dropped on the NIC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TxDrops")]
                    [Validation(Required=false)]
                    public long? TxDrops { get; set; }

                    /// <summary>
                    /// <para>The number of transmitted packet errors on the NIC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TxErrors")]
                    [Validation(Required=false)]
                    public long? TxErrors { get; set; }

                    /// <summary>
                    /// <para>The number of packets transmitted by the NIC.</para>
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
            /// <para>The time when the monitoring data entry was collected. The time follows the RFC 3339 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-08-25T16:22:00.000+08:00</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D81A4A13-6DCC-4579-AC62-90A6C3EC7BBC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
