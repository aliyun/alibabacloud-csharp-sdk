// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetSmartAuditResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataNotExists</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The review result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSmartAuditResultResponseBodyData Data { get; set; }
        public class GetSmartAuditResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of review error details.</para>
            /// </summary>
            [NameInMap("ErrorItemDetails")]
            [Validation(Required=false)]
            public List<GetSmartAuditResultResponseBodyDataErrorItemDetails> ErrorItemDetails { get; set; }
            public class GetSmartAuditResultResponseBodyDataErrorItemDetails : TeaModel {
                /// <summary>
                /// <para>The unique ID of the review item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>审核项唯一标识。</para>
                /// </summary>
                [NameInMap("CheckId")]
                [Validation(Required=false)]
                public string CheckId { get; set; }

                /// <summary>
                /// <para>The original text segment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>原文片段</para>
                /// </summary>
                [NameInMap("Context")]
                [Validation(Required=false)]
                public string Context { get; set; }

                /// <summary>
                /// <para>The offset index of the incorrect word within the context.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ContextOffset")]
                [Validation(Required=false)]
                public int? ContextOffset { get; set; }

                /// <summary>
                /// <para>The error level. 1: critical, 2: warning, 3: notice, 4: suggestion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ErrorLevel")]
                [Validation(Required=false)]
                public int? ErrorLevel { get; set; }

                /// <summary>
                /// <para>The incorrect word.</para>
                /// 
                /// <b>Example:</b>
                /// <para>”xxx“</para>
                /// </summary>
                [NameInMap("ErrorWord")]
                [Validation(Required=false)]
                public string ErrorWord { get; set; }

                /// <summary>
                /// <para>The primary error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ContentAccuracy</para>
                /// </summary>
                [NameInMap("MajorCode")]
                [Validation(Required=false)]
                public string MajorCode { get; set; }

                /// <summary>
                /// <para>The description of the primary error.</para>
                /// 
                /// <b>Example:</b>
                /// <para>内容准确性</para>
                /// </summary>
                [NameInMap("MajorCodeDesc")]
                [Validation(Required=false)]
                public string MajorCodeDesc { get; set; }

                /// <summary>
                /// <para>The offset index of the incorrect word in the full text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Offset")]
                [Validation(Required=false)]
                public int? Offset { get; set; }

                /// <summary>
                /// <para>The error description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>中文双引号应成对正确使用，先左双引号，后右双引号</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>The suggested correction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>“xxx”</para>
                /// </summary>
                [NameInMap("RightWord")]
                [Validation(Required=false)]
                public string RightWord { get; set; }

                /// <summary>
                /// <para>The sub-error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PunctuationError</para>
                /// </summary>
                [NameInMap("SubClassCode")]
                [Validation(Required=false)]
                public string SubClassCode { get; set; }

                /// <summary>
                /// <para>The description of the sub-error.</para>
                /// 
                /// <b>Example:</b>
                /// <para>标点符号错误</para>
                /// </summary>
                [NameInMap("SubClassDesc")]
                [Validation(Required=false)]
                public string SubClassDesc { get; set; }

                /// <summary>
                /// <para>In an image review scenario, this is the public URL of the image that triggered the review.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com/xxxx.jpg">http://www.example.com/xxxx.jpg</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>If the final status is not SUCCESSED, read this error message to identify the fault.</para>
            /// 
            /// <b>Example:</b>
            /// <para>审核被取消</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The task execution status. Valid values: PENDING, RUNNING, SUCCESSED, SUSPENDED, FAILED, and CANCELLED.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESSED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>错误消息</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
