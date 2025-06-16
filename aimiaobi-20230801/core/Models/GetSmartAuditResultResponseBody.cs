// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetSmartAuditResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DataNotExists</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSmartAuditResultResponseBodyData Data { get; set; }
        public class GetSmartAuditResultResponseBodyData : TeaModel {
            [NameInMap("ErrorItemDetails")]
            [Validation(Required=false)]
            public List<GetSmartAuditResultResponseBodyDataErrorItemDetails> ErrorItemDetails { get; set; }
            public class GetSmartAuditResultResponseBodyDataErrorItemDetails : TeaModel {
                [NameInMap("CheckId")]
                [Validation(Required=false)]
                public string CheckId { get; set; }

                [NameInMap("Context")]
                [Validation(Required=false)]
                public string Context { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ContextOffset")]
                [Validation(Required=false)]
                public int? ContextOffset { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ErrorLevel")]
                [Validation(Required=false)]
                public int? ErrorLevel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>”xxx“</para>
                /// </summary>
                [NameInMap("ErrorWord")]
                [Validation(Required=false)]
                public string ErrorWord { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ContentAccuracy</para>
                /// </summary>
                [NameInMap("MajorCode")]
                [Validation(Required=false)]
                public string MajorCode { get; set; }

                [NameInMap("MajorCodeDesc")]
                [Validation(Required=false)]
                public string MajorCodeDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Offset")]
                [Validation(Required=false)]
                public int? Offset { get; set; }

                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>“xxx”</para>
                /// </summary>
                [NameInMap("RightWord")]
                [Validation(Required=false)]
                public string RightWord { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PunctuationError</para>
                /// </summary>
                [NameInMap("SubClassCode")]
                [Validation(Required=false)]
                public string SubClassCode { get; set; }

                [NameInMap("SubClassDesc")]
                [Validation(Required=false)]
                public string SubClassDesc { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUCCESSED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>错误消息</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
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
