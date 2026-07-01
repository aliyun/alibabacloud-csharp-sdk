// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class CreateSmsSignShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The APP-ICP filing entity ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required when SignSource is set to 2.</description></item>
        /// <item><description>You can obtain the filing entity ID by calling the <a href="~~CreateSmsAppIcpRecord~~">CreateSmsAppIcpRecord</a> operation.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10000****029</para>
        /// </summary>
        [NameInMap("AppIcpRecordId")]
        [Validation(Required=false)]
        public long? AppIcpRecordId { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>Notice:  The signature source of launched apps is no longer supported.
        /// The app store link. If the signature source is a launched app, that is, SignSource is set to 2, specify a link that starts with http:// or https:// and make sure the app is already launched.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com/">http://www.aliyun.com/</a></para>
        /// </summary>
        [NameInMap("ApplySceneContent")]
        [Validation(Required=false)]
        public string ApplySceneContent { get; set; }

        /// <summary>
        /// <para>The ID of the power of attorney. When the signature is for third-party use, this parameter is required. Otherwise, the signature review will not pass. The unified social credit code in the power of attorney must match the unified social credit code in the qualification information bound to the signature. Otherwise, the signature creation fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000********1234</para>
        /// </summary>
        [NameInMap("AuthorizationLetterId")]
        [Validation(Required=false)]
        public long? AuthorizationLetterId { get; set; }

        /// <summary>
        /// <para>The supplementary materials. Upload business proof files or business screenshots to help reviewers understand your business details. See <a href="~~108076#section-xup-k46-yi4~~">Signature application materials</a> and upload the relevant materials.</para>
        /// </summary>
        [NameInMap("MoreData")]
        [Validation(Required=false)]
        public string MoreDataShrink { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the approved qualification.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Before applying for an SMS signature, <a href="https://help.aliyun.com/document_detail/2539801.html">apply for a qualification</a>.</description></item>
        /// <item><description>You can view the qualification ID on the <a href="https://dysms.console.aliyun.com/domestic/text/qualification">Qualification Management</a> page.</description></item>
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
        /// <para>The description of the SMS signature scenario. This is one of the reference materials for signature review. The description can be up to 200 characters in length.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can describe the scenarios of your online service and provide links to the actual business website or marketplace download page.</description></item>
        /// <item><description>You can provide a complete SMS example that reflects your business scenario.</description></item>
        /// <item><description>You can provide the pass parameter content of variables and describe in detail the business scenario and the reason for selecting the variable property.</description></item>
        /// <item><description>If the signature involves a government or public institution, specify the landline phone number of the institution.</description></item>
        /// </list>
        /// </remarks>
        /// <para>A well-documented application description improves the review efficiency for signatures and templates. Failure to follow the specifications or leaving this field empty may affect the approval of your signature.</para>
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
        /// <para>The signature name. The signature name must comply with the <a href="~~108076#section-0p8-qn8-mmy~~">signature specifications</a>:</para>
        /// <list type="bullet">
        /// <item><description><para>The name must be 2 to 12 characters in length and cannot contain words such as &quot;test&quot;.</para>
        /// </description></item>
        /// <item><description><para>The name cannot contain symbols such as 【】, (), or []. Special characters such as commas, periods, and spaces are not supported.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Signature names are case-sensitive. For example, 【Aliyun通信】 and 【aliyun通信】 are treated as two different signatures.</description></item>
        /// <item><description>If your verification code signature and general-purpose signature have the same name, the system uses the general-purpose signature to send SMS messages by default.</description></item>
        /// </list>
        /// </remarks>
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
        /// <item><description><b>0</b>: full name or abbreviation of an enterprise or public institution. <b>(Recommended)</b></description></item>
        /// <item><description><b>5</b>: full name or abbreviation of a trademark.</description></item>
        /// <item><description><b>2</b>: full name or abbreviation of an app. <b>(Not recommended)</b></description></item>
        /// </list>
        /// <para>For more information about signature sources, see <a href="~~108076#section-fow-bfu-wo9~~">Signature sources</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SignSource")]
        [Validation(Required=false)]
        public int? SignSource { get; set; }

        /// <summary>
        /// <para>The signature type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: verification code.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: general-purpose (default).</para>
        /// </description></item>
        /// </list>
        /// <para>We recommend that you use the default value: <b>general-purpose</b>.</para>
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
        /// <item><description><para>false: for personal use (default). The signature is the enterprise name, website, or product name verified under this account.</para>
        /// </description></item>
        /// <item><description><para>true: for third-party use. The signature is the enterprise name, website, or product name not verified under this account.</para>
        /// <remarks>
        /// <para>Notice: If the signature is for personal use, select a qualification ID for personal use. If the signature is for third-party use, select a qualification ID for third-party use..</para>
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
        /// <item><description><ol>
        /// <item><description>This parameter is required when SignSource is set to 5.</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><ol start="2">
        /// <item><description>You can obtain the trademark entity ID by calling the <a href="~~CreateSmsTrademark~~">CreateSmsTrademark</a> operation.</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><ol start="3">
        /// <item><description>Based on carrier real-name registration requirements, provide the relevant field information. Otherwise, the probability of review rejection or carrier registration failure increases significantly.</description></item>
        /// </ol>
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
