// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class VerifyFaceMaskResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public VerifyFaceMaskResponseBodyData Data { get; set; }
        public class VerifyFaceMaskResponseBodyData : TeaModel {
            [NameInMap("Confidence")]
            [Validation(Required=false)]
            public float? Confidence { get; set; }
            [NameInMap("Mask")]
            [Validation(Required=false)]
            public int? Mask { get; set; }
            [NameInMap("MaskRef")]
            [Validation(Required=false)]
            public int? MaskRef { get; set; }
            [NameInMap("Rectangle")]
            [Validation(Required=false)]
            public List<string> Rectangle { get; set; }
            [NameInMap("RectangleRef")]
            [Validation(Required=false)]
            public List<string> RectangleRef { get; set; }
            [NameInMap("Thresholds")]
            [Validation(Required=false)]
            public List<string> Thresholds { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
