// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cityvisual20181030.Models
{
    public class BatchModifyCameraStatusRequest : TeaModel {
        [NameInMap("StreamStatus")]
        [Validation(Required=false)]
        public string StreamStatus { get; set; }

        [NameInMap("CameraIds")]
        [Validation(Required=false)]
        public string CameraIds { get; set; }

        [NameInMap("WorkGroupId")]
        [Validation(Required=false)]
        public string WorkGroupId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
