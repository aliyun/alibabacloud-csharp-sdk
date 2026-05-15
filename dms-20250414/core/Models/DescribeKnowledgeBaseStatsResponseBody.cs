// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DescribeKnowledgeBaseStatsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeKnowledgeBaseStatsResponseBodyData Data { get; set; }
        public class DescribeKnowledgeBaseStatsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DocumentCount")]
            [Validation(Required=false)]
            public int? DocumentCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("KbHits")]
            [Validation(Required=false)]
            public long? KbHits { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>kb-***</para>
            /// </summary>
            [NameInMap("KbUuid")]
            [Validation(Required=false)]
            public string KbUuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalChunkCount")]
            [Validation(Required=false)]
            public int? TotalChunkCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4194588751</para>
            /// </summary>
            [NameInMap("TotalFileSize")]
            [Validation(Required=false)]
            public long? TotalFileSize { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Permission denied.</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Knowledge base limit exceeded. Current: xxx</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>67E910F2-4B62-5B0C-ACA3-7547695C****</para>
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

    }

}
