// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListVolumesResponseBody : TeaModel {
        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
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
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The information of file systems that are mounted on E-HPC clusters.
        /// </summary>
        [NameInMap("Volumes")]
        [Validation(Required=false)]
        public ListVolumesResponseBodyVolumes Volumes { get; set; }
        public class ListVolumesResponseBodyVolumes : TeaModel {
            [NameInMap("VolumeInfo")]
            [Validation(Required=false)]
            public List<ListVolumesResponseBodyVolumesVolumeInfo> VolumeInfo { get; set; }
            public class ListVolumesResponseBodyVolumesVolumeInfo : TeaModel {
                /// <summary>
                /// The information of additional file systems mounted on E-HPC clusters.
                /// </summary>
                [NameInMap("AdditionalVolumes")]
                [Validation(Required=false)]
                public ListVolumesResponseBodyVolumesVolumeInfoAdditionalVolumes AdditionalVolumes { get; set; }
                public class ListVolumesResponseBodyVolumesVolumeInfoAdditionalVolumes : TeaModel {
                    [NameInMap("VolumeInfo")]
                    [Validation(Required=false)]
                    public List<ListVolumesResponseBodyVolumesVolumeInfoAdditionalVolumesVolumeInfo> VolumeInfo { get; set; }
                    public class ListVolumesResponseBodyVolumesVolumeInfoAdditionalVolumesVolumeInfo : TeaModel {
                        /// <summary>
                        /// The queue to which the job belongs.
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
                        /// The location where the cluster is deployed. Valid values:
                        /// 
                        /// *   OnPremise: The node is deployed on a hybrid cloud.
                        /// *   PublicCloud: The cluster is deployed on a public cloud.
                        /// </summary>
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }

                        /// <summary>
                        /// The remote directory on which the file system is mounted.
                        /// </summary>
                        [NameInMap("RemoteDirectory")]
                        [Validation(Required=false)]
                        public string RemoteDirectory { get; set; }

                        /// <summary>
                        /// The type of the node on which the file system is mounted. Valid values:
                        /// 
                        /// *   Manager: management node
                        /// *   Login: logon node
                        /// *   Compute: compute node
                        /// </summary>
                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                        /// <summary>
                        /// The ID of the file system.
                        /// </summary>
                        [NameInMap("VolumeId")]
                        [Validation(Required=false)]
                        public string VolumeId { get; set; }

                        /// <summary>
                        /// The domain name of the mount target.
                        /// </summary>
                        [NameInMap("VolumeMountpoint")]
                        [Validation(Required=false)]
                        public string VolumeMountpoint { get; set; }

                        /// <summary>
                        /// The type of the storage protocol. Valid values:
                        /// 
                        /// *   NFS
                        /// *   SMB
                        /// </summary>
                        [NameInMap("VolumeProtocol")]
                        [Validation(Required=false)]
                        public string VolumeProtocol { get; set; }

                        /// <summary>
                        /// The type of the additional file system. Only NAS is supported.
                        /// </summary>
                        [NameInMap("VolumeType")]
                        [Validation(Required=false)]
                        public string VolumeType { get; set; }

                    }

                }

                /// <summary>
                /// The cluster ID.
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The instance name.
                /// </summary>
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The remote directory on which the file system is mounted.
                /// </summary>
                [NameInMap("RemoteDirectory")]
                [Validation(Required=false)]
                public string RemoteDirectory { get; set; }

                /// <summary>
                /// The ID of the file system.
                /// </summary>
                [NameInMap("VolumeId")]
                [Validation(Required=false)]
                public string VolumeId { get; set; }

                /// <summary>
                /// The domain name of the mount target.
                /// </summary>
                [NameInMap("VolumeMountpoint")]
                [Validation(Required=false)]
                public string VolumeMountpoint { get; set; }

                /// <summary>
                /// The type of the storage protocol. Valid values:
                /// 
                /// *   NFS
                /// *   SMB
                /// </summary>
                [NameInMap("VolumeProtocol")]
                [Validation(Required=false)]
                public string VolumeProtocol { get; set; }

                /// <summary>
                /// The type of the file system that is mounted on the cluster. Only NAS is supported.
                /// </summary>
                [NameInMap("VolumeType")]
                [Validation(Required=false)]
                public string VolumeType { get; set; }

            }

        }

    }

}
