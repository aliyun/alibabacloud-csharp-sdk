// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DescribeKnowledgeBaseStatsResponseBody : TeaModel {
        /// <summary>
        /// <para>The object that contains the knowledge base statistics.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeKnowledgeBaseStatsResponseBodyData Data { get; set; }
        public class DescribeKnowledgeBaseStatsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of documents in the knowledge base.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DocumentCount")]
            [Validation(Required=false)]
            public int? DocumentCount { get; set; }

            /// <summary>
            /// <para>The number of hits for the knowledge base.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("KbHits")]
            [Validation(Required=false)]
            public long? KbHits { get; set; }

            /// <summary>
            /// <para>The ID of the knowledge base.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kb-***</para>
            /// </summary>
            [NameInMap("KbUuid")]
            [Validation(Required=false)]
            public string KbUuid { get; set; }

            /// <summary>
            /// <para>The total number of knowledge chunks in the knowledge base.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalChunkCount")]
            [Validation(Required=false)]
            public int? TotalChunkCount { get; set; }

            /// <summary>
            /// <para>The total size of all files in the knowledge base, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4194588751</para>
            /// </summary>
            [NameInMap("TotalFileSize")]
            [Validation(Required=false)]
            public long? TotalFileSize { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Permission denied.</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Knowledge base limit exceeded. Current: xxx</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The unique ID of the request. Use this ID to troubleshoot errors.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67E910F2-4B62-5B0C-ACA3-7547695C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded. A value of <c>true</c> indicates success, and a value of <c>false</c> indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
