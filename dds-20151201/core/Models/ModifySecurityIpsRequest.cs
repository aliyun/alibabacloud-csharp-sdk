// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifySecurityIpsRequest : TeaModel {
        /// <summary>
        /// The ID of an instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The method of modification. Valid values:
        /// 
        /// *   **Cover**: overwrites the whitelist.
        /// *   **Append**: appends data to the whitelist.
        /// *   **Delete**: deletes the whitelist.
        /// 
        /// The default value is **Cover**.
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
        /// The attributes of an IP address whitelist. It can contain a maximum of 120 characters in length and can contain uppercase letters, lowercase letters, and digits.
        /// 
        /// This parameter is empty by default.
        /// </summary>
        [NameInMap("SecurityIpGroupAttribute")]
        [Validation(Required=false)]
        public string SecurityIpGroupAttribute { get; set; }

        /// <summary>
        /// The name of the IP address whitelist to be modified. The default value is **default**.
        /// </summary>
        [NameInMap("SecurityIpGroupName")]
        [Validation(Required=false)]
        public string SecurityIpGroupName { get; set; }

        /// <summary>
        /// The IP addresses in an IP address whitelist. Separate multiple IP addresses with commas (,). You can add a maximum of 1,000 different IP addresses to a whitelist. You can add IP addresses in one of the following two formats:
        /// 
        /// *   IP addresses. Example: 10.23.12.24.
        /// *   Classless Inter-Domain Routing (CIDR) blocks, such as 10.23.12.24/24, where 24 indicates that the prefix of the CIDR block is 24-bit long. You can replace 24 with a value within the range of 1 to 32.
        /// </summary>
        [NameInMap("SecurityIps")]
        [Validation(Required=false)]
        public string SecurityIps { get; set; }

    }

}
