// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeMultiContainerGroupMetricResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MonitorDatas")]
        [Validation(Required=false)]
        public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatas> MonitorDatas { get; set; }
        public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatas : TeaModel {
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecords> Records { get; set; }
            public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecords : TeaModel {
                [NameInMap("Network")]
                [Validation(Required=false)]
                public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsNetwork Network { get; set; }
                public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsNetwork : TeaModel {
                    [NameInMap("Interfaces")]
                    [Validation(Required=false)]
                    public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsNetworkInterfaces> Interfaces { get; set; }
                    public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsNetworkInterfaces : TeaModel {
                        public long? RxErrors { get; set; }
                        public long? TxDrops { get; set; }
                        public long? TxBytes { get; set; }
                        public long? RxPackets { get; set; }
                        public long? TxPackets { get; set; }
                        public string Name { get; set; }
                        public long? TxErrors { get; set; }
                        public long? RxBytes { get; set; }
                        public long? RxDrops { get; set; }
                    }
                };

                [NameInMap("CPU")]
                [Validation(Required=false)]
                public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsCPU CPU { get; set; }
                public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsCPU : TeaModel {
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

                [NameInMap("Disk")]
                [Validation(Required=false)]
                public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsDisk> Disk { get; set; }
                public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsDisk : TeaModel {
                    [NameInMap("WriteBytes")]
                    [Validation(Required=false)]
                    public long? WriteBytes { get; set; }

                    [NameInMap("Device")]
                    [Validation(Required=false)]
                    public string Device { get; set; }

                    [NameInMap("WriteIo")]
                    [Validation(Required=false)]
                    public long? WriteIo { get; set; }

                    [NameInMap("ReadBytes")]
                    [Validation(Required=false)]
                    public long? ReadBytes { get; set; }

                    [NameInMap("ReadIo")]
                    [Validation(Required=false)]
                    public long? ReadIo { get; set; }

                }

                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsMemory Memory { get; set; }
                public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsMemory : TeaModel {
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
                public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsContainers> Containers { get; set; }
                public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsContainers : TeaModel {
                    [NameInMap("CPU")]
                    [Validation(Required=false)]
                    public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsContainersCPU CPU { get; set; }
                    public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsContainersCPU : TeaModel {
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
                    public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsContainersMemory Memory { get; set; }
                    public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsContainersMemory : TeaModel {
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

                [NameInMap("Filesystem")]
                [Validation(Required=false)]
                public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsFilesystem> Filesystem { get; set; }
                public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasRecordsFilesystem : TeaModel {
                    [NameInMap("Capacity")]
                    [Validation(Required=false)]
                    public long? Capacity { get; set; }

                    [NameInMap("Available")]
                    [Validation(Required=false)]
                    public long? Available { get; set; }

                    [NameInMap("FsName")]
                    [Validation(Required=false)]
                    public string FsName { get; set; }

                    [NameInMap("Usage")]
                    [Validation(Required=false)]
                    public long? Usage { get; set; }

                }

            }

            [NameInMap("ContainerInfos")]
            [Validation(Required=false)]
            public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfos> ContainerInfos { get; set; }
            public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfos : TeaModel {
                [NameInMap("Aliases")]
                [Validation(Required=false)]
                public List<string> Aliases { get; set; }

                [NameInMap("ContainerSpec")]
                [Validation(Required=false)]
                public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerSpec ContainerSpec { get; set; }
                public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerSpec : TeaModel {
                    [NameInMap("CreationTime")]
                    [Validation(Required=false)]
                    public string CreationTime { get; set; }
                    [NameInMap("Image")]
                    [Validation(Required=false)]
                    public string Image { get; set; }
                    [NameInMap("Labels")]
                    [Validation(Required=false)]
                    public string Labels { get; set; }
                    [NameInMap("HasCustomMetrics")]
                    [Validation(Required=false)]
                    public bool? HasCustomMetrics { get; set; }
                    [NameInMap("HasCpu")]
                    [Validation(Required=false)]
                    public bool? HasCpu { get; set; }
                    [NameInMap("Envs")]
                    [Validation(Required=false)]
                    public string Envs { get; set; }
                    [NameInMap("HasDiskIo")]
                    [Validation(Required=false)]
                    public bool? HasDiskIo { get; set; }
                    [NameInMap("HasFilesystem")]
                    [Validation(Required=false)]
                    public bool? HasFilesystem { get; set; }
                    [NameInMap("HasNetwork")]
                    [Validation(Required=false)]
                    public bool? HasNetwork { get; set; }
                    [NameInMap("ContainerMemory")]
                    [Validation(Required=false)]
                    public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerSpecContainerMemory ContainerMemory { get; set; }
                    public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerSpecContainerMemory : TeaModel {
                        [NameInMap("Limit")]
                        [Validation(Required=false)]
                        public long? Limit { get; set; }

                        [NameInMap("SwapLimit")]
                        [Validation(Required=false)]
                        public long? SwapLimit { get; set; }

                        [NameInMap("Reservation")]
                        [Validation(Required=false)]
                        public long? Reservation { get; set; }

                    }
                    [NameInMap("HasMemory")]
                    [Validation(Required=false)]
                    public bool? HasMemory { get; set; }
                    [NameInMap("ContainerCpu")]
                    [Validation(Required=false)]
                    public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerSpecContainerCpu ContainerCpu { get; set; }
                    public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerSpecContainerCpu : TeaModel {
                        [NameInMap("Quota")]
                        [Validation(Required=false)]
                        public long? Quota { get; set; }

                        [NameInMap("Mask")]
                        [Validation(Required=false)]
                        public string Mask { get; set; }

                        [NameInMap("Limit")]
                        [Validation(Required=false)]
                        public long? Limit { get; set; }

                        [NameInMap("MaxLimit")]
                        [Validation(Required=false)]
                        public long? MaxLimit { get; set; }

                        [NameInMap("Period")]
                        [Validation(Required=false)]
                        public long? Period { get; set; }

                    }
                };

                [NameInMap("ContainerStats")]
                [Validation(Required=false)]
                public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStats> ContainerStats { get; set; }
                public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStats : TeaModel {
                    [NameInMap("NetworkStats")]
                    [Validation(Required=false)]
                    public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsNetworkStats NetworkStats { get; set; }
                    public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsNetworkStats : TeaModel {
                        [NameInMap("RxDropped")]
                        [Validation(Required=false)]
                        public long? RxDropped { get; set; }
                        [NameInMap("Tcp")]
                        [Validation(Required=false)]
                        public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsNetworkStatsTcp Tcp { get; set; }
                        public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsNetworkStatsTcp : TeaModel {
                            [NameInMap("CloseWait")]
                            [Validation(Required=false)]
                            public long? CloseWait { get; set; }

                            [NameInMap("FinWait2")]
                            [Validation(Required=false)]
                            public long? FinWait2 { get; set; }

                            [NameInMap("LastAck")]
                            [Validation(Required=false)]
                            public long? LastAck { get; set; }

                            [NameInMap("Closing")]
                            [Validation(Required=false)]
                            public long? Closing { get; set; }

                            [NameInMap("Listen")]
                            [Validation(Required=false)]
                            public long? Listen { get; set; }

                            [NameInMap("TimeWait")]
                            [Validation(Required=false)]
                            public long? TimeWait { get; set; }

                            [NameInMap("Established")]
                            [Validation(Required=false)]
                            public long? Established { get; set; }

                            [NameInMap("FinWait1")]
                            [Validation(Required=false)]
                            public long? FinWait1 { get; set; }

                            [NameInMap("Close")]
                            [Validation(Required=false)]
                            public long? Close { get; set; }

                            [NameInMap("SynRecv")]
                            [Validation(Required=false)]
                            public long? SynRecv { get; set; }

                            [NameInMap("SynSent")]
                            [Validation(Required=false)]
                            public long? SynSent { get; set; }

                        }
                        [NameInMap("TxErrors")]
                        [Validation(Required=false)]
                        public long? TxErrors { get; set; }
                        [NameInMap("RxErrors")]
                        [Validation(Required=false)]
                        public long? RxErrors { get; set; }
                        [NameInMap("InterfaceStats")]
                        [Validation(Required=false)]
                        public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsNetworkStatsInterfaceStats> InterfaceStats { get; set; }
                        public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsNetworkStatsInterfaceStats : TeaModel {
                            public long? RxErrors { get; set; }
                            public long? RxDropped { get; set; }
                            public long? TxDropped { get; set; }
                            public long? TxBytes { get; set; }
                            public long? RxPackets { get; set; }
                            public long? TxErrors { get; set; }
                            public long? TxPackets { get; set; }
                            public long? RxBytes { get; set; }
                            public string Name { get; set; }
                        }
                        [NameInMap("Tcp6")]
                        [Validation(Required=false)]
                        public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsNetworkStatsTcp6 Tcp6 { get; set; }
                        public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsNetworkStatsTcp6 : TeaModel {
                            [NameInMap("CloseWait")]
                            [Validation(Required=false)]
                            public long? CloseWait { get; set; }

                            [NameInMap("FinWait2")]
                            [Validation(Required=false)]
                            public long? FinWait2 { get; set; }

                            [NameInMap("LastAck")]
                            [Validation(Required=false)]
                            public long? LastAck { get; set; }

                            [NameInMap("Closing")]
                            [Validation(Required=false)]
                            public long? Closing { get; set; }

                            [NameInMap("Listen")]
                            [Validation(Required=false)]
                            public long? Listen { get; set; }

                            [NameInMap("TimeWait")]
                            [Validation(Required=false)]
                            public long? TimeWait { get; set; }

                            [NameInMap("Established")]
                            [Validation(Required=false)]
                            public long? Established { get; set; }

                            [NameInMap("FinWait1")]
                            [Validation(Required=false)]
                            public long? FinWait1 { get; set; }

                            [NameInMap("Close")]
                            [Validation(Required=false)]
                            public long? Close { get; set; }

                            [NameInMap("SynRecv")]
                            [Validation(Required=false)]
                            public long? SynRecv { get; set; }

                            [NameInMap("SynSent")]
                            [Validation(Required=false)]
                            public long? SynSent { get; set; }

                        }
                        [NameInMap("TxDropped")]
                        [Validation(Required=false)]
                        public long? TxDropped { get; set; }
                        [NameInMap("Udp")]
                        [Validation(Required=false)]
                        public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsNetworkStatsUdp Udp { get; set; }
                        public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsNetworkStatsUdp : TeaModel {
                            [NameInMap("TxQueued")]
                            [Validation(Required=false)]
                            public long? TxQueued { get; set; }

                            [NameInMap("Listen")]
                            [Validation(Required=false)]
                            public long? Listen { get; set; }

                            [NameInMap("Dropped")]
                            [Validation(Required=false)]
                            public long? Dropped { get; set; }

                            [NameInMap("RxQueued")]
                            [Validation(Required=false)]
                            public long? RxQueued { get; set; }

                        }
                        [NameInMap("TxBytes")]
                        [Validation(Required=false)]
                        public long? TxBytes { get; set; }
                        [NameInMap("Udp6")]
                        [Validation(Required=false)]
                        public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsNetworkStatsUdp6 Udp6 { get; set; }
                        public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsNetworkStatsUdp6 : TeaModel {
                            [NameInMap("TxQueued")]
                            [Validation(Required=false)]
                            public long? TxQueued { get; set; }

                            [NameInMap("Listen")]
                            [Validation(Required=false)]
                            public long? Listen { get; set; }

                            [NameInMap("Dropped")]
                            [Validation(Required=false)]
                            public long? Dropped { get; set; }

                            [NameInMap("RxQueued")]
                            [Validation(Required=false)]
                            public long? RxQueued { get; set; }

                        }
                        [NameInMap("RxPackets")]
                        [Validation(Required=false)]
                        public long? RxPackets { get; set; }
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }
                        [NameInMap("RxBytes")]
                        [Validation(Required=false)]
                        public long? RxBytes { get; set; }
                        [NameInMap("TxPackets")]
                        [Validation(Required=false)]
                        public long? TxPackets { get; set; }
                    };

                    [NameInMap("FsStats")]
                    [Validation(Required=false)]
                    public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsFsStats> FsStats { get; set; }
                    public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsFsStats : TeaModel {
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("ReadsMerged")]
                        [Validation(Required=false)]
                        public long? ReadsMerged { get; set; }

                        [NameInMap("HasInodes")]
                        [Validation(Required=false)]
                        public bool? HasInodes { get; set; }

                        [NameInMap("ReadsCompleted")]
                        [Validation(Required=false)]
                        public long? ReadsCompleted { get; set; }

                        [NameInMap("WritesMerged")]
                        [Validation(Required=false)]
                        public long? WritesMerged { get; set; }

                        [NameInMap("InodesFree")]
                        [Validation(Required=false)]
                        public long? InodesFree { get; set; }

                        [NameInMap("Available")]
                        [Validation(Required=false)]
                        public long? Available { get; set; }

                        [NameInMap("Usage")]
                        [Validation(Required=false)]
                        public long? Usage { get; set; }

                        [NameInMap("Inodes")]
                        [Validation(Required=false)]
                        public long? Inodes { get; set; }

                        [NameInMap("BaseUsage")]
                        [Validation(Required=false)]
                        public long? BaseUsage { get; set; }

                        [NameInMap("SectorsRead")]
                        [Validation(Required=false)]
                        public long? SectorsRead { get; set; }

                        [NameInMap("WriteTime")]
                        [Validation(Required=false)]
                        public long? WriteTime { get; set; }

                        [NameInMap("SectorsWritten")]
                        [Validation(Required=false)]
                        public long? SectorsWritten { get; set; }

                        [NameInMap("ReadTime")]
                        [Validation(Required=false)]
                        public long? ReadTime { get; set; }

                        [NameInMap("Limit")]
                        [Validation(Required=false)]
                        public long? Limit { get; set; }

                        [NameInMap("Device")]
                        [Validation(Required=false)]
                        public string Device { get; set; }

                        [NameInMap("WritesCompleted")]
                        [Validation(Required=false)]
                        public long? WritesCompleted { get; set; }

                        [NameInMap("IoTime")]
                        [Validation(Required=false)]
                        public long? IoTime { get; set; }

                        [NameInMap("WeightedIoTime")]
                        [Validation(Required=false)]
                        public long? WeightedIoTime { get; set; }

                        [NameInMap("IoInProgress")]
                        [Validation(Required=false)]
                        public long? IoInProgress { get; set; }

                    }

                    [NameInMap("AcceleratorStats")]
                    [Validation(Required=false)]
                    public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsAcceleratorStats> AcceleratorStats { get; set; }
                    public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsAcceleratorStats : TeaModel {
                        [NameInMap("Model")]
                        [Validation(Required=false)]
                        public string Model { get; set; }

                        [NameInMap("Minor")]
                        [Validation(Required=false)]
                        public long? Minor { get; set; }

                        [NameInMap("Temperature")]
                        [Validation(Required=false)]
                        public long? Temperature { get; set; }

                        [NameInMap("PowerUsage")]
                        [Validation(Required=false)]
                        public long? PowerUsage { get; set; }

                        [NameInMap("MemoryTotal")]
                        [Validation(Required=false)]
                        public long? MemoryTotal { get; set; }

                        [NameInMap("Make")]
                        [Validation(Required=false)]
                        public string Make { get; set; }

                        [NameInMap("DutyCycle")]
                        [Validation(Required=false)]
                        public long? DutyCycle { get; set; }

                        [NameInMap("MemoryUsed")]
                        [Validation(Required=false)]
                        public long? MemoryUsed { get; set; }

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                    }

                    [NameInMap("CpuStats")]
                    [Validation(Required=false)]
                    public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsCpuStats CpuStats { get; set; }
                    public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsCpuStats : TeaModel {
                        [NameInMap("CpuUsage")]
                        [Validation(Required=false)]
                        public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsCpuStatsCpuUsage CpuUsage { get; set; }
                        public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsCpuStatsCpuUsage : TeaModel {
                            [NameInMap("User")]
                            [Validation(Required=false)]
                            public long? User { get; set; }

                            [NameInMap("PerCpuUsages")]
                            [Validation(Required=false)]
                            public List<long?> PerCpuUsages { get; set; }

                            [NameInMap("Total")]
                            [Validation(Required=false)]
                            public long? Total { get; set; }

                            [NameInMap("System")]
                            [Validation(Required=false)]
                            public long? System { get; set; }

                        }
                        [NameInMap("LoadAverage")]
                        [Validation(Required=false)]
                        public long? LoadAverage { get; set; }
                        [NameInMap("CpuCFS")]
                        [Validation(Required=false)]
                        public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsCpuStatsCpuCFS CpuCFS { get; set; }
                        public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsCpuStatsCpuCFS : TeaModel {
                            [NameInMap("ThrottledTime")]
                            [Validation(Required=false)]
                            public long? ThrottledTime { get; set; }

                            [NameInMap("Periods")]
                            [Validation(Required=false)]
                            public long? Periods { get; set; }

                            [NameInMap("ThrottledPeriods")]
                            [Validation(Required=false)]
                            public long? ThrottledPeriods { get; set; }

                        }
                    };

                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public string Timestamp { get; set; }

                    [NameInMap("MemoryStats")]
                    [Validation(Required=false)]
                    public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsMemoryStats MemoryStats { get; set; }
                    public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsMemoryStats : TeaModel {
                        [NameInMap("FailCnt")]
                        [Validation(Required=false)]
                        public long? FailCnt { get; set; }
                        [NameInMap("MaxUsage")]
                        [Validation(Required=false)]
                        public long? MaxUsage { get; set; }
                        [NameInMap("HierarchicalData")]
                        [Validation(Required=false)]
                        public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsMemoryStatsHierarchicalData HierarchicalData { get; set; }
                        public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsMemoryStatsHierarchicalData : TeaModel {
                            [NameInMap("PgmajFault")]
                            [Validation(Required=false)]
                            public long? PgmajFault { get; set; }

                            [NameInMap("PgFault")]
                            [Validation(Required=false)]
                            public long? PgFault { get; set; }

                        }
                        [NameInMap("Rss")]
                        [Validation(Required=false)]
                        public long? Rss { get; set; }
                        [NameInMap("ContainerData")]
                        [Validation(Required=false)]
                        public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsMemoryStatsContainerData ContainerData { get; set; }
                        public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsMemoryStatsContainerData : TeaModel {
                            [NameInMap("PgmajFault")]
                            [Validation(Required=false)]
                            public long? PgmajFault { get; set; }

                            [NameInMap("PgFault")]
                            [Validation(Required=false)]
                            public long? PgFault { get; set; }

                        }
                        [NameInMap("WorkingSet")]
                        [Validation(Required=false)]
                        public long? WorkingSet { get; set; }
                        [NameInMap("Swap")]
                        [Validation(Required=false)]
                        public long? Swap { get; set; }
                        [NameInMap("Cache")]
                        [Validation(Required=false)]
                        public long? Cache { get; set; }
                        [NameInMap("Usage")]
                        [Validation(Required=false)]
                        public long? Usage { get; set; }
                    };

                    [NameInMap("TaskStats")]
                    [Validation(Required=false)]
                    public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsTaskStats TaskStats { get; set; }
                    public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsTaskStats : TeaModel {
                        [NameInMap("NrUninterruptible")]
                        [Validation(Required=false)]
                        public long? NrUninterruptible { get; set; }
                        [NameInMap("NrRunning")]
                        [Validation(Required=false)]
                        public long? NrRunning { get; set; }
                        [NameInMap("NrSleeping")]
                        [Validation(Required=false)]
                        public long? NrSleeping { get; set; }
                        [NameInMap("NrIoWait")]
                        [Validation(Required=false)]
                        public long? NrIoWait { get; set; }
                        [NameInMap("NrStopped")]
                        [Validation(Required=false)]
                        public long? NrStopped { get; set; }
                    };

                    [NameInMap("DiskIoStats")]
                    [Validation(Required=false)]
                    public DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsDiskIoStats DiskIoStats { get; set; }
                    public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsDiskIoStats : TeaModel {
                        [NameInMap("IoServiced")]
                        [Validation(Required=false)]
                        public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsDiskIoStatsIoServiced> IoServiced { get; set; }
                        public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsDiskIoStatsIoServiced : TeaModel {
                            public string Stats { get; set; }
                            public long? Minor { get; set; }
                            public long? Major { get; set; }
                            public string Device { get; set; }
                        }
                        [NameInMap("IoServiceTime")]
                        [Validation(Required=false)]
                        public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsDiskIoStatsIoServiceTime> IoServiceTime { get; set; }
                        public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsDiskIoStatsIoServiceTime : TeaModel {
                            public string Stats { get; set; }
                            public long? Minor { get; set; }
                            public long? Major { get; set; }
                            public string Device { get; set; }
                        }
                        [NameInMap("IoServiceBytes")]
                        [Validation(Required=false)]
                        public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsDiskIoStatsIoServiceBytes> IoServiceBytes { get; set; }
                        public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsDiskIoStatsIoServiceBytes : TeaModel {
                            public string Stats { get; set; }
                            public long? Minor { get; set; }
                            public long? Major { get; set; }
                            public string Device { get; set; }
                        }
                        [NameInMap("IoMerged")]
                        [Validation(Required=false)]
                        public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsDiskIoStatsIoMerged> IoMerged { get; set; }
                        public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsDiskIoStatsIoMerged : TeaModel {
                            public string Stats { get; set; }
                            public long? Minor { get; set; }
                            public long? Major { get; set; }
                            public string Device { get; set; }
                        }
                        [NameInMap("Sectors")]
                        [Validation(Required=false)]
                        public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsDiskIoStatsSectors> Sectors { get; set; }
                        public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsDiskIoStatsSectors : TeaModel {
                            public string Stats { get; set; }
                            public long? Minor { get; set; }
                            public long? Major { get; set; }
                            public string Device { get; set; }
                        }
                        [NameInMap("IoQueued")]
                        [Validation(Required=false)]
                        public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsDiskIoStatsIoQueued> IoQueued { get; set; }
                        public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsDiskIoStatsIoQueued : TeaModel {
                            public string Stats { get; set; }
                            public long? Minor { get; set; }
                            public long? Major { get; set; }
                            public string Device { get; set; }
                        }
                        [NameInMap("IoTime")]
                        [Validation(Required=false)]
                        public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsDiskIoStatsIoTime> IoTime { get; set; }
                        public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsDiskIoStatsIoTime : TeaModel {
                            public string Stats { get; set; }
                            public long? Minor { get; set; }
                            public long? Major { get; set; }
                            public string Device { get; set; }
                        }
                        [NameInMap("IoWaitTime")]
                        [Validation(Required=false)]
                        public List<DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsDiskIoStatsIoWaitTime> IoWaitTime { get; set; }
                        public class DescribeMultiContainerGroupMetricResponseBodyMonitorDatasContainerInfosContainerStatsDiskIoStatsIoWaitTime : TeaModel {
                            public string Stats { get; set; }
                            public long? Minor { get; set; }
                            public long? Major { get; set; }
                            public string Device { get; set; }
                        }
                    };

                }

                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

            [NameInMap("ContainerGroupId")]
            [Validation(Required=false)]
            public string ContainerGroupId { get; set; }

        }

    }

}
