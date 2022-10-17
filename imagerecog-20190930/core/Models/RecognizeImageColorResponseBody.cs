// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class RecognizeImageColorResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeImageColorResponseBodyData Data { get; set; }
        public class RecognizeImageColorResponseBodyData : TeaModel {
            [NameInMap("ColorTemplateList")]
            [Validation(Required=false)]
            public List<RecognizeImageColorResponseBodyDataColorTemplateList> ColorTemplateList { get; set; }
            public class RecognizeImageColorResponseBodyDataColorTemplateList : TeaModel {
                [NameInMap("Color")]
                [Validation(Required=false)]
                public string Color { get; set; }

                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("Percentage")]
                [Validation(Required=false)]
                public float? Percentage { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
