// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class UpdateSmsTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The business scenario.</para>
        /// <list type="bullet">
        /// <item><description><para>If the associated SMS signature\&quot;s business scenario is &quot;Live App&quot;, the <c>ApplySceneContent</c> parameter must be an app URL starting with <c>http://</c> or <c>https://</c>.</para>
        /// </description></item>
        /// <item><description><para>The <c>ApplySceneContent</c> parameter is required if the associated SMS signature\&quot;s business scenario is &quot;Registered Trademark&quot; or &quot;Name of Enterprise or Public Institution&quot;.</para>
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
        /// <para>The type of the international/regional template. This parameter is required when the <b>TemplateType</b> parameter is set to <b>3</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: SMS notification.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: promotional SMS.</para>
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
        /// <para>Additional materials, such as supporting documents or business screenshots, to help reviewers understand your business. If <c>TemplateType</c> is set to <c>2</c> (promotional SMS), you must upload proof of user authorization. For more information, see <a href="https://help.aliyun.com/document_detail/312341.html">Upload specifications for user authorization materials</a>.</para>
        /// </summary>
        [NameInMap("MoreData")]
        [Validation(Required=false)]
        public string MoreDataShrink { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The SMS signature associated with the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云</para>
        /// </summary>
        [NameInMap("RelatedSignName")]
        [Validation(Required=false)]
        public string RelatedSignName { get; set; }

        /// <summary>
        /// <para>Describe your business scenario, including a URL if applicable. You must also provide a complete SMS message example with populated variables. Providing this information as required is critical for template approval.</para>
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
        /// <para>The code of the rejected SMS template. You can find the template code on the <a href="https://dysms.console.aliyun.com/domestic/text/template">Messages in Chinese Mainland &gt; Template Management</a> tab in the console or by calling the <a href="~~QuerySmsTemplateList~~">QuerySmsTemplateList</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMS_152550****</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>The new template content, up to 500 characters long.</para>
        /// <para>The template content and its variables must comply with <a href="https://help.aliyun.com/document_detail/463161.html">SMS template specifications</a> to be approved. To increase the approval rate and efficiency, refer to the common examples on the <a href="https://dysms.console.aliyun.com/domestic/text/template/add">Apply for Template</a> page. For more information about variable specifications, see <a href="https://help.aliyun.com/document_detail/2806243.html">TemplateContent parameter variable specifications</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>您正在申请手机注册，验证码为：${code}，5分钟内有效！</para>
        /// </summary>
        [NameInMap("TemplateContent")]
        [Validation(Required=false)]
        public string TemplateContent { get; set; }

        /// <summary>
        /// <para>The name of the SMS template, up to 30 characters long. You can find the names of rejected templates on the <a href="https://dysms.console.aliyun.com/domestic/text/template">Messages in Chinese Mainland &gt; Template Management</a> tab in the console or by calling the <a href="~~QuerySmsTemplateList~~">QuerySmsTemplateList</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>验证码模板</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The rules for the variables in the template. For details on how to define these rules, see the <a href="https://help.aliyun.com/document_detail/2806243.html">example document</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;code&quot;:&quot;characterWithNumber&quot;}</para>
        /// </summary>
        [NameInMap("TemplateRule")]
        [Validation(Required=false)]
        public string TemplateRule { get; set; }

        /// <summary>
        /// <para>The SMS type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: verification code.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: SMS notification.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: promotional SMS.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: international/regional message.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Only enterprise-verified users can apply for promotional SMS and international/regional messages. For more information about the differences between personal and enterprise accounts, see <a href="https://help.aliyun.com/zh/sms/user-guide/usage-notes?spm=a2c4g.11186623.0.0.67447f576NJnE8">Usage notes</a>.</para>
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
        /// <para>To manage SMS content security, messages that contain traffic-driving information such as phone numbers and URLs may be blocked by carriers, which can cause delivery failures. We recommend that you avoid including such information in your SMS templates to prevent delivery failures.</para>
        /// <para>A JSON string that contains a list of traffic-driving information.</para>
        /// <remarks>
        /// <para>Notice: The value must be in the JSON format. Convert the value to a string before you pass it in.</para>
        /// </remarks>
        /// <h3>1. Fields</h3>
        /// <para>{
        /// &quot;trafficDrivingType&quot;:&quot;Traffic-driving type&quot;,
        /// &quot;trafficDrivingContent&quot;:&quot;Traffic-driving content&quot;,
        /// &quot;variableName&quot;:&quot;variable name&quot;,
        /// &quot;companyName&quot;:&quot;Name of the enterprise or public institution&quot;,
        /// &quot;organizationCode&quot;:&quot;Unified Social Credit Code&quot;,
        /// &quot;icpNo&quot;:&quot;ICP filing/permit number&quot;,
        /// &quot;icpPicOssKey&quot;:&quot;OSS key of the ICP filing screenshot&quot;,
        /// &quot;companyDifferentFromSignQuaReason&quot;:&quot;The reason why the name of the enterprise or public institution is different from that in the SMS signature qualification&quot;
        /// }</para>
        /// <h3>2. Notes</h3>
        /// <list type="bullet">
        /// <item><description><para>If the content is not a variable, do not pass the <c>variableName</c> field.</para>
        /// </description></item>
        /// <item><description><para>If the name of the enterprise or public institution is different from that in the SMS signature qualification, provide the <c>companyDifferentFromSignQuaReason</c> field.</para>
        /// </description></item>
        /// <item><description><para>If <c>trafficDrivingType</c> is set to <c>DOMAIN</c>, you must provide all the fields.</para>
        /// </description></item>
        /// <item><description><para>For <c>trafficDrivingType</c> values other than <c>DOMAIN</c>, the <c>trafficDrivingType</c>, <c>trafficDrivingContent</c>, <c>companyName</c>, and <c>organizationCode</c> fields are required. The <c>variableName</c> and <c>companyDifferentFromSignQuaReason</c> fields are optional.</para>
        /// </description></item>
        /// </list>
        /// <h3>3. TrafficDrivingType enumeration</h3>
        /// <remarks>
        /// <para>Warning: </para>
        /// </remarks>
        /// <para>Due to regulatory requirements, mobile numbers are not supported.</para>
        /// <list type="bullet">
        /// <item><description><para><c>DOMAIN</c>: A domain name.</para>
        /// </description></item>
        /// <item><description><para><c>FIXED_PHONE</c>: A fixed-line phone number.</para>
        /// </description></item>
        /// <item><description><para><c>400_PHONE</c>: A phone number that starts with 400.</para>
        /// </description></item>
        /// <item><description><para><c>800_PHONE</c>: A phone number that starts with 800.</para>
        /// </description></item>
        /// <item><description><para><c>95_PHONE</c>: A phone number that starts with 95.</para>
        /// </description></item>
        /// <item><description><para><c>96_PHONE</c>: A phone number that starts with 96.</para>
        /// </description></item>
        /// <item><description><para><c>1_PHONE</c>: A 3-digit to 8-digit phone number that starts with 1.</para>
        /// </description></item>
        /// <item><description><para><c>OTHER_PHONE</c>: Another type of phone number.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;trafficDrivingType&quot;:&quot;DOMAIN&quot;,&quot;trafficDrivingContent&quot;:&quot;aliyun.com&quot;,&quot;companyName&quot;:&quot;阿里云计算有限公司&quot;,&quot;organizationCode&quot;:&quot;91330<b><b>73959654P&quot;,&quot;icpNo&quot;:&quot;浙B2-20</b></b>01-4&quot;,&quot;icpPicOssKey&quot;:&quot;db7784d8-cb0c-498f-<b><b>-295f1ad6d665_mf29l7nf.png&quot;,&quot;companyDifferentFromSignQuaReason&quot;:&quot;这是一段说明文字&quot;},{&quot;trafficDrivingType&quot;:&quot;1_PHONE&quot;,&quot;trafficDrivingContent&quot;:&quot;1</b>86&quot;,&quot;variableName&quot;:&quot;my1Phone&quot;,&quot;companyName&quot;:&quot;阿里云计算有限公司&quot;,&quot;organizationCode&quot;:&quot;91330**</b>73959654P&quot;,&quot;companyDifferentFromSignQuaReason&quot;:&quot;这是一段说明文字&quot;}]</para>
        /// </summary>
        [NameInMap("TrafficDriving")]
        [Validation(Required=false)]
        public string TrafficDriving { get; set; }

    }

}
