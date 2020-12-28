// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListVolumesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Volumes")]
        [Validation(Required=false)]
        public List<ListVolumesResponseBodyVolumes> Volumes { get; set; }
        public class ListVolumesResponseBodyVolumes : TeaModel {
            [NameInMap("VolumeId")]
            [Validation(Required=false)]
            public string VolumeId { get; set; }

            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("RemoteDirectory")]
            [Validation(Required=false)]
            public string RemoteDirectory { get; set; }

            [NameInMap("VolumeMountpoint")]
            [Validation(Required=false)]
            public string VolumeMountpoint { get; set; }

            [NameInMap("AdditionalVolumes")]
            [Validation(Required=false)]
            public List<ListVolumesResponseBodyVolumesAdditionalVolumes> AdditionalVolumes { get; set; }
            public class ListVolumesResponseBodyVolumesAdditionalVolumes : TeaModel {
                [NameInMap("JobQueue")]
                [Validation(Required=false)]
                public string JobQueue { get; set; }

                [NameInMap("VolumeId")]
                [Validation(Required=false)]
                public string VolumeId { get; set; }

                [NameInMap("RemoteDirectory")]
                [Validation(Required=false)]
                public string RemoteDirectory { get; set; }

                [NameInMap("VolumeMountpoint")]
                [Validation(Required=false)]
                public string VolumeMountpoint { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("LocalDirectory")]
                [Validation(Required=false)]
                public string LocalDirectory { get; set; }

                [NameInMap("VolumeType")]
                [Validation(Required=false)]
                public string VolumeType { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("VolumeProtocol")]
                [Validation(Required=false)]
                public string VolumeProtocol { get; set; }

            }

            [NameInMap("VolumeType")]
            [Validation(Required=false)]
            public string VolumeType { get; set; }

            [NameInMap("VolumeProtocol")]
            [Validation(Required=false)]
            public string VolumeProtocol { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

        }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
