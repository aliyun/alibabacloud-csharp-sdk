// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserDomainsRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC+0.
        /// 
        /// > The end time must be later than the start time.
        /// </summary>
        [NameInMap("ChangeEndTime")]
        [Validation(Required=false)]
        public string ChangeEndTime { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC+0.
        /// </summary>
        [NameInMap("ChangeStartTime")]
        [Validation(Required=false)]
        public string ChangeStartTime { get; set; }

        /// <summary>
        /// Specifies whether to display domain names that are under review, failed the review, or failed to be configured. Valid values:
        /// 
        /// *   true: displays domain names.
        /// *   false: does not display detailed information.
        /// </summary>
        [NameInMap("CheckDomainShow")]
        [Validation(Required=false)]
        public bool? CheckDomainShow { get; set; }

        /// <summary>
        /// The acceleration region. By default, all acceleration regions are queried.
        /// 
        /// *   **domestic**: Chinese mainland
        /// *   **overseas**: outside the Chinese mainland
        /// *   **global**: global
        /// </summary>
        [NameInMap("Coverage")]
        [Validation(Required=false)]
        public string Coverage { get; set; }

        /// <summary>
        /// The accelerated domain names. If you do not set this parameter, configurations of all domain names that match the conditions are returned.
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
        /// *   **full_match** (default): exact match
        /// 
        /// > If you specify the domain names to query but do not set the DomainSearchType parameter, the exact match mode is used.
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

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of returned pages. Valid values: **1** to **100000**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **20**. Valid values: **1** to **500**.
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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The list of tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDcdnUserDomainsRequestTag> Tag { get; set; }
        public class DescribeDcdnUserDomainsRequestTag : TeaModel {
            /// <summary>
            /// The tag key. Valid values of N: **1** to **20**. You can call the TagDcdnResources operation to set a tag for a domain name.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value. Valid values of N: **1** to **20**.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
