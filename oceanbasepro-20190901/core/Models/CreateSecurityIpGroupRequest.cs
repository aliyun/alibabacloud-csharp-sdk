// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateSecurityIpGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the OceanBase cluster.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the whitelist group.
        /// </summary>
        [NameInMap("SecurityIpGroupName")]
        [Validation(Required=false)]
        public string SecurityIpGroupName { get; set; }

        /// <summary>
        /// The IP addresses or CIDR blocks in the IP address whitelist group.   
        /// It is a JSON array. Each object in the array is an IP address or CIDR block. The following two formats are supported:  
        /// - IP address: for example, 10.23.12.24. 
        /// - CIDR block: for example, 10.23.12.24/24, where 24 indicates the length of the prefix in the IP address, and the prefix is 1 to 30 characters in length.  Limit: You can set no more than 40 IP addresses or CIDR blocks for a whitelist group. A total of 200 IP addresses or CIDR blocks are supported for all whitelist groups.
        /// </summary>
        [NameInMap("SecurityIps")]
        [Validation(Required=false)]
        public string SecurityIps { get; set; }

    }

}
