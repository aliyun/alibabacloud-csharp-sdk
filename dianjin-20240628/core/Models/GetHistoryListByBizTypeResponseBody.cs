// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetHistoryListByBizTypeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetHistoryListByBizTypeResponseBodyData Data { get; set; }
        public class GetHistoryListByBizTypeResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("currentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("records")]
            [Validation(Required=false)]
            public List<GetHistoryListByBizTypeResponseBodyDataRecords> Records { get; set; }
            public class GetHistoryListByBizTypeResponseBodyDataRecords : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>GysYBsxx</para>
                /// </summary>
                [NameInMap("bizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>LibraryChat</para>
                /// </summary>
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("extraMessage")]
                [Validation(Required=false)]
                public object ExtraMessage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>210</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("llmAnswer")]
                [Validation(Required=false)]
                public string LlmAnswer { get; set; }

                [NameInMap("llmPrompt")]
                [Validation(Required=false)]
                public string LlmPrompt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>qwen-max</para>
                /// </summary>
                [NameInMap("llmType")]
                [Validation(Required=false)]
                public string LlmType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("sessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                [NameInMap("userQuery")]
                [Validation(Required=false)]
                public string UserQuery { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("totalPages")]
            [Validation(Required=false)]
            public long? TotalPages { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("totalRecords")]
            [Validation(Required=false)]
            public long? TotalRecords { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9DF9B3F3-9FFE-52CB-A8DC-F7BD5F842F0E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
