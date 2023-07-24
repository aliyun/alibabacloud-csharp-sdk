// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnIpaUserDomainsRequest : TeaModel {
        /// <summary>
        /// Specifies whether to display domain names that are under review, failed the review, or failed to be configured. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("CheckDomainShow")]
        [Validation(Required=false)]
        public bool? CheckDomainShow { get; set; }

        /// <summary>
        /// The domain name that is used as a keyword to filter domain names. Fuzzy match is supported.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The search method. Default value: full_match. Valid values:
        /// 
        /// *   **fuzzy_match**: fuzzy match
        /// *   **pre_match**: prefix match
        /// *   **suf_match**: suffix match
        /// *   **full_match**: exact match
        /// </summary>
        [NameInMap("DomainSearchType")]
        [Validation(Required=false)]
        public string DomainSearchType { get; set; }

        /// <summary>
        /// The status of the domain name. Valid values:
        /// 
        /// *   **online**: enabled
        /// *   **offline**: disabled
        /// *   **configuring**: configuring
        /// *   **configure_failed**: configuration failed
        /// *   **checking**: reviewing
        /// *   **check_failed:** review failed
        /// </summary>
        [NameInMap("DomainStatus")]
        [Validation(Required=false)]
        public string DomainStatus { get; set; }

        /// <summary>
        /// The status of the feature.
        /// 
        /// *   config: The feature is enabled.
        /// *   unconfig: The feature is not enabled.
        /// </summary>
        [NameInMap("FuncFilter")]
        [Validation(Required=false)]
        public string FuncFilter { get; set; }

        /// <summary>
        /// The ID of the feature. For example, a value of 7 specifies the feature of configuring an expiration rule for a specific directory. For more information about feature IDs, see [Parameters for configuring features for domain names](~~410622~~).
        /// </summary>
        [NameInMap("FuncId")]
        [Validation(Required=false)]
        public string FuncId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number of the returned page. Valid values: **1** to **100000**. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of domain names to return on each page. Default value: **20**. Maximum value: **500**. Valid values: an integer between **1** and **500**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The tags of the command.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDcdnIpaUserDomainsRequestTag> Tag { get; set; }
        public class DescribeDcdnIpaUserDomainsRequestTag : TeaModel {
            /// <summary>
            /// The tag key. Valid values of N: 1 to 20. You can call the TagDcdnResources operation to set a tag for a domain name.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value. Valid values of N: 1 to 20.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
