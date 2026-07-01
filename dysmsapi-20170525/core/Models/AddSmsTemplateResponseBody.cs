// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class AddSmsTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The request status code.</para>
        /// <list type="bullet">
        /// <item><description>The value OK indicates that the request was successful.</description></item>
        /// <item><description>For other error codes, see <a href="https://help.aliyun.com/document_detail/101346.html">API error codes</a>.</description></item>
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
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
        /// <para>The SMS template code.</para>
        /// <para>After submitting the template application, you can use the SMS template code to query the template review details through the <a href="https://help.aliyun.com/document_detail/419289.html">QuerySmsTemplate</a> operation. You can also <a href="https://help.aliyun.com/document_detail/101508.html">configure receipt messages</a> and obtain the template review status messages through <a href="https://help.aliyun.com/document_detail/120999.html">TemplateSmsReport</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMS_46817****</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

    }

}
