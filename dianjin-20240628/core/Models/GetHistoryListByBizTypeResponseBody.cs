// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetHistoryListByBizTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>Response time in milliseconds</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        /// <summary>
        /// <para>Response data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetHistoryListByBizTypeResponseBodyData Data { get; set; }
        public class GetHistoryListByBizTypeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Current page number</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("currentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            /// <summary>
            /// <para>Number of records per page</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>Records</para>
            /// </summary>
            [NameInMap("records")]
            [Validation(Required=false)]
            public List<GetHistoryListByBizTypeResponseBodyDataRecords> Records { get; set; }
            public class GetHistoryListByBizTypeResponseBodyDataRecords : TeaModel {
                /// <summary>
                /// <para>Business ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>GysYBsxx</para>
                /// </summary>
                [NameInMap("bizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                /// <summary>
                /// <para>Business type</para>
                /// 
                /// <b>Example:</b>
                /// <para>LibraryChat</para>
                /// </summary>
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// <para>Extension information</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("extraMessage")]
                [Validation(Required=false)]
                public object ExtraMessage { get; set; }

                /// <summary>
                /// <para>Creation time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>Last modified time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>History record ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>210</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Large Language Model (LLM) response</para>
                /// 
                /// <b>Example:</b>
                /// <para>你好。</para>
                /// </summary>
                [NameInMap("llmAnswer")]
                [Validation(Required=false)]
                public string LlmAnswer { get; set; }

                /// <summary>
                /// <para>Prompt for the Large Language Model (LLM)</para>
                /// 
                /// <b>Example:</b>
                /// <para>请使用以下上下文来回答最后的问题。\n以下是上下文内容：</para>
                /// </summary>
                [NameInMap("llmPrompt")]
                [Validation(Required=false)]
                public string LlmPrompt { get; set; }

                /// <summary>
                /// <para>Large Language Model (LLM) type</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen-max</para>
                /// </summary>
                [NameInMap("llmType")]
                [Validation(Required=false)]
                public string LlmType { get; set; }

                /// <summary>
                /// <para>Session ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("sessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <para>User query</para>
                /// 
                /// <b>Example:</b>
                /// <para>你是谁</para>
                /// </summary>
                [NameInMap("userQuery")]
                [Validation(Required=false)]
                public string UserQuery { get; set; }

            }

            /// <summary>
            /// <para>Total number of pages</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("totalPages")]
            [Validation(Required=false)]
            public long? TotalPages { get; set; }

            /// <summary>
            /// <para>Total number of records</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("totalRecords")]
            [Validation(Required=false)]
            public long? TotalRecords { get; set; }

        }

        /// <summary>
        /// <para>Data type</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>Error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>9DF9B3F3-9FFE-52CB-A8DC-F7BD5F842F0E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Timestamp</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
