// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageaudit20191230.Models
{
    public class ScanTextResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ScanTextResponseBodyData Data { get; set; }
        public class ScanTextResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<ScanTextResponseBodyDataElements> Elements { get; set; }
            public class ScanTextResponseBodyDataElements : TeaModel {
                [NameInMap("Results")]
                [Validation(Required=false)]
                public List<ScanTextResponseBodyDataElementsResults> Results { get; set; }
                public class ScanTextResponseBodyDataElementsResults : TeaModel {
                    [NameInMap("Details")]
                    [Validation(Required=false)]
                    public List<ScanTextResponseBodyDataElementsResultsDetails> Details { get; set; }
                    public class ScanTextResponseBodyDataElementsResultsDetails : TeaModel {
                        [NameInMap("Contexts")]
                        [Validation(Required=false)]
                        public List<ScanTextResponseBodyDataElementsResultsDetailsContexts> Contexts { get; set; }
                        public class ScanTextResponseBodyDataElementsResultsDetailsContexts : TeaModel {
                            [NameInMap("Context")]
                            [Validation(Required=false)]
                            public string Context { get; set; }

                        }

                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                    }

                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public float? Rate { get; set; }

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
