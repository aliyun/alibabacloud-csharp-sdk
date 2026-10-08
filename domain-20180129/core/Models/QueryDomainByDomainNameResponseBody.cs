// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryDomainByDomainNameResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the privacy protection service for .cn domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UN_SUPPORT</para>
        /// </summary>
        [NameInMap("CnnicPrivacyServiceStatus")]
        [Validation(Required=false)]
        public string CnnicPrivacyServiceStatus { get; set; }

        [NameInMap("DnsList")]
        [Validation(Required=false)]
        public QueryDomainByDomainNameResponseBodyDnsList DnsList { get; set; }
        public class QueryDomainByDomainNameResponseBodyDnsList : TeaModel {
            [NameInMap("Dns")]
            [Validation(Required=false)]
            public List<string> Dns { get; set; }

        }

        /// <summary>
        /// <para>The ID of the domain group. You can obtain the ID by calling the <a href="https://help.aliyun.com/document_detail/69362.html">QueryDomainGroupList</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("DomainGroupId")]
        [Validation(Required=false)]
        public long? DomainGroupId { get; set; }

        /// <summary>
        /// <para>The name of the domain group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试分组</para>
        /// </summary>
        [NameInMap("DomainGroupName")]
        [Validation(Required=false)]
        public string DomainGroupName { get; set; }

        /// <summary>
        /// <para>The domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Indicates whether privacy protection is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DomainNameProxyService")]
        [Validation(Required=false)]
        public bool? DomainNameProxyService { get; set; }

        /// <summary>
        /// <para>The status of the domain name review. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NONAUDIT</b>: Not reviewed.</para>
        /// </description></item>
        /// <item><description><para><b>SUCCEED</b>: Successful.</para>
        /// </description></item>
        /// <item><description><para><b>FAILED</b>: Failed.</para>
        /// </description></item>
        /// <item><description><para><b>AUDITING</b>: In review.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCEED</para>
        /// </summary>
        [NameInMap("DomainNameVerificationStatus")]
        [Validation(Required=false)]
        public string DomainNameVerificationStatus { get; set; }

        /// <summary>
        /// <para>The status of the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Renewal required.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Redemption required.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: Active.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DomainStatus")]
        [Validation(Required=false)]
        public string DomainStatus { get; set; }

        /// <summary>
        /// <para>The type of the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>New gTLD</para>
        /// </description></item>
        /// <item><description><para>gTLD</para>
        /// </description></item>
        /// <item><description><para>ccTLD</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>gTLD</para>
        /// </summary>
        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        /// <summary>
        /// <para>The registrant\&quot;s email.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:username@example.com">username@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>Indicates whether the domain name has a <c>clientHold</c> status due to email verification failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EmailVerificationClientHold")]
        [Validation(Required=false)]
        public bool? EmailVerificationClientHold { get; set; }

        /// <summary>
        /// <para>The email verification status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Not verified.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Verified.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EmailVerificationStatus")]
        [Validation(Required=false)]
        public int? EmailVerificationStatus { get; set; }

        /// <summary>
        /// <para>The number of days until the expiration date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>356</para>
        /// </summary>
        [NameInMap("ExpirationCurrDateDiff")]
        [Validation(Required=false)]
        public int? ExpirationCurrDateDiff { get; set; }

        /// <summary>
        /// <para>The expiration date of the domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-12-07 17:02:13</para>
        /// </summary>
        [NameInMap("ExpirationDate")]
        [Validation(Required=false)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// <para>The timestamp of the expiration date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1625111915000</para>
        /// </summary>
        [NameInMap("ExpirationDateLong")]
        [Validation(Required=false)]
        public long? ExpirationDateLong { get; set; }

        /// <summary>
        /// <para>The expiration status of the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: The domain name has not expired.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: The domain name has expired.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ExpirationDateStatus")]
        [Validation(Required=false)]
        public string ExpirationDateStatus { get; set; }

        /// <summary>
        /// <para>The instance ID of the domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S20179H1BBI9****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Indicates whether the domain name is a premium domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Premium")]
        [Validation(Required=false)]
        public bool? Premium { get; set; }

        /// <summary>
        /// <para>The status of the privacy protection service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UN_SUPPORT</para>
        /// </summary>
        [NameInMap("PrivacyServiceStatus")]
        [Validation(Required=false)]
        public string PrivacyServiceStatus { get; set; }

        /// <summary>
        /// <para>The real-name verification status of the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NONAUDIT</b>: Not verified.</para>
        /// </description></item>
        /// <item><description><para><b>SUCCEED</b>: Successful.</para>
        /// </description></item>
        /// <item><description><para><b>FAILED</b>: Failed.</para>
        /// </description></item>
        /// <item><description><para><b>AUDITING</b>: In review.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NONAUDIT</para>
        /// </summary>
        [NameInMap("RealNameStatus")]
        [Validation(Required=false)]
        public string RealNameStatus { get; set; }

        /// <summary>
        /// <para>The name of the individual registrant or the contact person for an organization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test litm</para>
        /// </summary>
        [NameInMap("RegistrantName")]
        [Validation(Required=false)]
        public string RegistrantName { get; set; }

        /// <summary>
        /// <para>The name of the registrant organization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test litm</para>
        /// </summary>
        [NameInMap("RegistrantOrganization")]
        [Validation(Required=false)]
        public string RegistrantOrganization { get; set; }

        /// <summary>
        /// <para>The type of the registrant. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Individual.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Enterprise.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RegistrantType")]
        [Validation(Required=false)]
        public string RegistrantType { get; set; }

        /// <summary>
        /// <para>The status of registrant information updates. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PENDING</b>: The registrant information is being updated.</para>
        /// </description></item>
        /// <item><description><para><b>NORMAL</b>: No update is in progress.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("RegistrantUpdatingStatus")]
        [Validation(Required=false)]
        public string RegistrantUpdatingStatus { get; set; }

        /// <summary>
        /// <para>The registrar of the domain name.</para>
        /// </summary>
        [NameInMap("Registrar")]
        [Validation(Required=false)]
        public string Registrar { get; set; }

        /// <summary>
        /// <para>The registration date of the domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-07 17:02:13</para>
        /// </summary>
        [NameInMap("RegistrationDate")]
        [Validation(Required=false)]
        public string RegistrationDate { get; set; }

        /// <summary>
        /// <para>The timestamp of the registration date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1584675448000</para>
        /// </summary>
        [NameInMap("RegistrationDateLong")]
        [Validation(Required=false)]
        public long? RegistrationDateLong { get; set; }

        /// <summary>
        /// <para>The user-provided remark for the domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试备注</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44101664-3E70-4F0E-89E5-CCB74BF*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmw6bpc6n7zai</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags attached to the domain name.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public QueryDomainByDomainNameResponseBodyTag Tag { get; set; }
        public class QueryDomainByDomainNameResponseBodyTag : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<QueryDomainByDomainNameResponseBodyTagTag> Tag { get; set; }
            public class QueryDomainByDomainNameResponseBodyTagTag : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Vaue")]
                [Validation(Required=false)]
                public string Vaue { get; set; }

            }

        }

        /// <summary>
        /// <para>The status of the domain transfer out. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NORMAL</b>: The domain name is not being transferred out.</para>
        /// </description></item>
        /// <item><description><para><b>PENDING</b>: The domain name is being transferred out from HiChina.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("TransferOutStatus")]
        [Validation(Required=false)]
        public string TransferOutStatus { get; set; }

        /// <summary>
        /// <para>The status of the domain transfer lock. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NONE_SETTING</b>: Not set.</para>
        /// </description></item>
        /// <item><description><para><b>OPEN</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>CLOSE</b>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CLOSE</para>
        /// </summary>
        [NameInMap("TransferProhibitionLock")]
        [Validation(Required=false)]
        public string TransferProhibitionLock { get; set; }

        /// <summary>
        /// <para>The status of the domain name security lock. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NONE_SETTING</b>: Not set.</para>
        /// </description></item>
        /// <item><description><para><b>OPEN</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>CLOSE</b>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CLOSE</para>
        /// </summary>
        [NameInMap("UpdateProhibitionLock")]
        [Validation(Required=false)]
        public string UpdateProhibitionLock { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>121000000****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The name of the contact person in Chinese.</para>
        /// 
        /// <b>Example:</b>
        /// <para>王先生</para>
        /// </summary>
        [NameInMap("ZhRegistrantName")]
        [Validation(Required=false)]
        public string ZhRegistrantName { get; set; }

        /// <summary>
        /// <para>The name of the registrant in Chinese.</para>
        /// 
        /// <b>Example:</b>
        /// <para>王先生</para>
        /// </summary>
        [NameInMap("ZhRegistrantOrganization")]
        [Validation(Required=false)]
        public string ZhRegistrantOrganization { get; set; }

    }

}
