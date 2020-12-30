// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cityvisual20181030.Models
{
    public class DescribeCamerasRequest : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("CameraId")]
        [Validation(Required=false)]
        public string CameraId { get; set; }

        [NameInMap("CameraName")]
        [Validation(Required=false)]
        public string CameraName { get; set; }

        [NameInMap("StreamStatus")]
        [Validation(Required=false)]
        public string StreamStatus { get; set; }

        [NameInMap("WorkGroupId")]
        [Validation(Required=false)]
        public string WorkGroupId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
