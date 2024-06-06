// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetDocumentAnalyzeResultResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDocumentAnalyzeResultResponseBodyData Data { get; set; }
        public class GetDocumentAnalyzeResultResponseBodyData : TeaModel {
            [NameInMap("kvListInfo")]
            [Validation(Required=false)]
            public List<GetDocumentAnalyzeResultResponseBodyDataKvListInfo> KvListInfo { get; set; }
            public class GetDocumentAnalyzeResultResponseBodyDataKvListInfo : TeaModel {
                [NameInMap("context")]
                [Validation(Required=false)]
                public GetDocumentAnalyzeResultResponseBodyDataKvListInfoContext Context { get; set; }
                public class GetDocumentAnalyzeResultResponseBodyDataKvListInfoContext : TeaModel {
                    [NameInMap("confidence")]
                    [Validation(Required=false)]
                    public GetDocumentAnalyzeResultResponseBodyDataKvListInfoContextConfidence Confidence { get; set; }
                    public class GetDocumentAnalyzeResultResponseBodyDataKvListInfoContextConfidence : TeaModel {
                        [NameInMap("keyConfidence")]
                        [Validation(Required=false)]
                        public double? KeyConfidence { get; set; }

                        [NameInMap("valueConfidence")]
                        [Validation(Required=false)]
                        public double? ValueConfidence { get; set; }

                    }

                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public List<ContentItem> Key { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public List<ContentItem> Value { get; set; }

                }

                [NameInMap("keyName")]
                [Validation(Required=false)]
                public string KeyName { get; set; }

                [NameInMap("keyValue")]
                [Validation(Required=false)]
                public string KeyValue { get; set; }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
