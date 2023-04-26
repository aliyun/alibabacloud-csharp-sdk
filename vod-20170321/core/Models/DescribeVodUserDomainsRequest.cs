// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodUserDomainsRequest : TeaModel {
        /// <summary>
        /// The search method. Valid values:
        /// 
        /// *   **fuzzy_match**: fuzzy match. This is the default value.
        /// *   **pre_match**: prefix match.
        /// *   **suf_match**: suffix match.
        /// *   **full_match**: exact match.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The remarks.
        /// </summary>
        [NameInMap("DomainSearchType")]
        [Validation(Required=false)]
        public string DomainSearchType { get; set; }

        /// <summary>
        /// The value of tag N. Valid values of N: **1** to **20**.
        /// 
        /// If you do not specify this parameter, all tag values are queried.
        /// </summary>
        [NameInMap("DomainStatus")]
        [Validation(Required=false)]
        public string DomainStatus { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The detailed information about each domain name for CDN. The returned information is displayed in the format that is specified by the PageData parameter.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **DescribeVodUserDomains**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **20**. Maximum value: **50**. Valid values: integers in the range of **1** to **50**.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeVodUserDomainsRequestTag> Tag { get; set; }
        public class DescribeVodUserDomainsRequestTag : TeaModel {
            /// <summary>
            /// The status of the domain name for CDN. Valid values:
            /// 
            /// *   **online**: indicates that the domain name is enabled.
            /// *   **offline**: indicates that the domain name is disabled.
            /// *   **configuring**: indicates that the domain name is being configured.
            /// *   **configure_failed**: indicates that the domain name failed to be configured.
            /// *   **checking**: indicates that the domain name is under review.
            /// *   **check_failed**: indicates that the domain name failed the review.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The canonical domain name that is assigned to the domain name for CDN.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
