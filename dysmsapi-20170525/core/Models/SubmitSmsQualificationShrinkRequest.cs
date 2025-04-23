// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class SubmitSmsQualificationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>经办人身份证有效期，格式示例2023-01-01~2033-01-01</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-01~2033-01-01</para>
        /// </summary>
        [NameInMap("AdminIDCardExpDate")]
        [Validation(Required=false)]
        public string AdminIDCardExpDate { get; set; }

        /// <summary>
        /// <para>经办人身份证照片国徽面</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456/111.png</para>
        /// </summary>
        [NameInMap("AdminIDCardFrontFace")]
        [Validation(Required=false)]
        public string AdminIDCardFrontFace { get; set; }

        /// <summary>
        /// <para>经办人身份证号码</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>511391********5123</para>
        /// </summary>
        [NameInMap("AdminIDCardNo")]
        [Validation(Required=false)]
        public string AdminIDCardNo { get; set; }

        /// <summary>
        /// <para>经办人身份证照片人像面</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456/111.png</para>
        /// </summary>
        [NameInMap("AdminIDCardPic")]
        [Validation(Required=false)]
        public string AdminIDCardPic { get; set; }

        /// <summary>
        /// <para>管理员身份证类型。identityCard:中国居民身份证;passport:护照;homeReturnPermit:港澳居民来往内地通行证;TaiwanCompatriotPermit:台湾居民来往大陆通行证;residencePermit:港澳台居民居住证&quot;;other:其他</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>identityCard</para>
        /// </summary>
        [NameInMap("AdminIDCardType")]
        [Validation(Required=false)]
        public string AdminIDCardType { get; set; }

        /// <summary>
        /// <para>经办人姓名</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("AdminName")]
        [Validation(Required=false)]
        public string AdminName { get; set; }

        /// <summary>
        /// <para>经办人手机号码</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>137****1234</para>
        /// </summary>
        [NameInMap("AdminPhoneNo")]
        [Validation(Required=false)]
        public string AdminPhoneNo { get; set; }

        /// <summary>
        /// <para>企业营业证件信息，非大客户必填</para>
        /// </summary>
        [NameInMap("BusinessLicensePics")]
        [Validation(Required=false)]
        public string BusinessLicensePicsShrink { get; set; }

        /// <summary>
        /// <para>企业营业时间开始和结束字符串，格式示例2023-01-01~2033-01-01</para>
        /// <para>This parameter is required.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("CompanyName")]
        [Validation(Required=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// <para>企业类型, COMPANY:公司;NON_PROFIT_ORGANIZATION:政府或者事业单位</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMPANY</para>
        /// </summary>
        [NameInMap("CompanyType")]
        [Validation(Required=false)]
        public string CompanyType { get; set; }

        /// <summary>
        /// <para>法人身份证号码</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>511391********5123</para>
        /// </summary>
        [NameInMap("LegalPersonIDCardNo")]
        [Validation(Required=false)]
        public string LegalPersonIDCardNo { get; set; }

        /// <summary>
        /// <para>法人身份证类型。identityCard:中国居民身份证;passport:护照;homeReturnPermit:港澳居民来往内地通行证;TaiwanCompatriotPermit:台湾居民来往大陆通行证;residencePermit:港澳台居民居住证&quot;;other:其他</para>
        /// <para>This parameter is required.</para>
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
        /// <para>法人身份证有效期</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-01~2033-01-01</para>
        /// </summary>
        [NameInMap("LegalPersonIdCardEffTime")]
        [Validation(Required=false)]
        public string LegalPersonIdCardEffTime { get; set; }

        /// <summary>
        /// <para>法人身份证照片国徽面</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456/111.png</para>
        /// </summary>
        [NameInMap("LegalPersonIdCardFrontSide")]
        [Validation(Required=false)]
        public string LegalPersonIdCardFrontSide { get; set; }

        /// <summary>
        /// <para>法人姓名</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("LegalPersonName")]
        [Validation(Required=false)]
        public string LegalPersonName { get; set; }

        /// <summary>
        /// <para>社会统一信用代码</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>910X********0012</para>
        /// </summary>
        [NameInMap("OrganizationCode")]
        [Validation(Required=false)]
        public string OrganizationCode { get; set; }

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
        /// <para>资质名称,名称不能重复</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("QualificationName")]
        [Validation(Required=false)]
        public string QualificationName { get; set; }

        /// <summary>
        /// <para>备注</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
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
        /// <para>资质是自用还是他用，true：自用，false：他用</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseBySelf")]
        [Validation(Required=false)]
        public bool? UseBySelf { get; set; }

        /// <summary>
        /// <para>是否同意与其他业务线共享</para>
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
