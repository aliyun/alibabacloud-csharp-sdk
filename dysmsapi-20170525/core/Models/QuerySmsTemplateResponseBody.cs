// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySmsTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the request.</para>
        /// <list type="bullet">
        /// <item><description><para>OK indicates that the request was successful.</para>
        /// </description></item>
        /// <item><description><para>For a list of other error codes, see <a href="https://help.aliyun.com/document_detail/101346.html">Error codes</a>.</para>
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
        /// <para>The time when the template was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-03 10:02:34</para>
        /// </summary>
        [NameInMap("CreateDate")]
        [Validation(Required=false)]
        public string CreateDate { get; set; }

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
        /// <para>The review notes for the template.</para>
        /// <list type="bullet">
        /// <item><description><para>If the review status is <b>Approved</b> or <b>Reviewing</b>, the message &quot;No review remarks&quot; is returned.</para>
        /// </description></item>
        /// <item><description><para>If the review status is <b>Rejected</b>, the reason for the rejection is returned.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>无审批备注</para>
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
        /// <para>The template code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMS_1525****</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>The template content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>亲爱的会员！阿里云短信服务祝您新年快乐！</para>
        /// </summary>
        [NameInMap("TemplateContent")]
        [Validation(Required=false)]
        public string TemplateContent { get; set; }

        /// <summary>
        /// <para>The template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>通知短信</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The review status of the template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Reviewing.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Approved.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Rejected. The reason for the rejection is returned in the response. For more information, see <a href="https://help.aliyun.com/document_detail/65990.html">Suggestions for handling a failed review</a>. You can then call the <a href="https://help.aliyun.com/document_detail/419287.html">ModifySmsTemplate</a> API or modify the template on the <a href="https://dysms.console.aliyun.com/domestic/text/template">Template Management</a> page.</para>
        /// </description></item>
        /// <item><description><para><b>10</b>: Canceled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TemplateStatus")]
        [Validation(Required=false)]
        public int? TemplateStatus { get; set; }

        /// <summary>
        /// <para>The message type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Verification code.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Message notification.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Promotional message.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: International message.</para>
        /// </description></item>
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
