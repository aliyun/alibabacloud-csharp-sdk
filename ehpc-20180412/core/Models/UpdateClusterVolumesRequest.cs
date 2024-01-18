// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class UpdateClusterVolumesRequest : TeaModel {
        /// <summary>
        /// The list of file system information.
        /// </summary>
        [NameInMap("AdditionalVolumes")]
        [Validation(Required=false)]
        public List<UpdateClusterVolumesRequestAdditionalVolumes> AdditionalVolumes { get; set; }
        public class UpdateClusterVolumesRequestAdditionalVolumes : TeaModel {
            /// <summary>
            /// The queue name of the attached mounted file system.
            /// </summary>
            [NameInMap("JobQueue")]
            [Validation(Required=false)]
            public string JobQueue { get; set; }

            /// <summary>
            /// The on-premises mount directory for the additional mounted file system.
            /// </summary>
            [NameInMap("LocalDirectory")]
            [Validation(Required=false)]
            public string LocalDirectory { get; set; }

            /// <summary>
            /// The storage location of the attached mounted file system. Valid values:
            /// 
            /// *   OnPremise: The cluster is deployed on a hybrid cloud.
            /// *   PublicCloud: The cluster is deployed on a public cloud.
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// The remote directory to be mounted by the additional mounted file system.
            /// </summary>
            [NameInMap("RemoteDirectory")]
            [Validation(Required=false)]
            public string RemoteDirectory { get; set; }

            /// <summary>
            /// The array of the node on which the file system is mounted.
            /// </summary>
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<UpdateClusterVolumesRequestAdditionalVolumesRoles> Roles { get; set; }
            public class UpdateClusterVolumesRequestAdditionalVolumesRoles : TeaModel {
                /// <summary>
                /// The node type on which the additional mounted file system is mounted. Valid values:
                /// 
                /// *   Manager: management node
                /// *   Login: logon node
                /// *   Compute: compute node
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// The ID of the additional mounted file system.
            /// </summary>
            [NameInMap("VolumeId")]
            [Validation(Required=false)]
            public string VolumeId { get; set; }

            /// <summary>
            /// The mount option of the attached mounted file system.
            /// </summary>
            [NameInMap("VolumeMountOption")]
            [Validation(Required=false)]
            public string VolumeMountOption { get; set; }

            /// <summary>
            /// The domain name of the mount target for the additional mounted file system.
            /// </summary>
            [NameInMap("VolumeMountpoint")]
            [Validation(Required=false)]
            public string VolumeMountpoint { get; set; }

            /// <summary>
            /// The protocol type of the additional mounted file system. Valid values:
            /// 
            /// *   NFS
            /// *   SMB
            /// </summary>
            [NameInMap("VolumeProtocol")]
            [Validation(Required=false)]
            public string VolumeProtocol { get; set; }

            /// <summary>
            /// The type of the additional mounted file system. Only NAS is supported.
            /// </summary>
            [NameInMap("VolumeType")]
            [Validation(Required=false)]
            public string VolumeType { get; set; }

        }

        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

    }

}
