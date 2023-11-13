// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigL7RsPolicyRequest : TeaModel {
        /// <summary>
        /// The domain name of the website.
        /// 
        /// > A forwarding rule must be configured for the domain name. You can call the [DescribeDomains](~~91724~~) operation to query the domain names for which forwarding rules are configured.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The back-to-origin policy. The value is a string that consists of a JSON struct. The JSON struct contains the following fields:
        /// 
        /// *   **ProxyMode**: The load balancing algorithm for back-to-origin traffic. This field is required and must be a string. Valid values:
        /// 
        ///     *   **ip_hash**: the IP hash algorithm. This algorithm is used to redirect the requests from the same IP address to the same origin server.
        ///     *   **rr**: the round-robin algorithm. This algorithm is used to redirect requests to origin servers in turn. If you use this algorithm, you can specify a weight for each server based on server performance.
        ///     *   **least_time**: the least response time algorithm. This algorithm is used to minimize the latency when requests are forwarded from Anti-DDoS Pro or Anti-DDoS Premium instances to origin servers based on the intelligent DNS resolution feature.
        /// 
        /// *   **Attributes**: the parameters for back-to-origin. This field is optional and must be a JSON array. Each element in the array contains the following fields:
        /// 
        ///     *   **RealServer**: the address of the origin server. This field is optional and must be a string.
        /// 
        ///     *   **Attribute**: the parameter for back-to-origin. This field is optional and must be a JSON object. The value contains the following field:
        /// 
        ///         *   **Weight**: the weight of the server. This field is optional and must be an integer. This field takes effect only when **ProxyMode** is set to **rr**. Valid values: **1** to **100**. Default value: **100**. An origin server with a higher weight receives more requests.
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.
        /// 
        /// For more information about resource groups, see [Create a resource group](~~94485~~).
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
