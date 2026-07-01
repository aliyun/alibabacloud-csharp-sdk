// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class CreateSmsTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The business scenario.</para>
        /// <list type="bullet">
        /// <item><description><para>If the associated signature\&quot;s use case is &quot;Live App&quot;, <c>ApplySceneContent</c> must be an app URL that starts with <c>http://</c> or <c>https://</c>.</para>
        /// </description></item>
        /// <item><description><para>This parameter is required if the associated signature\&quot;s use case is &quot;Registered Trademark Name&quot; or &quot;organization name&quot;.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com/">http://www.aliyun.com/</a></para>
        /// </summary>
        [NameInMap("ApplySceneContent")]
        [Validation(Required=false)]
        public string ApplySceneContent { get; set; }

        /// <summary>
        /// <para>The type of the template for international/Hong Kong, Macao, and Taiwan messages. This parameter is required when <b>TemplateType</b> is set to <b>3</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: notification message.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: promotional message.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: verification code.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IntlType")]
        [Validation(Required=false)]
        public int? IntlType { get; set; }

        /// <summary>
        /// <para>Additional information. You can upload supporting documents or business screenshots to help reviewers better understand your business scenario. If you are applying for a promotional message template (where <c>TemplateType</c> is <c>2</c>), you must upload user authorization materials. For more information, see <a href="https://help.aliyun.com/document_detail/312341.html">Specifications for Uploading User Authorization Materials</a>.</para>
        /// </summary>
        [NameInMap("MoreData")]
        [Validation(Required=false)]
        public List<string> MoreData { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The name of the signature to associate with the template. The signature must be an approved signature.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required if <b>TemplateType</b> is set to <b>0</b>, <b>1</b>, or <b>2</b>.</para>
        /// </description></item>
        /// <item><description><para>Associating a signature can expedite the review process. The signature associated here is unrelated to the one you select when sending SMS messages.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>验证码签名</para>
        /// </summary>
        [NameInMap("RelatedSignName")]
        [Validation(Required=false)]
        public string RelatedSignName { get; set; }

        /// <summary>
        /// <para>Describe the business scenario for the SMS messages, or provide a URL for online scenarios. You must also provide a complete SMS example with actual values for any variables. Complete information increases the chance of template approval. Templates that do not provide this information as specified may be rejected.</para>
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
        /// <para>The template content. The content must be 500 characters or less.</para>
        /// <para>The template content and variables must comply with the <a href="https://help.aliyun.com/document_detail/463161.html">SMS Template Specifications</a>. Templates that do not comply may be rejected. You can find common template examples on the <a href="https://dysms.console.aliyun.com/domestic/text/template/add">Apply for Template</a> page. Using these examples can speed up the review process and increase the approval rate. For variable specifications, see <a href="https://help.aliyun.com/document_detail/2806243.html">Variable Specifications for the TemplateContent Parameter</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>您正在申请手机注册，验证码为：${code}，5分钟内有效！</para>
        /// </summary>
        [NameInMap("TemplateContent")]
        [Validation(Required=false)]
        public string TemplateContent { get; set; }

        /// <summary>
        /// <para>The template name. The name must be 30 characters or less.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>验证码</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The rules for variables in the template. For instructions on how to define these rules, see <a href="https://help.aliyun.com/document_detail/2806243.html">Sample Document</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required if the message template contains variables.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;code&quot;:&quot;characterWithNumber2&quot;}</para>
        /// </summary>
        [NameInMap("TemplateRule")]
        [Validation(Required=false)]
        public string TemplateRule { get; set; }

        /// <summary>
        /// <para>The SMS type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: verification code.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: notification message.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: promotional message.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: international/Hong Kong, Macao, and Taiwan messages.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Only enterprise-verified users can apply for promotional messages or international/Hong Kong, Macao, and Taiwan messages. For more information about the differences in privileges between individual and enterprise users, see <a href="https://help.aliyun.com/zh/sms/user-guide/usage-notes?spm=a2c4g.11186623.0.0.67447f576NJnE8">Usage Notes</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public int? TemplateType { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>Warning: </para>
        /// </remarks>
        /// <para>To control the security of SMS content, messages that contain traffic-driving information, such as phone numbers and links, may be blocked by carriers, which can lead to delivery failures. To reduce this risk, we recommend that you avoid including such information in message templates.</para>
        /// <para>A JSON string that contains a list of traffic-driving information.</para>
        /// <remarks>
        /// <para>Notice: The value must be a JSON array serialized into a string.</para>
        /// </remarks>
        /// <h3>1. Fields</h3>
        /// <para>{
        /// &quot;trafficDrivingType&quot;:&quot;traffic driving type&quot;,
        /// &quot;trafficDrivingContent&quot;:&quot;traffic driving content&quot;,
        /// &quot;variableName&quot;:&quot;variable name&quot;,
        /// &quot;companyName&quot;:&quot;organization name&quot;,
        /// &quot;organizationCode&quot;:&quot;unified social credit code&quot;,
        /// &quot;icpNo&quot;:&quot;ICP filing or license number&quot;,
        /// &quot;icpPicOssKey&quot;:&quot;OSS key of the ICP filing screenshot&quot;,
        /// &quot;companyDifferentFromSignQuaReason&quot;:&quot;Reason for the discrepancy between the organization name and the signature qualification&quot;
        /// }</para>
        /// <h3>2. Notes</h3>
        /// <list type="bullet">
        /// <item><description><para>If the content is not a variable, do not pass the <c>variableName</c> parameter.</para>
        /// </description></item>
        /// <item><description><para>If the organization name is different from the one in the signature qualification, pass the <c>companyDifferentFromSignQuaReason</c> parameter.</para>
        /// </description></item>
        /// <item><description><para>If <c>trafficDrivingType</c> is set to <c>DOMAIN</c>, all parameters in this object are required.</para>
        /// </description></item>
        /// <item><description><para>If <c>trafficDrivingType</c> is set to another value, pass the <c>trafficDrivingType</c>, <c>trafficDrivingContent</c>, <c>variableName</c> (if applicable), <c>companyName</c>, <c>organizationCode</c>, and <c>companyDifferentFromSignQuaReason</c> (if applicable) parameters.</para>
        /// </description></item>
        /// </list>
        /// <h3>3. trafficDrivingType enum values</h3>
        /// <remarks>
        /// <para>Warning: </para>
        /// </remarks>
        /// <para>Due to regulatory requirements, mobile phone numbers are not supported.</para>
        /// <list type="bullet">
        /// <item><description><para>DOMAIN: A domain link.</para>
        /// </description></item>
        /// <item><description><para>FIXED_PHONE: Fixed-line phone.</para>
        /// </description></item>
        /// <item><description><para>400_PHONE: Phone number prefixed with 400.</para>
        /// </description></item>
        /// <item><description><para>800_PHONE: Phone number prefixed with 800.</para>
        /// </description></item>
        /// <item><description><para>95_PHONE: Phone number prefixed with 95.</para>
        /// </description></item>
        /// <item><description><para>96_PHONE: Phone number prefixed with 96.</para>
        /// </description></item>
        /// <item><description><para>1_PHONE: A 3- to 8-digit phone number that starts with 1.</para>
        /// </description></item>
        /// <item><description><para>OTHER_PHONE: Other phone number.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;trafficDrivingType&quot;:&quot;DOMAIN&quot;,&quot;trafficDrivingContent&quot;:&quot;aliyun.com&quot;,&quot;companyName&quot;:&quot;阿里云计算有限公司&quot;,&quot;organizationCode&quot;:&quot;91330<b><b>73959654P&quot;,&quot;icpNo&quot;:&quot;浙B2-20</b></b>01-4&quot;,&quot;icpPicOssKey&quot;:&quot;db7784d8-cb0c-498f-<b><b>-295f1ad6d665_mf29l7nf.png&quot;, &quot;companyDifferentFromSignQuaReason&quot;:&quot;这是一段说明文字&quot;},{&quot;trafficDrivingType&quot;:&quot;1_PHONE&quot;,&quot;trafficDrivingContent&quot;:&quot;1</b>86&quot;,&quot;variableName&quot;:&quot;my1Phone&quot;,&quot;companyName&quot;:&quot;阿里云计算有限公司&quot;,&quot;organizationCode&quot;:&quot;91330**</b>73959654P&quot;,&quot;companyDifferentFromSignQuaReason&quot;:&quot;这是一段说明文字&quot;}]</para>
        /// </summary>
        [NameInMap("TrafficDriving")]
        [Validation(Required=false)]
        public string TrafficDriving { get; set; }

    }

}
