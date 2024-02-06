// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateClassicNetworkRequest : TeaModel {
        /// <summary>
        /// The CIDR block of the network. You can use one of the following CIDR blocks or their subnets as the CIDR block of the network:
        /// 
        /// *   10.0.0.0/8 (default)
        /// *   172.16.0.0/12
        /// *   192.168.0.0/16
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// The description of the listener. The description is **1** to **80** characters in length.
        /// 
        /// >  The value cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the edge node.
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// The name of the network. The name must meet the following requirements:
        /// 
        /// *   The name must be 2 to 128 characters in length.
        /// *   The name must start with a letter but cannot start with http:// or https://.
        /// *   The name can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("NetworkName")]
        [Validation(Required=false)]
        public string NetworkName { get; set; }

    }

}
