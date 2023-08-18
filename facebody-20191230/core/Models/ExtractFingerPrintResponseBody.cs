// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class ExtractFingerPrintResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ExtractFingerPrintResponseBodyData Data { get; set; }
        public class ExtractFingerPrintResponseBodyData : TeaModel {
            [NameInMap("FingerPrint")]
            [Validation(Required=false)]
            public string FingerPrint { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
