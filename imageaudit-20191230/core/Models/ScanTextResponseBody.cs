// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageaudit20191230.Models
{
    public class ScanTextResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ScanTextResponseBodyData Data { get; set; }
        public class ScanTextResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<ScanTextResponseBodyDataElements> Elements { get; set; }
            public class ScanTextResponseBodyDataElements : TeaModel {
                public string TaskId { get; set; }
                public List<ScanTextResponseBodyDataElementsResults> Results { get; set; }
                public class ScanTextResponseBodyDataElementsResults : TeaModel {
                    public string Suggestion { get; set; }
                    public string Label { get; set; }
                    public float? Rate { get; set; }
                    public List<ScanTextResponseBodyDataElementsResultsDetails> Details { get; set; }
                    public class ScanTextResponseBodyDataElementsResultsDetails : TeaModel {
                        public string Label { get; set; }
                        public List<ScanTextResponseBodyDataElementsResultsDetailsContexts> Contexts { get; set; }
                        public class ScanTextResponseBodyDataElementsResultsDetailsContexts : TeaModel {
                            public string Context { get; set; }
                        }
                    }
                }
            }
        };

    }

}
