// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetClusterVolumesResponseBody : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Volumes")]
        [Validation(Required=false)]
        public GetClusterVolumesResponseBodyVolumes Volumes { get; set; }
        public class GetClusterVolumesResponseBodyVolumes : TeaModel {
            [NameInMap("VolumeInfo")]
            [Validation(Required=false)]
            public List<GetClusterVolumesResponseBodyVolumesVolumeInfo> VolumeInfo { get; set; }
            public class GetClusterVolumesResponseBodyVolumesVolumeInfo : TeaModel {
                public string JobQueue { get; set; }
                public string LocalDirectory { get; set; }
                public string Location { get; set; }
                public bool? MustKeep { get; set; }
                public string RemoteDirectory { get; set; }
                public GetClusterVolumesResponseBodyVolumesVolumeInfoRoles Roles { get; set; }
                public class GetClusterVolumesResponseBodyVolumesVolumeInfoRoles : TeaModel {
                    [NameInMap("RoleInfo")]
                    [Validation(Required=false)]
                    public List<GetClusterVolumesResponseBodyVolumesVolumeInfoRolesRoleInfo> RoleInfo { get; set; }
                    public class GetClusterVolumesResponseBodyVolumesVolumeInfoRolesRoleInfo : TeaModel {
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }
                public string VolumeId { get; set; }
                public string VolumeMountpoint { get; set; }
                public string VolumeProtocol { get; set; }
                public string VolumeType { get; set; }
            }
        };

    }

}
