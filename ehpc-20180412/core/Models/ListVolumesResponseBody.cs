// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListVolumesResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

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
                public string VolumeId { get; set; }
                public string ClusterName { get; set; }
                public string RemoteDirectory { get; set; }
                public string VolumeMountpoint { get; set; }
                public string VolumeType { get; set; }
                public string VolumeProtocol { get; set; }
                public string RegionId { get; set; }
                public string ClusterId { get; set; }
                public ListVolumesResponseBodyVolumesVolumeInfoAdditionalVolumes AdditionalVolumes { get; set; }
                public class ListVolumesResponseBodyVolumesVolumeInfoAdditionalVolumes : TeaModel {
                    [NameInMap("VolumeInfo")]
                    [Validation(Required=false)]
                    public List<ListVolumesResponseBodyVolumesVolumeInfoAdditionalVolumesVolumeInfo> VolumeInfo { get; set; }
                    public class ListVolumesResponseBodyVolumesVolumeInfoAdditionalVolumesVolumeInfo : TeaModel {
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

                }
            }
        };

    }

}
