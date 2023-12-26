// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeMountTargetsResponseBody : TeaModel {
        /// <summary>
        /// The information about mount targets.
        /// </summary>
        [NameInMap("MountTargets")]
        [Validation(Required=false)]
        public DescribeMountTargetsResponseBodyMountTargets MountTargets { get; set; }
        public class DescribeMountTargetsResponseBodyMountTargets : TeaModel {
            [NameInMap("MountTarget")]
            [Validation(Required=false)]
            public List<DescribeMountTargetsResponseBodyMountTargetsMountTarget> MountTarget { get; set; }
            public class DescribeMountTargetsResponseBodyMountTargetsMountTarget : TeaModel {
                /// <summary>
                /// The name of the permission group that is attached to the mount target.
                /// </summary>
                [NameInMap("AccessGroup")]
                [Validation(Required=false)]
                public string AccessGroup { get; set; }

                /// <summary>
                /// The information about client management nodes.
                /// </summary>
                [NameInMap("ClientMasterNodes")]
                [Validation(Required=false)]
                public DescribeMountTargetsResponseBodyMountTargetsMountTargetClientMasterNodes ClientMasterNodes { get; set; }
                public class DescribeMountTargetsResponseBodyMountTargetsMountTargetClientMasterNodes : TeaModel {
                    [NameInMap("ClientMasterNode")]
                    [Validation(Required=false)]
                    public List<DescribeMountTargetsResponseBodyMountTargetsMountTargetClientMasterNodesClientMasterNode> ClientMasterNode { get; set; }
                    public class DescribeMountTargetsResponseBodyMountTargetsMountTargetClientMasterNodesClientMasterNode : TeaModel {
                        /// <summary>
                        /// The default logon password of the ECS instance.
                        /// </summary>
                        [NameInMap("DefaultPasswd")]
                        [Validation(Required=false)]
                        public string DefaultPasswd { get; set; }

                        /// <summary>
                        /// The ID of the ECS instance on the client management node.
                        /// </summary>
                        [NameInMap("EcsId")]
                        [Validation(Required=false)]
                        public string EcsId { get; set; }

                        /// <summary>
                        /// The IP address of the ECS instance on the client management node.
                        /// </summary>
                        [NameInMap("EcsIp")]
                        [Validation(Required=false)]
                        public string EcsIp { get; set; }

                    }

                }

                /// <summary>
                /// The dual-stack (IPv4 and IPv6) domain name of the mount target.
                /// </summary>
                [NameInMap("DualStackMountTargetDomain")]
                [Validation(Required=false)]
                public string DualStackMountTargetDomain { get; set; }

                /// <summary>
                /// The type of the mount target.
                /// 
                /// *   IPv4: an IPv4 mount target
                /// *   DualStack: a dual-stack mount target
                /// </summary>
                [NameInMap("IPVersion")]
                [Validation(Required=false)]
                public string IPVersion { get; set; }

                /// <summary>
                /// The IPv4 domain name of the mount target.
                /// </summary>
                [NameInMap("MountTargetDomain")]
                [Validation(Required=false)]
                public string MountTargetDomain { get; set; }

                /// <summary>
                /// The network type. Valid value: **Vpc**.
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// The status of the mount target.
                /// 
                /// Valid values:
                /// 
                /// *   Active: The mount target is available.
                /// *   Inactive: The mount target is unavailable.
                /// *   Pending: The mount target is being created or modified.
                /// *   Deleting: The mount target is being deleted.
                /// *   Hibernating: The mount target is being hibernated.
                /// *   Hibernated: The mount target is hibernated.
                /// 
                /// > You can mount a file system only when the mount target of the file system is in the Active state.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The ID of the virtual private cloud (VPC).
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The ID of the vSwitch.
                /// </summary>
                [NameInMap("VswId")]
                [Validation(Required=false)]
                public string VswId { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
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
        /// The total number of mount targets.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
