// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeL7RsPolicyRequest : TeaModel {
        /// <summary>
        /// The domain name of the website to query.
        /// 
        /// > A forwarding rule must be configured for the domain name. You can call the [DescribeDomains](https://help.aliyun.com/document_detail/91724.html) operation to query the domain names for which forwarding rules are configured.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// An array that consists of N addresses of origin servers to query. The maximum value of N is 200. You can specify up to 200 addresses.
        /// </summary>
        [NameInMap("RealServers")]
        [Validation(Required=false)]
        public List<string> RealServers { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.
        /// 
        /// For more information about resource groups, see [Create a resource group](https://help.aliyun.com/document_detail/94485.html).
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
