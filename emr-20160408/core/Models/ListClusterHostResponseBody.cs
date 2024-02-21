// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListClusterHostResponseBody : TeaModel {
        [NameInMap("HostList")]
        [Validation(Required=false)]
        public ListClusterHostResponseBodyHostList HostList { get; set; }
        public class ListClusterHostResponseBodyHostList : TeaModel {
            [NameInMap("Host")]
            [Validation(Required=false)]
            public List<ListClusterHostResponseBodyHostListHost> Host { get; set; }
            public class ListClusterHostResponseBodyHostListHost : TeaModel {
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DiskList")]
                [Validation(Required=false)]
                public ListClusterHostResponseBodyHostListHostDiskList DiskList { get; set; }
                public class ListClusterHostResponseBodyHostListHostDiskList : TeaModel {
                    [NameInMap("Disk")]
                    [Validation(Required=false)]
                    public List<ListClusterHostResponseBodyHostListHostDiskListDisk> Disk { get; set; }
                    public class ListClusterHostResponseBodyHostListHostDiskListDisk : TeaModel {
                        [NameInMap("BlockMountPoint")]
                        [Validation(Required=false)]
                        public string BlockMountPoint { get; set; }

                        [NameInMap("Device")]
                        [Validation(Required=false)]
                        public string Device { get; set; }

                        [NameInMap("DiskId")]
                        [Validation(Required=false)]
                        public string DiskId { get; set; }

                        [NameInMap("DiskMountPoint")]
                        [Validation(Required=false)]
                        public string DiskMountPoint { get; set; }

                        [NameInMap("DiskSize")]
                        [Validation(Required=false)]
                        public int? DiskSize { get; set; }

                        [NameInMap("DiskType")]
                        [Validation(Required=false)]
                        public string DiskType { get; set; }

                        [NameInMap("Event")]
                        [Validation(Required=false)]
                        public string Event { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                [NameInMap("EmrExpiredTime")]
                [Validation(Required=false)]
                public string EmrExpiredTime { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public long? ExpiredTime { get; set; }

                [NameInMap("HostGroupId")]
                [Validation(Required=false)]
                public string HostGroupId { get; set; }

                [NameInMap("HostInstanceId")]
                [Validation(Required=false)]
                public string HostInstanceId { get; set; }

                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                [NameInMap("InstanceStatus")]
                [Validation(Required=false)]
                public string InstanceStatus { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

                [NameInMap("PrivateIp")]
                [Validation(Required=false)]
                public string PrivateIp { get; set; }

                [NameInMap("PublicIp")]
                [Validation(Required=false)]
                public string PublicIp { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("SupportIpV6")]
                [Validation(Required=false)]
                public bool? SupportIpV6 { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
