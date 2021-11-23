// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeVINCodeResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeVINCodeResponseBodyData Data { get; set; }
        public class RecognizeVINCodeResponseBodyData : TeaModel {
            [NameInMap("VinCode")]
            [Validation(Required=false)]
            public string VinCode { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
