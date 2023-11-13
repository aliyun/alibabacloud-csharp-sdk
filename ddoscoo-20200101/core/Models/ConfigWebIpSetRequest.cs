// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigWebIpSetRequest : TeaModel {
        /// <summary>
        /// IP address N or CIDR block N that you want to add to the blacklist. The maximum value of N is 200. You can add up to 200 IP addresses or CIDR blocks to the blacklist.
        /// </summary>
        [NameInMap("BlackList")]
        [Validation(Required=false)]
        public List<string> BlackList { get; set; }

        /// <summary>
        /// The domain name of the website.
        /// 
        /// > A forwarding rule must be configured for the domain name. You can call the [DescribeDomains](~~91724~~) operation to query all domain names.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// IP address N or CIDR block N that you want to add to the whitelist. The maximum value of N is 200. You can add up to 200 IP addresses or CIDR blocks to the whitelist.
        /// </summary>
        [NameInMap("WhiteList")]
        [Validation(Required=false)]
        public List<string> WhiteList { get; set; }

    }

}
