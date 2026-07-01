// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class UpdateSmsQualificationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Validity period of the administrator ID card. Format: YYYY-MM-DD~YYYY-MM-DD.</para>
        /// <remarks>
        /// <para>When the certificate validity period is long-term, the end date can be set to 2099-12-31.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-01~2033-01-01</para>
        /// </summary>
        [NameInMap("AdminIDCardExpDate")]
        [Validation(Required=false)]
        public string AdminIDCardExpDate { get; set; }

        /// <summary>
        /// <para>Photo of the front of the administrator\&quot;s ID card (national emblem side). Only jpg, png, gif, and jpeg image formats are supported, and the image must not exceed 5 MB. Please provide the path of the file uploaded to OSS. The file name to be uploaded must not contain Chinese characters or special characters. For upload operations, see <a href="https://help.aliyun.com/document_detail/2833114.html">Upload Files via OSS</a>.</para>
        /// <remarks>
        /// <para>Notice: 
        /// No stamp is required for color originals of the certificate. If you upload a photocopy or black-and-white photo, you must affix the enterprise red seal to the photocopy and take a photo to upload.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123456/111.png</para>
        /// </summary>
        [NameInMap("AdminIDCardFrontFace")]
        [Validation(Required=false)]
        public string AdminIDCardFrontFace { get; set; }

        /// <summary>
        /// <para>Administrator\&quot;s ID number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>511391********5123</para>
        /// </summary>
        [NameInMap("AdminIDCardNo")]
        [Validation(Required=false)]
        public string AdminIDCardNo { get; set; }

        /// <summary>
        /// <para>Photo of the back of the administrator\&quot;s ID card (portrait side). Only jpg, png, gif, and jpeg image formats are supported, and the image must not exceed 5 MB. Please provide the path of the file uploaded to OSS. The file name to be uploaded must not contain Chinese characters or special characters. For upload operations, see <a href="https://help.aliyun.com/document_detail/2833114.html">Upload Files via OSS</a>.</para>
        /// <remarks>
        /// <para>Notice: 
        ///  No stamp is required for color originals of the certificate. If you upload a photocopy or black-and-white photo, you must affix the enterprise red seal to the photocopy and take a photo to upload.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123456/111.png</para>
        /// </summary>
        [NameInMap("AdminIDCardPic")]
        [Validation(Required=false)]
        public string AdminIDCardPic { get; set; }

        /// <summary>
        /// <para>Administrator ID card type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>identityCard: ID card.</description></item>
        /// <item><description>passport: Passport.</description></item>
        /// <item><description>homeReturnPermit: Mainland Travel Permit for Hong Kong and Macao Residents.</description></item>
        /// <item><description>TaiwanCompatriotPermit: Mainland Travel Permit for Taiwan Residents.</description></item>
        /// <item><description>residencePermit: Residence Permit for Hong Kong, Macao, and Taiwan Residents.</description></item>
        /// <item><description>other: Other.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>identityCard</para>
        /// </summary>
        [NameInMap("AdminIDCardType")]
        [Validation(Required=false)]
        public string AdminIDCardType { get; set; }

        /// <summary>
        /// <para>Administrator name.</para>
        /// <remarks>
        /// <para>The administrator (also known as the operator) refers to the person who logs in to the Alibaba Cloud account and manages the SMS service. Generally, this is the operations personnel who manages qualifications, signatures, and templates and sends SMS messages under this Alibaba Cloud account, and whose phone number can receive verification codes. The administrator is not necessarily the administrator of this Alibaba Cloud account. The administrator can be the same person as the enterprise\&quot;s legal representative.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>李华</para>
        /// </summary>
        [NameInMap("AdminName")]
        [Validation(Required=false)]
        public string AdminName { get; set; }

        /// <summary>
        /// <para>Administrator\&quot;s mobile phone number. Format: +/+86/0086/86 prefix or a phone number without any prefix, for example, 1390000****.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>137********</para>
        /// </summary>
        [NameInMap("AdminPhoneNo")]
        [Validation(Required=false)]
        public string AdminPhoneNo { get; set; }

        /// <summary>
        /// <para>Enterprise business license information. This parameter is required when the purpose of the qualification to be modified is for use by others.</para>
        /// </summary>
        [NameInMap("BusinessLicensePics")]
        [Validation(Required=false)]
        public string BusinessLicensePicsShrink { get; set; }

        /// <summary>
        /// <para>Validity period of the business license. Format: YYYY-MM-DD~YYYY-MM-DD.</para>
        /// <remarks>
        /// <para>When the certificate validity period is long-term, the end date can be set to 2099-12-31.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-01~2033-01-01</para>
        /// </summary>
        [NameInMap("BussinessLicenseExpDate")]
        [Validation(Required=false)]
        public string BussinessLicenseExpDate { get; set; }

        /// <summary>
        /// <para>Phone verification code. Please call the <a href="~~RequiredPhoneCode~~">RequiredPhoneCode</a> API and pass in the <b>administrator\&quot;s phone number</b>, then enter the SMS verification code you receive here.</para>
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
        /// <para>Enterprise name. Supported symbols are only the middle dot <c>·</c>, the Chinese symbols <c>【】（）</c>, the English symbols <c>()</c>, and the <c>space</c>. Other symbols or pure numbers are not allowed. The length must not exceed 150 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云云通信有限公司</para>
        /// </summary>
        [NameInMap("CompanyName")]
        [Validation(Required=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// <para>Legal person\&quot;s ID number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>511391********5123</para>
        /// </summary>
        [NameInMap("LegalPersonIDCardNo")]
        [Validation(Required=false)]
        public string LegalPersonIDCardNo { get; set; }

        /// <summary>
        /// <para>Legal person ID card type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>identityCard: ID card.</description></item>
        /// <item><description>passport: Passport.</description></item>
        /// <item><description>homeReturnPermit: Mainland Travel Permit for Hong Kong and Macao Residents.</description></item>
        /// <item><description>TaiwanCompatriotPermit: Mainland Travel Permit for Taiwan Residents.</description></item>
        /// <item><description>residencePermit: Residence Permit for Hong Kong, Macao, and Taiwan Residents.</description></item>
        /// <item><description>other: Other.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>identityCard</para>
        /// </summary>
        [NameInMap("LegalPersonIDCardType")]
        [Validation(Required=false)]
        public string LegalPersonIDCardType { get; set; }

        /// <summary>
        /// <para>Photo of the back of the legal representative\&quot;s ID card (portrait side). Only jpg, png, gif, and jpeg image formats are supported, and the image must not exceed 5 MB. Please provide the path of the file uploaded to OSS. The file name to be uploaded must not contain Chinese characters or special characters. For upload operations, see <a href="https://help.aliyun.com/document_detail/2833114.html">Upload Files via OSS</a>.</para>
        /// <remarks>
        /// <para>The system will use the legal person name and ID number you provide for verification. If the verification fails, you need to upload a photo of the legal representative\&quot;s ID card.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123456/111.png</para>
        /// </summary>
        [NameInMap("LegalPersonIdCardBackSide")]
        [Validation(Required=false)]
        public string LegalPersonIdCardBackSide { get; set; }

        /// <summary>
        /// <para>Validity period of the legal person ID card. Format: YYYY-MM-DD~YYYY-MM-DD.</para>
        /// <remarks>
        /// <para>When the certificate validity period is long-term, the end date can be set to 2099-12-31.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-01~2033-01-01</para>
        /// </summary>
        [NameInMap("LegalPersonIdCardEffTime")]
        [Validation(Required=false)]
        public string LegalPersonIdCardEffTime { get; set; }

        /// <summary>
        /// <para>Photo of the front of the legal representative\&quot;s ID card (national emblem side). Only jpg, png, gif, and jpeg image formats are supported, and the image must not exceed 5 MB. Please provide the path of the file uploaded to OSS. The file name to be uploaded must not contain Chinese characters or special characters. For upload operations, see <a href="https://help.aliyun.com/document_detail/2833114.html">Upload Files via OSS</a>.</para>
        /// <remarks>
        /// <para>The system will use the legal person name and ID number you provide for verification. If the verification fails, you need to upload a photo of the legal representative\&quot;s ID card.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123456/111.png</para>
        /// </summary>
        [NameInMap("LegalPersonIdCardFrontSide")]
        [Validation(Required=false)]
        public string LegalPersonIdCardFrontSide { get; set; }

        /// <summary>
        /// <para>Name of the legal representative.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If there is no legal representative information on the organization\&quot;s certificate, but there is information about a person in charge / chief representative or similar, please prepare the ID card photo of the corresponding person in charge or chief representative listed on the certificate.</description></item>
        /// <item><description>If there is no legal representative information on the organization\&quot;s certificate, and there is no information about any person in charge, please prepare the name and ID card photo of the main business contact person.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>李华</para>
        /// </summary>
        [NameInMap("LegalPersonName")]
        [Validation(Required=false)]
        public string LegalPersonName { get; set; }

        /// <summary>
        /// <para>The review order ID. You can obtain the qualifications and their corresponding review order IDs under the current account by calling <a href="~~QuerySmsQualificationRecord~~">Query Qualification List</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2001*****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>Additional materials. If you have other supporting or supplementary materials, photos, etc., you can upload them here.</para>
        /// </summary>
        [NameInMap("OtherFiles")]
        [Validation(Required=false)]
        public string OtherFilesShrink { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The qualification ID, that is, the ID returned when you <a href="~~SubmitSmsQualification~~">apply for SMS qualification</a>. You can obtain the qualification IDs under the current account by calling <a href="~~QuerySmsQualificationRecord~~">Query Qualification List</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000****</para>
        /// </summary>
        [NameInMap("QualificationGroupId")]
        [Validation(Required=false)]
        public long? QualificationGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
