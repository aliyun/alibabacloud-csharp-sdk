// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySingleSmsQualificationResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySingleSmsQualificationResponseBodyData Data { get; set; }
        public class QuerySingleSmsQualificationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>经办人身份证有效期</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-01~2033-01-01</para>
            /// </summary>
            [NameInMap("AdminIDCardExpDate")]
            [Validation(Required=false)]
            public string AdminIDCardExpDate { get; set; }

            /// <summary>
            /// <para>经办人身份证国徽面，产品需求，要求身份证可以分正反面上传</para>
            /// 
            /// <b>Example:</b>
            /// <para>https://<b><b><b>.aliyuncs.com/</b></b></b></para>
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
            /// <para>经办人身份证图片地址，正反面合一</para>
            /// 
            /// <b>Example:</b>
            /// <para>https://<b><b><b>.aliyuncs.com/</b></b></b></para>
            /// </summary>
            [NameInMap("AdminIDCardPic")]
            [Validation(Required=false)]
            public string AdminIDCardPic { get; set; }

            /// <summary>
            /// <para>管理员身份证类型</para>
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
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("AdminName")]
            [Validation(Required=false)]
            public string AdminName { get; set; }

            /// <summary>
            /// <para>经办人手机号码</para>
            /// 
            /// <b>Example:</b>
            /// <para>137*******</para>
            /// </summary>
            [NameInMap("AdminPhoneNo")]
            [Validation(Required=false)]
            public string AdminPhoneNo { get; set; }

            /// <summary>
            /// <para>证件信息</para>
            /// </summary>
            [NameInMap("BusinessLicensePics")]
            [Validation(Required=false)]
            public List<QuerySingleSmsQualificationResponseBodyDataBusinessLicensePics> BusinessLicensePics { get; set; }
            public class QuerySingleSmsQualificationResponseBodyDataBusinessLicensePics : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>123456/111.png</para>
                /// </summary>
                [NameInMap("LicensePic")]
                [Validation(Required=false)]
                public string LicensePic { get; set; }

                /// <summary>
                /// <para>文件的完整路径</para>
                /// 
                /// <b>Example:</b>
                /// <para>https://<b><b><b>.aliyuncs.com/</b></b></b></para>
                /// </summary>
                [NameInMap("PicUrl")]
                [Validation(Required=false)]
                public string PicUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>businessLicense</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>行业类型，在当前模式下是可以用产品线code来区分</para>
            /// 
            /// <b>Example:</b>
            /// <para>dysms</para>
            /// </summary>
            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public string BusinessType { get; set; }

            /// <summary>
            /// <para>公司名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("CompanyName")]
            [Validation(Required=false)]
            public string CompanyName { get; set; }

            /// <summary>
            /// <para>企业类型, COMPANY:公司，政府或者事业单位:NON_PROFIT_ORGANIZATION</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPANY</para>
            /// </summary>
            [NameInMap("CompanyType")]
            [Validation(Required=false)]
            public string CompanyType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-01-01~2033-01-01</para>
            /// </summary>
            [NameInMap("EffTimeStr")]
            [Validation(Required=false)]
            public string EffTimeStr { get; set; }

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
            /// <para>法人身份证类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>identityCard</para>
            /// </summary>
            [NameInMap("LegalPersonIDCardType")]
            [Validation(Required=false)]
            public string LegalPersonIDCardType { get; set; }

            /// <summary>
            /// <para>法人身份证有效期</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-01~2033-01-01</para>
            /// </summary>
            [NameInMap("LegalPersonIdCardEffTime")]
            [Validation(Required=false)]
            public string LegalPersonIdCardEffTime { get; set; }

            /// <summary>
            /// <para>法人姓名</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值</para>
            /// </summary>
            [NameInMap("LegalPersonName")]
            [Validation(Required=false)]
            public string LegalPersonName { get; set; }

            /// <summary>
            /// <para>社会统一信用代码</para>
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
            public List<QuerySingleSmsQualificationResponseBodyDataOtherFiles> OtherFiles { get; set; }
            public class QuerySingleSmsQualificationResponseBodyDataOtherFiles : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>123456/111.png</para>
                /// </summary>
                [NameInMap("LicensePic")]
                [Validation(Required=false)]
                public string LicensePic { get; set; }

                /// <summary>
                /// <para>文件的完整路径</para>
                /// 
                /// <b>Example:</b>
                /// <para>https://<b><b><b>.aliyuncs.com/</b></b></b></para>
                /// </summary>
                [NameInMap("PicUrl")]
                [Validation(Required=false)]
                public string PicUrl { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000****</para>
            /// </summary>
            [NameInMap("QualificationGroupId")]
            [Validation(Required=false)]
            public long? QualificationGroupId { get; set; }

            /// <summary>
            /// <para>资质名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
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

            /// <summary>
            /// <para>当前审核状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>PASSED</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>是否自用</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("UseBySelf")]
            [Validation(Required=false)]
            public bool? UseBySelf { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("WhetherShare")]
            [Validation(Required=false)]
            public bool? WhetherShare { get; set; }

            /// <summary>
            /// <para>乾坤袋工单ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>2001****</para>
            /// </summary>
            [NameInMap("WorkOrderId")]
            [Validation(Required=false)]
            public long? WorkOrderId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>25D5AFDE-8EBC-132E-8909-1FDC071DA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
