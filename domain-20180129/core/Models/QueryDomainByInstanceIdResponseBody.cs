// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryDomainByInstanceIdResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>UN_SUPPORT</para>
        /// </summary>
        [NameInMap("CnnicPrivacyServiceStatus")]
        [Validation(Required=false)]
        public string CnnicPrivacyServiceStatus { get; set; }

        [NameInMap("DnsList")]
        [Validation(Required=false)]
        public QueryDomainByInstanceIdResponseBodyDnsList DnsList { get; set; }
        public class QueryDomainByInstanceIdResponseBodyDnsList : TeaModel {
            [NameInMap("Dns")]
            [Validation(Required=false)]
            public List<string> Dns { get; set; }

        }

        /// <summary>
        /// <para>The ID of the domain name group. You can call the <a href="https://help.aliyun.com/document_detail/69362.html">QueryDomainGroupList</a> operation to obtain the ID of the domain name group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("DomainGroupId")]
        [Validation(Required=false)]
        public long? DomainGroupId { get; set; }

        /// <summary>
        /// <para>The name of the domain name group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试分组</para>
        /// </summary>
        [NameInMap("DomainGroupName")]
        [Validation(Required=false)]
        public string DomainGroupName { get; set; }

        [NameInMap("DomainLifecycleStatus")]
        [Validation(Required=false)]
        public string DomainLifecycleStatus { get; set; }

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
        /// <para>Indicates whether the domain name privacy protection service is enabled.</para>
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
        /// <item><description><para><b>NONAUDIT</b>: The domain name is not verified.</para>
        /// </description></item>
        /// <item><description><para><b>SUCCEED</b>: The domain name is verified.</para>
        /// </description></item>
        /// <item><description><para><b>FAILED</b>: The domain name fails to be verified.</para>
        /// </description></item>
        /// <item><description><para><b>AUDITING</b>: The domain name is being verified.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NONAUDIT</para>
        /// </summary>
        [NameInMap("DomainNameVerificationStatus")]
        [Validation(Required=false)]
        public string DomainNameVerificationStatus { get; set; }

        /// <summary>
        /// <para>The status of the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1: The domain name needs to be renewed.</para>
        /// </description></item>
        /// <item><description><para>2: The domain name needs to be redeemed.</para>
        /// </description></item>
        /// <item><description><para>3: The domain name is normal.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DomainStatus")]
        [Validation(Required=false)]
        public string DomainStatus { get; set; }

        /// <summary>
        /// <para>The type of the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>New gTLD.</para>
        /// </description></item>
        /// <item><description><para>gTLD.</para>
        /// </description></item>
        /// <item><description><para>ccTLD.</para>
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
        /// <para>The email address of the domain name registrant.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:username@example.com">username@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>Indicates whether the DNS resolution for the domain name is suspended. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b>: The DNS resolution for the domain name is not suspended.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: The DNS resolution for the domain name is suspended.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EmailVerificationClientHold")]
        [Validation(Required=false)]
        public bool? EmailVerificationClientHold { get; set; }

        /// <summary>
        /// <para>Indicates whether the email address of the domain name registrant is verified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: The email address is not verified.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: The email address is verified.</para>
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
        /// <para>The number of days from the expiration date to the current date.</para>
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
        /// <para>The expiration timestamp of the domain name.</para>
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
        /// <para>S20179H1BBI9test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Indicates whether the domain name is a premium domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: a premium domain name.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: not a premium domain name.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Premium")]
        [Validation(Required=false)]
        public bool? Premium { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UN_SUPPORT</para>
        /// </summary>
        [NameInMap("PrivacyServiceStatus")]
        [Validation(Required=false)]
        public string PrivacyServiceStatus { get; set; }

        /// <summary>
        /// <para>The real-name verification status of the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NONAUDIT</b>: The real-name verification is not performed.</para>
        /// </description></item>
        /// <item><description><para><b>SUCCEED</b>: The real-name verification is successful.</para>
        /// </description></item>
        /// <item><description><para><b>FAILED</b>: The real-name verification fails.</para>
        /// </description></item>
        /// <item><description><para><b>AUDITING</b>: The real-name verification is in progress.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The real-name verification status of a domain name is a composite status of domain name review and real-name verification. The real-name verification of a domain name is successful only when both the domain name review and real-name verification are successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>NONAUDIT</para>
        /// </summary>
        [NameInMap("RealNameStatus")]
        [Validation(Required=false)]
        public string RealNameStatus { get; set; }

        /// <summary>
        /// <para>The name of the contact person.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test litm</para>
        /// </summary>
        [NameInMap("RegistrantName")]
        [Validation(Required=false)]
        public string RegistrantName { get; set; }

        /// <summary>
        /// <para>The registrant of the domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test litm</para>
        /// </summary>
        [NameInMap("RegistrantOrganization")]
        [Validation(Required=false)]
        public string RegistrantOrganization { get; set; }

        /// <summary>
        /// <para>The type of the domain name registrant. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: an individual.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: an enterprise.</para>
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
        /// <para>The status of the domain name registrant. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PENDING</b>: The information about the domain name registrant is being modified.</para>
        /// </description></item>
        /// <item><description><para><b>NORMAL</b>: The information about the domain name registrant is not being modified.</para>
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
        /// <para>The registration date of the domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-07 17:02:13</para>
        /// </summary>
        [NameInMap("RegistrationDate")]
        [Validation(Required=false)]
        public string RegistrationDate { get; set; }

        /// <summary>
        /// <para>The registration timestamp of the domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1625111915000</para>
        /// </summary>
        [NameInMap("RegistrationDateLong")]
        [Validation(Required=false)]
        public long? RegistrationDateLong { get; set; }

        /// <summary>
        /// <para>The remarks of the domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试备注</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23C9B3C4-9E2C-4405-A88D-BD33E459D140</para>
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

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public QueryDomainByInstanceIdResponseBodyTag Tag { get; set; }
        public class QueryDomainByInstanceIdResponseBodyTag : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<QueryDomainByInstanceIdResponseBodyTagTag> Tag { get; set; }
            public class QueryDomainByInstanceIdResponseBodyTagTag : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The status of the domain name transfer. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NORMAL</b>: The domain name is not being transferred out of Alibaba Cloud.</para>
        /// </description></item>
        /// <item><description><para><b>PENDING</b>: The domain name is being transferred out of Alibaba Cloud.</para>
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
        /// <para>The status of the domain name transfer lock. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NONE_SETTING</b>: The domain name transfer lock is not enabled.</para>
        /// </description></item>
        /// <item><description><para><b>OPEN</b>: The domain name transfer lock is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>CLOSE</b>: The domain name transfer lock is disabled.</para>
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
        /// <para>The status of the security lock for the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NONE_SETTING</b>: The security lock is not enabled.</para>
        /// </description></item>
        /// <item><description><para><b>OPEN</b>: The security lock is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>CLOSE</b>: The security lock is disabled.</para>
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
        /// <para>The user ID (UID) of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>121000000****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The contact person in Chinese.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to the China site.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>李四</para>
        /// </summary>
        [NameInMap("ZhRegistrantName")]
        [Validation(Required=false)]
        public string ZhRegistrantName { get; set; }

        /// <summary>
        /// <para>The registrant of the domain name in Chinese.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to the China site.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>李四</para>
        /// </summary>
        [NameInMap("ZhRegistrantOrganization")]
        [Validation(Required=false)]
        public string ZhRegistrantOrganization { get; set; }

    }

}
