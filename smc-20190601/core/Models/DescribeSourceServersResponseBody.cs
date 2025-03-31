// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class DescribeSourceServersResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>410E6073-66D0-45D3-AB3E-4DC3F5E4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the migration source.</para>
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
                /// <para>The version number of the SMC client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.5.2.3</para>
                /// </summary>
                [NameInMap("AgentVersion")]
                [Validation(Required=false)]
                public string AgentVersion { get; set; }

                /// <summary>
                /// <para>The system architecture of the migration source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>x86_64</para>
                /// </summary>
                [NameInMap("Architecture")]
                [Validation(Required=false)]
                public string Architecture { get; set; }

                /// <summary>
                /// <para>The time when the migration source was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-06-27T02:58:09Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The data disks on the migration source.</para>
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
                        /// <para>The index number of the data disk.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Index")]
                        [Validation(Required=false)]
                        public int? Index { get; set; }

                        /// <summary>
                        /// <para>The information about the data disk partition.</para>
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
                                /// <para>Indicates whether block replication is enabled for the data disk partition.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>false</para>
                                /// </summary>
                                [NameInMap("CanBlock")]
                                [Validation(Required=false)]
                                public bool? CanBlock { get; set; }

                                /// <summary>
                                /// <para>The device ID of the data disk partition.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1_0</para>
                                /// </summary>
                                [NameInMap("Device")]
                                [Validation(Required=false)]
                                public string Device { get; set; }

                                /// <summary>
                                /// <para>Indicates whether the data disk partition must be selected.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>false</para>
                                /// </summary>
                                [NameInMap("Need")]
                                [Validation(Required=false)]
                                public bool? Need { get; set; }

                                /// <summary>
                                /// <para>The path of the data disk partition.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>/home/data</para>
                                /// </summary>
                                [NameInMap("Path")]
                                [Validation(Required=false)]
                                public string Path { get; set; }

                                /// <summary>
                                /// <para>The size of the data disk partition. Unit: bytes.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>21474836480</para>
                                /// </summary>
                                [NameInMap("SizeBytes")]
                                [Validation(Required=false)]
                                public long? SizeBytes { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The path of data disk N.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/home/data</para>
                        /// </summary>
                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        /// <summary>
                        /// <para>The size of data disk N. Unit: GiB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20</para>
                        /// </summary>
                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public int? Size { get; set; }

                    }

                }

                /// <summary>
                /// <para>The description of the migration source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Server Source Imported By GotoAliyun.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The information about the disk.</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>false</c>
                /// </summary>
                [NameInMap("Disks")]
                [Validation(Required=false)]
                public DescribeSourceServersResponseBodySourceServersSourceServerDisks Disks { get; set; }
                public class DescribeSourceServersResponseBodySourceServersSourceServerDisks : TeaModel {
                    /// <summary>
                    /// <para>The list of data disk information.</para>
                    /// </summary>
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public DescribeSourceServersResponseBodySourceServersSourceServerDisksData Data { get; set; }
                    public class DescribeSourceServersResponseBodySourceServersSourceServerDisksData : TeaModel {
                        [NameInMap("Data")]
                        [Validation(Required=false)]
                        public List<DescribeSourceServersResponseBodySourceServersSourceServerDisksDataData> Data { get; set; }
                        public class DescribeSourceServersResponseBodySourceServersSourceServerDisksDataData : TeaModel {
                            /// <summary>
                            /// <para>The start offset of the first partition of the data disk. Unit: bytes.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1024</para>
                            /// </summary>
                            [NameInMap("Offset")]
                            [Validation(Required=false)]
                            public long? Offset { get; set; }

                            /// <summary>
                            /// <para>The information about the data disk partition.</para>
                            /// </summary>
                            [NameInMap("Parts")]
                            [Validation(Required=false)]
                            public DescribeSourceServersResponseBodySourceServersSourceServerDisksDataDataParts Parts { get; set; }
                            public class DescribeSourceServersResponseBodySourceServersSourceServerDisksDataDataParts : TeaModel {
                                [NameInMap("Part")]
                                [Validation(Required=false)]
                                public List<DescribeSourceServersResponseBodySourceServersSourceServerDisksDataDataPartsPart> Part { get; set; }
                                public class DescribeSourceServersResponseBodySourceServersSourceServerDisksDataDataPartsPart : TeaModel {
                                    /// <summary>
                                    /// <para>Whether block replication is enabled for the data disk partition. Valid values:</para>
                                    /// <list type="bullet">
                                    /// <item><description>true: Block replication is enabled for the data disk partition.</description></item>
                                    /// <item><description>false: Block replication is disabled for the data disk partition.</description></item>
                                    /// </list>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>false</para>
                                    /// </summary>
                                    [NameInMap("CanBlock")]
                                    [Validation(Required=false)]
                                    public bool? CanBlock { get; set; }

                                    /// <summary>
                                    /// <para>The path of the data disk partition.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>/home/data</para>
                                    /// </summary>
                                    [NameInMap("Path")]
                                    [Validation(Required=false)]
                                    public string Path { get; set; }

                                    /// <summary>
                                    /// <para>The size of the data disk partition. Unit: bytes.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>21474836480</para>
                                    /// </summary>
                                    [NameInMap("SizeBytes")]
                                    [Validation(Required=false)]
                                    public long? SizeBytes { get; set; }

                                    /// <summary>
                                    /// <para>The type of the data disk partition. Valid values:</para>
                                    /// <list type="bullet">
                                    /// <item><description>Normal: normal partition.</description></item>
                                    /// <item><description>System: system partition.</description></item>
                                    /// <item><description>Boot: boot partition.</description></item>
                                    /// </list>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>Normal</para>
                                    /// </summary>
                                    [NameInMap("Type")]
                                    [Validation(Required=false)]
                                    public string Type { get; set; }

                                }

                            }

                            /// <summary>
                            /// <para>The data disk size of the migration source. Unit: GiB.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>80</para>
                            /// </summary>
                            [NameInMap("Size")]
                            [Validation(Required=false)]
                            public int? Size { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The information about the system disk.</para>
                    /// 
                    /// <b>if can be null:</b>
                    /// <c>false</c>
                    /// </summary>
                    [NameInMap("System")]
                    [Validation(Required=false)]
                    public DescribeSourceServersResponseBodySourceServersSourceServerDisksSystem System { get; set; }
                    public class DescribeSourceServersResponseBodySourceServersSourceServerDisksSystem : TeaModel {
                        /// <summary>
                        /// <para>The start offset of the first partition of the system disk. Unit: bytes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1024</para>
                        /// </summary>
                        [NameInMap("Offset")]
                        [Validation(Required=false)]
                        public long? Offset { get; set; }

                        /// <summary>
                        /// <para>The information about the system disk partition.</para>
                        /// </summary>
                        [NameInMap("Parts")]
                        [Validation(Required=false)]
                        public DescribeSourceServersResponseBodySourceServersSourceServerDisksSystemParts Parts { get; set; }
                        public class DescribeSourceServersResponseBodySourceServersSourceServerDisksSystemParts : TeaModel {
                            [NameInMap("Part")]
                            [Validation(Required=false)]
                            public List<DescribeSourceServersResponseBodySourceServersSourceServerDisksSystemPartsPart> Part { get; set; }
                            public class DescribeSourceServersResponseBodySourceServersSourceServerDisksSystemPartsPart : TeaModel {
                                /// <summary>
                                /// <para>Indicates whether block replication is enabled for the system disk partition. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>true: Block replication is enabled for the system disk partition.</description></item>
                                /// <item><description>false: Block replication is disabled for the system disk partition.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>false</para>
                                /// </summary>
                                [NameInMap("CanBlock")]
                                [Validation(Required=false)]
                                public bool? CanBlock { get; set; }

                                /// <summary>
                                /// <para>The path of the system disk partition.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>/home/data</para>
                                /// </summary>
                                [NameInMap("Path")]
                                [Validation(Required=false)]
                                public string Path { get; set; }

                                /// <summary>
                                /// <para>The size of the system disk partition. Unit: bytes.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>21474836480</para>
                                /// </summary>
                                [NameInMap("SizeBytes")]
                                [Validation(Required=false)]
                                public long? SizeBytes { get; set; }

                                /// <summary>
                                /// <para>The type of the system disk partition. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>Normal: normal partition.</description></item>
                                /// <item><description>System: system partition.</description></item>
                                /// <item><description>Boot: boot partition.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>Normal</para>
                                /// </summary>
                                [NameInMap("Type")]
                                [Validation(Required=false)]
                                public string Type { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The size of the source system disk. Unit: GiB. Valid values: 20 to 32768.</para>
                        /// <remarks>
                        /// <para> The parameter value must be greater than the actual used space of the data disk on the source server. For example, if the size of the source disk is 500 GiB but the actual used space is 100 GiB, you must set this parameter to a value greater than 100 GiB.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public int? Size { get; set; }

                    }

                }

                /// <summary>
                /// <para>The error code of the migration source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SourceServer.Offline</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The interval at which heartbeats are sent from the SMC client. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("HeartbeatRate")]
                [Validation(Required=false)]
                public int? HeartbeatRate { get; set; }

                /// <summary>
                /// <para>The ID of the last migration job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>j-bp19vlwm0tyigbmj****</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The kernel level of the migration source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("KernelLevel")]
                [Validation(Required=false)]
                public int? KernelLevel { get; set; }

                /// <summary>
                /// <para>The name of the migration source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SourceServerName</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The operating system of the migration source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OpenSUSE</para>
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// <para>The replication driver used for migration. Default value: SMT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SMT</para>
                /// </summary>
                [NameInMap("ReplicationDriver")]
                [Validation(Required=false)]
                public string ReplicationDriver { get; set; }

                /// <summary>
                /// <para>The resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmw3ty5y7****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the migration source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>s-bp1e2fsl57knvuug****</para>
                /// </summary>
                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

                /// <summary>
                /// <para>The state of the migration source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InUse</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The status information of the migration source. This parameter is returned if the migration source is in the Unavailable state. The value of this parameter consists of key-value pairs in the JSON format. Sample keys:</para>
                /// <pre><c>error_code: The error code.
                /// error_msg: the error message.
                /// </c></pre>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;error_code&quot;: &quot;S1&quot;, &quot;error_msg&quot;: &quot;Rsync not found. Please install rsync.&quot;}</para>
                /// </summary>
                [NameInMap("StatusInfo")]
                [Validation(Required=false)]
                public string StatusInfo { get; set; }

                /// <summary>
                /// <para>The information about the system disk partition.</para>
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
                        /// <para>Indicates whether block replication is enabled for the system disk partition.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("CanBlock")]
                        [Validation(Required=false)]
                        public bool? CanBlock { get; set; }

                        /// <summary>
                        /// <para>The device ID of the system disk partition.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0_0</para>
                        /// </summary>
                        [NameInMap("Device")]
                        [Validation(Required=false)]
                        public string Device { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the system disk partition must be selected.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Need")]
                        [Validation(Required=false)]
                        public bool? Need { get; set; }

                        /// <summary>
                        /// <para>The path of the system disk partition.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/boot</para>
                        /// </summary>
                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        /// <summary>
                        /// <para>The size of the system disk partition. Unit: bytes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>254803968</para>
                        /// </summary>
                        [NameInMap("SizeBytes")]
                        [Validation(Required=false)]
                        public long? SizeBytes { get; set; }

                    }

                }

                /// <summary>
                /// <para>The system disk size of the migration source. Unit: GiB</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("SystemDiskSize")]
                [Validation(Required=false)]
                public int? SystemDiskSize { get; set; }

                /// <summary>
                /// <para>The system information of the migration source. The parameter must be specified as key-value pairs in the JSON format. The key-value pairs are extensible and have fixed keys. Maximum value: 1 KB. Example:</para>
                /// <pre><c>agent_mode: the running mode.
                /// agent_type: the type of the run.
                /// client_type: the type of the client.
                /// hostname : the hostname.
                /// ipv4:IPv4 address
                /// ipv6: IPv6 address
                /// cores: the number of CPU cores.
                /// cpu_usage: the CPU utilization.
                /// memory: the memory size.
                /// memory_usage: the memory usage.
                /// </c></pre>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;agent_mode\&quot;:\&quot;daemon\&quot;,\&quot;agent_type\&quot;:\&quot;aliyun\&quot;,\&quot;client_type\&quot;:\&quot;\&quot;,\&quot;cores\&quot;:\&quot;2\&quot;,\&quot;cpu_usage\&quot;:\&quot;0.00\&quot;,\&quot;hostname\&quot;:\&quot;ixxxxxxxxxx\&quot;,\&quot;ipv4\&quot;:\&quot;10.0.0.1\&quot;,\&quot;memory\&quot;:\&quot;8.00\&quot;,\&quot;memory_usage\&quot;:\&quot;3.61\&quot;}</para>
                /// </summary>
                [NameInMap("SystemInfo")]
                [Validation(Required=false)]
                public string SystemInfo { get; set; }

                /// <summary>
                /// <para>The tag details.</para>
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
                        /// <para>The key of tag N that is attached to the SMC resource. Valid values of N: 1 to 20.</para>
                        /// <para>You cannot specify an empty string as a tag key. The tag key can be up to 64 characters in length and cannot contain http:// or https://. The tag key cannot start with acs: or aliyun.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestKey</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of tag N that is attached to the SMC resource. Valid values of N: 1 to 20.</para>
                        /// <para>The tag key can be an empty string. The tag value can be up to 64 characters in length and cannot contain http:// or https://.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestValue</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The workgroup ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>w-bp1ja22kdqphehlj****</para>
                /// </summary>
                [NameInMap("WorkgroupId")]
                [Validation(Required=false)]
                public string WorkgroupId { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of migration sources returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
