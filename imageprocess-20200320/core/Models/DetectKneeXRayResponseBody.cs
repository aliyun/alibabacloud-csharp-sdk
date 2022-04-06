// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectKneeXRayResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectKneeXRayResponseBodyData Data { get; set; }
        public class DetectKneeXRayResponseBodyData : TeaModel {
            [NameInMap("KLDetections")]
            [Validation(Required=false)]
            public List<DetectKneeXRayResponseBodyDataKLDetections> KLDetections { get; set; }
            public class DetectKneeXRayResponseBodyDataKLDetections : TeaModel {
                public List<string> Detections { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
