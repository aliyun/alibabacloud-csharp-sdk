// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterAccessWhitelistRequest : TeaModel {
        /// <summary>
        /// The attributes of the IP whitelist group. Set this parameter to **hidden** to hide the IP whitelist group in the console.
        /// 
        /// > *   The IP whitelist group that has appeared in the console cannot be hidden.
        /// > *   This parameter can be specified only when the **WhiteListType** parameter is set to **IP**.
        /// </summary>
        [NameInMap("DBClusterIPArrayAttribute")]
        [Validation(Required=false)]
        public string DBClusterIPArrayAttribute { get; set; }

        /// <summary>
        /// The name of the IP whitelist group. The group name must be 2 to 120 characters in length and consists of lowercase letters and digits. It must start with a letter, and end with a letter or a digit.
        /// 
        /// *   If the specified whitelist group name does not exist, the whitelist group is created.
        /// *   If the specified whitelist group name exists, the whitelist group is modified.
        /// *   If you do not specify this parameter, the default group is modified.
        /// 
        /// > 
        /// 
        /// *   You can create a maximum of 50 IP whitelist groups for a cluster.
        /// 
        /// *   This parameter can be specified only when the **WhiteListType** parameter is set to **IP**.
        /// </summary>
        [NameInMap("DBClusterIPArrayName")]
        [Validation(Required=false)]
        public string DBClusterIPArrayName { get; set; }

        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The method used to modify the IP whitelist. Valid values:
        /// 
        /// *   **Cover** (default): overwrites the original IP whitelist.
        /// *   **Append**: appends IP addresses to the original whitelist.
        /// *   **Delete**: deletes IP addresses.
        /// 
        /// >  This parameter can be specified only when the **WhiteListType** parameter is set to **IP**.
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
        /// The ID of the security group. Separate multiple security groups with commas (,).
        /// 
        /// > *   You can add a maximum of three security groups to a cluster.
        /// > *   This parameter can be specified only when the **WhiteListType** parameter is set to **SecurityGroup**.
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public string SecurityGroupIds { get; set; }

        /// <summary>
        /// The IP addresses or Classless Inter-Domain Routing (CIDR) blocks in the IP whitelist group. You can add 1,000 IP addresses or CIDR blocks to all the IP whitelist groups. Separate multiple IP addresses with commas (,). The following two formats are supported:
        /// 
        /// *   IP addresses. Example: 10.23.12.24.
        /// *   CIDR blocks. Example: 10.23.12.24/24. 24 indicates the length of the prefix of the CIDR block. The length is the range of 1 to 32.
        /// 
        /// >  This parameter can be specified only when the **WhiteListType** parameter is set to **IP**.
        /// </summary>
        [NameInMap("SecurityIps")]
        [Validation(Required=false)]
        public string SecurityIps { get; set; }

        /// <summary>
        /// The type of the whitelist. Valid values:
        /// 
        /// *   **IP**: IP whitelist group.
        /// *   **SecurityGroup**: security group.
        /// 
        /// Default value: **IP**.
        /// </summary>
        [NameInMap("WhiteListType")]
        [Validation(Required=false)]
        public string WhiteListType { get; set; }

    }

}
