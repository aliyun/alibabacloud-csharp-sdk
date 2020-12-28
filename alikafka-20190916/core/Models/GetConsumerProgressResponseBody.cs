// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetConsumerProgressResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ConsumerProgress")]
        [Validation(Required=false)]
        public GetConsumerProgressResponseBodyConsumerProgress ConsumerProgress { get; set; }
        public class GetConsumerProgressResponseBodyConsumerProgress : TeaModel {
            [NameInMap("TopicList")]
            [Validation(Required=false)]
            public List<GetConsumerProgressResponseBodyConsumerProgressTopicList> TopicList { get; set; }
            public class GetConsumerProgressResponseBodyConsumerProgressTopicList : TeaModel {
                public long? TotalDiff { get; set; }
                public long? LastTimestamp { get; set; }
                public string Topic { get; set; }
                public List<GetConsumerProgressResponseBodyConsumerProgressTopicListOffsetList> OffsetList { get; set; }
                public class GetConsumerProgressResponseBodyConsumerProgressTopicListOffsetList : TeaModel {
                    public long? BrokerOffset { get; set; }
                    public long? ConsumerOffset { get; set; }
                    public long? LastTimestamp { get; set; }
                    public int? Partition { get; set; }
                }
            }
            [NameInMap("LastTimestamp")]
            [Validation(Required=false)]
            public long? LastTimestamp { get; set; }
            [NameInMap("TotalDiff")]
            [Validation(Required=false)]
            public long? TotalDiff { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
