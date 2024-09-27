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
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.9994202852249146</para>
                        /// </summary>
                        [NameInMap("keyConfidence")]
                        [Validation(Required=false)]
                        public double? KeyConfidence { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.9794202852249146</para>
                        /// </summary>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>83A5A7DD-8974-5769-952E-590A97BEA34E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
