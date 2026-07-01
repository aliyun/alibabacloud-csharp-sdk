// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class CreateSmsTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>OK: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>For other error codes, see the <b>Error codes</b> list in this topic or <a href="https://help.aliyun.com/document_detail/101346.html">API Error Codes</a>.</para>
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
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ticket ID.</para>
        /// <para>Reviewers use this ID to check the review status. You must provide this ID when you request an expedited review.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2005020****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique ID for each request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F655A8D5-B967-440B-8683-DAD6FF8DE991</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The code of the message template.</para>
        /// <para>After you submit a template application, you can use the template code to call the <a href="https://help.aliyun.com/document_detail/2807433.html">GetSmsTemplate</a> operation and query the review details of the template. You can also <a href="https://help.aliyun.com/document_detail/101508.html">configure delivery receipts</a> to receive the review status of the template in the <a href="https://help.aliyun.com/document_detail/120999.html">TemplateSmsReport</a> message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMS_10000****</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>The name of the message template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>验证码模板</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
