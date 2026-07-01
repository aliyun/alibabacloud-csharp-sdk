// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class ModifySmsTemplateRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The description of the SMS template application. The description cannot exceed 100 characters in length.</para>
        /// <para>This information helps reviewers understand your business scenarios and improves review efficiency. Guidelines:</para>
        /// <list type="bullet">
        /// <item><description>Provide the use case of your live business.</description></item>
        /// <item><description>Provide SMS examples for real scenarios to reflect your business scenarios.</description></item>
        /// <item><description>Provide variable values and describe in detail the business use case and the reason for choosing the variable attributes.</description></item>
        /// <item><description>Provide the website URL, registered domain name, or application marketplace download link of the actual business.</description></item>
        /// <item><description>For logon scenarios, provide the test account and password.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>手机注册登录</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The code of the SMS template that failed the review.</para>
        /// <list type="bullet">
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/419288.html">QuerySmsTemplateList</a> operation to obtain the code of the SMS template that failed the review.</description></item>
        /// <item><description>View the code of the SMS template that failed the review on the <a href="https://dysms.console.aliyun.com/domestic/text/template">Templates</a> page.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMS_15255****</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>The template content. The content cannot exceed 500 characters in length.</para>
        /// <para>The template content and variable content must comply with the <a href="https://help.aliyun.com/document_detail/463161.html">SMS template specifications</a>. Otherwise, the template fails the review. You can view common template examples on the <a href="https://dysms.console.aliyun.com/domestic/text/template/add">Apply for Template</a> page. Using sample templates can improve review efficiency and success rate. For variable specifications, see <a href="https://help.aliyun.com/document_detail/2806243.html">TemplateContent variable specifications</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>您正在申请手机注册，验证码为：${code}，5分钟内有效！</para>
        /// </summary>
        [NameInMap("TemplateContent")]
        [Validation(Required=false)]
        public string TemplateContent { get; set; }

        /// <summary>
        /// <para>The template name. The name must be 1 to 30 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>验证码模板</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The SMS type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: verification code.</description></item>
        /// <item><description><b>1</b>: SMS notification.</description></item>
        /// <item><description><b>2</b>: promotional message.</description></item>
        /// <item><description><b>3</b>: international or Hong Kong, Macao, and Taiwan message.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public int? TemplateType { get; set; }

    }

}
