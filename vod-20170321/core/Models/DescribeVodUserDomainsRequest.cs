// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodUserDomainsRequest : TeaModel {
        /// <summary>
        /// The domain name. The value of this parameter is used as a filter condition for a fuzzy match.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The search method. Valid values:
        /// 
        /// *   **fuzzy_match** (default): fuzzy match.
        /// *   **pre_match**: prefix match
        /// *   **suf_match**: suffix match
        /// *   **full_match**: exact match
        /// </summary>
        [NameInMap("DomainSearchType")]
        [Validation(Required=false)]
        public string DomainSearchType { get; set; }

        /// <summary>
        /// The status of the domain name. Value values:
        /// 
        /// *   **online**: indicates that the domain name is enabled.
        /// *   **offline**: indicates that the domain name is disabled.
        /// *   **configuring**: indicates that the domain name is being configured.
        /// *   **configure_failed**: indicates that the domain name failed to be configured.
        /// *   **checking**: indicates that the domain name is under review.
        /// *   **check_failed**: indicates that the domain name failed the review.
        /// </summary>
        [NameInMap("DomainStatus")]
        [Validation(Required=false)]
        public string DomainStatus { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: **20**. Maximum value: **50**. Valid values: **1** to **50**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeVodUserDomainsRequestTag> Tag { get; set; }
        public class DescribeVodUserDomainsRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N. Valid values of N: **1** to **20**.
            /// 
            /// By default, all tag keys are queried.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N. Valid values of N: **1** to **20**.
            /// 
            /// By default, all tag values are queried.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
