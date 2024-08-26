// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryDomainListRequest : TeaModel {
        /// <summary>
        /// The name of the domain name registrant.
        /// </summary>
        [NameInMap("Ccompany")]
        [Validation(Required=false)]
        public string Ccompany { get; set; }

        /// <summary>
        /// The ID of the domain name group.
        /// </summary>
        [NameInMap("DomainGroupId")]
        [Validation(Required=false)]
        public string DomainGroupId { get; set; }

        /// <summary>
        /// The domain name that you want to search for.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The end of the time range to query domain names based on expiration dates. Set the value to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. Only queries by day are supported.
        /// </summary>
        [NameInMap("EndExpirationDate")]
        [Validation(Required=false)]
        public long? EndExpirationDate { get; set; }

        /// <summary>
        /// The end of the time range to query domain names based on registration dates. Set the value to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. Only queries by day are supported.
        /// </summary>
        [NameInMap("EndRegistrationDate")]
        [Validation(Required=false)]
        public long? EndRegistrationDate { get; set; }

        /// <summary>
        /// The language of the error message to return if the request fails. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// 
        /// Default value: **en**.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The order of the information based on which the domain names are sorted, such as the registration date and expiration date. Valid values:
        /// 
        /// *   **ASC**: ascending order
        /// *   **DESC**: descending order
        /// 
        /// >  If this parameter is not specified, the default value **DESC** is used.
        /// </summary>
        [NameInMap("OrderByType")]
        [Validation(Required=false)]
        public string OrderByType { get; set; }

        /// <summary>
        /// The field that you use to sort the domain names. Valid values:
        /// 
        /// *   **RegistrationDate**: registration date
        /// *   **ExpirationDate**: expiration date
        /// 
        /// >  If this parameter is not specified, the domain names are sorted by the time when they were added to the database.
        /// </summary>
        [NameInMap("OrderKeyType")]
        [Validation(Required=false)]
        public string OrderKeyType { get; set; }

        /// <summary>
        /// The page number.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The type of the domain name. Valid values:
        /// 
        /// *   **New gTLD**: new generic top-level domain names
        /// *   **gTLD**: generic top-level domain names
        /// *   **ccTLD**: country code top-level domain names
        /// </summary>
        [NameInMap("ProductDomainType")]
        [Validation(Required=false)]
        public string ProductDomainType { get; set; }

        /// <summary>
        /// The category of the domain names that you want to query. Valid values:
        /// 
        /// *   **1**: the domain names that need to be renewed
        /// *   **2**: the domain names that need to be redeemed
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The beginning of the time range to query domain names based on expiration dates. Set the value to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. Only queries by day are supported.
        /// </summary>
        [NameInMap("StartExpirationDate")]
        [Validation(Required=false)]
        public long? StartExpirationDate { get; set; }

        /// <summary>
        /// The beginning of the time range to query domain names based on registration dates. Set the value to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. Only queries by day are supported.
        /// </summary>
        [NameInMap("StartRegistrationDate")]
        [Validation(Required=false)]
        public long? StartRegistrationDate { get; set; }

        /// <summary>
        /// The tags to add to the resource.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<QueryDomainListRequestTag> Tag { get; set; }
        public class QueryDomainListRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag to add to the resource.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag to add to the resource.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The IP address of the client. Set the value to **127.0.0.1**.
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
