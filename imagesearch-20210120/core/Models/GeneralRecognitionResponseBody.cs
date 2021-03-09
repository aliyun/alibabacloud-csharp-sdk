// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20210120.Models
{
    public class GeneralRecognitionResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GeneralRecognitionResponseBodyData Data { get; set; }
        public class GeneralRecognitionResponseBodyData : TeaModel {
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<GeneralRecognitionResponseBodyDataResult> Result { get; set; }
            public class GeneralRecognitionResponseBodyDataResult : TeaModel {
                public string Tag { get; set; }
                public string Score { get; set; }
            }
            [NameInMap("Regions")]
            [Validation(Required=false)]
            public List<string> Regions { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
