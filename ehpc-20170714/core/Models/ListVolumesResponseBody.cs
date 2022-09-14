// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20170714.Models
{
    public class ListVolumesResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Volumes")]
        [Validation(Required=false)]
        public ListVolumesResponseBodyVolumes Volumes { get; set; }
        public class ListVolumesResponseBodyVolumes : TeaModel {
            [NameInMap("VolumeInfo")]
            [Validation(Required=false)]
            public List<ListVolumesResponseBodyVolumesVolumeInfo> VolumeInfo { get; set; }
            public class ListVolumesResponseBodyVolumesVolumeInfo : TeaModel {
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("RemoteDirectory")]
                [Validation(Required=false)]
                public string RemoteDirectory { get; set; }

                [NameInMap("VolumeId")]
                [Validation(Required=false)]
                public string VolumeId { get; set; }

                [NameInMap("VolumeMountpoint")]
                [Validation(Required=false)]
                public string VolumeMountpoint { get; set; }

                [NameInMap("VolumeProtocol")]
                [Validation(Required=false)]
                public string VolumeProtocol { get; set; }

                [NameInMap("VolumeType")]
                [Validation(Required=false)]
                public string VolumeType { get; set; }

            }

        }

    }

}
