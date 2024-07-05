// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SetAuditSecurityIpRequest : TeaModel {
        /// <summary>
        /// The IP addresses that you want to add to the review security group. You can add a maximum of 100 IP addresses to a review security group. Separate multiple IP addresses with commas (,). You can add IP addresses in the following formats to review security groups:
        /// 
        /// *   IP address: 192.168.0.1
        /// *   CIDR block: 192.168.0.1/24. /24 indicates that the prefix of the CIDR block is 24 bits in length. You can replace 24 with a value that ranges `from 1 to 32`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Ips")]
        [Validation(Required=false)]
        public string Ips { get; set; }

        /// <summary>
        /// The operation type. Valid values:
        /// 
        /// *   **Append** (default): adds the IP addresses to the original whitelist.
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
