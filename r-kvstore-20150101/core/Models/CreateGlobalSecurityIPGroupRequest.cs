// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateGlobalSecurityIPGroupRequest : TeaModel {
        /// <summary>
        /// The IP address in the whitelist template.
        /// 
        /// >  Separate multiple IP addresses with commas (,). You can create up to 1,000 IP addresses or CIDR blocks for all IP whitelists.
        /// </summary>
        [NameInMap("GIpList")]
        [Validation(Required=false)]
        public string GIpList { get; set; }

        /// <summary>
        /// The name of the IP whitelist template. The name must meet the following requirements:
        /// 
        /// *   The name can contain lowercase letters, digits, and underscores (\_).
        /// *   The name must start with a letter and end with a letter or digit.
        /// *   The name must be 2 to 120 characters in length.
        /// </summary>
        [NameInMap("GlobalIgName")]
        [Validation(Required=false)]
        public string GlobalIgName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource group ID.
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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
