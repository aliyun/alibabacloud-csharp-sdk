// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySingleSmsQualificationResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial. This parameter is returned only when the RAM check fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code of the request.</para>
        /// <list type="bullet">
        /// <item><description>The value OK indicates that the request was successful.</description></item>
        /// <item><description>For other error codes, see the error code list in this chapter or the product <a href="https://help.aliyun.com/document_detail/101346.html">error code list</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of a single qualification.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySingleSmsQualificationResponseBodyData Data { get; set; }
        public class QuerySingleSmsQualificationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The validity period of the administrator\&quot;s certificate. Format: YYYY-MM-DD~YYYY-MM-DD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-01~2033-01-01</para>
            /// </summary>
            [NameInMap("AdminIDCardExpDate")]
            [Validation(Required=false)]
            public string AdminIDCardExpDate { get; set; }

            /// <summary>
            /// <para>The full URL of the photo of the front side of the administrator\&quot;s certificate (national emblem side of the ID card).</para>
            /// 
            /// <b>Example:</b>
            /// <para>https://<b><b><b>.aliyuncs.com/</b></b></b></para>
            /// </summary>
            [NameInMap("AdminIDCardFrontFace")]
            [Validation(Required=false)]
            public string AdminIDCardFrontFace { get; set; }

            /// <summary>
            /// <para>The certificate number of the administrator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>511391********5123</para>
            /// </summary>
            [NameInMap("AdminIDCardNo")]
            [Validation(Required=false)]
            public string AdminIDCardNo { get; set; }

            /// <summary>
            /// <para>The full URL of the photo of the back side of the administrator\&quot;s certificate (portrait side of the ID card).</para>
            /// 
            /// <b>Example:</b>
            /// <para>https://<b><b><b>.aliyuncs.com/</b></b></b></para>
            /// </summary>
            [NameInMap("AdminIDCardPic")]
            [Validation(Required=false)]
            public string AdminIDCardPic { get; set; }

            /// <summary>
            /// <para>The type of the administrator\&quot;s certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>identityCard: ID card.</description></item>
            /// <item><description>passport: Passport.</description></item>
            /// <item><description>homeReturnPermit: Home return permit for Hong Kong and Macao residents.</description></item>
            /// <item><description>TaiwanCompatriotPermit: Mainland travel permit for Taiwan residents.</description></item>
            /// <item><description>residencePermit: Residence permit for residents of Hong Kong, Macao, and Taiwan.</description></item>
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
            /// <para>The name of the administrator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>李华</para>
            /// </summary>
            [NameInMap("AdminName")]
            [Validation(Required=false)]
            public string AdminName { get; set; }

            /// <summary>
            /// <para>The mobile phone number of the administrator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>137*******</para>
            /// </summary>
            [NameInMap("AdminPhoneNo")]
            [Validation(Required=false)]
            public string AdminPhoneNo { get; set; }

            /// <summary>
            /// <para>The business license information of the enterprise.</para>
            /// </summary>
            [NameInMap("BusinessLicensePics")]
            [Validation(Required=false)]
            public List<QuerySingleSmsQualificationResponseBodyDataBusinessLicensePics> BusinessLicensePics { get; set; }
            public class QuerySingleSmsQualificationResponseBodyDataBusinessLicensePics : TeaModel {
                /// <summary>
                /// <para>The file path parameter of the business license.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456/111.png</para>
                /// </summary>
                [NameInMap("LicensePic")]
                [Validation(Required=false)]
                public string LicensePic { get; set; }

                /// <summary>
                /// <para>The full URL of the business license file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>https://<b><b><b>.aliyuncs.com/</b></b></b></para>
                /// </summary>
                [NameInMap("PicUrl")]
                [Validation(Required=false)]
                public string PicUrl { get; set; }

                /// <summary>
                /// <para>The type of business license. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>socialCreditLicense: Unified social credit code certificate.</description></item>
                /// <item><description>businessLicense: Business license.</description></item>
                /// <item><description>signLegalLicense: Legal person certificate of a public institution.</description></item>
                /// <item><description>otherLicense: Other types of license certificates.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>businessLicense</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The industry type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dysms</para>
            /// </summary>
            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public string BusinessType { get; set; }

            /// <summary>
            /// <para>The name of the enterprise.</para>
            /// 
            /// <b>Example:</b>
            /// <para>阿里云云通信有限公司</para>
            /// </summary>
            [NameInMap("CompanyName")]
            [Validation(Required=false)]
            public string CompanyName { get; set; }

            /// <summary>
            /// <para>The type of enterprise. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>COMPANY: Enterprise.</description></item>
            /// <item><description>NON_PROFIT_ORGANIZATION: Government agency or public institution.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPANY</para>
            /// </summary>
            [NameInMap("CompanyType")]
            [Validation(Required=false)]
            public string CompanyType { get; set; }

            /// <summary>
            /// <para>The validity period of the business license. Format: YYYY-MM-DD~YYYY-MM-DD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-01~2033-01-01</para>
            /// </summary>
            [NameInMap("EffTimeStr")]
            [Validation(Required=false)]
            public string EffTimeStr { get; set; }

            /// <summary>
            /// <para>The certificate number of the legal representative.</para>
            /// 
            /// <b>Example:</b>
            /// <para>511391********5123</para>
            /// </summary>
            [NameInMap("LegalPersonIDCardNo")]
            [Validation(Required=false)]
            public string LegalPersonIDCardNo { get; set; }

            /// <summary>
            /// <para>The type of the legal representative\&quot;s certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>identityCard: ID card.</description></item>
            /// <item><description>passport: Passport.</description></item>
            /// <item><description>homeReturnPermit: Home return permit for Hong Kong and Macao residents.</description></item>
            /// <item><description>TaiwanCompatriotPermit: Mainland travel permit for Taiwan residents.</description></item>
            /// <item><description>residencePermit: Residence permit for residents of Hong Kong, Macao, and Taiwan.</description></item>
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
            /// <para>The validity period of the legal representative\&quot;s certificate. Format: YYYY-MM-DD~YYYY-MM-DD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-01~2033-01-01</para>
            /// </summary>
            [NameInMap("LegalPersonIdCardEffTime")]
            [Validation(Required=false)]
            public string LegalPersonIdCardEffTime { get; set; }

            /// <summary>
            /// <para>The name of the legal representative.</para>
            /// 
            /// <b>Example:</b>
            /// <para>李华</para>
            /// </summary>
            [NameInMap("LegalPersonName")]
            [Validation(Required=false)]
            public string LegalPersonName { get; set; }

            /// <summary>
            /// <para>The unified social credit code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>910X********0012</para>
            /// </summary>
            [NameInMap("OrganizationCode")]
            [Validation(Required=false)]
            public string OrganizationCode { get; set; }

            /// <summary>
            /// <para>Additional materials.</para>
            /// </summary>
            [NameInMap("OtherFiles")]
            [Validation(Required=false)]
            public List<QuerySingleSmsQualificationResponseBodyDataOtherFiles> OtherFiles { get; set; }
            public class QuerySingleSmsQualificationResponseBodyDataOtherFiles : TeaModel {
                /// <summary>
                /// <para>The file path parameter of the additional materials.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456/111.png</para>
                /// </summary>
                [NameInMap("LicensePic")]
                [Validation(Required=false)]
                public string LicensePic { get; set; }

                /// <summary>
                /// <para>The full URL of the additional materials file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>https://<b><b><b>.aliyuncs.com/</b></b></b></para>
                /// </summary>
                [NameInMap("PicUrl")]
                [Validation(Required=false)]
                public string PicUrl { get; set; }

            }

            /// <summary>
            /// <para>The qualification ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000****</para>
            /// </summary>
            [NameInMap("QualificationGroupId")]
            [Validation(Required=false)]
            public long? QualificationGroupId { get; set; }

            /// <summary>
            /// <para>The qualification name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>阿里云云通信有限公司资质李华</para>
            /// </summary>
            [NameInMap("QualificationName")]
            [Validation(Required=false)]
            public string QualificationName { get; set; }

            /// <summary>
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>无</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The review status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>INT: Under review.</description></item>
            /// <item><description>FAILED: Review failed.</description></item>
            /// <item><description>PASSED: Review passed.</description></item>
            /// <item><description>NOT_FINISH: Materials to be supplemented.</description></item>
            /// <item><description>CANCELED: Cancelled.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This API does not return review remarks. To query review remarks (<c>AuditRemark</c>), use <a href="~~QuerySmsQualificationRecord~~">QuerySmsQualificationRecord</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>PASSED</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The purpose of the qualification application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: For self-use.</description></item>
            /// <item><description><b>false</b>: For other use.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("UseBySelf")]
            [Validation(Required=false)]
            public bool? UseBySelf { get; set; }

            /// <summary>
            /// <para>Qualification authorization. Indicates whether to allow this qualification to be shared with other cloud communication products (such as Domestic Voice and Domestic Number Privacy Protection). The qualification can be shared and reused only when you apply for a <b>self-use qualification</b> and the qualification information <b>matches the enterprise information authenticated under the current Alibaba Cloud account</b>. Other cases are invalid. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Agree. Your qualification information can be invoked in the &quot;qualification authentication step&quot; of other cloud communication products, eliminating duplicate authentication steps.</description></item>
            /// <item><description>false: Disagree.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("WhetherShare")]
            [Validation(Required=false)]
            public bool? WhetherShare { get; set; }

            /// <summary>
            /// <para>The review ticket ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2001****</para>
            /// </summary>
            [NameInMap("WorkOrderId")]
            [Validation(Required=false)]
            public long? WorkOrderId { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of this API call request, which is the unique identifier generated by Alibaba Cloud for this request. It can be used to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25D5AFDE-8EBC-132E-8909-1FDC071DA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
