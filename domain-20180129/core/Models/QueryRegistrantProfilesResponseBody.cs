// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryRegistrantProfilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        /// <summary>
        /// <para>Indicates whether the current page is followed by a page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page. Default value: <b>0</b>. Maximum value: <b>5000</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Indicates whether the current page is preceded by a page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        /// <summary>
        /// <para>The list of registrant profiles.</para>
        /// </summary>
        [NameInMap("RegistrantProfiles")]
        [Validation(Required=false)]
        public QueryRegistrantProfilesResponseBodyRegistrantProfiles RegistrantProfiles { get; set; }
        public class QueryRegistrantProfilesResponseBodyRegistrantProfiles : TeaModel {
            [NameInMap("RegistrantProfile")]
            [Validation(Required=false)]
            public List<QueryRegistrantProfilesResponseBodyRegistrantProfilesRegistrantProfile> RegistrantProfile { get; set; }
            public class QueryRegistrantProfilesResponseBodyRegistrantProfilesRegistrantProfile : TeaModel {
                /// <summary>
                /// <para>The address of the domain name registrant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zhe jiang sheng hang zhou shi shi li qu shi li zhen shi li da sha 1001 hao</para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>The city where the domain name registrant is located, in English.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hang zhou shi</para>
                /// </summary>
                [NameInMap("City")]
                [Validation(Required=false)]
                public string City { get; set; }

                /// <summary>
                /// <para>The code of the country or region where the domain name registrant is located, such as <b>CN</b> or <b>US</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("Country")]
                [Validation(Required=false)]
                public string Country { get; set; }

                /// <summary>
                /// <para>The time when the registrant profile was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-02-18 10:46:47</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The certificate number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4****************1</para>
                /// </summary>
                [NameInMap("CredentialNo")]
                [Validation(Required=false)]
                public string CredentialNo { get; set; }

                /// <summary>
                /// <para>The certificate type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>YYZZ</para>
                /// </summary>
                [NameInMap("CredentialType")]
                [Validation(Required=false)]
                public string CredentialType { get; set; }

                /// <summary>
                /// <para>Indicates whether the template is the default template. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// <para>Default value: <b>false</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DefaultRegistrantProfile")]
                [Validation(Required=false)]
                public bool? DefaultRegistrantProfile { get; set; }

                /// <summary>
                /// <para>The email address of the domain name registrant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>82106****@qq.com</para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>The status of the verification for the email address. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: not verified</description></item>
                /// <item><description><b>1</b>: verified</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("EmailVerificationStatus")]
                [Validation(Required=false)]
                public int? EmailVerificationStatus { get; set; }

                [NameInMap("Params")]
                [Validation(Required=false)]
                public string Params { get; set; }

                /// <summary>
                /// <para>The postal code of the region where the domain name registrant is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>310024</para>
                /// </summary>
                [NameInMap("PostalCode")]
                [Validation(Required=false)]
                public string PostalCode { get; set; }

                /// <summary>
                /// <para>The province where the domain name registrant is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zhe jiang</para>
                /// </summary>
                [NameInMap("Province")]
                [Validation(Required=false)]
                public string Province { get; set; }

                /// <summary>
                /// <para>The state of real-name verification for the domain name registrant. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>FAILED</b>: Real-name verification for the domain name fails.</description></item>
                /// <item><description><b>SUCCEED</b>: Real-name verification for the domain name is successful.</description></item>
                /// <item><description><b>NONAUDIT</b>: Real-name verification for the domain name is not performed.</description></item>
                /// <item><description><b>AUDITING</b>: Real-name verification for the domain name is in progress.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCEED</para>
                /// </summary>
                [NameInMap("RealNameStatus")]
                [Validation(Required=false)]
                public string RealNameStatus { get; set; }

                /// <summary>
                /// <para>The name of the domain name contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>li si</para>
                /// </summary>
                [NameInMap("RegistrantName")]
                [Validation(Required=false)]
                public string RegistrantName { get; set; }

                /// <summary>
                /// <para>The name of the domain name registrant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>li si</para>
                /// </summary>
                [NameInMap("RegistrantOrganization")]
                [Validation(Required=false)]
                public string RegistrantOrganization { get; set; }

                /// <summary>
                /// <para>The ID of the registrant profile.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000001</para>
                /// </summary>
                [NameInMap("RegistrantProfileId")]
                [Validation(Required=false)]
                public long? RegistrantProfileId { get; set; }

                /// <summary>
                /// <para>The type of the registrant profile. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>common</b>: common profile.</description></item>
                /// <item><description><b>cnnic</b>: CNNIC profile.</description></item>
                /// </list>
                /// <remarks>
                /// <para> Only the Alibaba Cloud international site (alibabacloud.com) supports CNNIC profiles. To register domain names provided by CNNIC such as the .cn and . domain names on the Alibaba Cloud international site, you must use a CNNIC profile. To register other domain names, use a common profile.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>common</para>
                /// </summary>
                [NameInMap("RegistrantProfileType")]
                [Validation(Required=false)]
                public string RegistrantProfileType { get; set; }

                /// <summary>
                /// <para>The type of the domain name registrant. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: individual.</description></item>
                /// <item><description><b>2</b>: enterprise.</description></item>
                /// </list>
                /// <para>Default value: <b>1</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RegistrantType")]
                [Validation(Required=false)]
                public string RegistrantType { get; set; }

                /// <summary>
                /// <para>The remarks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test domain name</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The international dialing code of the country or region where the domain name contact is located. For example, the international dialing code of China is <b>86</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86</para>
                /// </summary>
                [NameInMap("TelArea")]
                [Validation(Required=false)]
                public string TelArea { get; set; }

                /// <summary>
                /// <para>The extension of the phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("TelExt")]
                [Validation(Required=false)]
                public string TelExt { get; set; }

                /// <summary>
                /// <para>The phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1829756****</para>
                /// </summary>
                [NameInMap("Telephone")]
                [Validation(Required=false)]
                public string Telephone { get; set; }

                /// <summary>
                /// <para>The time when the registrant profile was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-03-15 15:32:45</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The address of the domain name registrant, in Chinese.</para>
                /// </summary>
                [NameInMap("ZhAddress")]
                [Validation(Required=false)]
                public string ZhAddress { get; set; }

                /// <summary>
                /// <para>The city where the domain name registrant is located, in Chinese.</para>
                /// </summary>
                [NameInMap("ZhCity")]
                [Validation(Required=false)]
                public string ZhCity { get; set; }

                /// <summary>
                /// <para>The province where the domain name registrant is located, in Chinese.</para>
                /// </summary>
                [NameInMap("ZhProvince")]
                [Validation(Required=false)]
                public string ZhProvince { get; set; }

                /// <summary>
                /// <para>The Chinese name of the domain name contact.</para>
                /// </summary>
                [NameInMap("ZhRegistrantName")]
                [Validation(Required=false)]
                public string ZhRegistrantName { get; set; }

                /// <summary>
                /// <para>The Chinese name of the domain name registrant.</para>
                /// </summary>
                [NameInMap("ZhRegistrantOrganization")]
                [Validation(Required=false)]
                public string ZhRegistrantOrganization { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94053D79-7455-4F71-BF06-20EB2DEDE6BD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// <remarks>
        /// <para> This parameter indicates the total number of queried registrant profiles. If multiple registrant profiles are queried, the information about these profiles is returned in sequence by profile.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        /// <summary>
        /// <para>The total number of returned pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
