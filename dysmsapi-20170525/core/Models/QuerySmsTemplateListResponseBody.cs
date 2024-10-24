// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySmsTemplateListResponseBody : TeaModel {
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
        /// <para>The number of templates per page. Valid values: <b>1 to 50</b>.</para>
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
        /// <para>The queried message templates.</para>
        /// </summary>
        [NameInMap("SmsTemplateList")]
        [Validation(Required=false)]
        public List<QuerySmsTemplateListResponseBodySmsTemplateList> SmsTemplateList { get; set; }
        public class QuerySmsTemplateListResponseBodySmsTemplateList : TeaModel {
            /// <summary>
            /// <para>The approval status of the message template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>AUDIT_STATE_INIT</b>: The message template is pending approval.</description></item>
            /// <item><description><b>AUDIT_STATE_PASS</b>: The message template is approved.</description></item>
            /// <item><description><b>AUDIT_STATE_NOT_PASS</b>: The message template is rejected. You can view the reason in the Reason response parameter.</description></item>
            /// <item><description><b>AUDIT_STATE_CANCEL</b> or <b>AUDIT_SATE_CANCEL</b>: The approval is canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AUDIT_STATE_PASS</para>
            /// </summary>
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public string AuditStatus { get; set; }

            /// <summary>
            /// <para>The time when the message template was created. The time is in the yyyy-MM-dd HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-04 11:42:17</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The ticket ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2361****</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// <para>The type of the message template. We recommend that you specify this parameter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: verification code</description></item>
            /// <item><description><b>1</b>: notification message</description></item>
            /// <item><description><b>2</b>: promotional message</description></item>
            /// <item><description><b>3</b>: message sent to countries or regions outside the Chinese mainland</description></item>
            /// <item><description><b>7</b>: digital message</description></item>
            /// </list>
            /// <remarks>
            /// <para>The template type is the same as the value of the TemplateType parameter in the AddSmsTemplate and ModifySmsTemplate operations.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OuterTemplateType")]
            [Validation(Required=false)]
            public int? OuterTemplateType { get; set; }

            /// <summary>
            /// <para>The approval remarks.</para>
            /// <list type="bullet">
            /// <item><description>If the value of AuditStatus is <b>AUDIT_STATE_PASS</b> or <b>AUDIT_STATE_INIT</b>, the value of Reason is No Approval Remarks.</description></item>
            /// <item><description>If the value of AuditStatus is <b>AUDIT_STATE_NOT_PASS</b>, the reason why the message template is rejected is returned.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public QuerySmsTemplateListResponseBodySmsTemplateListReason Reason { get; set; }
            public class QuerySmsTemplateListResponseBodySmsTemplateListReason : TeaModel {
                /// <summary>
                /// <para>The time when the message template was rejected. Format: yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-06-04 16:01:17</para>
                /// </summary>
                [NameInMap("RejectDate")]
                [Validation(Required=false)]
                public string RejectDate { get; set; }

                /// <summary>
                /// <para>The reason why the message template was rejected.</para>
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
            /// <para>The code of the message template.</para>
            /// <para>You can log on to the <a href="https://dysms.console.aliyun.com/dysms.htm">Short Message Service (SMS) console</a>, click <b>Go China</b> or <b>Go Globe</b> in the left-side navigation pane, and then view the template code on the <b>Templates</b> tab. You can also call the <a href="https://help.aliyun.com/document_detail/121208.html">AddSmsTemplate</a> operation to obtain the template code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SMS_1525***</para>
            /// </summary>
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            /// <summary>
            /// <para>The content of the message template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("TemplateContent")]
            [Validation(Required=false)]
            public string TemplateContent { get; set; }

            /// <summary>
            /// <para>The name of the message template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun verification code</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The type of the message template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: notification message</description></item>
            /// <item><description><b>1</b>: promotional message</description></item>
            /// <item><description><b>2</b>: verification code</description></item>
            /// <item><description><b>6</b>: message sent to countries or regions outside the Chinese mainland</description></item>
            /// <item><description><b>7</b>: digital message</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public int? TemplateType { get; set; }

        }

        /// <summary>
        /// <para>The total number of templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
