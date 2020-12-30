// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListClusterHostResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("HostList")]
        [Validation(Required=false)]
        public ListClusterHostResponseBodyHostList HostList { get; set; }
        public class ListClusterHostResponseBodyHostList : TeaModel {
            [NameInMap("Host")]
            [Validation(Required=false)]
            public List<ListClusterHostResponseBodyHostListHost> Host { get; set; }
            public class ListClusterHostResponseBodyHostListHost : TeaModel {
                public string Status { get; set; }
                public string Type { get; set; }
                public string SerialNumber { get; set; }
                public string PrivateIp { get; set; }
                public ListClusterHostResponseBodyHostListHostDiskList DiskList { get; set; }
                public class ListClusterHostResponseBodyHostListHostDiskList : TeaModel {
                    [NameInMap("Disk")]
                    [Validation(Required=false)]
                    public List<ListClusterHostResponseBodyHostListHostDiskListDisk> Disk { get; set; }
                    public class ListClusterHostResponseBodyHostListHostDiskListDisk : TeaModel {
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("DiskMountPoint")]
                        [Validation(Required=false)]
                        public string DiskMountPoint { get; set; }

                        [NameInMap("BlockMountPoint")]
                        [Validation(Required=false)]
                        public string BlockMountPoint { get; set; }

                        [NameInMap("Device")]
                        [Validation(Required=false)]
                        public string Device { get; set; }

                        [NameInMap("DiskSize")]
                        [Validation(Required=false)]
                        public int? DiskSize { get; set; }

                        [NameInMap("Event")]
                        [Validation(Required=false)]
                        public string Event { get; set; }

                        [NameInMap("DiskType")]
                        [Validation(Required=false)]
                        public string DiskType { get; set; }

                        [NameInMap("DiskId")]
                        [Validation(Required=false)]
                        public string DiskId { get; set; }

                    }

                }
                public string CreateTime { get; set; }
                public string ChargeType { get; set; }
                public string HostName { get; set; }
                public string HostGroupId { get; set; }
                public string InstanceType { get; set; }
                public string HostInstanceId { get; set; }
                public bool? SupportIpV6 { get; set; }
                public int? Cpu { get; set; }
                public long? ExpiredTime { get; set; }
                public string ZoneId { get; set; }
                public string PublicIp { get; set; }
                public string InstanceStatus { get; set; }
                public int? Memory { get; set; }
                public string EmrExpiredTime { get; set; }
                public string Role { get; set; }
            }
        };

    }

}
