// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class UpdateClusterVolumesRequest : TeaModel {
        [NameInMap("AdditionalVolumes")]
        [Validation(Required=false)]
        public List<UpdateClusterVolumesRequestAdditionalVolumes> AdditionalVolumes { get; set; }
        public class UpdateClusterVolumesRequestAdditionalVolumes : TeaModel {
            /// <summary>
            /// The queue name of the nth attached mounted filesystem.
            /// </summary>
            [NameInMap("JobQueue")]
            [Validation(Required=false)]
            public string JobQueue { get; set; }

            /// <summary>
            /// The on-premises mount directory for the nth additional mounted file system.
            /// </summary>
            [NameInMap("LocalDirectory")]
            [Validation(Required=false)]
            public string LocalDirectory { get; set; }

            /// <summary>
            /// The storage location of the nth attached mounted file system. Valid values:
            /// 
            /// *   OnPremise: hybrid cloud cluster
            /// *   PublicCloud: public cloud cluster
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// The remote directory to be mounted by the nth additional mounted file system.
            /// </summary>
            [NameInMap("RemoteDirectory")]
            [Validation(Required=false)]
            public string RemoteDirectory { get; set; }

            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<UpdateClusterVolumesRequestAdditionalVolumesRoles> Roles { get; set; }
            public class UpdateClusterVolumesRequestAdditionalVolumesRoles : TeaModel {
                /// <summary>
                /// The node type on which the nth additional mounted file system is mounted. Valid values:
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
            /// The ID of the nth additional mounted file system.
            /// </summary>
            [NameInMap("VolumeId")]
            [Validation(Required=false)]
            public string VolumeId { get; set; }

            [NameInMap("VolumeMountOption")]
            [Validation(Required=false)]
            public string VolumeMountOption { get; set; }

            /// <summary>
            /// The domain name of the mount target for the nth additional mounted file system.
            /// </summary>
            [NameInMap("VolumeMountpoint")]
            [Validation(Required=false)]
            public string VolumeMountpoint { get; set; }

            /// <summary>
            /// The protocol type of the nth additional mounted file system. Valid values:
            /// 
            /// *   NFS
            /// *   SMB
            /// </summary>
            [NameInMap("VolumeProtocol")]
            [Validation(Required=false)]
            public string VolumeProtocol { get; set; }

            /// <summary>
            /// The type of the nth additional mounted file system. Currently, only NAS is supported.
            /// 
            /// Valid values of N: 1 to 10.
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
