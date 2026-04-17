// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetTopicStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned. The HTTP status code 200 indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E475C7E2-8C35-46EF-BE7D-5D2A9F5D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The status information about messages in the topic.</para>
        /// </summary>
        [NameInMap("TopicStatus")]
        [Validation(Required=false)]
        public GetTopicStatusResponseBodyTopicStatus TopicStatus { get; set; }
        public class GetTopicStatusResponseBodyTopicStatus : TeaModel {
            /// <summary>
            /// <para>The time when the last consumed message was generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1566470063575</para>
            /// </summary>
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
                    [NameInMap("LastUpdateTimestamp")]
                    [Validation(Required=false)]
                    public long? LastUpdateTimestamp { get; set; }

                    [NameInMap("MaxOffset")]
                    [Validation(Required=false)]
                    public long? MaxOffset { get; set; }

                    [NameInMap("MinOffset")]
                    [Validation(Required=false)]
                    public long? MinOffset { get; set; }

                    [NameInMap("Partition")]
                    [Validation(Required=false)]
                    public int? Partition { get; set; }

                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }

            }

            /// <summary>
            /// <para>The number of messages in the topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>423</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

    }

}
