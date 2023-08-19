// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SetAuditSecurityIpRequest : TeaModel {
        /// <summary>
        /// The IP addresses to be added to a review security group. You can add a maximum of 100 IP addresses to each review security group. Separate multiple IP addresses with commas (,). You can enter individual IP addresses or a CIDR block.
        /// 
        /// *   Individual IP address: for example, 10.23.12.24
        /// *   CIDR block: for example, 10.23.12.24/24, where /24 indicates that the prefix of the CIDR block is 24 bits in length. You can replace 24 with a value that ranges from `1 to 32`.
        /// </summary>
        [NameInMap("Ips")]
        [Validation(Required=false)]
        public string Ips { get; set; }

        /// <summary>
        /// The operation type. Valid values:
        /// 
        /// *   **Append**: adds the IP addresses to the original whitelist. This is the default value.
        /// *   **Cover**: overwrites the original whitelist.
        /// *   **Delete**: removes the IP addresses from the original whitelist.
        /// </summary>
        [NameInMap("OperateMode")]
        [Validation(Required=false)]
        public string OperateMode { get; set; }

        /// <summary>
        /// The name of the review security group. Default value: **Default**. You can specify a maximum of 10 review security groups.
        /// </summary>
        [NameInMap("SecurityGroupName")]
        [Validation(Required=false)]
        public string SecurityGroupName { get; set; }

    }

}
