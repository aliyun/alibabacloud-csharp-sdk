// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cityvisual20181030.Models
{
    public class ModifyCameraRequest : TeaModel {
        [NameInMap("CameraName")]
        [Validation(Required=false)]
        public string CameraName { get; set; }

        [NameInMap("CameraId")]
        [Validation(Required=false)]
        public string CameraId { get; set; }

        [NameInMap("LocationInfo")]
        [Validation(Required=false)]
        public string LocationInfo { get; set; }

        [NameInMap("InviteUri")]
        [Validation(Required=false)]
        public string InviteUri { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("StreamStatus")]
        [Validation(Required=false)]
        public string StreamStatus { get; set; }

    }

}
