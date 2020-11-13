// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizePoiNameResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public RecognizePoiNameResponseData Data { get; set; }
        public class RecognizePoiNameResponseData : TeaModel {
            [NameInMap("Signboards")]
            [Validation(Required=true)]
            public List<RecognizePoiNameResponseDataSignboards> Signboards { get; set; }
            public class RecognizePoiNameResponseDataSignboards : TeaModel {
                public List<RecognizePoiNameResponseDataSignboardsTexts> Texts { get; set; }
                public class RecognizePoiNameResponseDataSignboardsTexts : TeaModel {
                    public string Label { get; set; }
                    public float? Score { get; set; }
                    public string Tag { get; set; }
                    public string Type { get; set; }
                    public List<string> Points { get; set; }
                }
            }
            [NameInMap("Summary")]
            [Validation(Required=true)]
            public RecognizePoiNameResponseDataSummary Summary { get; set; }
            public class RecognizePoiNameResponseDataSummary : TeaModel {
                [NameInMap("Brand")]
                [Validation(Required=true)]
                public string Brand { get; set; }

                [NameInMap("Score")]
                [Validation(Required=true)]
                public float? Score { get; set; }

            }
        };

    }

}
