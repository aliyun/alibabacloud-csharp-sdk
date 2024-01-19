// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class DescribeSourceServersResponseBody : TeaModel {
        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the migration source.
        /// </summary>
        [NameInMap("SourceServers")]
        [Validation(Required=false)]
        public DescribeSourceServersResponseBodySourceServers SourceServers { get; set; }
        public class DescribeSourceServersResponseBodySourceServers : TeaModel {
            [NameInMap("SourceServer")]
            [Validation(Required=false)]
            public List<DescribeSourceServersResponseBodySourceServersSourceServer> SourceServer { get; set; }
            public class DescribeSourceServersResponseBodySourceServersSourceServer : TeaModel {
                /// <summary>
                /// The version number of the SMC client.
                /// </summary>
                [NameInMap("AgentVersion")]
                [Validation(Required=false)]
                public string AgentVersion { get; set; }

                /// <summary>
                /// The system architecture of the migration source.
                /// </summary>
                [NameInMap("Architecture")]
                [Validation(Required=false)]
                public string Architecture { get; set; }

                /// <summary>
                /// The time when the migration source was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The data disk on the migration source.
                /// </summary>
                [NameInMap("DataDisks")]
                [Validation(Required=false)]
                public DescribeSourceServersResponseBodySourceServersSourceServerDataDisks DataDisks { get; set; }
                public class DescribeSourceServersResponseBodySourceServersSourceServerDataDisks : TeaModel {
                    [NameInMap("DataDisk")]
                    [Validation(Required=false)]
                    public List<DescribeSourceServersResponseBodySourceServersSourceServerDataDisksDataDisk> DataDisk { get; set; }
                    public class DescribeSourceServersResponseBodySourceServersSourceServerDataDisksDataDisk : TeaModel {
                        /// <summary>
                        /// The index number of the data disk.
                        /// </summary>
                        [NameInMap("Index")]
                        [Validation(Required=false)]
                        public int? Index { get; set; }

                        /// <summary>
                        /// The information about the data disk partition.
                        /// </summary>
                        [NameInMap("Parts")]
                        [Validation(Required=false)]
                        public DescribeSourceServersResponseBodySourceServersSourceServerDataDisksDataDiskParts Parts { get; set; }
                        public class DescribeSourceServersResponseBodySourceServersSourceServerDataDisksDataDiskParts : TeaModel {
                            [NameInMap("Part")]
                            [Validation(Required=false)]
                            public List<DescribeSourceServersResponseBodySourceServersSourceServerDataDisksDataDiskPartsPart> Part { get; set; }
                            public class DescribeSourceServersResponseBodySourceServersSourceServerDataDisksDataDiskPartsPart : TeaModel {
                                /// <summary>
                                /// Indicates whether block replication is enabled for the data disk partition.
                                /// </summary>
                                [NameInMap("CanBlock")]
                                [Validation(Required=false)]
                                public bool? CanBlock { get; set; }

                                /// <summary>
                                /// The device ID of the data disk partition.
                                /// </summary>
                                [NameInMap("Device")]
                                [Validation(Required=false)]
                                public string Device { get; set; }

                                /// <summary>
                                /// Indicates whether the data disk partition must be selected.
                                /// </summary>
                                [NameInMap("Need")]
                                [Validation(Required=false)]
                                public bool? Need { get; set; }

                                /// <summary>
                                /// The path of the data disk partition.
                                /// </summary>
                                [NameInMap("Path")]
                                [Validation(Required=false)]
                                public string Path { get; set; }

                                /// <summary>
                                /// The size of the data disk partition. Unit: byte.
                                /// </summary>
                                [NameInMap("SizeBytes")]
                                [Validation(Required=false)]
                                public long? SizeBytes { get; set; }

                            }

                        }

                        /// <summary>
                        /// The path of the data disk.
                        /// </summary>
                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        /// <summary>
                        /// The size of the data disk. Unit: GiB.
                        /// </summary>
                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public int? Size { get; set; }

                    }

                }

                /// <summary>
                /// The description of the migration source.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The error code of the migration source.
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// The interval at which heartbeats are sent from the SMC client. Unit: seconds.
                /// </summary>
                [NameInMap("HeartbeatRate")]
                [Validation(Required=false)]
                public int? HeartbeatRate { get; set; }

                /// <summary>
                /// The ID of the last migration job.
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// The kernel level of the migration source.
                /// </summary>
                [NameInMap("KernelLevel")]
                [Validation(Required=false)]
                public int? KernelLevel { get; set; }

                /// <summary>
                /// The name of the migration source.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The operating system of the migration source.
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// The replication driver used for migration. Default value: SMT.
                /// </summary>
                [NameInMap("ReplicationDriver")]
                [Validation(Required=false)]
                public string ReplicationDriver { get; set; }

                /// <summary>
                /// The resource group ID.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The ID of the migration source.
                /// </summary>
                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

                /// <summary>
                /// The state of the migration source.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The status information of the migration source. This parameter is returned if the migration source is in the Unavailable state. The value of this parameter consists of key-value pairs in the JSON format. Sample keys:
                /// 
                ///     error_code: The error code.
                ///     error_msg: The error message.
                /// </summary>
                [NameInMap("StatusInfo")]
                [Validation(Required=false)]
                public string StatusInfo { get; set; }

                /// <summary>
                /// The information about the system disk partition.
                /// </summary>
                [NameInMap("SystemDiskParts")]
                [Validation(Required=false)]
                public DescribeSourceServersResponseBodySourceServersSourceServerSystemDiskParts SystemDiskParts { get; set; }
                public class DescribeSourceServersResponseBodySourceServersSourceServerSystemDiskParts : TeaModel {
                    [NameInMap("SystemDiskPart")]
                    [Validation(Required=false)]
                    public List<DescribeSourceServersResponseBodySourceServersSourceServerSystemDiskPartsSystemDiskPart> SystemDiskPart { get; set; }
                    public class DescribeSourceServersResponseBodySourceServersSourceServerSystemDiskPartsSystemDiskPart : TeaModel {
                        /// <summary>
                        /// Indicates whether block replication is enabled for the system disk partition.
                        /// </summary>
                        [NameInMap("CanBlock")]
                        [Validation(Required=false)]
                        public bool? CanBlock { get; set; }

                        /// <summary>
                        /// The device ID of the system disk partition.
                        /// </summary>
                        [NameInMap("Device")]
                        [Validation(Required=false)]
                        public string Device { get; set; }

                        /// <summary>
                        /// Indicates whether the system disk partition must be selected.
                        /// </summary>
                        [NameInMap("Need")]
                        [Validation(Required=false)]
                        public bool? Need { get; set; }

                        /// <summary>
                        /// The path of the system disk partition.
                        /// </summary>
                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        /// <summary>
                        /// The size of the system disk partition. Unit: byte.
                        /// </summary>
                        [NameInMap("SizeBytes")]
                        [Validation(Required=false)]
                        public long? SizeBytes { get; set; }

                    }

                }

                /// <summary>
                /// The system disk size of the migration source. Unit: GiB.
                /// </summary>
                [NameInMap("SystemDiskSize")]
                [Validation(Required=false)]
                public int? SystemDiskSize { get; set; }

                /// <summary>
                /// The system information of the migration source. The value of this parameter consists of key-value pairs in the JSON format. The key-value pairs are extensible and have fixed keys. The JSON string does not exceed 1 KB in size. Sample keys:
                /// 
                ///     agent_mode: The migration mode.
                ///     agent_type: The migration type.
                ///     client_type: The client type.
                ///     hostname: The host name.
                ///     ipv4: The IPv4 address.
                ///     ipv6: The IPv6 address.
                ///     .cores: The number of CPU cores.
                ///     cpu_usage: The CPU utilization.
                ///     memory: The memory size.
                ///     memory_usage: The memory usage.
                /// </summary>
                [NameInMap("SystemInfo")]
                [Validation(Required=false)]
                public string SystemInfo { get; set; }

                /// <summary>
                /// The information about the tags.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeSourceServersResponseBodySourceServersSourceServerTags Tags { get; set; }
                public class DescribeSourceServersResponseBodySourceServersSourceServerTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeSourceServersResponseBodySourceServersSourceServerTagsTag> Tag { get; set; }
                    public class DescribeSourceServersResponseBodySourceServersSourceServerTagsTag : TeaModel {
                        /// <summary>
                        /// The key of tag N that is added to the SMC resource. Valid values of N: 1 to 20
                        /// 
                        /// You cannot specify empty strings as tag keys. It can be up to 64 characters in length and cannot start with acs: or aliyun. It cannot contain http:// or https://.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of tag N that is added to the SMC resource. Valid values of N: 1 to 20
                        /// 
                        /// The tag key can be an empty string. It can be up to 64 characters in length and cannot contain http:// or https://.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The total number of migration sources returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
