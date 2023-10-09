// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class UpdateAllowedIpRequest : TeaModel {
        /// <summary>
        /// The IP addresses that you want to manage. You can specify a CIDR block. Example: **192.168.0.0/16**.
        /// 
        /// *   If the **UpdateType** parameter is set to **add**, specify one or more IP addresses for this parameter. Separate multiple IP addresses with commas (,).
        /// *   If the **UpdateType** parameter is set to **delete**, specify only one IP address.
        /// *   Exercise caution when you delete IP addresses.
        /// </summary>
        [NameInMap("AllowedListIp")]
        [Validation(Required=false)]
        public string AllowedListIp { get; set; }

        /// <summary>
        /// The type of the whitelist. Valid values:
        /// 
        /// *   **vpc**: a whitelist for access from a VPC.
        /// *   **internet**: a whitelist for access from the Internet.
        /// </summary>
        [NameInMap("AllowedListType")]
        [Validation(Required=false)]
        public string AllowedListType { get; set; }

        /// <summary>
        /// The description of the whitelist.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The port range. Valid values:
        /// 
        /// *   **9092/9092**: the port range for access from a virtual private cloud (VPC).
        /// *   **9093/9093**: the port range for access from the Internet.
        /// 
        /// The value of this parameter must match the value of the **AllowdedListType** parameter.
        /// </summary>
        [NameInMap("PortRange")]
        [Validation(Required=false)]
        public string PortRange { get; set; }

        /// <summary>
        /// The ID of the region where the instance resides.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The type of configuration change. Valid values:
        /// 
        /// *   **add**
        /// *   **delete**
        /// </summary>
        [NameInMap("UpdateType")]
        [Validation(Required=false)]
        public string UpdateType { get; set; }

    }

}
