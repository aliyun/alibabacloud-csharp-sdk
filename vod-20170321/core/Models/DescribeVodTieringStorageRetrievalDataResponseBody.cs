// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodTieringStorageRetrievalDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A13-BEF6-D73936****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The retrieval data.</para>
        /// </summary>
        [NameInMap("RetrievalData")]
        [Validation(Required=false)]
        public List<DescribeVodTieringStorageRetrievalDataResponseBodyRetrievalData> RetrievalData { get; set; }
        public class DescribeVodTieringStorageRetrievalDataResponseBodyRetrievalData : TeaModel {
            /// <summary>
            /// <para>The Cold Archive bulk retrieval data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("CABulkRetrievalData")]
            [Validation(Required=false)]
            public long? CABulkRetrievalData { get; set; }

            /// <summary>
            /// <para>The Cold Archive high-priority retrieval data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("CAHighPriorRetrievalData")]
            [Validation(Required=false)]
            public long? CAHighPriorRetrievalData { get; set; }

            /// <summary>
            /// <para>The Cold Archive standard retrieval data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("CAStdRetrievalData")]
            [Validation(Required=false)]
            public long? CAStdRetrievalData { get; set; }

            /// <summary>
            /// <para>The storage region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The retrieval data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("RetrievalData")]
            [Validation(Required=false)]
            public long? RetrievalData { get; set; }

            /// <summary>
            /// <para>The media asset storage class.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IA</para>
            /// </summary>
            [NameInMap("StorageClass")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }

            /// <summary>
            /// <para>The start time of the time interval. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-02T10:20:00Z</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

        }

    }

}
