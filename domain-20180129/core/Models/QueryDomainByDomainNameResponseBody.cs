// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryDomainByDomainNameResponseBody : TeaModel {
        /// <summary>
        /// The Domain Name System (DNS) servers of the domain name.
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
        /// The ID of the domain name group. You can call the [QueryDomainGroupList](https://help.aliyun.com/document_detail/69362.html) operation to query the ID of the domain name group.
        /// </summary>
        [NameInMap("DomainGroupId")]
        [Validation(Required=false)]
        public long? DomainGroupId { get; set; }

        /// <summary>
        /// The name of the domain name group.
        /// </summary>
        [NameInMap("DomainGroupName")]
        [Validation(Required=false)]
        public string DomainGroupName { get; set; }

        /// <summary>
        /// The domain name.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// Indicates whether privacy protection is enabled for the domain name.
        /// </summary>
        [NameInMap("DomainNameProxyService")]
        [Validation(Required=false)]
        public bool? DomainNameProxyService { get; set; }

        /// <summary>
        /// The status of name auditing for the domain name. Valid values:
        /// 
        /// *   **NONAUDIT**: The name auditing for the domain name is not performed.
        /// *   **SUCCEED**: The name auditing for the domain name is successful.
        /// *   **FAILED**: The name auditing for the domain name fails.
        /// *   **AUDITING**: The name auditing for the domain name is in progress.
        /// </summary>
        [NameInMap("DomainNameVerificationStatus")]
        [Validation(Required=false)]
        public string DomainNameVerificationStatus { get; set; }

        /// <summary>
        /// The status of the domain name. Valid values:
        /// 
        /// *   1: The domain name needs to be renewed.
        /// *   2: The domain name needs to be redeemed.
        /// *   3: The domain name is normal.
        /// </summary>
        [NameInMap("DomainStatus")]
        [Validation(Required=false)]
        public string DomainStatus { get; set; }

        /// <summary>
        /// The type of the domain name. Valid values:
        /// 
        /// *   New gTLD
        /// *   gTLD
        /// *   ccTLD
        /// </summary>
        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        /// <summary>
        /// The email address of the domain name registrant.
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// Indicates whether the domain name is in the ClientHold state.
        /// </summary>
        [NameInMap("EmailVerificationClientHold")]
        [Validation(Required=false)]
        public bool? EmailVerificationClientHold { get; set; }

        /// <summary>
        /// Indicates whether the email address passes verification. Valid values:
        /// 
        /// *   **0**: The email address fails the verification.
        /// *   **1**: The email address passes the verification.
        /// </summary>
        [NameInMap("EmailVerificationStatus")]
        [Validation(Required=false)]
        public int? EmailVerificationStatus { get; set; }

        /// <summary>
        /// The number of days from the expiration date of the domain name to the current date.
        /// </summary>
        [NameInMap("ExpirationCurrDateDiff")]
        [Validation(Required=false)]
        public int? ExpirationCurrDateDiff { get; set; }

        /// <summary>
        /// The expiration date.
        /// </summary>
        [NameInMap("ExpirationDate")]
        [Validation(Required=false)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// The timestamp generated when the domain name expired.
        /// </summary>
        [NameInMap("ExpirationDateLong")]
        [Validation(Required=false)]
        public long? ExpirationDateLong { get; set; }

        /// <summary>
        /// Indicates whether the domain name expires. Valid values:
        /// 
        /// *   **1**: The domain name does not expire.
        /// *   **2**: The domain name expires.
        /// </summary>
        [NameInMap("ExpirationDateStatus")]
        [Validation(Required=false)]
        public string ExpirationDateStatus { get; set; }

        /// <summary>
        /// The instance ID of the domain name.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Indicates whether the domain name is a premium domain name.
        /// </summary>
        [NameInMap("Premium")]
        [Validation(Required=false)]
        public bool? Premium { get; set; }

        /// <summary>
        /// The status of real-name verification for the domain name. Valid values:
        /// 
        /// *   **NONAUDIT**: The real-name verification is not performed.
        /// *   **SUCCEED**: The real-name verification is successful.
        /// *   **FAILED**: The real-name verification fails.
        /// *   **AUDITING**: The real-name verification is in progress.
        /// </summary>
        [NameInMap("RealNameStatus")]
        [Validation(Required=false)]
        public string RealNameStatus { get; set; }

        /// <summary>
        /// The name of the contact.
        /// </summary>
        [NameInMap("RegistrantName")]
        [Validation(Required=false)]
        public string RegistrantName { get; set; }

        /// <summary>
        /// The registrant of the domain name.
        /// </summary>
        [NameInMap("RegistrantOrganization")]
        [Validation(Required=false)]
        public string RegistrantOrganization { get; set; }

        /// <summary>
        /// The type of contact who registers the domain name. Valid values:
        /// 
        /// *   **1**: individual.
        /// *   **2**: enterprise.
        /// </summary>
        [NameInMap("RegistrantType")]
        [Validation(Required=false)]
        public string RegistrantType { get; set; }

        /// <summary>
        /// The status of the information about the domain name registrant. Valid values:
        /// 
        /// *   **PENDING**: The information about the domain name registrant is being modified.
        /// *   **NORMAL**: normal.
        /// </summary>
        [NameInMap("RegistrantUpdatingStatus")]
        [Validation(Required=false)]
        public string RegistrantUpdatingStatus { get; set; }

        /// <summary>
        /// The time when the domain name was registered.
        /// </summary>
        [NameInMap("RegistrationDate")]
        [Validation(Required=false)]
        public string RegistrationDate { get; set; }

        /// <summary>
        /// The timestamp generated when the domain name was registered.
        /// </summary>
        [NameInMap("RegistrationDateLong")]
        [Validation(Required=false)]
        public long? RegistrationDateLong { get; set; }

        /// <summary>
        /// The remarks on the domain name.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The tags.
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
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Vaue")]
                [Validation(Required=false)]
                public string Vaue { get; set; }

            }

        }

        /// <summary>
        /// The transfer status of the domain name. Valid values:
        /// 
        /// *   **NORMAL**: The domain name is normal.
        /// *   **PENDING**: The domain name is being transferred out from Alibaba Cloud.
        /// </summary>
        [NameInMap("TransferOutStatus")]
        [Validation(Required=false)]
        public string TransferOutStatus { get; set; }

        /// <summary>
        /// The status of the transfer lock for the domain name. Valid values:
        /// 
        /// *   **NONE_SETTING**: No transfer lock is configured.
        /// *   **OPEN**: The transfer lock is enabled.
        /// *   **CLOSE**: The transfer lock is disabled.
        /// </summary>
        [NameInMap("TransferProhibitionLock")]
        [Validation(Required=false)]
        public string TransferProhibitionLock { get; set; }

        /// <summary>
        /// The status of the security lock for the domain name. Valid values:
        /// 
        /// *   **NONE_SETTING**: No security lock is configured.
        /// *   **OPEN**: The security lock is enabled.
        /// *   **CLOSE**: The security lock is disabled.
        /// </summary>
        [NameInMap("UpdateProhibitionLock")]
        [Validation(Required=false)]
        public string UpdateProhibitionLock { get; set; }

        /// <summary>
        /// The user ID.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// The Chinese name of the domain name contact.
        /// </summary>
        [NameInMap("ZhRegistrantName")]
        [Validation(Required=false)]
        public string ZhRegistrantName { get; set; }

        /// <summary>
        /// The Chinese name of the domain name registrant.
        /// </summary>
        [NameInMap("ZhRegistrantOrganization")]
        [Validation(Required=false)]
        public string ZhRegistrantOrganization { get; set; }

    }

}
