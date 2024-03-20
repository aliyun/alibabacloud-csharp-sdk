// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class ScrollDomainListRequest : TeaModel {
        /// <summary>
        /// The ID of the domain name group. You can call the [QueryDomainGroupList](https://help.aliyun.com/document_detail/69362.html) operation to obtain the ID of the domain name group.
        /// </summary>
        [NameInMap("DomainGroupId")]
        [Validation(Required=false)]
        public long? DomainGroupId { get; set; }

        /// <summary>
        /// The status of the domain name. Valid values:
        /// 
        /// *   **0**: All.
        /// *   **1**: The domain name needs to be renewed.
        /// *   **2**: The domain name needs to be redeemed.
        /// *   **3**: The domain name is normal.
        /// *   **4**: The domain name is being transferred from Alibaba Cloud.
        /// *   **5**: The information about the domain name registrant is being modified.
        /// *   **6**: Real-name verification is not performed on the domain name.
        /// *   **7**: Real-name verification for the domain name fails. Real-name reverification is required.
        /// *   **8**: The domain name is being reviewed.
        /// </summary>
        [NameInMap("DomainStatus")]
        [Validation(Required=false)]
        public int? DomainStatus { get; set; }

        /// <summary>
        /// The end of the time range to query domain names based on expiration dates. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("EndExpirationDate")]
        [Validation(Required=false)]
        public long? EndExpirationDate { get; set; }

        /// <summary>
        /// The end of domain name length to query.
        /// </summary>
        [NameInMap("EndLength")]
        [Validation(Required=false)]
        public int? EndLength { get; set; }

        /// <summary>
        /// The end of the time range to query domain names based on registration dates. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("EndRegistrationDate")]
        [Validation(Required=false)]
        public long? EndRegistrationDate { get; set; }

        /// <summary>
        /// The keyword that is used to exclude domain names.
        /// </summary>
        [NameInMap("Excluded")]
        [Validation(Required=false)]
        public string Excluded { get; set; }

        /// <summary>
        /// Specifies whether to exclude the prefix keyword.
        /// </summary>
        [NameInMap("ExcludedPrefix")]
        [Validation(Required=false)]
        public bool? ExcludedPrefix { get; set; }

        /// <summary>
        /// Specifies whether to exclude the suffix keyword.
        /// </summary>
        [NameInMap("ExcludedSuffix")]
        [Validation(Required=false)]
        public bool? ExcludedSuffix { get; set; }

        /// <summary>
        /// The composition of the domain name.
        /// </summary>
        [NameInMap("Form")]
        [Validation(Required=false)]
        public int? Form { get; set; }

        /// <summary>
        /// The keyword.
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// Specifies whether the keyword is the prefix.
        /// </summary>
        [NameInMap("KeyWordPrefix")]
        [Validation(Required=false)]
        public bool? KeyWordPrefix { get; set; }

        /// <summary>
        /// Specifies whether the keyword is the suffix.
        /// </summary>
        [NameInMap("KeyWordSuffix")]
        [Validation(Required=false)]
        public bool? KeyWordSuffix { get; set; }

        /// <summary>
        /// The language of the error message to return if the request fails. Valid values:
        /// 
        /// *   **zh**: Chinese.
        /// *   **en**: English.
        /// 
        /// Default value: **en**.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The type of the domain name. Valid values:
        /// 
        /// *   **New gTLD**
        /// *   **gTLD**
        /// *   **ccTLD**
        /// *   **other**
        /// </summary>
        [NameInMap("ProductDomainType")]
        [Validation(Required=false)]
        public string ProductDomainType { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The scroll ID. This parameter is a technical parameter.
        /// </summary>
        [NameInMap("ScrollId")]
        [Validation(Required=false)]
        public string ScrollId { get; set; }

        /// <summary>
        /// The beginning of the time range to query domain names based on expiration dates. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("StartExpirationDate")]
        [Validation(Required=false)]
        public long? StartExpirationDate { get; set; }

        /// <summary>
        /// The start of the domain name length to query.
        /// </summary>
        [NameInMap("StartLength")]
        [Validation(Required=false)]
        public int? StartLength { get; set; }

        /// <summary>
        /// The beginning of the time range to query domain names based on registration dates. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("StartRegistrationDate")]
        [Validation(Required=false)]
        public long? StartRegistrationDate { get; set; }

        /// <summary>
        /// The suffixes of domain names to be queried. Separate multiple suffixes with commas (,).
        /// </summary>
        [NameInMap("Suffixs")]
        [Validation(Required=false)]
        public string Suffixs { get; set; }

        /// <summary>
        /// The publishing status of the domain name. Valid values:
        /// 
        /// *   **2**: The domain name is published at a fixed price.
        /// *   **3**: The domain name is published with the price negotiable.
        /// *   **4**: The domain name is published for bidding.
        /// *   **6**: The domain name is published with price push.
        /// *   **-1**: The domain name is not published.
        /// </summary>
        [NameInMap("TradeType")]
        [Validation(Required=false)]
        public int? TradeType { get; set; }

        /// <summary>
        /// The IP address of the client. Set the value to **127.0.0.1**.
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
