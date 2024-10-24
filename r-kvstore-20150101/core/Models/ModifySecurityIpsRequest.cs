// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifySecurityIpsRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The method that is used to modify the whitelist. Valid values:
        /// 
        /// *   **Cover**: overwrites the original whitelist.
        /// *   **Append**: appends data to the whitelist.
        /// *   **Delete**: deletes the whitelist.
        /// </summary>
        [NameInMap("ModifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// By default, this parameter is left empty. The attribute of the whitelist. The console does not display the whitelist whose value of this parameter is **hidden**.
        /// </summary>
        [NameInMap("SecurityIpGroupAttribute")]
        [Validation(Required=false)]
        public string SecurityIpGroupAttribute { get; set; }

        /// <summary>
        /// The name of the IP address whitelist.
        /// >Warning: You cannot modify the whitelist that is generated by the system. If you do not specify this parameter, the default whitelist is modified by default.
        /// </summary>
        [NameInMap("SecurityIpGroupName")]
        [Validation(Required=false)]
        public string SecurityIpGroupName { get; set; }

        /// <summary>
        /// The IP addresses in the whitelist. Up to 1,000 IP addresses can be specified in a whitelist. Separate multiple IP addresses with a comma (,). Specify an IP address in the 0.0.0.0/0, 10.23.12.24, or 10.23.12.24/24 format. In CIDR block 10.23.12.24/24, /24 specifies the length of the prefix of an IP address. The prefix length ranges from 1 to 32.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecurityIps")]
        [Validation(Required=false)]
        public string SecurityIps { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
