// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class RecognizePublicFaceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizePublicFaceResponseBodyData Data { get; set; }
        public class RecognizePublicFaceResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<RecognizePublicFaceResponseBodyDataElements> Elements { get; set; }
            public class RecognizePublicFaceResponseBodyDataElements : TeaModel {
                public string ImageURL { get; set; }
                public List<RecognizePublicFaceResponseBodyDataElementsResults> Results { get; set; }
                public class RecognizePublicFaceResponseBodyDataElementsResults : TeaModel {
                    public string Label { get; set; }
                    public float? Rate { get; set; }
                    public List<RecognizePublicFaceResponseBodyDataElementsResultsSubResults> SubResults { get; set; }
                    public class RecognizePublicFaceResponseBodyDataElementsResultsSubResults : TeaModel {
                        public List<RecognizePublicFaceResponseBodyDataElementsResultsSubResultsFaces> Faces { get; set; }
                        public class RecognizePublicFaceResponseBodyDataElementsResultsSubResultsFaces : TeaModel {
                            public string Id { get; set; }
                            public string Name { get; set; }
                            public float? Rate { get; set; }
                        }
                        public float? H { get; set; }
                        public float? W { get; set; }
                        public float? X { get; set; }
                        public float? Y { get; set; }
                    }
                    public string Suggestion { get; set; }
                }
                public string TaskId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
