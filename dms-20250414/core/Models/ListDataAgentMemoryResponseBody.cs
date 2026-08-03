// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListDataAgentMemoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of Success indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataAgentMemoryResponseBodyData Data { get; set; }
        public class ListDataAgentMemoryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The response struct.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListDataAgentMemoryResponseBodyDataData> Data { get; set; }
            public class ListDataAgentMemoryResponseBodyDataData : TeaModel {
                /// <summary>
                /// <para>The memory content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Diamond pricing analysis requires examining the skewness and outliers of the distribution of each feature.</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The memory source ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>w3xa1********x6y8zm</para>
                /// </summary>
                [NameInMap("FromId")]
                [Validation(Required=false)]
                public string FromId { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-07-29T07:11:23Z</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-07-29T07:11:23Z</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The memory hit level (hotness).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("HintLevel")]
                [Validation(Required=false)]
                public long? HintLevel { get; set; }

                /// <summary>
                /// <para>The memory source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>session</para>
                /// </summary>
                [NameInMap("MemFrom")]
                [Validation(Required=false)]
                public string MemFrom { get; set; }

                /// <summary>
                /// <para>The memory status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>memorized</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The memory UUID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8zm3w********g3yxa1</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidTid</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Specified parameter Tid is not valid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>67E910F2-4B62-5B0C-ACA3-7547695C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.                                 </description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The operation timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1768270172</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public string Timestamp { get; set; }

    }

}
