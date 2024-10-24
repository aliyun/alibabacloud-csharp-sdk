// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class CreateSmsTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>If there is an applicable scenario, you can fill it in.</para>
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
        /// <item><description><b>2</b>: Promotional message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IntlType")]
        [Validation(Required=false)]
        public int? IntlType { get; set; }

        /// <summary>
        /// <para>Additional materials you can upload, such as business proof documents or screenshots, to help reviewers understand your business details.</para>
        /// <para>This parameter is optional; please fill it in according to actual needs.</para>
        /// </summary>
        [NameInMap("MoreData")]
        [Validation(Required=false)]
        public string MoreDataShrink { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The signature name that the template needs to be associated with. The associated SMS signature must have passed the review.</para>
        /// <para>This parameter is mandatory when the TemplateType parameter is <b>0</b>, <b>1</b>, or <b>2</b>.</para>
        /// <para><notice>Associating a signature can expedite the review process. Note that this associated signature is unrelated to the signature selected when sending SMS messages.</notice></para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun</para>
        /// </summary>
        [NameInMap("RelatedSignName")]
        [Validation(Required=false)]
        public string RelatedSignName { get; set; }

        /// <summary>
        /// <para>Please describe the business scenario where you use SMS or provide an online link to the scenario, along with a complete example of the SMS (with variable contents filled), as complete information helps increase the template approval rate. Failure to follow guidelines or leaving this field blank may affect the approval of your template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Request verification code SMS.</para>
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
        /// <para>Template content, up to 500 characters in length.</para>
        /// <para>Both the template content and variable content must comply with SMS specifications; otherwise, the template will fail the review. You can also view common template examples on the template application page. Using sample templates can enhance review efficiency and success rates. For variable specifications, see <a href="https://help.aliyun.com/zh/sms/templaterule-template-variable-parameter-filling-example">TemplateContent Variable Parameter Filling Specifications</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You are applying for mobile registration. The verification code is: ${code}. It is valid for 5 minutes!</para>
        /// </summary>
        [NameInMap("TemplateContent")]
        [Validation(Required=false)]
        public string TemplateContent { get; set; }

        /// <summary>
        /// <para>Template name, up to 30 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyunCode</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>Template variable rules.</para>
        /// <para>For filling in variable rules, refer to the <a href="https://help.aliyun.com/zh/sms/templaterule-template-variable-parameter-filling-example">Sample Documentation</a>.</para>
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
        /// <item><description><b>2</b>: Promotional message.</description></item>
        /// <item><description><b>3</b>: International/Hong Kong, Macao, and Taiwan messages.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Only enterprise-verified users can apply for promotional messages and international/Hong Kong, Macao, and Taiwan messages. For details on the differences between personal and enterprise user rights, please refer to <a href="https://help.aliyun.com/zh/sms/user-guide/usage-notes?spm=a2c4g.11186623.0.0.67447f576NJnE8">Usage Instructions</a>.</para>
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
