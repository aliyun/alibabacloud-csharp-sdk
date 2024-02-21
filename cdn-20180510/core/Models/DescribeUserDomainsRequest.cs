// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeUserDomainsRequest : TeaModel {
        /// <summary>
        /// The type of workload accelerated by Alibaba Cloud CDN. Separate types with commas (,). Valid values:
        /// 
        /// *   **web**: images and small files
        /// *   **download**: large files
        /// *   **video**: on-demand video and audio streaming
        /// 
        /// If you do not set this parameter, all service types are queried.
        /// </summary>
        [NameInMap("CdnType")]
        [Validation(Required=false)]
        public string CdnType { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// > The end time must be later than the start time.
        /// </summary>
        [NameInMap("ChangeEndTime")]
        [Validation(Required=false)]
        public string ChangeEndTime { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("ChangeStartTime")]
        [Validation(Required=false)]
        public string ChangeStartTime { get; set; }

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
        /// The acceleration region. By default, all acceleration regions are queried. Valid values:
        /// 
        /// *   **domestic**: Chinese mainland
        /// *   **global**: global
        /// *   **overseas**: outside the Chinese mainland
        /// </summary>
        [NameInMap("Coverage")]
        [Validation(Required=false)]
        public string Coverage { get; set; }

        /// <summary>
        /// The accelerated domain. If you do not set this parameter, all domain names that match the conditions are returned.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The search mode. Valid values:
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
        /// *   **online**
        /// *   **offline**
        /// *   **configuring**
        /// *   **configure_failed**
        /// *   **checking**
        /// *   **check_failed**
        /// *   **stopping**
        /// *   **deleting**
        /// 
        /// If you do not set this parameter, domain names in all states are queried.
        /// </summary>
        [NameInMap("DomainStatus")]
        [Validation(Required=false)]
        public string DomainStatus { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number. Valid values: **1** to **100000**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: **1 to 500**. Default value: **20**. Maximum value: **500**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the resource group. By default, all IDs are queried.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The information about the origin server.
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The list of tags. Maximum number of elements in the list: 20
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeUserDomainsRequestTag> Tag { get; set; }
        public class DescribeUserDomainsRequestTag : TeaModel {
            /// <summary>
            /// The key of a tag.
            /// 
            /// By default, all tag keys are queried.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag.
            /// 
            /// By default, all tag values are queried.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
