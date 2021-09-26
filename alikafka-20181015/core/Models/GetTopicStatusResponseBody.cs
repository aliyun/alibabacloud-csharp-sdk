// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20181015.Models
{
    public class GetTopicStatusResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TopicStatus")]
        [Validation(Required=false)]
        public GetTopicStatusResponseBodyTopicStatus TopicStatus { get; set; }
        public class GetTopicStatusResponseBodyTopicStatus : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
            [NameInMap("LastTimeStamp")]
            [Validation(Required=false)]
            public long? LastTimeStamp { get; set; }
            [NameInMap("OffsetTable")]
            [Validation(Required=false)]
            public GetTopicStatusResponseBodyTopicStatusOffsetTable OffsetTable { get; set; }
            public class GetTopicStatusResponseBodyTopicStatusOffsetTable : TeaModel {
                [NameInMap("OffsetTable")]
                [Validation(Required=false)]
                public List<GetTopicStatusResponseBodyTopicStatusOffsetTableOffsetTable> OffsetTable { get; set; }
                public class GetTopicStatusResponseBodyTopicStatusOffsetTableOffsetTable : TeaModel {
                    [NameInMap("Partition")]
                    [Validation(Required=false)]
                    public int? Partition { get; set; }

                    [NameInMap("MinOffset")]
                    [Validation(Required=false)]
                    public long? MinOffset { get; set; }

                    [NameInMap("LastUpdateTimestamp")]
                    [Validation(Required=false)]
                    public long? LastUpdateTimestamp { get; set; }

                    [NameInMap("MaxOffset")]
                    [Validation(Required=false)]
                    public long? MaxOffset { get; set; }

                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }

            }
        };

    }

}
