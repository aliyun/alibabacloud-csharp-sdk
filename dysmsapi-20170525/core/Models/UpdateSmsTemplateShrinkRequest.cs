// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class UpdateSmsTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Application scenarios, instructions as follows:</para>
        /// <list type="bullet">
        /// <item><description>For registered websites, please enter the MIIT-registered domain with HTTP or HTTPS.</description></item>
        /// <item><description>For launched apps, provide the app store display link with HTTP or HTTPS, ensuring the app is online.</description></item>
        /// <item><description>For public accounts or mini-programs, enter the full name of the public account or mini-program, ensuring they are online.</description></item>
        /// <item><description>For e-commerce platform stores, applicable only to enterprise users, enter the display link of the e-commerce store with HTTP or HTTPS.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com/">http://www.aliyun.com/</a></para>
        /// </summary>
        [NameInMap("ApplySceneContent")]
        [Validation(Required=false)]
        public string ApplySceneContent { get; set; }

        /// <summary>
        /// <para>International/Hong Kong, Macao, and Taiwan template type. When the <b>TemplateType</b> parameter is <b>3</b>, this parameter is required for international/Hong Kong, Macao, and Taiwan templates, with values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Verification code.</description></item>
        /// <item><description><b>1</b>: SMS notification.</description></item>
        /// <item><description><b>2</b>: Promotional SMS.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IntlType")]
        [Validation(Required=false)]
        public int? IntlType { get; set; }

        /// <summary>
        /// <para>Additional information, such as uploading business proof documents or screenshots, to help reviewers understand your business details. Optional and can be left unset.</para>
        /// </summary>
        [NameInMap("MoreData")]
        [Validation(Required=false)]
        public string MoreDataShrink { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>SMS signature associated with the template during the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云</para>
        /// </summary>
        [NameInMap("RelatedSignName")]
        [Validation(Required=false)]
        public string RelatedSignName { get; set; }

        /// <summary>
        /// <para>Explanation for the SMS template application, which serves as a reference for template review.</para>
        /// 
        /// <b>Example:</b>
        /// <para>登录场景使用验证码</para>
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
        /// <para>Template Code of an unapproved template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMS_152550****</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>Template content, up to 500 characters in length.</para>
        /// <para>Both the template content and variable content must comply with SMS regulations; otherwise, the template will fail the review. You can also view common template examples on the template application page. Using sample templates can enhance review efficiency and success rates. Variable specifications can be found in <a href="https://help.aliyun.com/zh/sms/templaterule-template-variable-parameter-filling-example?spm">TemplateContent Parameter Variable Specifications</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>您正在申请手机注册，验证码为：${code}，5分钟内有效！</para>
        /// </summary>
        [NameInMap("TemplateContent")]
        [Validation(Required=false)]
        public string TemplateContent { get; set; }

        /// <summary>
        /// <para>Template name, up to 30 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>验证码</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>Template variable rules.</para>
        /// <para>For guidance on filling variable rules, refer to the <a href="https://help.aliyun.com/zh/sms/templaterule-template-variable-parameter-filling-example?spm">Sample Documentation</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;code&quot;:&quot;characterWithNumber&quot;}</para>
        /// </summary>
        [NameInMap("TemplateRule")]
        [Validation(Required=false)]
        public string TemplateRule { get; set; }

        /// <summary>
        /// <para>SMS type. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Verification code.</description></item>
        /// <item><description><b>1</b>: SMS notification.</description></item>
        /// <item><description><b>2</b>: Promotional SMS.</description></item>
        /// <item><description><b>3</b>: International/Hong Kong, Macao, and Taiwan messages.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Only enterprise-certified users can apply for promotional SMS and international/Hong Kong, Macao, and Taiwan messages. Details on differences between personal and enterprise user rights are available in <a href="https://help.aliyun.com/zh/sms/user-guide/usage-notes?spm=a2c4g.11186623.0.0.67447f576NJnE8">Usage Guidelines</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public int? TemplateType { get; set; }

        [NameInMap("TrafficDriving")]
        [Validation(Required=false)]
        public string TrafficDriving { get; set; }

    }

}
