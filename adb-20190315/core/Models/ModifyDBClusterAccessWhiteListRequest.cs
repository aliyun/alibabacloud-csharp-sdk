// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class ModifyDBClusterAccessWhiteListRequest : TeaModel {
        /// <summary>
        /// The attribute of the whitelist. This parameter is empty by default.
        /// 
        /// The IP address whitelists that have the hidden attribute are not displayed in the AnalyticDB for MySQL console. These IP address whitelists are used to access Alibaba Cloud services such as Data Transmission Service (DTS) and PolarDB-X.
        /// </summary>
        [NameInMap("DBClusterIPArrayAttribute")]
        [Validation(Required=false)]
        public string DBClusterIPArrayAttribute { get; set; }

        /// <summary>
        /// The name of the IP address whitelist to be modified. Default value: Default.
        /// 
        /// The name of an IP address whitelist must be 2 to 32 characters in length. The name must contain lowercase letters, digits, and underscores (\_). The name must start with a lowercase letter and end with a digit or lowercase letter.
        /// 
        /// You can create up to 50 whitelists for a cluster.
        /// </summary>
        [NameInMap("DBClusterIPArrayName")]
        [Validation(Required=false)]
        public string DBClusterIPArrayName { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The method used to modify the whitelist. Valid values:
        /// 
        /// *   Cover: overwrites the original IP address whitelist.
        /// *   Append: adds one or more IP addresses.
        /// *   Delete: deletes one or more IP addresses.
        /// 
        /// Default value: Cover.
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
        /// The IP addresses in an IP address whitelist of a cluster. Separate multiple IP addresses with commas (,). You can add a maximum of 500 different IP addresses to a whitelist. The following formats are supported:
        /// 
        /// *   IP addresses. Example: 10.23.12.24.
        /// *   CIDR blocks. Example: 10.23.12.24/24. 24 indicates that the prefix of the CIDR block is 24-bit long. You can replace 24 with a value within the range of 1 to 32.
        /// 
        /// This parameter must be specified unless the ModifyMode parameter is set to Delete.
        /// </summary>
        [NameInMap("SecurityIps")]
        [Validation(Required=false)]
        public string SecurityIps { get; set; }

    }

}
