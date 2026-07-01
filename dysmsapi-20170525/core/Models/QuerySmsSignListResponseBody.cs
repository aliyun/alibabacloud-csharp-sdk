// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySmsSignListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>OK: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>For other error codes, see <a href="https://help.aliyun.com/document_detail/101346.html">Error codes</a>.</para>
        /// </description></item>
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
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The number of signatures to return on each page. Default value: <b>10</b>. Valid values: <b>1 to 50</b>.</para>
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
        /// <para>F655A8D5-B967-440B-8683-DAD6FF8DE990</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of returned results.</para>
        /// </summary>
        [NameInMap("SmsSignList")]
        [Validation(Required=false)]
        public List<QuerySmsSignListResponseBodySmsSignList> SmsSignList { get; set; }
        public class QuerySmsSignListResponseBodySmsSignList : TeaModel {
            /// <summary>
            /// <para>The APP-ICP filing entity ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000001***123</para>
            /// </summary>
            [NameInMap("AppIcpRecordId")]
            [Validation(Required=false)]
            public long? AppIcpRecordId { get; set; }

            /// <summary>
            /// <para>The audit status of the signature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>AUDIT_STATE_INIT</b>: under review.</para>
            /// </description></item>
            /// <item><description><para><b>AUDIT_STATE_PASS</b>: approved.</para>
            /// </description></item>
            /// <item><description><para><b>AUDIT_STATE_NOT_PASS</b>: rejected. You can view the rejection reason in the Reason response parameter.</para>
            /// </description></item>
            /// <item><description><para><b>AUDIT_STATE_CANCEL</b>: review canceled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AUDIT_STATE_NOT_PASS</para>
            /// </summary>
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public string AuditStatus { get; set; }

            /// <summary>
            /// <para>The ID of the letter of authorization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000********1234</para>
            /// </summary>
            [NameInMap("AuthorizationLetterId")]
            [Validation(Required=false)]
            public long? AuthorizationLetterId { get; set; }

            /// <summary>
            /// <para>The scenario type of the signature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Verification code.</para>
            /// </description></item>
            /// <item><description><para>General-purpose.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>验证码类型</para>
            /// </summary>
            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public string BusinessType { get; set; }

            /// <summary>
            /// <para>The time when the SMS signature was created. The format is yyyy-MM-dd HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-04 11:42:17</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The order ID.</para>
            /// <para>This parameter is used by auditors when querying the audit. You must provide this order ID if you need to expedite the audit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2005098****</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// <para>The audit remarks.</para>
            /// <list type="bullet">
            /// <item><description><para>If the audit status is <b>approved</b> or <b>under review</b>, the Reason parameter is displayed as &quot;No audit remarks&quot;.</para>
            /// </description></item>
            /// <item><description><para>If the audit status is <b>rejected</b>, the Reason parameter displays the specific reason for the rejection.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public QuerySmsSignListResponseBodySmsSignListReason Reason { get; set; }
            public class QuerySmsSignListResponseBodySmsSignListReason : TeaModel {
                /// <summary>
                /// <para>The time when the signature was rejected. The format is yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-06-04 13:35:10</para>
                /// </summary>
                [NameInMap("RejectDate")]
                [Validation(Required=false)]
                public string RejectDate { get; set; }

                /// <summary>
                /// <para>The reason for the rejection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>文件不能证明信息真实性，请重新上传。</para>
                /// </summary>
                [NameInMap("RejectInfo")]
                [Validation(Required=false)]
                public string RejectInfo { get; set; }

                /// <summary>
                /// <para>The remarks for the rejection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>文件不能证明信息真实性，请重新上传。</para>
                /// </summary>
                [NameInMap("RejectSubInfo")]
                [Validation(Required=false)]
                public string RejectSubInfo { get; set; }

            }

            /// <summary>
            /// <para>The signature name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>阿里云</para>
            /// </summary>
            [NameInMap("SignName")]
            [Validation(Required=false)]
            public string SignName { get; set; }

            /// <summary>
            /// <para>The trademark entity ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000009081***</para>
            /// </summary>
            [NameInMap("TrademarkId")]
            [Validation(Required=false)]
            public long? TrademarkId { get; set; }

            /// <summary>
            /// <para>The audit status of the letter of authorization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: approved.</description></item>
            /// <item><description>false: not approved (includes all statuses other than approved).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
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
