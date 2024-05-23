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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The information of the IP address whitelist group.
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
