// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetTopicStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E475C7E2-8C35-46EF-BE7D-5D2A9F5D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Topic status.</para>
        /// </summary>
        [NameInMap("TopicStatus")]
        [Validation(Required=false)]
        public GetTopicStatusResponseBodyTopicStatus TopicStatus { get; set; }
        public class GetTopicStatusResponseBodyTopicStatus : TeaModel {
            /// <summary>
            /// <para>Generation time of the last consumed message. Unit: ms.</para>
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
            /// <para>Total number of messages.</para>
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
