// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySmsSignListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description>The value OK indicates that the request was successful.</description></item>
        /// <item><description>Other values indicate that the request failed. For more information, see <a href="https://help.aliyun.com/document_detail/101346.html">Error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

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
        /// <para>The number of signatures per page. Valid values: <b>1 to 50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>819BE656-D2E0-4858-8B21-B2E47708****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The queried message signatures.</para>
        /// </summary>
        [NameInMap("SmsSignList")]
        [Validation(Required=false)]
        public List<QuerySmsSignListResponseBodySmsSignList> SmsSignList { get; set; }
        public class QuerySmsSignListResponseBodySmsSignList : TeaModel {
            /// <summary>
            /// <para>The approval status of the signature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>AUDIT_STATE_INIT</b>: The signature is pending approval.</description></item>
            /// <item><description><b>AUDIT_STATE_PASS</b>: The signature is approved.</description></item>
            /// <item><description><b>AUDIT_STATE_NOT_PASS</b>: The signature is rejected. You can view the reason in the Reason response parameter.</description></item>
            /// <item><description><b>AUDIT_STATE_CANCEL</b>: The approval is canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AUDIT_STATE_NOT_PASS</para>
            /// </summary>
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public string AuditStatus { get; set; }

            [NameInMap("AuthorizationLetterId")]
            [Validation(Required=false)]
            public long? AuthorizationLetterId { get; set; }

            /// <summary>
            /// <para>The type of the signature scenario. The return value ends with &quot;type&quot;. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Verification code type</description></item>
            /// <item><description>General-purpose type</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Verification code type</para>
            /// </summary>
            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public string BusinessType { get; set; }

            /// <summary>
            /// <para>The time when the signature was created. Format: yyyy-MM-dd HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-01-08 16:44:13</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The ticket ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>236****5</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// <para>The approval remarks.</para>
            /// <list type="bullet">
            /// <item><description>If the value of AuditStatus is <b>AUDIT_STATE_PASS</b> or <b>AUDIT_STATE_INIT</b>, the value of Reason is No Approval Remarks.</description></item>
            /// <item><description>If the value of AuditStatus is <b>AUDIT_STATE_NOT_PASS</b>, the reason why the signature is rejected is returned.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public QuerySmsSignListResponseBodySmsSignListReason Reason { get; set; }
            public class QuerySmsSignListResponseBodySmsSignListReason : TeaModel {
                /// <summary>
                /// <para>The time when the signature was rejected. Format: yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-01-08 19:02:13</para>
                /// </summary>
                [NameInMap("RejectDate")]
                [Validation(Required=false)]
                public string RejectDate { get; set; }

                /// <summary>
                /// <para>The reason why the signature was rejected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The document cannot verify the authenticity of the information. Please upload it again.</para>
                /// </summary>
                [NameInMap("RejectInfo")]
                [Validation(Required=false)]
                public string RejectInfo { get; set; }

                /// <summary>
                /// <para>The remarks about the rejection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The document cannot verify the authenticity of the information. Please upload it again.</para>
                /// </summary>
                [NameInMap("RejectSubInfo")]
                [Validation(Required=false)]
                public string RejectSubInfo { get; set; }

            }

            /// <summary>
            /// <para>The name of the signature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Aliyun</para>
            /// </summary>
            [NameInMap("SignName")]
            [Validation(Required=false)]
            public string SignName { get; set; }

            [NameInMap("authorizationLetterAuditPass")]
            [Validation(Required=false)]
            public bool? AuthorizationLetterAuditPass { get; set; }

        }

        /// <summary>
        /// <para>The total number of signatures.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
