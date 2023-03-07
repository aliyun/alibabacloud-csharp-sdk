// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetClusterVolumesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The array of the file system mounted to the E-HPC cluster.
        /// </summary>
        [NameInMap("Volumes")]
        [Validation(Required=false)]
        public GetClusterVolumesResponseBodyVolumes Volumes { get; set; }
        public class GetClusterVolumesResponseBodyVolumes : TeaModel {
            [NameInMap("VolumeInfo")]
            [Validation(Required=false)]
            public List<GetClusterVolumesResponseBodyVolumesVolumeInfo> VolumeInfo { get; set; }
            public class GetClusterVolumesResponseBodyVolumesVolumeInfo : TeaModel {
                /// <summary>
                /// The queue of the job.
                /// </summary>
                [NameInMap("JobQueue")]
                [Validation(Required=false)]
                public string JobQueue { get; set; }

                /// <summary>
                /// The local mount directory.
                /// </summary>
                [NameInMap("LocalDirectory")]
                [Validation(Required=false)]
                public string LocalDirectory { get; set; }

                /// <summary>
                /// The type of cluster. Valid values:
                /// 
                /// *   OnPremise: The cluster is deployed on a hybrid cloud.
                /// *   PublicCloud: The cluster is deployed on a public cloud.
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// Indicates whether the resource can be unmounted.
                /// </summary>
                [NameInMap("MustKeep")]
                [Validation(Required=false)]
                public bool? MustKeep { get; set; }

                /// <summary>
                /// The remote mount directory.
                /// </summary>
                [NameInMap("RemoteDirectory")]
                [Validation(Required=false)]
                public string RemoteDirectory { get; set; }

                /// <summary>
                /// The array of the node on which the file system is mounted.
                /// </summary>
                [NameInMap("Roles")]
                [Validation(Required=false)]
                public GetClusterVolumesResponseBodyVolumesVolumeInfoRoles Roles { get; set; }
                public class GetClusterVolumesResponseBodyVolumesVolumeInfoRoles : TeaModel {
                    [NameInMap("RoleInfo")]
                    [Validation(Required=false)]
                    public List<GetClusterVolumesResponseBodyVolumesVolumeInfoRolesRoleInfo> RoleInfo { get; set; }
                    public class GetClusterVolumesResponseBodyVolumesVolumeInfoRolesRoleInfo : TeaModel {
                        /// <summary>
                        /// The type of the node on which the file system is mounted. Valid values:
                        /// 
                        /// *   Compute: compute node
                        /// *   Manager: management node
                        /// *   Login: logon node
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the file system.
                /// </summary>
                [NameInMap("VolumeId")]
                [Validation(Required=false)]
                public string VolumeId { get; set; }

                /// <summary>
                /// The address of the mount target.
                /// </summary>
                [NameInMap("VolumeMountpoint")]
                [Validation(Required=false)]
                public string VolumeMountpoint { get; set; }

                /// <summary>
                /// The storage protocol type of the file system. Valid values:
                /// 
                /// *   NFS
                /// *   SMB
                /// </summary>
                [NameInMap("VolumeProtocol")]
                [Validation(Required=false)]
                public string VolumeProtocol { get; set; }

                /// <summary>
                /// The type of the file system. Valid values:
                /// 
                /// *   NAS
                /// </summary>
                [NameInMap("VolumeType")]
                [Validation(Required=false)]
                public string VolumeType { get; set; }

            }

        }

    }

}
