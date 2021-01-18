// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20200910.Models
{
    public class DetectIPCPedestrianOptimizedResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectIPCPedestrianOptimizedResponseBodyData Data { get; set; }
        public class DetectIPCPedestrianOptimizedResponseBodyData : TeaModel {
            [NameInMap("ImageInfoList")]
            [Validation(Required=false)]
            public List<DetectIPCPedestrianOptimizedResponseBodyDataImageInfoList> ImageInfoList { get; set; }
            public class DetectIPCPedestrianOptimizedResponseBodyDataImageInfoList : TeaModel {
                public List<DetectIPCPedestrianOptimizedResponseBodyDataImageInfoListElements> Elements { get; set; }
                public class DetectIPCPedestrianOptimizedResponseBodyDataImageInfoListElements : TeaModel {
                    public List<string> Boxes { get; set; }
                    public float? Score { get; set; }
                }
            }
        };

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
