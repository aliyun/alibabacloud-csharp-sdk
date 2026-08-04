// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class BatchDeleteTopicsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public BatchDeleteTopicsResponseBodyData Data { get; set; }
        public class BatchDeleteTopicsResponseBodyData : TeaModel {
            [NameInMap("FailedCount")]
            [Validation(Required=false)]
            public int? FailedCount { get; set; }

            [NameInMap("Results")]
            [Validation(Required=false)]
            public BatchDeleteTopicsResponseBodyDataResults Results { get; set; }
            public class BatchDeleteTopicsResponseBodyDataResults : TeaModel {
                [NameInMap("TopicDeleteResultItemVO")]
                [Validation(Required=false)]
                public List<BatchDeleteTopicsResponseBodyDataResultsTopicDeleteResultItemVO> TopicDeleteResultItemVO { get; set; }
                public class BatchDeleteTopicsResponseBodyDataResultsTopicDeleteResultItemVO : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    [NameInMap("DynamicCode")]
                    [Validation(Required=false)]
                    public string DynamicCode { get; set; }

                    [NameInMap("DynamicMessage")]
                    [Validation(Required=false)]
                    public string DynamicMessage { get; set; }

                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("Success")]
                    [Validation(Required=false)]
                    public bool? Success { get; set; }

                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }

            }

            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
