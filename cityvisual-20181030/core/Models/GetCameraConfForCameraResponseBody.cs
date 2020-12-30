// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cityvisual20181030.Models
{
    public class GetCameraConfForCameraResponseBody : TeaModel {
        [NameInMap("CameraConf")]
        [Validation(Required=false)]
        public GetCameraConfForCameraResponseBodyCameraConf CameraConf { get; set; }
        public class GetCameraConfForCameraResponseBodyCameraConf : TeaModel {
            [NameInMap("Context")]
            [Validation(Required=false)]
            public string Context { get; set; }
            [NameInMap("CameraId")]
            [Validation(Required=false)]
            public string CameraId { get; set; }
            [NameInMap("CameraName")]
            [Validation(Required=false)]
            public string CameraName { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
