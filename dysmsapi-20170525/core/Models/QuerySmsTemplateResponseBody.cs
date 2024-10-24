// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySmsTemplateResponseBody : TeaModel {
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
        /// <para>The time when the message template was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-06-04 11:42:17</para>
        /// </summary>
        [NameInMap("CreateDate")]
        [Validation(Required=false)]
        public string CreateDate { get; set; }

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
        /// <para>The approval remarks.</para>
        /// <list type="bullet">
        /// <item><description>If the value of AuditStatus is <b>AUDIT_STATE_PASS</b> or <b>AUDIT_STATE_INIT</b>, the value of Reason is No Approval Remarks.</description></item>
        /// <item><description>If the value of AuditStatus is <b>AUDIT_STATE_NOT_PASS</b>, the reason why the message template is rejected is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>The document cannot verify the authenticity of the information. Please upload it again.</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A974B78-02BF-4C79-ADF3-90CFBA1B55B1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The code of the message template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMS_16703****</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>The content of the message template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You are applying for mobile registration. The verification code is: ${code}, valid for 5 minutes!</para>
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
        /// <para>The approval status of the message template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The message template is pending approval.</description></item>
        /// <item><description><b>1</b>: The message template is approved.</description></item>
        /// <item><description><b>AUDIT_STATE_NOT_PASS</b>: The message template is rejected. You can view the reason in the Reason response parameter.</description></item>
        /// <item><description><b>10</b>: The approval is canceled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateStatus")]
        [Validation(Required=false)]
        public int? TemplateStatus { get; set; }

        /// <summary>
        /// <para>The type of the message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: verification code</description></item>
        /// <item><description><b>1</b>: notification message</description></item>
        /// <item><description><b>2</b>: promotional message</description></item>
        /// <item><description><b>3</b>: message sent to countries or regions outside the Chinese mainland</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public int? TemplateType { get; set; }

    }

}
