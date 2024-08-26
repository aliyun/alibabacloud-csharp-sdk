// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryDomainListResponseBody : TeaModel {
        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        /// <summary>
        /// The domain names.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDomainListResponseBodyData Data { get; set; }
        public class QueryDomainListResponseBodyData : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public List<QueryDomainListResponseBodyDataDomain> Domain { get; set; }
            public class QueryDomainListResponseBodyDataDomain : TeaModel {
                /// <summary>
                /// The name of the domain name registrant.
                /// </summary>
                [NameInMap("Ccompany")]
                [Validation(Required=false)]
                public string Ccompany { get; set; }

                [NameInMap("ChgholderStatus")]
                [Validation(Required=false)]
                public string ChgholderStatus { get; set; }

                /// <summary>
                /// The state of real-name verification for the domain name. Valid values:
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
                /// The state of the domain name. Valid values:
                /// 
                /// *   **1**: The domain name needs to be renewed.
                /// *   **2**: The domain name needs to be redeemed.
                /// *   **3**: The domain name is normal.
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
                /// The validity period of the domain name. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
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
                /// The instance ID.
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
                /// The registration type of the domain name. Valid values:
                /// 
                /// *   **1**: individual
                /// *   **2**: enterprise
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
                /// Indicates how long the domain name has been registered. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("RegistrationDateLong")]
                [Validation(Required=false)]
                public long? RegistrationDateLong { get; set; }

                /// <summary>
                /// The remarks of the domain name.
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// The ID of the resource group to which the domain name belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The tags added to the resource.
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public QueryDomainListResponseBodyDataDomainTag Tag { get; set; }
                public class QueryDomainListResponseBodyDataDomainTag : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<QueryDomainListResponseBodyDataDomainTagTag> Tag { get; set; }
                    public class QueryDomainListResponseBodyDataDomainTagTag : TeaModel {
                        /// <summary>
                        /// The key of the tag added to the resource.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of the tag added to the resource.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// Indicates whether the current page is followed by a page.
        /// </summary>
        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Indicates whether the current page is preceded by a page.
        /// </summary>
        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of domain names returned.
        /// </summary>
        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        /// <summary>
        /// The total number of pages returned.
        /// </summary>
        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
