// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectLymphResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectLymphResponseBodyData Data { get; set; }
        public class DetectLymphResponseBodyData : TeaModel {
            [NameInMap("Lesions")]
            [Validation(Required=false)]
            public List<DetectLymphResponseBodyDataLesions> Lesions { get; set; }
            public class DetectLymphResponseBodyDataLesions : TeaModel {
                public List<string> Boxes { get; set; }
                public List<string> Diametermm { get; set; }
                public long? KeySlice { get; set; }
                public List<string> Recist { get; set; }
                public float? Score { get; set; }
            }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
