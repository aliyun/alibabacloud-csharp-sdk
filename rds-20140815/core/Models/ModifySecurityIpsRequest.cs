// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifySecurityIpsRequest : TeaModel {
        /// <summary>
        /// The attribute of the IP address whitelist. By default, this parameter is empty.
        /// 
        /// > The IP address whitelists that have the hidden attribute are not displayed in the ApsaraDB RDS console. These IP address whitelists are used to access Alibaba Cloud services, such as Data Transmission Service (DTS).
        /// </summary>
        [NameInMap("DBInstanceIPArrayAttribute")]
        [Validation(Required=false)]
        public string DBInstanceIPArrayAttribute { get; set; }

        /// <summary>
        /// The name of the IP address whitelist that you want to modify. Default value: **Default**.
        /// 
        /// > A maximum of 200 IP address whitelists can be configured for each instance.
        /// </summary>
        [NameInMap("DBInstanceIPArrayName")]
        [Validation(Required=false)]
        public string DBInstanceIPArrayName { get; set; }

        /// <summary>
        /// The ID of the instance. You can call the [DescribeDBInstances](~~610396~~) operation to query the ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The read-only instances to which you want to synchronize the IP address whitelist.
        /// 
        /// *   This parameter applies only to ApsaraDB RDS for PostgreSQL instances.
        /// *   If the instance is attached with a read-only instance, you can use this parameter to synchronize the IP address whitelist to the read-only instance. If the instance is attached with multiple read-only instances, separate the read-only instances with commas (,).
        /// *   If the instance is not attached with a read-only instance, leave this parameter empty.
        /// </summary>
        [NameInMap("FreshWhiteListReadins")]
        [Validation(Required=false)]
        public string FreshWhiteListReadins { get; set; }

        /// <summary>
        /// The method that is used to modify the whitelist. Valid values:
        /// 
        /// *   **Cover**: Use the IP addresses and CIDR blocks that are specified in the **SecurityIps** parameter to overwrite the existing IP addresses and CIDR blocks in the IP address whitelist.
        /// *   **Append**: Add the IP addresses and CIDR blocks that are specified in the **SecurityIps** parameter to the IP address whitelist.
        /// *   **Delete**: Delete the IP addresses and CIDR blocks that are specified in the **SecurityIps** parameter from the IP address whitelist. You must retain at least one IP address or CIDR block.
        /// 
        /// Default value: **Cover**.
        /// </summary>
        [NameInMap("ModifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The type of the IP addresses in the IP address whitelist. Set the value to IPv4. IPv6 is not supported.
        /// </summary>
        [NameInMap("SecurityIPType")]
        [Validation(Required=false)]
        public string SecurityIPType { get; set; }

        /// <summary>
        /// The IP addresses in an IP address whitelist. Separate multiple IP addresses with commas (,). Each IP address in the IP address whitelist must be unique. The entries in the IP address whitelist must be in one of the following formats:
        /// 
        /// *   IP addresses, such as 10.23.XX.XX.
        /// *   CIDR blocks, such as 10.23.XX.XX/24. In this example, 24 indicates that the prefix of each IP address in the IP address whitelist is 24 bits in length. You can replace 24 with a value within the range of 1 to 32.
        /// 
        /// > A maximum of 1,000 IP addresses or CIDR blocks can be added for each instance. If you want to add a large number of IP addresses, we recommend that you merge them into CIDR blocks, such as 10.23.XX.XX/24.
        /// </summary>
        [NameInMap("SecurityIps")]
        [Validation(Required=false)]
        public string SecurityIps { get; set; }

        /// <summary>
        /// The network type of the IP address whitelist. Valid values:
        /// 
        /// *   **Classic**: classic network in enhanced whitelist mode
        /// *   **VPC**: virtual private cloud (VPC) in enhanced whitelist mode
        /// *   **MIX**: standard whitelist mode
        /// 
        /// Default value: **MIX**.
        /// 
        /// > In standard whitelist mode, IP addresses and CIDR blocks are added only to the default IP address whitelist. In enhanced whitelist mode, IP addresses and CIDR blocks are added to the IP address whitelists of the classic network type and the VPC network type.
        /// </summary>
        [NameInMap("WhitelistNetworkType")]
        [Validation(Required=false)]
        public string WhitelistNetworkType { get; set; }

    }

}
