// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectMaskResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectMaskResponseBodyData Data { get; set; }
        public class DetectMaskResponseBodyData : TeaModel {
            [NameInMap("Mask")]
            [Validation(Required=false)]
            public int? Mask { get; set; }
            [NameInMap("FaceProbability")]
            [Validation(Required=false)]
            public float? FaceProbability { get; set; }
        };

    }

}
