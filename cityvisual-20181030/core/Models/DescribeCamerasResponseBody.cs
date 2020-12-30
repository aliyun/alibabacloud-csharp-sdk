// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cityvisual20181030.Models
{
    public class DescribeCamerasResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Cameras")]
        [Validation(Required=false)]
        public DescribeCamerasResponseBodyCameras Cameras { get; set; }
        public class DescribeCamerasResponseBodyCameras : TeaModel {
            [NameInMap("Camera")]
            [Validation(Required=false)]
            public List<DescribeCamerasResponseBodyCamerasCamera> Camera { get; set; }
            public class DescribeCamerasResponseBodyCamerasCamera : TeaModel {
                public string StreamStatus { get; set; }
                public string UpdateTime { get; set; }
                public string CameraId { get; set; }
                public string Conf { get; set; }
                public string RtmpPath { get; set; }
                public string InviteUri { get; set; }
                public string CameraName { get; set; }
                public string WorkGroupId { get; set; }
                public string Location { get; set; }
            }
        };

    }

}
