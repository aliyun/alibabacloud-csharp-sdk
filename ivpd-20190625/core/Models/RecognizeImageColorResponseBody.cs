// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivpd20190625.Models
{
    public class RecognizeImageColorResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeImageColorResponseBodyData Data { get; set; }
        public class RecognizeImageColorResponseBodyData : TeaModel {
            [NameInMap("ColorTemplateList")]
            [Validation(Required=false)]
            public List<RecognizeImageColorResponseBodyDataColorTemplateList> ColorTemplateList { get; set; }
            public class RecognizeImageColorResponseBodyDataColorTemplateList : TeaModel {
                public string Color { get; set; }
                public string Label { get; set; }
                public float? Percentage { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
