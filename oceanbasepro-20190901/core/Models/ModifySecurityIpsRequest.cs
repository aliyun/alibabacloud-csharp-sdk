// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifySecurityIpsRequest : TeaModel {
        /// <summary>
        /// The ID of the OceanBase cluster.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the IP address whitelist group.   
        /// It must be 2 to 32 characters in length, start with a lowercase letter, end with a lowercase letter or digit, and contain only lowercase letters, digits, and underscores (_).
        /// </summary>
        [NameInMap("SecurityIpGroupName")]
        [Validation(Required=false)]
        public string SecurityIpGroupName { get; set; }

        /// <summary>
        /// The list of IP addresses and CIDR blocks in the whitelist.   
        /// It is a JSON array. Each object in the array is an IP address or CIDR block. You can specify at most 40 IP addresses or CIDR blocks.
        /// </summary>
        [NameInMap("SecurityIps")]
        [Validation(Required=false)]
        public string SecurityIps { get; set; }

    }

}
