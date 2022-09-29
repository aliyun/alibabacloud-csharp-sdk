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
                [NameInMap("ImageURL")]
                [Validation(Required=false)]
                public string ImageURL { get; set; }

                [NameInMap("Results")]
                [Validation(Required=false)]
                public List<RecognizePublicFaceResponseBodyDataElementsResults> Results { get; set; }
                public class RecognizePublicFaceResponseBodyDataElementsResults : TeaModel {
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public float? Rate { get; set; }

                    [NameInMap("SubResults")]
                    [Validation(Required=false)]
                    public List<RecognizePublicFaceResponseBodyDataElementsResultsSubResults> SubResults { get; set; }
                    public class RecognizePublicFaceResponseBodyDataElementsResultsSubResults : TeaModel {
                        [NameInMap("Faces")]
                        [Validation(Required=false)]
                        public List<RecognizePublicFaceResponseBodyDataElementsResultsSubResultsFaces> Faces { get; set; }
                        public class RecognizePublicFaceResponseBodyDataElementsResultsSubResultsFaces : TeaModel {
                            [NameInMap("Id")]
                            [Validation(Required=false)]
                            public string Id { get; set; }

                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            [NameInMap("Rate")]
                            [Validation(Required=false)]
                            public float? Rate { get; set; }

                        }

                        [NameInMap("H")]
                        [Validation(Required=false)]
                        public float? H { get; set; }

                        [NameInMap("W")]
                        [Validation(Required=false)]
                        public float? W { get; set; }

                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public float? X { get; set; }

                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public float? Y { get; set; }

                    }

                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
