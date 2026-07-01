// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class AddSmsTemplateRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The description for the SMS template application. The length must not exceed 100 characters.</para>
        /// <para>This is reference information for template review. Providing a complete application description helps reviewers understand your business scenario and improves review efficiency. Guidelines:</para>
        /// <list type="bullet">
        /// <item><description>You can provide the usage scenario of business that has been launched.</description></item>
        /// <item><description>You can provide SMS examples for real scenarios to demonstrate your business scenario.</description></item>
        /// <item><description>You can provide the variable parameter content, describing the business usage scenario in detail and the reason for choosing this variable attribute.</description></item>
        /// <item><description>You can provide website links of actual business, registered domain addresses, app market download links, and so on.</description></item>
        /// <item><description>For login scenarios, you can provide a test account and password.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>申请验证码短信</para>
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
        /// <para>The template content. The length must not exceed 500 characters.</para>
        /// <para>The template content and variable content must comply with the <a href="https://help.aliyun.com/document_detail/463161.html">SMS template specifications</a>; otherwise, the template review will fail. You can also view common template examples on the <a href="https://dysms.console.aliyun.com/domestic/text/template/add">Apply for template</a> page. Using example templates can improve review efficiency and success rate. For variable specifications, see <a href="https://help.aliyun.com/document_detail/2806243.html">TemplateContent parameter variable specifications</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>您正在申请手机注册，验证码为：${code}，5分钟内有效！</para>
        /// </summary>
        [NameInMap("TemplateContent")]
        [Validation(Required=false)]
        public string TemplateContent { get; set; }

        /// <summary>
        /// <para>The template name. The length must not exceed 30 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>验证码</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The SMS type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: verification code.</description></item>
        /// <item><description><b>1</b>: notification SMS.</description></item>
        /// <item><description><b>2</b>: promotional SMS.</description></item>
        /// <item><description><b>3</b>: international/Hong Kong, Macao, and Taiwan messages.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Only enterprise-verified users can apply for promotional SMS and international/Hong Kong, Macao, and Taiwan messages. For details about the differences between individual and enterprise user privileges, see <a href="https://help.aliyun.com/document_detail/55324.html">Usage notes</a>.</para>
        /// </remarks>
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
