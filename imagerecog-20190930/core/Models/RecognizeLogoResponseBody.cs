// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class RecognizeLogoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeLogoResponseBodyData Data { get; set; }
        public class RecognizeLogoResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<RecognizeLogoResponseBodyDataElements> Elements { get; set; }
            public class RecognizeLogoResponseBodyDataElements : TeaModel {
                public string ImageURL { get; set; }
                public string TaskId { get; set; }
                public List<RecognizeLogoResponseBodyDataElementsResults> Results { get; set; }
                public class RecognizeLogoResponseBodyDataElementsResults : TeaModel {
                    public string Suggestion { get; set; }
                    public List<RecognizeLogoResponseBodyDataElementsResultsLogosData> LogosData { get; set; }
                    public class RecognizeLogoResponseBodyDataElementsResultsLogosData : TeaModel {
                        public string Type { get; set; }
                        public float? W { get; set; }
                        public float? H { get; set; }
                        public float? Y { get; set; }
                        public string Name { get; set; }
                        public float? X { get; set; }
                    }
                    public string Label { get; set; }
                    public float? Rate { get; set; }
                }
            }
        };

    }

}
