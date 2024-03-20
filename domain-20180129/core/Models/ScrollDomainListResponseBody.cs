// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class ScrollDomainListResponseBody : TeaModel {
        /// <summary>
        /// The domain names.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ScrollDomainListResponseBodyData Data { get; set; }
        public class ScrollDomainListResponseBodyData : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public List<ScrollDomainListResponseBodyDataDomain> Domain { get; set; }
            public class ScrollDomainListResponseBodyDataDomain : TeaModel {
                /// <summary>
                /// The Domain Name System (DNS) servers of the domain name.
                /// </summary>
                [NameInMap("DnsList")]
                [Validation(Required=false)]
                public ScrollDomainListResponseBodyDataDomainDnsList DnsList { get; set; }
                public class ScrollDomainListResponseBodyDataDomainDnsList : TeaModel {
                    [NameInMap("Dns")]
                    [Validation(Required=false)]
                    public List<string> Dns { get; set; }

                }

                /// <summary>
                /// The status of real-name verification for the domain name. Valid values:
                /// 
                /// *   **FAILED**: Real-name verification for the domain name fails.
                /// *   **SUCCEED**: Real-name verification for the domain name is successful.
                /// *   **NONAUDIT**: Real-name verification for the domain name is not performed.
                /// *   **AUDITING**: Real-name verification for the domain name is in progress.
                /// </summary>
                [NameInMap("DomainAuditStatus")]
                [Validation(Required=false)]
                public string DomainAuditStatus { get; set; }

                /// <summary>
                /// The ID of the domain name group.
                /// </summary>
                [NameInMap("DomainGroupId")]
                [Validation(Required=false)]
                public string DomainGroupId { get; set; }

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
                /// The status of the domain name. Valid values:
                /// 
                /// *   **1**: The domain name needs to be renewed.
                /// *   **2**: The domain name needs to be redeemed.
                /// *   **3**: The domain name is normal.
                /// *   **4**: The domain name is being transferred out.
                /// *   **5**: The information about the domain name registrant is being modified.
                /// *   **6**: Real-name verification is not performed on the domain name.
                /// *   **7**: Real-name verification for the domain name fails.
                /// *   **8**: The real-name verification is being reviewed.
                /// </summary>
                [NameInMap("DomainStatus")]
                [Validation(Required=false)]
                public string DomainStatus { get; set; }

                /// <summary>
                /// The type of the domain name. Valid values:
                /// 
                /// *   **New gTLD**
                /// *   **gTLD**
                /// *   **ccTLD**
                /// </summary>
                [NameInMap("DomainType")]
                [Validation(Required=false)]
                public string DomainType { get; set; }

                /// <summary>
                /// The email address.
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// The number of days from the expiration date of the domain name to the current date.
                /// </summary>
                [NameInMap("ExpirationCurrDateDiff")]
                [Validation(Required=false)]
                public int? ExpirationCurrDateDiff { get; set; }

                /// <summary>
                /// The time when the domain name expires.
                /// </summary>
                [NameInMap("ExpirationDate")]
                [Validation(Required=false)]
                public string ExpirationDate { get; set; }

                /// <summary>
                /// The time when the domain name expires. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
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
                /// The service ID.
                /// </summary>
                [NameInMap("ProductId")]
                [Validation(Required=false)]
                public string ProductId { get; set; }

                /// <summary>
                /// The registrant of the domain name.
                /// </summary>
                [NameInMap("RegistrantOrganization")]
                [Validation(Required=false)]
                public string RegistrantOrganization { get; set; }

                /// <summary>
                /// The registration type of the domain name. Valid values:
                /// 
                /// *   **1**: individual.
                /// *   **2**: enterprise.
                /// </summary>
                [NameInMap("RegistrantType")]
                [Validation(Required=false)]
                public string RegistrantType { get; set; }

                /// <summary>
                /// The time when the domain name was registered.
                /// </summary>
                [NameInMap("RegistrationDate")]
                [Validation(Required=false)]
                public string RegistrationDate { get; set; }

                /// <summary>
                /// The time when the domain name was registered. This value is a UNIX timestamp that indicates the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
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
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The resource tag.
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public ScrollDomainListResponseBodyDataDomainTag Tag { get; set; }
                public class ScrollDomainListResponseBodyDataDomainTag : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<ScrollDomainListResponseBodyDataDomainTagTag> Tag { get; set; }
                    public class ScrollDomainListResponseBodyDataDomainTagTag : TeaModel {
                        /// <summary>
                        /// The tag key.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The tag value.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The Chinese name of the domain name registrant.
                /// </summary>
                [NameInMap("ZhRegistrantOrganization")]
                [Validation(Required=false)]
                public string ZhRegistrantOrganization { get; set; }

            }

        }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The scroll ID.
        /// </summary>
        [NameInMap("ScrollId")]
        [Validation(Required=false)]
        public string ScrollId { get; set; }

        /// <summary>
        /// The number of remaining domain names to be queried.
        /// </summary>
        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

    }

}
