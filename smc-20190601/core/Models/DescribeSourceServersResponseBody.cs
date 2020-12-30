// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class DescribeSourceServersResponseBody : TeaModel {
        [NameInMap("SourceServers")]
        [Validation(Required=false)]
        public DescribeSourceServersResponseBodySourceServers SourceServers { get; set; }
        public class DescribeSourceServersResponseBodySourceServers : TeaModel {
            [NameInMap("SourceServer")]
            [Validation(Required=false)]
            public List<DescribeSourceServersResponseBodySourceServersSourceServer> SourceServer { get; set; }
            public class DescribeSourceServersResponseBodySourceServersSourceServer : TeaModel {
                public string CreationTime { get; set; }
                public int? HeartbeatRate { get; set; }
                public string State { get; set; }
                public DescribeSourceServersResponseBodySourceServersSourceServerDataDisks DataDisks { get; set; }
                public class DescribeSourceServersResponseBodySourceServersSourceServerDataDisks : TeaModel {
                    [NameInMap("DataDisk")]
                    [Validation(Required=false)]
                    public List<DescribeSourceServersResponseBodySourceServersSourceServerDataDisksDataDisk> DataDisk { get; set; }
                    public class DescribeSourceServersResponseBodySourceServersSourceServerDataDisksDataDisk : TeaModel {
                        [NameInMap("Index")]
                        [Validation(Required=false)]
                        public int? Index { get; set; }

                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public int? Size { get; set; }

                        [NameInMap("Parts")]
                        [Validation(Required=false)]
                        public DescribeSourceServersResponseBodySourceServersSourceServerDataDisksDataDiskParts Parts { get; set; }
                        public class DescribeSourceServersResponseBodySourceServersSourceServerDataDisksDataDiskParts : TeaModel {
                            [NameInMap("Part")]
                            [Validation(Required=false)]
                            public List<DescribeSourceServersResponseBodySourceServersSourceServerDataDisksDataDiskPartsPart> Part { get; set; }
                            public class DescribeSourceServersResponseBodySourceServersSourceServerDataDisksDataDiskPartsPart : TeaModel {
                                public bool? CanBlock { get; set; }
                                public long? SizeBytes { get; set; }
                                public bool? Need { get; set; }
                                public string Device { get; set; }
                                public string Path { get; set; }
                            }
                        };

                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                    }

                }
                public DescribeSourceServersResponseBodySourceServersSourceServerSystemDiskParts SystemDiskParts { get; set; }
                public class DescribeSourceServersResponseBodySourceServersSourceServerSystemDiskParts : TeaModel {
                    [NameInMap("SystemDiskPart")]
                    [Validation(Required=false)]
                    public List<DescribeSourceServersResponseBodySourceServersSourceServerSystemDiskPartsSystemDiskPart> SystemDiskPart { get; set; }
                    public class DescribeSourceServersResponseBodySourceServersSourceServerSystemDiskPartsSystemDiskPart : TeaModel {
                        [NameInMap("CanBlock")]
                        [Validation(Required=false)]
                        public bool? CanBlock { get; set; }

                        [NameInMap("SizeBytes")]
                        [Validation(Required=false)]
                        public long? SizeBytes { get; set; }

                        [NameInMap("Need")]
                        [Validation(Required=false)]
                        public bool? Need { get; set; }

                        [NameInMap("Device")]
                        [Validation(Required=false)]
                        public string Device { get; set; }

                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                    }

                }
                public int? KernelLevel { get; set; }
                public string SourceId { get; set; }
                public string AgentVersion { get; set; }
                public string StatusInfo { get; set; }
                public int? SystemDiskSize { get; set; }
                public string Description { get; set; }
                public string ErrorCode { get; set; }
                public string JobId { get; set; }
                public string Platform { get; set; }
                public string ReplicationDriver { get; set; }
                public string Name { get; set; }
                public string SystemInfo { get; set; }
                public string Architecture { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
