// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp20190901.Models
{
    public class GetQueueErrorByTaskIdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetQueueErrorByTaskIdResponseBodyData Data { get; set; }
        public class GetQueueErrorByTaskIdResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            [NameInMap("VoList")]
            [Validation(Required=false)]
            public GetQueueErrorByTaskIdResponseBodyDataVoList VoList { get; set; }
            public class GetQueueErrorByTaskIdResponseBodyDataVoList : TeaModel {
                [NameInMap("QueueErrorDO")]
                [Validation(Required=false)]
                public List<GetQueueErrorByTaskIdResponseBodyDataVoListQueueErrorDO> QueueErrorDO { get; set; }
                public class GetQueueErrorByTaskIdResponseBodyDataVoListQueueErrorDO : TeaModel {
                    [NameInMap("AutoDelete")]
                    [Validation(Required=false)]
                    public bool? AutoDelete { get; set; }

                    [NameInMap("Durable")]
                    [Validation(Required=false)]
                    public bool? Durable { get; set; }

                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public int? ErrorMessage { get; set; }

                    [NameInMap("QueueName")]
                    [Validation(Required=false)]
                    public string QueueName { get; set; }

                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public long? TaskId { get; set; }

                    [NameInMap("VhostName")]
                    [Validation(Required=false)]
                    public string VhostName { get; set; }

                }

            }

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
