// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsCloudmeshSysmetricsResponseBody : TeaModel {
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
        public QueryRmsCloudmeshSysmetricsResponseBodyResponse Response { get; set; }
        public class QueryRmsCloudmeshSysmetricsResponseBodyResponse : TeaModel {
            [NameInMap("ErrMsg")]
            [Validation(Required=false)]
            public string ErrMsg { get; set; }
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public QueryRmsCloudmeshSysmetricsResponseBodyResponseData Data { get; set; }
            public class QueryRmsCloudmeshSysmetricsResponseBodyResponseData : TeaModel {
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public List<QueryRmsCloudmeshSysmetricsResponseBodyResponseDataCpu> Cpu { get; set; }
                public class QueryRmsCloudmeshSysmetricsResponseBodyResponseDataCpu : TeaModel {
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("FlowIn")]
                [Validation(Required=false)]
                public List<QueryRmsCloudmeshSysmetricsResponseBodyResponseDataFlowIn> FlowIn { get; set; }
                public class QueryRmsCloudmeshSysmetricsResponseBodyResponseDataFlowIn : TeaModel {
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("FlowOut")]
                [Validation(Required=false)]
                public List<QueryRmsCloudmeshSysmetricsResponseBodyResponseDataFlowOut> FlowOut { get; set; }
                public class QueryRmsCloudmeshSysmetricsResponseBodyResponseDataFlowOut : TeaModel {
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public List<QueryRmsCloudmeshSysmetricsResponseBodyResponseDataMemory> Memory { get; set; }
                public class QueryRmsCloudmeshSysmetricsResponseBodyResponseDataMemory : TeaModel {
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
