// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryDomainByDomainNameResponseBody : TeaModel {
        /// <summary>
        /// <para>The Domain Name System (DNS) servers of the domain name.</para>
        /// </summary>
        [NameInMap("DnsList")]
        [Validation(Required=false)]
        public QueryDomainByDomainNameResponseBodyDnsList DnsList { get; set; }
        public class QueryDomainByDomainNameResponseBodyDnsList : TeaModel {
            [NameInMap("Dns")]
            [Validation(Required=false)]
            public List<string> Dns { get; set; }

        }

        /// <summary>
        /// <para>The ID of the domain name group. You can call the <a href="https://help.aliyun.com/document_detail/69362.html">QueryDomainGroupList</a> operation to query the ID of the domain name group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("DomainGroupId")]
        [Validation(Required=false)]
        public long? DomainGroupId { get; set; }

        /// <summary>
        /// <para>The name of the domain name group.</para>
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
        /// <para>Indicates whether privacy protection is enabled for the domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DomainNameProxyService")]
        [Validation(Required=false)]
        public bool? DomainNameProxyService { get; set; }

        /// <summary>
        /// <para>The status of name auditing for the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NONAUDIT</b>: The name auditing for the domain name is not performed.</description></item>
        /// <item><description><b>SUCCEED</b>: The name auditing for the domain name is successful.</description></item>
        /// <item><description><b>FAILED</b>: The name auditing for the domain name fails.</description></item>
        /// <item><description><b>AUDITING</b>: The name auditing for the domain name is in progress.</description></item>
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
        /// <item><description>1: The domain name needs to be renewed.</description></item>
        /// <item><description>2: The domain name needs to be redeemed.</description></item>
        /// <item><description>3: The domain name is normal.</description></item>
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
        /// <item><description>New gTLD</description></item>
        /// <item><description>gTLD</description></item>
        /// <item><description>ccTLD</description></item>
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
        /// <para>Indicates whether the domain name is in the ClientHold state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EmailVerificationClientHold")]
        [Validation(Required=false)]
        public bool? EmailVerificationClientHold { get; set; }

        /// <summary>
        /// <para>Indicates whether the email address passes verification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The email address fails the verification.</description></item>
        /// <item><description><b>1</b>: The email address passes the verification.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EmailVerificationStatus")]
        [Validation(Required=false)]
        public int? EmailVerificationStatus { get; set; }

        /// <summary>
        /// <para>The number of days from the expiration date of the domain name to the current date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>356</para>
        /// </summary>
        [NameInMap("ExpirationCurrDateDiff")]
        [Validation(Required=false)]
        public int? ExpirationCurrDateDiff { get; set; }

        /// <summary>
        /// <para>The expiration date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-12-07 17:02:13</para>
        /// </summary>
        [NameInMap("ExpirationDate")]
        [Validation(Required=false)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// <para>The timestamp generated when the domain name expired.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1625111915000</para>
        /// </summary>
        [NameInMap("ExpirationDateLong")]
        [Validation(Required=false)]
        public long? ExpirationDateLong { get; set; }

        /// <summary>
        /// <para>Indicates whether the domain name expires. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: The domain name does not expire.</description></item>
        /// <item><description><b>2</b>: The domain name expires.</description></item>
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
        /// <para>Indicates whether the domain name is a premium domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Premium")]
        [Validation(Required=false)]
        public bool? Premium { get; set; }

        /// <summary>
        /// <para>The status of real-name verification for the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NONAUDIT</b>: The real-name verification is not performed.</description></item>
        /// <item><description><b>SUCCEED</b>: The real-name verification is successful.</description></item>
        /// <item><description><b>FAILED</b>: The real-name verification fails.</description></item>
        /// <item><description><b>AUDITING</b>: The real-name verification is in progress.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NONAUDIT</para>
        /// </summary>
        [NameInMap("RealNameStatus")]
        [Validation(Required=false)]
        public string RealNameStatus { get; set; }

        /// <summary>
        /// <para>The name of the contact.</para>
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
        /// <para>The type of contact who registers the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: individual.</description></item>
        /// <item><description><b>2</b>: enterprise.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RegistrantType")]
        [Validation(Required=false)]
        public string RegistrantType { get; set; }

        /// <summary>
        /// <para>The status of the information about the domain name registrant. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PENDING</b>: The information about the domain name registrant is being modified.</description></item>
        /// <item><description><b>NORMAL</b>: normal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("RegistrantUpdatingStatus")]
        [Validation(Required=false)]
        public string RegistrantUpdatingStatus { get; set; }

        /// <summary>
        /// <para>The time when the domain name was registered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-07 17:02:13</para>
        /// </summary>
        [NameInMap("RegistrationDate")]
        [Validation(Required=false)]
        public string RegistrationDate { get; set; }

        /// <summary>
        /// <para>The timestamp generated when the domain name was registered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1584675448000</para>
        /// </summary>
        [NameInMap("RegistrationDateLong")]
        [Validation(Required=false)]
        public long? RegistrationDateLong { get; set; }

        /// <summary>
        /// <para>The remarks on the domain name.</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
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
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public QueryDomainByDomainNameResponseBodyTag Tag { get; set; }
        public class QueryDomainByDomainNameResponseBodyTag : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<QueryDomainByDomainNameResponseBodyTagTag> Tag { get; set; }
            public class QueryDomainByDomainNameResponseBodyTagTag : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// </summary>
                [NameInMap("Vaue")]
                [Validation(Required=false)]
                public string Vaue { get; set; }

            }

        }

        /// <summary>
        /// <para>The transfer status of the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NORMAL</b>: The domain name is normal.</description></item>
        /// <item><description><b>PENDING</b>: The domain name is being transferred out from Alibaba Cloud.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("TransferOutStatus")]
        [Validation(Required=false)]
        public string TransferOutStatus { get; set; }

        /// <summary>
        /// <para>The status of the transfer lock for the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NONE_SETTING</b>: No transfer lock is configured.</description></item>
        /// <item><description><b>OPEN</b>: The transfer lock is enabled.</description></item>
        /// <item><description><b>CLOSE</b>: The transfer lock is disabled.</description></item>
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
        /// <item><description><b>NONE_SETTING</b>: No security lock is configured.</description></item>
        /// <item><description><b>OPEN</b>: The security lock is enabled.</description></item>
        /// <item><description><b>CLOSE</b>: The security lock is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CLOSE</para>
        /// </summary>
        [NameInMap("UpdateProhibitionLock")]
        [Validation(Required=false)]
        public string UpdateProhibitionLock { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>121000000****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

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
