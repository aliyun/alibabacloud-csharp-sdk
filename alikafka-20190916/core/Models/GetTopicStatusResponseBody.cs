// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetTopicStatusResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned. The HTTP status code 200 indicates that the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The status information about messages in the topic.
        /// </summary>
        [NameInMap("TopicStatus")]
        [Validation(Required=false)]
        public GetTopicStatusResponseBodyTopicStatus TopicStatus { get; set; }
        public class GetTopicStatusResponseBodyTopicStatus : TeaModel {
            /// <summary>
            /// The time when the last consumed message was generated.
            /// </summary>
            [NameInMap("LastTimeStamp")]
            [Validation(Required=false)]
            public long? LastTimeStamp { get; set; }

            /// <summary>
            /// The information about offsets in the topic.
            /// </summary>
            [NameInMap("OffsetTable")]
            [Validation(Required=false)]
            public GetTopicStatusResponseBodyTopicStatusOffsetTable OffsetTable { get; set; }
            public class GetTopicStatusResponseBodyTopicStatusOffsetTable : TeaModel {
                [NameInMap("OffsetTable")]
                [Validation(Required=false)]
                public List<GetTopicStatusResponseBodyTopicStatusOffsetTableOffsetTable> OffsetTable { get; set; }
                public class GetTopicStatusResponseBodyTopicStatusOffsetTableOffsetTable : TeaModel {
                    /// <summary>
                    /// The last time when the partition was modified.
                    /// </summary>
                    [NameInMap("LastUpdateTimestamp")]
                    [Validation(Required=false)]
                    public long? LastUpdateTimestamp { get; set; }

                    /// <summary>
                    /// The latest offset in the partition of the topic.
                    /// </summary>
                    [NameInMap("MaxOffset")]
                    [Validation(Required=false)]
                    public long? MaxOffset { get; set; }

                    /// <summary>
                    /// The earliest offset in the partition of the topic.
                    /// </summary>
                    [NameInMap("MinOffset")]
                    [Validation(Required=false)]
                    public long? MinOffset { get; set; }

                    /// <summary>
                    /// The ID of the partition.
                    /// </summary>
                    [NameInMap("Partition")]
                    [Validation(Required=false)]
                    public int? Partition { get; set; }

                    /// <summary>
                    /// The name of the topic.
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }

            }

            /// <summary>
            /// The number of messages in the topic.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

    }

}
