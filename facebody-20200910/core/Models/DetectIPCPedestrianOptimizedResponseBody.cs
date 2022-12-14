// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20200910.Models
{
    public class DetectIPCPedestrianOptimizedResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectIPCPedestrianOptimizedResponseBodyData Data { get; set; }
        public class DetectIPCPedestrianOptimizedResponseBodyData : TeaModel {
            [NameInMap("ImageInfoList")]
            [Validation(Required=false)]
            public List<DetectIPCPedestrianOptimizedResponseBodyDataImageInfoList> ImageInfoList { get; set; }
            public class DetectIPCPedestrianOptimizedResponseBodyDataImageInfoList : TeaModel {
                [NameInMap("Elements")]
                [Validation(Required=false)]
                public List<DetectIPCPedestrianOptimizedResponseBodyDataImageInfoListElements> Elements { get; set; }
                public class DetectIPCPedestrianOptimizedResponseBodyDataImageInfoListElements : TeaModel {
                    [NameInMap("Boxes")]
                    [Validation(Required=false)]
                    public List<long?> Boxes { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
