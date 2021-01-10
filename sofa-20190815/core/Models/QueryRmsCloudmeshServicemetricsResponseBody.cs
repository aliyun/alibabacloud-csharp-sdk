// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsCloudmeshServicemetricsResponseBody : TeaModel {
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
        public QueryRmsCloudmeshServicemetricsResponseBodyResponse Response { get; set; }
        public class QueryRmsCloudmeshServicemetricsResponseBodyResponse : TeaModel {
            [NameInMap("ErrMsg")]
            [Validation(Required=false)]
            public string ErrMsg { get; set; }
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public QueryRmsCloudmeshServicemetricsResponseBodyResponseData Data { get; set; }
            public class QueryRmsCloudmeshServicemetricsResponseBodyResponseData : TeaModel {
                [NameInMap("ErrorRate")]
                [Validation(Required=false)]
                public List<QueryRmsCloudmeshServicemetricsResponseBodyResponseDataErrorRate> ErrorRate { get; set; }
                public class QueryRmsCloudmeshServicemetricsResponseBodyResponseDataErrorRate : TeaModel {
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("ResTime")]
                [Validation(Required=false)]
                public List<QueryRmsCloudmeshServicemetricsResponseBodyResponseDataResTime> ResTime { get; set; }
                public class QueryRmsCloudmeshServicemetricsResponseBodyResponseDataResTime : TeaModel {
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Rps")]
                [Validation(Required=false)]
                public List<QueryRmsCloudmeshServicemetricsResponseBodyResponseDataRps> Rps { get; set; }
                public class QueryRmsCloudmeshServicemetricsResponseBodyResponseDataRps : TeaModel {
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
