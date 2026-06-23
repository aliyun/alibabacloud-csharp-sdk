// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GenDocQaResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The time consumed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GenDocQaResultResponseBodyData Data { get; set; }
        public class GenDocQaResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current status. Valid values: \<c>INIT\\</c>, \<c>PROCESSING\\</c>, \<c>COMPLETED\\</c>, and \<c>FAIL\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROCESSING</para>
            /// </summary>
            [NameInMap("currentStatus")]
            [Validation(Required=false)]
            public string CurrentStatus { get; set; }

            /// <summary>
            /// <para>The document ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>873648346573245</para>
            /// </summary>
            [NameInMap("docId")]
            [Validation(Required=false)]
            public string DocId { get; set; }

            /// <summary>
            /// <para>The document library ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7wxwrjpabj</para>
            /// </summary>
            [NameInMap("libraryId")]
            [Validation(Required=false)]
            public string LibraryId { get; set; }

            /// <summary>
            /// <para>The results of the Q\&amp;A pair parsing.</para>
            /// </summary>
            [NameInMap("parseQaResults")]
            [Validation(Required=false)]
            public List<GenDocQaResultResponseBodyDataParseQaResults> ParseQaResults { get; set; }
            public class GenDocQaResultResponseBodyDataParseQaResults : TeaModel {
                /// <summary>
                /// <para>The answer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>今天的天气不错，多云转晴。</para>
                /// </summary>
                [NameInMap("answer")]
                [Validation(Required=false)]
                public string Answer { get; set; }

                /// <summary>
                /// <para>The question.</para>
                /// 
                /// <b>Example:</b>
                /// <para>今天的天气怎么样？</para>
                /// </summary>
                [NameInMap("question")]
                [Validation(Required=false)]
                public string Question { get; set; }

            }

        }

        /// <summary>
        /// <para>The data type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44BD277A-87F9-5310-8D63-3E6645F1DA85</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-04-24 11:54:34</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
