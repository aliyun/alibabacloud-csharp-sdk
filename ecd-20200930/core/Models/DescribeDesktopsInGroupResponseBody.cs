// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopsInGroupResponseBody : TeaModel {
        /// <summary>
        /// The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The number of subscription cloud computers that are in the Connected state.
        /// </summary>
        [NameInMap("OnlinePrePaidDesktopsCount")]
        [Validation(Required=false)]
        public int? OnlinePrePaidDesktopsCount { get; set; }

        /// <summary>
        /// The details about subscription cloud computers.
        /// </summary>
        [NameInMap("PaidDesktops")]
        [Validation(Required=false)]
        public List<DescribeDesktopsInGroupResponseBodyPaidDesktops> PaidDesktops { get; set; }
        public class DescribeDesktopsInGroupResponseBodyPaidDesktops : TeaModel {
            /// <summary>
            /// The connection status of the cloud computer.
            /// 
            /// Valid values:
            /// 
            /// *   Unknown
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Connected
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Disconnected
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            /// <summary>
            /// The ID of the cloud computer.
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// The name of the cloud computer.
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// The status of the cloud computer.
            /// 
            /// Valid values:
            /// 
            /// *   Stopped
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Starting
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Rebuilding
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Running
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Stopping
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Expired
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Deleted
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Pending
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("DesktopStatus")]
            [Validation(Required=false)]
            public string DesktopStatus { get; set; }

            /// <summary>
            /// The type of the disk.
            /// 
            /// Valid values:
            /// 
            /// *   SYSTEM: system disk
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   DATA: data disk
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// The ID of the authorized user of the cloud computer.
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// The IDs of the end users who are connected to the cloud computers in the cloud computer pool. If no end users are connected, no values are returned for this parameter.
            /// </summary>
            [NameInMap("EndUserIds")]
            [Validation(Required=false)]
            public List<string> EndUserIds { get; set; }

            /// <summary>
            /// The username of the authorized user.
            /// </summary>
            [NameInMap("EndUserName")]
            [Validation(Required=false)]
            public string EndUserName { get; set; }

            /// <summary>
            /// The usernames of the end users who are connected to the cloud computers in the cloud computer pool. If no end users are connected, no values are returned for this parameter.
            /// </summary>
            [NameInMap("EndUserNames")]
            [Validation(Required=false)]
            public List<string> EndUserNames { get; set; }

            /// <summary>
            /// The image version.
            /// </summary>
            [NameInMap("FotaVersion")]
            [Validation(Required=false)]
            public string FotaVersion { get; set; }

            /// <summary>
            /// The version of the GPU driver.
            /// </summary>
            [NameInMap("GpuDriverVersion")]
            [Validation(Required=false)]
            public string GpuDriverVersion { get; set; }

            /// <summary>
            /// The image ID.
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The image name.
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// The flag that is used to manage the cloud computer.
            /// 
            /// Valid values:
            /// 
            /// *   Updating: The configurations of the cloud computer are being updated.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   NoFlag: No flags are attached to the cloud computer.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("ManagementFlag")]
            [Validation(Required=false)]
            public string ManagementFlag { get; set; }

            /// <summary>
            /// The flags that are used to manage the cloud computers.
            /// </summary>
            [NameInMap("ManagementFlags")]
            [Validation(Required=false)]
            public List<string> ManagementFlags { get; set; }

            /// <summary>
            /// The IP address of the member network interface controller (NIC) of the instance.
            /// </summary>
            [NameInMap("MemberEniIp")]
            [Validation(Required=false)]
            public string MemberEniIp { get; set; }

            /// <summary>
            /// The OS.
            /// 
            /// Valid values:
            /// 
            /// *   Linux
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Windows
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// The IP address of the primary NIC of the instance.
            /// </summary>
            [NameInMap("PrimaryEniIp")]
            [Validation(Required=false)]
            public string PrimaryEniIp { get; set; }

            /// <summary>
            /// The protocol.
            /// 
            /// Valid values:
            /// 
            /// *   HDX: High-definition Experience (HDX) protocol
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   ASP: Adaptive Streaming Protocol (ASP) protocol provided by Alibaba Cloud
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// The time when the cloud computer was reset.
            /// </summary>
            [NameInMap("ResetTime")]
            [Validation(Required=false)]
            public string ResetTime { get; set; }

            /// <summary>
            /// The system disk size. Unit: GiB.
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

        }

        /// <summary>
        /// The total number of queried subscription cloud computers.
        /// </summary>
        [NameInMap("PaidDesktopsCount")]
        [Validation(Required=false)]
        public int? PaidDesktopsCount { get; set; }

        /// <summary>
        /// The details about pay-as-you-go cloud computers.
        /// </summary>
        [NameInMap("PostPaidDesktops")]
        [Validation(Required=false)]
        public List<DescribeDesktopsInGroupResponseBodyPostPaidDesktops> PostPaidDesktops { get; set; }
        public class DescribeDesktopsInGroupResponseBodyPostPaidDesktops : TeaModel {
            /// <summary>
            /// The connection status of the cloud computer.
            /// 
            /// Valid values:
            /// 
            /// *   Unknown
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Connected
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Disconnected
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            /// <summary>
            /// The retention period of the cloud computer.
            /// </summary>
            [NameInMap("CreateDuration")]
            [Validation(Required=false)]
            public string CreateDuration { get; set; }

            /// <summary>
            /// The time when the cloud computer was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The ID of the cloud computer.
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// The name of the cloud computer.
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// The status of the cloud computer.
            /// 
            /// Valid values:
            /// 
            /// *   Stopped
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Starting
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Rebuilding
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Running
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Stopping
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Expired
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Deleted
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Pending
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("DesktopStatus")]
            [Validation(Required=false)]
            public string DesktopStatus { get; set; }

            /// <summary>
            /// The type of the disk.
            /// 
            /// Valid values:
            /// 
            /// *   SYSTEM: system disk
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   DATA: data disk
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// The ID of the authorized user.
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// The IDs of the end users who are connected to the cloud computers in the cloud computer pool. If no end users are connected, no values are returned for this parameter.
            /// </summary>
            [NameInMap("EndUserIds")]
            [Validation(Required=false)]
            public List<string> EndUserIds { get; set; }

            /// <summary>
            /// The username of the authorized user.
            /// </summary>
            [NameInMap("EndUserName")]
            [Validation(Required=false)]
            public string EndUserName { get; set; }

            /// <summary>
            /// The usernames of the end users who are connected to the cloud computers in the cloud computer pool. If no end users are connected, no values are returned for this parameter.
            /// </summary>
            [NameInMap("EndUserNames")]
            [Validation(Required=false)]
            public List<string> EndUserNames { get; set; }

            /// <summary>
            /// The image version.
            /// </summary>
            [NameInMap("FotaVersion")]
            [Validation(Required=false)]
            public string FotaVersion { get; set; }

            /// <summary>
            /// The version of the GPU driver.
            /// </summary>
            [NameInMap("GpuDriverVersion")]
            [Validation(Required=false)]
            public string GpuDriverVersion { get; set; }

            /// <summary>
            /// The image ID.
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The image name.
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// The flag that is used to manage the cloud computer.
            /// 
            /// Valid values:
            /// 
            /// *   Updating: The configurations of the cloud computer are being updated.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   NoFlag: No flags are attached to the cloud computer.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("ManagementFlag")]
            [Validation(Required=false)]
            public string ManagementFlag { get; set; }

            /// <summary>
            /// The flags that are used to manage the cloud computers.
            /// </summary>
            [NameInMap("ManagementFlags")]
            [Validation(Required=false)]
            public List<string> ManagementFlags { get; set; }

            /// <summary>
            /// The IP address of the member NIC of the instance.
            /// </summary>
            [NameInMap("MemberEniIp")]
            [Validation(Required=false)]
            public string MemberEniIp { get; set; }

            /// <summary>
            /// The OS.
            /// 
            /// Valid values:
            /// 
            /// *   Linux
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Windows
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// The IP address of the primary NIC of the instance.
            /// </summary>
            [NameInMap("PrimaryEniIp")]
            [Validation(Required=false)]
            public string PrimaryEniIp { get; set; }

            /// <summary>
            /// The protocol.
            /// 
            /// Valid values:
            /// 
            /// *   HDX: HDX protocol
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   ASP: ASP protocol provided by Alibaba Cloud
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// The time when the cloud computer was released.
            /// </summary>
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public string ReleaseTime { get; set; }

            /// <summary>
            /// The time when the cloud computer was reset.
            /// </summary>
            [NameInMap("ResetTime")]
            [Validation(Required=false)]
            public string ResetTime { get; set; }

            /// <summary>
            /// The system disk size. Unit: GiB.
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

        }

        /// <summary>
        /// The total number of queried pay-as-you-go cloud computers.
        /// </summary>
        [NameInMap("PostPaidDesktopsCount")]
        [Validation(Required=false)]
        public int? PostPaidDesktopsCount { get; set; }

        /// <summary>
        /// The total amount of bills for pay-as-you-go cloud computers.
        /// </summary>
        [NameInMap("PostPaidDesktopsTotalAmount")]
        [Validation(Required=false)]
        public int? PostPaidDesktopsTotalAmount { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of subscription cloud computers that are in the Running state.
        /// </summary>
        [NameInMap("RunningPrePaidDesktopsCount")]
        [Validation(Required=false)]
        public int? RunningPrePaidDesktopsCount { get; set; }

        /// <summary>
        /// The number of subscription cloud computers that are in the Stopped state.
        /// </summary>
        [NameInMap("StopedPrePaidDesktopsCount")]
        [Validation(Required=false)]
        public int? StopedPrePaidDesktopsCount { get; set; }

        /// <summary>
        /// The number of subscription cloud computers that are in the Stopped state.
        /// </summary>
        [NameInMap("StoppedPrePaidDesktopsCount")]
        [Validation(Required=false)]
        public int? StoppedPrePaidDesktopsCount { get; set; }

    }

}
