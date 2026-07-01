// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class UpdateSmsSignRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the app\&quot;s ICP filing entity.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required if <c>SignSource</c> is set to 2.</para>
        /// </description></item>
        /// <item><description><para>You can obtain the filing entity ID by calling the <a href="~~CreateSmsAppIcpRecord~~">Create ICP Filing Entity</a> operation.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100001***1234</para>
        /// </summary>
        [NameInMap("AppIcpRecordId")]
        [Validation(Required=false)]
        public long? AppIcpRecordId { get; set; }

        /// <summary>
        /// <para>The app store link. This parameter is required if the signature source (<c>SignSource</c>) is an app (the value is 2). The link must start with <c>http://</c> or <c>https://</c>, and the app must be published in the app store.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com/">http://www.aliyun.com/</a></para>
        /// </summary>
        [NameInMap("ApplySceneContent")]
        [Validation(Required=false)]
        public string ApplySceneContent { get; set; }

        /// <summary>
        /// <para>The authorization letter ID. This parameter is required if the signature is for third-party use (<c>ThirdParty</c> is set to <c>true</c>). The Unified Social Credit Code on the authorization letter must match the code in the selected qualification\&quot;s information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000********1234</para>
        /// </summary>
        [NameInMap("AuthorizationLetterId")]
        [Validation(Required=false)]
        public long? AuthorizationLetterId { get; set; }

        /// <summary>
        /// <para>Additional supporting materials. You can upload supporting business documents or business screenshots to help with the review. For details on what to upload, see <a href="~~108076#section-xup-k46-yi4~~">Signature application materials</a>.</para>
        /// </summary>
        [NameInMap("MoreData")]
        [Validation(Required=false)]
        public List<string> MoreData { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the approved qualification.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You must <a href="https://help.aliyun.com/zh/sms/user-guide/new-qualification?spm=a2c4g.11186623.0.0.718d187bbkpMRK">apply for a qualification</a> before applying for an SMS signature.</para>
        /// </description></item>
        /// <item><description><para>You can find the qualification ID on the <a href="https://dysms.console.aliyun.com/domestic/text/qualification">qualification management</a> page.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8563**</para>
        /// </summary>
        [NameInMap("QualificationId")]
        [Validation(Required=false)]
        public long? QualificationId { get; set; }

        /// <summary>
        /// <para>A description of the SMS signature\&quot;s use case. This information is used during the review and must be 200 characters or less.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Describe the use case for your live service. Include relevant links, such as a website link or an app store link.</para>
        /// </description></item>
        /// <item><description><para>Provide a complete example of an SMS message that reflects your use case.</para>
        /// </description></item>
        /// <item><description><para>Provide the values for any variables. Describe the use case in detail and explain why the variables are necessary.</para>
        /// </description></item>
        /// <item><description><para>If the signature involves a government agency or public institution, provide its official landline number.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <para>Providing complete and accurate information accelerates the review process. If you do not provide the required information, your signature application may be rejected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>登录场景申请验证码</para>
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
        /// <para>The name of the rejected SMS signature. You can find rejected SMS signatures on the <a href="https://dysms.console.aliyun.com/domestic/text/sign">Domestic Messages &gt; Signature Management</a> page in the console, or by calling the <a href="~~QuerySmsSignList~~">QuerySmsSignList</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云验证码</para>
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        /// <summary>
        /// <para>The signature source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: The full or abbreviated name of an enterprise or public institution. <b>(Recommended)</b></para>
        /// </description></item>
        /// <item><description><para><b>5</b>: The full or abbreviated trademark name.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: The full or abbreviated name of an app. <b>(Not recommended)</b></para>
        /// </description></item>
        /// </list>
        /// <para>For more information, see <a href="~~108076#section-fow-bfu-wo9~~">signature source</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SignSource")]
        [Validation(Required=false)]
        public int? SignSource { get; set; }

        /// <summary>
        /// <para>The signature type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: verification code.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: general (default).</para>
        /// </description></item>
        /// </list>
        /// <para>We recommend that you use the default value, <b>general</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SignType")]
        [Validation(Required=false)]
        public int? SignType { get; set; }

        /// <summary>
        /// <para>The signature purpose. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false: for own use (default). The signature is for a business, website, or product owned by your account\&quot;s verified entity.</para>
        /// </description></item>
        /// <item><description><para>true: for third-party use. The signature is for a business, website, or product not owned by your account\&quot;s verified entity.</para>
        /// <remarks>
        /// <para>Notice: Ensure the selected qualification ID matches the signature purpose (for own use or for third-party use).</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ThirdParty")]
        [Validation(Required=false)]
        public bool? ThirdParty { get; set; }

        /// <summary>
        /// <para>The trademark entity ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required if <c>SignSource</c> is set to 5.</para>
        /// </description></item>
        /// <item><description><para>You can obtain the trademark entity ID by calling the <a href="~~CreateSmsTrademark~~">Create Trademark Entity</a> operation.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000009081***</para>
        /// </summary>
        [NameInMap("TrademarkId")]
        [Validation(Required=false)]
        public long? TrademarkId { get; set; }

    }

}
