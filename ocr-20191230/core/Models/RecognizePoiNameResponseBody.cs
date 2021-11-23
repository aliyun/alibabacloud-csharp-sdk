// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizePoiNameResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizePoiNameResponseBodyData Data { get; set; }
        public class RecognizePoiNameResponseBodyData : TeaModel {
            [NameInMap("Signboards")]
            [Validation(Required=false)]
            public List<RecognizePoiNameResponseBodyDataSignboards> Signboards { get; set; }
            public class RecognizePoiNameResponseBodyDataSignboards : TeaModel {
                public List<RecognizePoiNameResponseBodyDataSignboardsTexts> Texts { get; set; }
                public class RecognizePoiNameResponseBodyDataSignboardsTexts : TeaModel {
                    public string Label { get; set; }
                    public List<string> Points { get; set; }
                    public float? Score { get; set; }
                    public string Tag { get; set; }
                    public string Type { get; set; }
                }
            }
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public RecognizePoiNameResponseBodyDataSummary Summary { get; set; }
            public class RecognizePoiNameResponseBodyDataSummary : TeaModel {
                [NameInMap("Brand")]
                [Validation(Required=false)]
                public string Brand { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
