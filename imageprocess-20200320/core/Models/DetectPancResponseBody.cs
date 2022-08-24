// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectPancResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectPancResponseBodyData Data { get; set; }
        public class DetectPancResponseBodyData : TeaModel {
            [NameInMap("Lesion")]
            [Validation(Required=false)]
            public DetectPancResponseBodyDataLesion Lesion { get; set; }
            public class DetectPancResponseBodyDataLesion : TeaModel {
                [NameInMap("Mask")]
                [Validation(Required=false)]
                public string Mask { get; set; }

                [NameInMap("NonPdacVol")]
                [Validation(Required=false)]
                public string NonPdacVol { get; set; }

                [NameInMap("PancVol")]
                [Validation(Required=false)]
                public string PancVol { get; set; }

                [NameInMap("PdacVol")]
                [Validation(Required=false)]
                public string PdacVol { get; set; }

                [NameInMap("Possibilities")]
                [Validation(Required=false)]
                public List<string> Possibilities { get; set; }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
