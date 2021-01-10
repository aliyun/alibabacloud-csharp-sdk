// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsCloudmeshMultibizqueryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Response")]
        [Validation(Required=false)]
        public QueryRmsCloudmeshMultibizqueryResponseBodyResponse Response { get; set; }
        public class QueryRmsCloudmeshMultibizqueryResponseBodyResponse : TeaModel {
            [NameInMap("ErrMsg")]
            [Validation(Required=false)]
            public string ErrMsg { get; set; }
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public QueryRmsCloudmeshMultibizqueryResponseBodyResponseData Data { get; set; }
            public class QueryRmsCloudmeshMultibizqueryResponseBodyResponseData : TeaModel {
                [NameInMap("ErrorRateDetail")]
                [Validation(Required=false)]
                public string ErrorRateDetail { get; set; }

                [NameInMap("ResTimeDetail")]
                [Validation(Required=false)]
                public string ResTimeDetail { get; set; }

                [NameInMap("RpsDetail")]
                [Validation(Required=false)]
                public string RpsDetail { get; set; }

                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public List<QueryRmsCloudmeshMultibizqueryResponseBodyResponseDataCpu> Cpu { get; set; }
                public class QueryRmsCloudmeshMultibizqueryResponseBodyResponseDataCpu : TeaModel {
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("ErrorRate")]
                [Validation(Required=false)]
                public List<QueryRmsCloudmeshMultibizqueryResponseBodyResponseDataErrorRate> ErrorRate { get; set; }
                public class QueryRmsCloudmeshMultibizqueryResponseBodyResponseDataErrorRate : TeaModel {
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("FlowIn")]
                [Validation(Required=false)]
                public List<QueryRmsCloudmeshMultibizqueryResponseBodyResponseDataFlowIn> FlowIn { get; set; }
                public class QueryRmsCloudmeshMultibizqueryResponseBodyResponseDataFlowIn : TeaModel {
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("FlowOut")]
                [Validation(Required=false)]
                public List<QueryRmsCloudmeshMultibizqueryResponseBodyResponseDataFlowOut> FlowOut { get; set; }
                public class QueryRmsCloudmeshMultibizqueryResponseBodyResponseDataFlowOut : TeaModel {
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public List<QueryRmsCloudmeshMultibizqueryResponseBodyResponseDataMemory> Memory { get; set; }
                public class QueryRmsCloudmeshMultibizqueryResponseBodyResponseDataMemory : TeaModel {
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("ResTime")]
                [Validation(Required=false)]
                public List<QueryRmsCloudmeshMultibizqueryResponseBodyResponseDataResTime> ResTime { get; set; }
                public class QueryRmsCloudmeshMultibizqueryResponseBodyResponseDataResTime : TeaModel {
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Rps")]
                [Validation(Required=false)]
                public List<QueryRmsCloudmeshMultibizqueryResponseBodyResponseDataRps> Rps { get; set; }
                public class QueryRmsCloudmeshMultibizqueryResponseBodyResponseDataRps : TeaModel {
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }
        };

    }

}
