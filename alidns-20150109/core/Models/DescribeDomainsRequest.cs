// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainsRequest : TeaModel {
        /// <summary>
        /// The ID of the domain name group. If you do not specify this parameter, all domain names are queried by default.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The keyword for searches in "%KeyWord%" mode. The value is not case-sensitive.
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// The language type.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page **1**. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: **100**. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The search mode. Valid values:
        /// 
        /// *   **LIKE**: fuzzy match.
        /// *   **EXACT**: exact match.
        /// </summary>
        [NameInMap("SearchMode")]
        [Validation(Required=false)]
        public string SearchMode { get; set; }

        /// <summary>
        /// Specifies whether to query the starmark of the domain name.
        /// </summary>
        [NameInMap("Starmark")]
        [Validation(Required=false)]
        public bool? Starmark { get; set; }

    }

}
