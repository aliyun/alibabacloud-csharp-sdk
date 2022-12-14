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
                [NameInMap("Elements")]
                [Validation(Required=false)]
                public List<DetectIPCPedestrianResponseBodyDataImageInfoListElements> Elements { get; set; }
                public class DetectIPCPedestrianResponseBodyDataImageInfoListElements : TeaModel {
                    [NameInMap("Boxes")]
                    [Validation(Required=false)]
                    public List<int?> Boxes { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

            }

        }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
