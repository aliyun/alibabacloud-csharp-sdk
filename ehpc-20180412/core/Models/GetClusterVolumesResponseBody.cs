// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetClusterVolumesResponseBody : TeaModel {
        [NameInMap("Volumes")]
        [Validation(Required=false)]
        public List<GetClusterVolumesResponseBodyVolumes> Volumes { get; set; }
        public class GetClusterVolumesResponseBodyVolumes : TeaModel {
            [NameInMap("JobQueue")]
            [Validation(Required=false)]
            public string JobQueue { get; set; }

            [NameInMap("VolumeId")]
            [Validation(Required=false)]
            public string VolumeId { get; set; }

            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<GetClusterVolumesResponseBodyVolumesRoles> Roles { get; set; }
            public class GetClusterVolumesResponseBodyVolumesRoles : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("RemoteDirectory")]
            [Validation(Required=false)]
            public string RemoteDirectory { get; set; }

            [NameInMap("VolumeMountpoint")]
            [Validation(Required=false)]
            public string VolumeMountpoint { get; set; }

            [NameInMap("LocalDirectory")]
            [Validation(Required=false)]
            public string LocalDirectory { get; set; }

            [NameInMap("VolumeType")]
            [Validation(Required=false)]
            public string VolumeType { get; set; }

            [NameInMap("MustKeep")]
            [Validation(Required=false)]
            public bool? MustKeep { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("VolumeProtocol")]
            [Validation(Required=false)]
            public string VolumeProtocol { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
