// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeStorageVolumeResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StorageVolumes")]
        [Validation(Required=false)]
        public List<DescribeStorageVolumeResponseBodyStorageVolumes> StorageVolumes { get; set; }
        public class DescribeStorageVolumeResponseBodyStorageVolumes : TeaModel {
            [NameInMap("AuthProtocol")]
            [Validation(Required=false)]
            public string AuthProtocol { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            [NameInMap("IsAuth")]
            [Validation(Required=false)]
            public int? IsAuth { get; set; }

            [NameInMap("IsEnable")]
            [Validation(Required=false)]
            public int? IsEnable { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StorageGatewayId")]
            [Validation(Required=false)]
            public string StorageGatewayId { get; set; }

            [NameInMap("StorageId")]
            [Validation(Required=false)]
            public string StorageId { get; set; }

            [NameInMap("StorageVolumeId")]
            [Validation(Required=false)]
            public string StorageVolumeId { get; set; }

            [NameInMap("StorageVolumeName")]
            [Validation(Required=false)]
            public string StorageVolumeName { get; set; }

            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
