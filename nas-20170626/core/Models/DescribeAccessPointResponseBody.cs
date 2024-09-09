// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeAccessPointResponseBody : TeaModel {
        /// <summary>
        /// The information about the access point.
        /// </summary>
        [NameInMap("AccessPoint")]
        [Validation(Required=false)]
        public DescribeAccessPointResponseBodyAccessPoint AccessPoint { get; set; }
        public class DescribeAccessPointResponseBodyAccessPoint : TeaModel {
            /// <summary>
            /// The Alibaba Cloud Resource Name (ARN) of the access point.
            /// </summary>
            [NameInMap("ARN")]
            [Validation(Required=false)]
            public string ARN { get; set; }

            /// <summary>
            /// The name of the permission group.
            /// </summary>
            [NameInMap("AccessGroup")]
            [Validation(Required=false)]
            public string AccessGroup { get; set; }

            /// <summary>
            /// The ID of the access point.
            /// </summary>
            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public string AccessPointId { get; set; }

            /// <summary>
            /// The name of the access point.
            /// </summary>
            [NameInMap("AccessPointName")]
            [Validation(Required=false)]
            public string AccessPointName { get; set; }

            /// <summary>
            /// The time when the access point was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The domain name of the access point.
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// Indicates whether the RAM policy is enabled.
            /// </summary>
            [NameInMap("EnabledRam")]
            [Validation(Required=false)]
            public bool? EnabledRam { get; set; }

            /// <summary>
            /// The ID of the file system.
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// The time when the access point was modified.
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// The POSIX user.
            /// </summary>
            [NameInMap("PosixUser")]
            [Validation(Required=false)]
            public DescribeAccessPointResponseBodyAccessPointPosixUser PosixUser { get; set; }
            public class DescribeAccessPointResponseBodyAccessPointPosixUser : TeaModel {
                /// <summary>
                /// The ID of the POSIX user group.
                /// </summary>
                [NameInMap("PosixGroupId")]
                [Validation(Required=false)]
                public int? PosixGroupId { get; set; }

                /// <summary>
                /// The IDs of the secondary user groups.
                /// </summary>
                [NameInMap("PosixSecondaryGroupIds")]
                [Validation(Required=false)]
                public List<int?> PosixSecondaryGroupIds { get; set; }

                /// <summary>
                /// The ID of the POSIX user.
                /// </summary>
                [NameInMap("PosixUserId")]
                [Validation(Required=false)]
                public int? PosixUserId { get; set; }

            }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The root directory.
            /// </summary>
            [NameInMap("RootPath")]
            [Validation(Required=false)]
            public string RootPath { get; set; }

            /// <summary>
            /// The permissions to create the root directory.
            /// </summary>
            [NameInMap("RootPathPermission")]
            [Validation(Required=false)]
            public DescribeAccessPointResponseBodyAccessPointRootPathPermission RootPathPermission { get; set; }
            public class DescribeAccessPointResponseBodyAccessPointRootPathPermission : TeaModel {
                /// <summary>
                /// The ID of the owner group.
                /// </summary>
                [NameInMap("OwnerGroupId")]
                [Validation(Required=false)]
                public int? OwnerGroupId { get; set; }

                /// <summary>
                /// The owner ID.
                /// </summary>
                [NameInMap("OwnerUserId")]
                [Validation(Required=false)]
                public int? OwnerUserId { get; set; }

                /// <summary>
                /// The POSIX permission.
                /// </summary>
                [NameInMap("Permission")]
                [Validation(Required=false)]
                public string Permission { get; set; }

            }

            /// <summary>
            /// The status of the root directory.
            /// 
            /// Valid values:
            /// 
            /// *   0: The rootpath status is unknown.
            /// *   1: The rootpath does not exist and may be deleted.
            /// *   2: The rootpath is normal.
            /// </summary>
            [NameInMap("RootPathStatus")]
            [Validation(Required=false)]
            public string RootPathStatus { get; set; }

            /// <summary>
            /// The status of the access point.
            /// 
            /// Valid values:
            /// 
            /// *   Active: The access point is available.
            /// *   Inactive: The access point is unavailable.
            /// *   Pending: The access point is being created.
            /// *   Deleting: The access point is being deleted.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The vSwitch ID.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The ID of the virtual private cloud (VPC).
            /// 
            /// You must select the VPC of the Elastic Compute Service (ECS) instance on which you want to mount the file system.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
