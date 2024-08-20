// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafPolicyValidDomainsRequest : TeaModel {
        /// <summary>
        /// The type of the Web Application Firewall (WAF) protection policy. Valid values:
        /// 
        /// *   waf_group: basic web protection
        /// *   custom_acl: custom protection
        /// *   whitelist: IP address whitelist
        /// *   ip_blacklist: IP address blacklist
        /// *   region_block: region blacklist
        /// *   bot: bot management
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DefenseScene")]
        [Validation(Required=false)]
        public string DefenseScene { get; set; }

        /// <summary>
        /// The protected domain name. Fuzzy search is supported.
        /// </summary>
        [NameInMap("DomainNameLike")]
        [Validation(Required=false)]
        public string DomainNameLike { get; set; }

        /// <summary>
        /// The page number of the returned page. Valid values: **1** to **100000**. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of domain names to return on each page. Valid values: an integer from **1** to **500**. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
