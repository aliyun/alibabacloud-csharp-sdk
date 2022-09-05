// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopsInGroupResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OnlinePrePaidDesktopsCount")]
        [Validation(Required=false)]
        public int? OnlinePrePaidDesktopsCount { get; set; }

        [NameInMap("PaidDesktops")]
        [Validation(Required=false)]
        public List<DescribeDesktopsInGroupResponseBodyPaidDesktops> PaidDesktops { get; set; }
        public class DescribeDesktopsInGroupResponseBodyPaidDesktops : TeaModel {
            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            [NameInMap("DesktopStatus")]
            [Validation(Required=false)]
            public string DesktopStatus { get; set; }

            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            [NameInMap("EndUserIds")]
            [Validation(Required=false)]
            public List<string> EndUserIds { get; set; }

            [NameInMap("EndUserName")]
            [Validation(Required=false)]
            public string EndUserName { get; set; }

            [NameInMap("EndUserNames")]
            [Validation(Required=false)]
            public List<string> EndUserNames { get; set; }

            [NameInMap("GpuDriverVersion")]
            [Validation(Required=false)]
            public string GpuDriverVersion { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            [NameInMap("ManagementFlag")]
            [Validation(Required=false)]
            public string ManagementFlag { get; set; }

            [NameInMap("ManagementFlags")]
            [Validation(Required=false)]
            public List<string> ManagementFlags { get; set; }

            [NameInMap("MemberEniIp")]
            [Validation(Required=false)]
            public string MemberEniIp { get; set; }

            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            [NameInMap("PrimaryEniIp")]
            [Validation(Required=false)]
            public string PrimaryEniIp { get; set; }

            [NameInMap("ResetTime")]
            [Validation(Required=false)]
            public string ResetTime { get; set; }

            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

        }

        [NameInMap("PaidDesktopsCount")]
        [Validation(Required=false)]
        public int? PaidDesktopsCount { get; set; }

        [NameInMap("PostPaidDesktops")]
        [Validation(Required=false)]
        public List<DescribeDesktopsInGroupResponseBodyPostPaidDesktops> PostPaidDesktops { get; set; }
        public class DescribeDesktopsInGroupResponseBodyPostPaidDesktops : TeaModel {
            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            [NameInMap("CreateDuration")]
            [Validation(Required=false)]
            public string CreateDuration { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            [NameInMap("DesktopStatus")]
            [Validation(Required=false)]
            public string DesktopStatus { get; set; }

            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            [NameInMap("EndUserIds")]
            [Validation(Required=false)]
            public List<string> EndUserIds { get; set; }

            [NameInMap("EndUserName")]
            [Validation(Required=false)]
            public string EndUserName { get; set; }

            [NameInMap("EndUserNames")]
            [Validation(Required=false)]
            public List<string> EndUserNames { get; set; }

            [NameInMap("GpuDriverVersion")]
            [Validation(Required=false)]
            public string GpuDriverVersion { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            [NameInMap("ManagementFlag")]
            [Validation(Required=false)]
            public string ManagementFlag { get; set; }

            [NameInMap("ManagementFlags")]
            [Validation(Required=false)]
            public List<string> ManagementFlags { get; set; }

            [NameInMap("MemberEniIp")]
            [Validation(Required=false)]
            public string MemberEniIp { get; set; }

            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            [NameInMap("PrimaryEniIp")]
            [Validation(Required=false)]
            public string PrimaryEniIp { get; set; }

            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public string ReleaseTime { get; set; }

            [NameInMap("ResetTime")]
            [Validation(Required=false)]
            public string ResetTime { get; set; }

            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

        }

        [NameInMap("PostPaidDesktopsCount")]
        [Validation(Required=false)]
        public int? PostPaidDesktopsCount { get; set; }

        [NameInMap("PostPaidDesktopsTotalAmount")]
        [Validation(Required=false)]
        public int? PostPaidDesktopsTotalAmount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RunningPrePaidDesktopsCount")]
        [Validation(Required=false)]
        public int? RunningPrePaidDesktopsCount { get; set; }

        [NameInMap("StopedPrePaidDesktopsCount")]
        [Validation(Required=false)]
        public int? StopedPrePaidDesktopsCount { get; set; }

    }

}
