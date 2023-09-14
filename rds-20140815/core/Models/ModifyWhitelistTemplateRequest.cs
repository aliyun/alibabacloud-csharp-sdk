// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyWhitelistTemplateRequest : TeaModel {
        /// <summary>
        /// The IP addresses in an IP address whitelist. Separate multiple IP addresses with commas (,). Each IP address in the IP address whitelist must be unique. The entries in the IP address whitelist must be in one of the following formats:
        /// 
        /// *   IP addresses, such as 10.23.XX.XX.
        /// *   CIDR blocks, such as 10.23.XX.XX/24. In this example, 24 indicates that the prefix of the CIDR block is 24-bit in length. You can replace 24 with a value that ranges from 1 to 32.
        /// 
        /// > : A maximum of 1,000 IP addresses or CIDR blocks can be added for each instance. If you want to add a large number of IP addresses, we recommend that you merge them into CIDR blocks, such as 10.23.XX.XX/24.
        /// </summary>
        [NameInMap("IpWhitelist")]
        [Validation(Required=false)]
        public string IpWhitelist { get; set; }

        /// <summary>
        /// 资源组ID。 关于资源组的更多信息，请参见什么是资源组。
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the whitelist template. This parameter is required when you modify or delete a whitelist. You can call the DescribeAllWhitelistTemplate operation to obtain the ID of the whitelist.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public int? TemplateId { get; set; }

        /// <summary>
        /// The name of the IP whitelist. This parameter is required when you create a whitelist. The value of this parameter cannot be modified after the whitelist is created. The value must be unique to an Alibaba Cloud account and start with a letter. You can call the DescribeWhitelistTemplate operation to obtain the name of the whitelist.
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
