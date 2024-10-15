// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryVoiceFileAuditInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <para>The value OK indicates that the request was successful. For more information about other response codes, see <a href="https://help.aliyun.com/document_detail/112502.html">API error codes</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryVoiceFileAuditInfoResponseBodyData> Data { get; set; }
        public class QueryVoiceFileAuditInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The review state of the voice file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>AUDIT_STATE_INIT</b>: The voice file was under review.</description></item>
            /// <item><description><b>AUDIT_STATE_PASS</b>: The voice file was approved.</description></item>
            /// <item><description><b>AUDIT_STATE_NOT_PASS</b>: The voice file was rejected.</description></item>
            /// <item><description><b>AUDIT_STATE_UPLOADING</b>: The voice file was approved and is being uploaded.</description></item>
            /// <item><description><b>AUDIT_STATE_REDOING</b>: The voice file was being reprocessed.</description></item>
            /// <item><description><b>AUDIT_SATE_CANCEL</b>: The review of the voice file was canceled.</description></item>
            /// <item><description><b>AUDIT_PAUSE</b>: The review of the voice file was suspended.</description></item>
            /// <item><description><b>AUDIT_ORDER_FINISHED</b>: The voice file was approved by the ticket system and was waiting for the review of the Internet service provider (ISP).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AUDIT_STATE_NOT_PASS</para>
            /// </summary>
            [NameInMap("AuditState")]
            [Validation(Required=false)]
            public string AuditState { get; set; }

            /// <summary>
            /// <para>The reason why the voice file was rejected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This business is not supported</para>
            /// </summary>
            [NameInMap("RejectInfo")]
            [Validation(Required=false)]
            public string RejectInfo { get; set; }

            /// <summary>
            /// <para>The code of the voice file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8501d2eb-efbb-471f-xxx8-****.wav</para>
            /// </summary>
            [NameInMap("VoiceCode")]
            [Validation(Required=false)]
            public string VoiceCode { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A90E4451-FED7-49D2-87C8-00700A8C4D0D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
