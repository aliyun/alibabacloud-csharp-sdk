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
                [NameInMap("Texts")]
                [Validation(Required=false)]
                public List<RecognizePoiNameResponseBodyDataSignboardsTexts> Texts { get; set; }
                public class RecognizePoiNameResponseBodyDataSignboardsTexts : TeaModel {
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("Points")]
                    [Validation(Required=false)]
                    public List<int?> Points { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
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

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
