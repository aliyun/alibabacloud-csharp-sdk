// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class SubmitSmsQualificationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The administrator\&quot;s ID card validity period. Format: YYYY-MM-DD~YYYY-MM-DD.</para>
        /// <remarks>
        /// <para>If the ID card has a long-term validity period, set the end date to 2099-12-31.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-01~2033-01-01</para>
        /// </summary>
        [NameInMap("AdminIDCardExpDate")]
        [Validation(Required=false)]
        public string AdminIDCardExpDate { get; set; }

        /// <summary>
        /// <para>The front photo of the administrator\&quot;s ID card (national emblem side). Only jpg, png, gif, and jpeg formats are supported. The image must not exceed 5 MB. Specify the file path uploaded to OSS. The file name must not contain Chinese characters or special characters. For upload instructions, see <a href="https://help.aliyun.com/document_detail/2833114.html">Upload files through OSS</a>.</para>
        /// <remarks>
        /// <para>Notice: 
        /// Color originals do not require a stamp. If you upload a photocopy or black-and-white photo, stamp the photocopy with the company seal and take a photo to upload.</para>
        /// </remarks>
        /// <para>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456/111.png</para>
        /// </summary>
        [NameInMap("AdminIDCardFrontFace")]
        [Validation(Required=false)]
        public string AdminIDCardFrontFace { get; set; }

        /// <summary>
        /// <para>The administrator\&quot;s ID card number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>511391********5123</para>
        /// </summary>
        [NameInMap("AdminIDCardNo")]
        [Validation(Required=false)]
        public string AdminIDCardNo { get; set; }

        /// <summary>
        /// <para>The back photo of the administrator\&quot;s ID card (portrait side). Only jpg, png, gif, and jpeg formats are supported. The image must not exceed 5 MB. Specify the file path uploaded to OSS. The file name must not contain Chinese characters or special characters. For upload instructions, see <a href="https://help.aliyun.com/document_detail/2833114.html">Upload files through OSS</a>.</para>
        /// <remarks>
        /// <para>Notice: 
        /// Color originals do not require a stamp. If you upload a photocopy or black-and-white photo, stamp the photocopy with the company seal and take a photo to upload.</para>
        /// </remarks>
        /// <para>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456/111.png</para>
        /// </summary>
        [NameInMap("AdminIDCardPic")]
        [Validation(Required=false)]
        public string AdminIDCardPic { get; set; }

        /// <summary>
        /// <para>The administrator\&quot;s ID card type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>identityCard: ID card.</description></item>
        /// <item><description>passport: passport.</description></item>
        /// <item><description>homeReturnPermit: Hong Kong/Macao resident travel permit to mainland.</description></item>
        /// <item><description>TaiwanCompatriotPermit: Taiwan resident travel permit to mainland.</description></item>
        /// <item><description>residencePermit: Hong Kong/Macao/Taiwan resident residence permit.</description></item>
        /// <item><description>other: other.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>identityCard</para>
        /// </summary>
        [NameInMap("AdminIDCardType")]
        [Validation(Required=false)]
        public string AdminIDCardType { get; set; }

        /// <summary>
        /// <para>The administrator\&quot;s name. Maximum length: 50 characters. <b>Under the current <a href="https://help.aliyun.com/document_detail/2873145.html">SMS signature real-name requirements</a>, if the same administrator applies for qualifications for multiple different enterprises, carrier registration will fail. Ensure one administrator per enterprise to improve the registration success rate.</b></para>
        /// <remarks>
        /// <para>The administrator (also called the handler) is the person who logs on to the Alibaba Cloud account and manages SMS services. This person typically manages qualifications, signatures, and templates under this Alibaba Cloud account and performs SMS sending operations. This person\&quot;s phone number must be able to receive verification codes. The administrator does not have to be the Alibaba Cloud account administrator and can be the same person as the legal representative.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>李华</para>
        /// </summary>
        [NameInMap("AdminName")]
        [Validation(Required=false)]
        public string AdminName { get; set; }

        /// <summary>
        /// <para>The administrator\&quot;s phone number. Format: +/+86/0086/86 or a phone number without any prefix, such as 1390000****.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>137****1234</para>
        /// </summary>
        [NameInMap("AdminPhoneNo")]
        [Validation(Required=false)]
        public string AdminPhoneNo { get; set; }

        /// <summary>
        /// <para>The business license information. This parameter is required when the qualification purpose <c>UseBySelf</c> is set to <c>false</c> (third-party use).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Based on carrier real-name registration regulatory requirements, we strongly recommend that you provide the relevant field information. Otherwise, the probability of &quot;review rejection or carrier registration failure&quot; increases significantly.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("BusinessLicensePics")]
        [Validation(Required=false)]
        public string BusinessLicensePicsShrink { get; set; }

        /// <summary>
        /// <para>The business license validity period. Format: YYYY-MM-DD~YYYY-MM-DD.</para>
        /// <remarks>
        /// <para>If the certificate has a long-term validity period, set the end date to 2099-12-31.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-01~2033-01-01</para>
        /// </summary>
        [NameInMap("BussinessLicenseExpDate")]
        [Validation(Required=false)]
        public string BussinessLicenseExpDate { get; set; }

        /// <summary>
        /// <para>The phone verification code. Call the <a href="~~RequiredPhoneCode~~">RequiredPhoneCode</a> operation with the <b>administrator\&quot;s phone number</b>, and then enter the SMS verification code received.</para>
        /// <remarks>
        /// <para>You can use <a href="~~ValidPhoneCode~~">ValidPhoneCode</a> to verify whether the SMS verification code is correct before passing it in.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("CertifyCode")]
        [Validation(Required=false)]
        public string CertifyCode { get; set; }

        /// <summary>
        /// <para>The enterprise name. Only the middle dot <c>·</c>, Chinese brackets <c>【】（）</c>, English parentheses <c>()</c>, and <c>spaces</c> are supported as symbols. Other symbols or pure digits are not allowed. Maximum length: 150 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云云通信有限公司</para>
        /// </summary>
        [NameInMap("CompanyName")]
        [Validation(Required=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// <para>The enterprise type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>COMPANY: enterprise.</para>
        /// </description></item>
        /// <item><description><para>NON_PROFIT_ORGANIZATION: government agency or public institution.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMPANY</para>
        /// </summary>
        [NameInMap("CompanyType")]
        [Validation(Required=false)]
        public string CompanyType { get; set; }

        /// <summary>
        /// <para>The legal representative\&quot;s ID card number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>511391********5123</para>
        /// </summary>
        [NameInMap("LegalPersonIDCardNo")]
        [Validation(Required=false)]
        public string LegalPersonIDCardNo { get; set; }

        /// <summary>
        /// <para>The legal representative\&quot;s ID card type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>identityCard: ID card.</description></item>
        /// <item><description>passport: passport.</description></item>
        /// <item><description>homeReturnPermit: Hong Kong/Macao resident travel permit to mainland.</description></item>
        /// <item><description>TaiwanCompatriotPermit: Taiwan resident travel permit to mainland.</description></item>
        /// <item><description>residencePermit: Hong Kong/Macao/Taiwan resident residence permit.</description></item>
        /// <item><description>other: other.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>identityCard</para>
        /// </summary>
        [NameInMap("LegalPersonIDCardType")]
        [Validation(Required=false)]
        public string LegalPersonIDCardType { get; set; }

        /// <summary>
        /// <para>The back photo of the legal representative\&quot;s ID card (portrait side). Only jpg, png, gif, and jpeg formats are supported. The image must not exceed 5 MB. Specify the file path uploaded to OSS. The file name must not contain Chinese characters or special characters. For upload instructions, see <a href="https://help.aliyun.com/document_detail/2833114.html">Upload files through OSS</a>.</para>
        /// <remarks>
        /// <para>The system verifies the legal representative\&quot;s name and ID number you provide. If verification fails, you must upload photos of the legal representative\&quot;s ID card.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123456/111.png</para>
        /// </summary>
        [NameInMap("LegalPersonIdCardBackSide")]
        [Validation(Required=false)]
        public string LegalPersonIdCardBackSide { get; set; }

        /// <summary>
        /// <para>The legal representative\&quot;s ID card validity period. Format: YYYY-MM-DD~YYYY-MM-DD.</para>
        /// <remarks>
        /// <para>If the ID card has a long-term validity period, set the end date to 2099-12-31.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-01~2033-01-01</para>
        /// </summary>
        [NameInMap("LegalPersonIdCardEffTime")]
        [Validation(Required=false)]
        public string LegalPersonIdCardEffTime { get; set; }

        /// <summary>
        /// <para>The front photo of the legal representative\&quot;s ID card (national emblem side). Only jpg, png, gif, and jpeg formats are supported. The image must not exceed 5 MB. Specify the file path uploaded to OSS. The file name must not contain Chinese characters or special characters. For upload instructions, see <a href="https://help.aliyun.com/document_detail/2833114.html">Upload files through OSS</a>.</para>
        /// <remarks>
        /// <para>The system verifies the legal representative\&quot;s name and ID number you provide. If verification fails, you must upload photos of the legal representative\&quot;s ID card.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123456/111.png</para>
        /// </summary>
        [NameInMap("LegalPersonIdCardFrontSide")]
        [Validation(Required=false)]
        public string LegalPersonIdCardFrontSide { get; set; }

        /// <summary>
        /// <para>The legal representative\&quot;s name. Maximum length: 50 characters.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the organization certificate does not contain legal representative information but includes a person in charge or chief representative, prepare the ID card photos of the corresponding person in charge or chief representative listed on the certificate.</description></item>
        /// <item><description>If the organization certificate contains neither legal representative information nor any person in charge, prepare the name and ID card photos of the primary business contact.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>李华</para>
        /// </summary>
        [NameInMap("LegalPersonName")]
        [Validation(Required=false)]
        public string LegalPersonName { get; set; }

        /// <summary>
        /// <para>The unified social credit code. Maximum length: 150 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>910X********0012</para>
        /// </summary>
        [NameInMap("OrganizationCode")]
        [Validation(Required=false)]
        public string OrganizationCode { get; set; }

        /// <summary>
        /// <para>Additional materials. If you have other supporting documents, notes, or photos, upload them here.</para>
        /// </summary>
        [NameInMap("OtherFiles")]
        [Validation(Required=false)]
        public string OtherFilesShrink { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The qualification name, used to manage and distinguish multiple qualifications you apply for. It does not appear in SMS content. The name must be unique among your existing qualifications. Only Chinese characters, English letters, or combinations with digits are supported. Symbols or pure digits are not supported. Maximum length: 100 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云云通信有限公司资质李华</para>
        /// </summary>
        [NameInMap("QualificationName")]
        [Validation(Required=false)]
        public string QualificationName { get; set; }

        /// <summary>
        /// <para>Remarks. If you have additional information to provide or notes for the qualification verification reviewer, add a description here.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
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
        /// <para>The purpose of the qualification application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: <b>Self-use</b>. The entity that owns the signature is the same as the entity verified for this account.</description></item>
        /// <item><description><b>false</b>: <b>Third-party use</b>. The entity that owns the signature is different from the entity verified for this account.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseBySelf")]
        [Validation(Required=false)]
        public bool? UseBySelf { get; set; }

        /// <summary>
        /// <para>Qualification authorization. Specifies whether to share the qualification with other cloud communication products (such as domestic voice services and domestic number privacy protection). Sharing is available only when you apply for a <b>self-use qualification</b> and the qualification information <b>matches the enterprise information verified for the current Alibaba Cloud account</b>. Otherwise, this setting has no effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Agree. Your qualification information can be referenced during the qualification verification process of other cloud communication products, eliminating redundant verification.</description></item>
        /// <item><description>false: Disagree.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("WhetherShare")]
        [Validation(Required=false)]
        public bool? WhetherShare { get; set; }

    }

}
