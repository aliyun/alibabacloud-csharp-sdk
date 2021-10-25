// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class UpdateClusterVolumesRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("AdditionalVolumes")]
        [Validation(Required=false)]
        public List<UpdateClusterVolumesRequestAdditionalVolumes> AdditionalVolumes { get; set; }
        public class UpdateClusterVolumesRequestAdditionalVolumes : TeaModel {
            [NameInMap("JobQueue")]
            [Validation(Required=false)]
            public string JobQueue { get; set; }

            [NameInMap("VolumeId")]
            [Validation(Required=false)]
            public string VolumeId { get; set; }

            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<UpdateClusterVolumesRequestAdditionalVolumesRoles> Roles { get; set; }
            public class UpdateClusterVolumesRequestAdditionalVolumesRoles : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("VolumeMountpoint")]
            [Validation(Required=false)]
            public string VolumeMountpoint { get; set; }

            [NameInMap("RemoteDirectory")]
            [Validation(Required=false)]
            public string RemoteDirectory { get; set; }

            [NameInMap("VolumeType")]
            [Validation(Required=false)]
            public string VolumeType { get; set; }

            [NameInMap("LocalDirectory")]
            [Validation(Required=false)]
            public string LocalDirectory { get; set; }

            [NameInMap("VolumeProtocol")]
            [Validation(Required=false)]
            public string VolumeProtocol { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

        }

    }

}
