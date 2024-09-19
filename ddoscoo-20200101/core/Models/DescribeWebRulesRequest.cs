// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebRulesRequest : TeaModel {
        /// <summary>
        /// The CNAME address to query.
        /// </summary>
        [NameInMap("Cname")]
        [Validation(Required=false)]
        public string Cname { get; set; }

        /// <summary>
        /// The domain name of the website to query.
        /// 
        /// > The domain must have been configured with website business forwarding rules. You can call [DescribeDomains](~~DescribeDomains~~) to query all domains that have been configured with website business forwarding rules.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The list of DDoS protection instance IDs to query.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// When paginating, set the page number of the current page. The default value is 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// When paginating, set the number of forwarding rules per page. The range of values is: 1~10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The query matching pattern. Values:
        /// - **fuzzy** (default): Indicates fuzzy query.
        /// - **exact**: Indicates exact query.
        /// </summary>
        [NameInMap("QueryDomainPattern")]
        [Validation(Required=false)]
        public string QueryDomainPattern { get; set; }

        /// <summary>
        /// The resource group ID of the DDoS protection instance in the resource management service.
        /// 
        /// Not setting this parameter indicates the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
