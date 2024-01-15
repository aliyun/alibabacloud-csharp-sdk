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
        /// The number of subscription cloud desktops that are connected.
        /// </summary>
        [NameInMap("OnlinePrePaidDesktopsCount")]
        [Validation(Required=false)]
        public int? OnlinePrePaidDesktopsCount { get; set; }

        /// <summary>
        /// The subscription cloud desktops.
        /// </summary>
        [NameInMap("PaidDesktops")]
        [Validation(Required=false)]
        public List<DescribeDesktopsInGroupResponseBodyPaidDesktops> PaidDesktops { get; set; }
        public class DescribeDesktopsInGroupResponseBodyPaidDesktops : TeaModel {
            /// <summary>
            /// The connection state.
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
            /// The cloud desktop ID.
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// The cloud desktop name.
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// The state of the cloud desktop.
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
            /// The disk type.
            /// 
            /// Valid values:
            /// 
            /// *   SYSTEM
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     the system disk
            /// 
            ///     <!-- -->
            /// 
            /// *   DATA:
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     the data disk
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// The authorized user.
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// The IDs of users that are connected to cloud desktops. If no users are connected, null is returned.
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
            /// The names of users that are connected to cloud desktops. If no users are connected, null is returned.
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
            /// The GPU driver version.
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
            /// The flag that is used for management.
            /// 
            /// Valid values:
            /// 
            /// *   Updating: The configurations of the cloud desktop are being changed.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   NoFlag: No flags are available.
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
            /// The flags that are used for management.
            /// </summary>
            [NameInMap("ManagementFlags")]
            [Validation(Required=false)]
            public List<string> ManagementFlags { get; set; }

            /// <summary>
            /// The IP address of the member Elastic Network Interface (ENI).
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
            /// The IP address of the primary ENI.
            /// </summary>
            [NameInMap("PrimaryEniIp")]
            [Validation(Required=false)]
            public string PrimaryEniIp { get; set; }

            /// <summary>
            /// The protocol type. Valid values:
            /// 
            /// *   ASP
            /// *   HDX
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// The point in time when the cloud desktop was reset.
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
        /// The total number of subscription cloud desktops.
        /// </summary>
        [NameInMap("PaidDesktopsCount")]
        [Validation(Required=false)]
        public int? PaidDesktopsCount { get; set; }

        /// <summary>
        /// The pay-as-you-go cloud desktops.
        /// </summary>
        [NameInMap("PostPaidDesktops")]
        [Validation(Required=false)]
        public List<DescribeDesktopsInGroupResponseBodyPostPaidDesktops> PostPaidDesktops { get; set; }
        public class DescribeDesktopsInGroupResponseBodyPostPaidDesktops : TeaModel {
            /// <summary>
            /// The connection state.
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
            /// The retention period.
            /// </summary>
            [NameInMap("CreateDuration")]
            [Validation(Required=false)]
            public string CreateDuration { get; set; }

            /// <summary>
            /// The time when the auxiliary media asset was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The cloud desktop ID.
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// The cloud desktop name.
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// The state of the cloud desktop.
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
            /// The disk type.
            /// 
            /// Valid values:
            /// 
            /// *   SYSTEM
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     the system disk
            /// 
            ///     <!-- -->
            /// 
            /// *   DATA:
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     the data disk
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// The authorized user.
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// The IDs of users that are connected to cloud desktops. If no users are connected, null is returned.
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
            /// The names of users that are connected to cloud desktops. If no users are connected, null is returned.
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
            /// The GPU driver version.
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
            /// The flag that is used for management.
            /// 
            /// Valid values:
            /// 
            /// *   Updating: The configurations of the cloud desktop are being changed.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   NoFlag: No flags are available.
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
            /// The flags that are used for management.
            /// </summary>
            [NameInMap("ManagementFlags")]
            [Validation(Required=false)]
            public List<string> ManagementFlags { get; set; }

            /// <summary>
            /// The IP address of the member Elastic Network Interface (ENI).
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
            /// The IP address of the primary ENI.
            /// </summary>
            [NameInMap("PrimaryEniIp")]
            [Validation(Required=false)]
            public string PrimaryEniIp { get; set; }

            /// <summary>
            /// The protocol type. Valid values:
            /// 
            /// *   ASP
            /// *   HDX
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// The time when the cloud desktop was released.
            /// </summary>
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public string ReleaseTime { get; set; }

            /// <summary>
            /// The point in time when the cloud desktop was reset.
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
        /// The total number of pay-as-you-go cloud desktops.
        /// </summary>
        [NameInMap("PostPaidDesktopsCount")]
        [Validation(Required=false)]
        public int? PostPaidDesktopsCount { get; set; }

        /// <summary>
        /// The total bill amount for the pay-as-you-go cloud desktops.
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
        /// The number of subscription cloud desktops that are running.
        /// </summary>
        [NameInMap("RunningPrePaidDesktopsCount")]
        [Validation(Required=false)]
        public int? RunningPrePaidDesktopsCount { get; set; }

        /// <summary>
        /// The number of subscription cloud desktops that are stopped.
        /// </summary>
        [NameInMap("StopedPrePaidDesktopsCount")]
        [Validation(Required=false)]
        public int? StopedPrePaidDesktopsCount { get; set; }

        /// <summary>
        /// The number of subscription cloud desktops that are stopped.
        /// </summary>
        [NameInMap("StoppedPrePaidDesktopsCount")]
        [Validation(Required=false)]
        public int? StoppedPrePaidDesktopsCount { get; set; }

    }

}
