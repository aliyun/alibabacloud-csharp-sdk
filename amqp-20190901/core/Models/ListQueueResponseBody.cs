// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp20190901.Models
{
    public class ListQueueResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListQueueResponseBodyData Data { get; set; }
        public class ListQueueResponseBodyData : TeaModel {
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
            public ListQueueResponseBodyDataVoList VoList { get; set; }
            public class ListQueueResponseBodyDataVoList : TeaModel {
                [NameInMap("QueueVO")]
                [Validation(Required=false)]
                public List<ListQueueResponseBodyDataVoListQueueVO> QueueVO { get; set; }
                public class ListQueueResponseBodyDataVoListQueueVO : TeaModel {
                    [NameInMap("AccumulationCount")]
                    [Validation(Required=false)]
                    public long? AccumulationCount { get; set; }

                    [NameInMap("Attributes")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Attributes { get; set; }

                    [NameInMap("AutoDelete")]
                    [Validation(Required=false)]
                    public bool? AutoDelete { get; set; }

                    [NameInMap("CanDelete")]
                    [Validation(Required=false)]
                    public bool? CanDelete { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    [NameInMap("Durable")]
                    [Validation(Required=false)]
                    public bool? Durable { get; set; }

                    [NameInMap("Exclusive")]
                    [Validation(Required=false)]
                    public bool? Exclusive { get; set; }

                    [NameInMap("LastConsumeTime")]
                    [Validation(Required=false)]
                    public long? LastConsumeTime { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

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
