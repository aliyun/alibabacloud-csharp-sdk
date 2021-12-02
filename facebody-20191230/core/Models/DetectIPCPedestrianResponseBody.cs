// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectIPCPedestrianResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectIPCPedestrianResponseBodyData Data { get; set; }
        public class DetectIPCPedestrianResponseBodyData : TeaModel {
            [NameInMap("ImageInfoList")]
            [Validation(Required=false)]
            public List<DetectIPCPedestrianResponseBodyDataImageInfoList> ImageInfoList { get; set; }
            public class DetectIPCPedestrianResponseBodyDataImageInfoList : TeaModel {
                public List<DetectIPCPedestrianResponseBodyDataImageInfoListElements> Elements { get; set; }
                public class DetectIPCPedestrianResponseBodyDataImageInfoListElements : TeaModel {
                    public List<string> Boxes { get; set; }
                    public float? Score { get; set; }
                }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
