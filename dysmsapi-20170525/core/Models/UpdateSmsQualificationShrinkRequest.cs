// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class UpdateSmsQualificationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>经办人身份证有效期，格式示例2023-01-01~2033-01-01</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-01~2033-01-01</para>
        /// </summary>
        [NameInMap("AdminIDCardExpDate")]
        [Validation(Required=false)]
        public string AdminIDCardExpDate { get; set; }

        /// <summary>
        /// <para>经办人身份证照片国徽面</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456/111.png</para>
        /// </summary>
        [NameInMap("AdminIDCardFrontFace")]
        [Validation(Required=false)]
        public string AdminIDCardFrontFace { get; set; }

        /// <summary>
        /// <para>经办人身份证号码</para>
        /// 
        /// <b>Example:</b>
        /// <para>511391********5123</para>
        /// </summary>
        [NameInMap("AdminIDCardNo")]
        [Validation(Required=false)]
        public string AdminIDCardNo { get; set; }

        /// <summary>
        /// <para>经办人身份证照片人像面</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456/111.png</para>
        /// </summary>
        [NameInMap("AdminIDCardPic")]
        [Validation(Required=false)]
        public string AdminIDCardPic { get; set; }

        /// <summary>
        /// <para>管理员身份证类型。identityCard:中国居民身份证;passport:护照;homeReturnPermit:港澳居民来往内地通行证;TaiwanCompatriotPermit:台湾居民来往大陆通行证;residencePermit:港澳台居民居住证&quot;;other:其他</para>
        /// 
        /// <b>Example:</b>
        /// <para>identityCard</para>
        /// </summary>
        [NameInMap("AdminIDCardType")]
        [Validation(Required=false)]
        public string AdminIDCardType { get; set; }

        /// <summary>
        /// <para>经办人姓名</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("AdminName")]
        [Validation(Required=false)]
        public string AdminName { get; set; }

        /// <summary>
        /// <para>经办人手机号码</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>137********</para>
        /// </summary>
        [NameInMap("AdminPhoneNo")]
        [Validation(Required=false)]
        public string AdminPhoneNo { get; set; }

        /// <summary>
        /// <para>企业证件信息</para>
        /// </summary>
        [NameInMap("BusinessLicensePics")]
        [Validation(Required=false)]
        public string BusinessLicensePicsShrink { get; set; }

        /// <summary>
        /// <para>企业营业时间开始和结束字符串，格式示例2023-01-01~2033-01-01</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-01~2033-01-01</para>
        /// </summary>
        [NameInMap("BussinessLicenseExpDate")]
        [Validation(Required=false)]
        public string BussinessLicenseExpDate { get; set; }

        /// <summary>
        /// <para>手机号验证码</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("CertifyCode")]
        [Validation(Required=false)]
        public string CertifyCode { get; set; }

        /// <summary>
        /// <para>公司名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("CompanyName")]
        [Validation(Required=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// <para>法人身份证号码</para>
        /// 
        /// <b>Example:</b>
        /// <para>511391********5123</para>
        /// </summary>
        [NameInMap("LegalPersonIDCardNo")]
        [Validation(Required=false)]
        public string LegalPersonIDCardNo { get; set; }

        /// <summary>
        /// <para>法人身份证类型。identityCard:中国居民身份证;passport:护照;homeReturnPermit:港澳居民来往内地通行证;TaiwanCompatriotPermit:台湾居民来往大陆通行证;residencePermit:港澳台居民居住证&quot;;other:其他</para>
        /// 
        /// <b>Example:</b>
        /// <para>identityCard</para>
        /// </summary>
        [NameInMap("LegalPersonIDCardType")]
        [Validation(Required=false)]
        public string LegalPersonIDCardType { get; set; }

        /// <summary>
        /// <para>法人身份证照片人像面</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456/111.png</para>
        /// </summary>
        [NameInMap("LegalPersonIdCardBackSide")]
        [Validation(Required=false)]
        public string LegalPersonIdCardBackSide { get; set; }

        /// <summary>
        /// <para>法人身份证有效期，格式示例2023-01-01~2033-01-01</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-01~2033-01-01</para>
        /// </summary>
        [NameInMap("LegalPersonIdCardEffTime")]
        [Validation(Required=false)]
        public string LegalPersonIdCardEffTime { get; set; }

        /// <summary>
        /// <para>法人身份照片证国徽面</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456/111.png</para>
        /// </summary>
        [NameInMap("LegalPersonIdCardFrontSide")]
        [Validation(Required=false)]
        public string LegalPersonIdCardFrontSide { get; set; }

        /// <summary>
        /// <para>法人姓名</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("LegalPersonName")]
        [Validation(Required=false)]
        public string LegalPersonName { get; set; }

        /// <summary>
        /// <para>工单ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2001*****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>更多资料</para>
        /// </summary>
        [NameInMap("OtherFiles")]
        [Validation(Required=false)]
        public string OtherFilesShrink { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>资质组ID</para>
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
