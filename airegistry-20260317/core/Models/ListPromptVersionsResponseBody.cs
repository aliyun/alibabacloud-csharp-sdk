// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class ListPromptVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListPromptVersionsResponseBodyData Data { get; set; }
        public class ListPromptVersionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of prompt versions.</para>
            /// </summary>
            [NameInMap("PageItems")]
            [Validation(Required=false)]
            public List<ListPromptVersionsResponseBodyDataPageItems> PageItems { get; set; }
            public class ListPromptVersionsResponseBodyDataPageItems : TeaModel {
                /// <summary>
                /// <para>The commit message of the prompt version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is a test version</para>
                /// </summary>
                [NameInMap("CommitMsg")]
                [Validation(Required=false)]
                public string CommitMsg { get; set; }

                /// <summary>
                /// <para>The modification date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-04T16:09:29+08:00</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <para>The unique identifier of the prompt.</para>
                /// 
                /// <b>Example:</b>
                /// <para>customer-service-qa</para>
                /// </summary>
                [NameInMap("PromptKey")]
                [Validation(Required=false)]
                public string PromptKey { get; set; }

                /// <summary>
                /// <para>The creator of the prompt version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("SrcUser")]
                [Validation(Required=false)]
                public string SrcUser { get; set; }

                /// <summary>
                /// <para>The status of the prompt version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>draft</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The page number. Valid values: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of available pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PagesAvailable")]
            [Validation(Required=false)]
            public int? PagesAvailable { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9E87E66-9EF0-5C10-A5E6-924020A0C9B7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
