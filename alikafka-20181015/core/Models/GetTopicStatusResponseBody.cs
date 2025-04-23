// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20181015.Models
{
    public class GetTopicStatusResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E475C7E2-8C35-46EF-BE7D-5D2A9F5D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TopicStatus")]
        [Validation(Required=false)]
        public GetTopicStatusResponseBodyTopicStatus TopicStatus { get; set; }
        public class GetTopicStatusResponseBodyTopicStatus : TeaModel {
            /// <summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1566470063547</para>
                    /// </summary>
                    [NameInMap("LastUpdateTimestamp")]
                    [Validation(Required=false)]
                    public long? LastUpdateTimestamp { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>76</para>
                    /// </summary>
                    [NameInMap("MaxOffset")]
                    [Validation(Required=false)]
                    public long? MaxOffset { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MinOffset")]
                    [Validation(Required=false)]
                    public long? MinOffset { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Partition")]
                    [Validation(Required=false)]
                    public int? Partition { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>testkafka</para>
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>423</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

    }

}
