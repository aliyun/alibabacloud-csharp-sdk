// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class AddAutoCcWhitelistRequest : TeaModel {
        /// <summary>
        /// This parameter is deprecated.
        /// 
        /// > This parameter indicates the validity period of the IP address blacklist. By default, the traffic from the IP addresses that you add to the whitelist is always allowed. You do not need to set this parameter.
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public int? ExpireTime { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// > You can call the [DescribeInstanceIds](~~157459~~) operation to query the IDs of all instances.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The configuration of the IP addresses that you want to add to the whitelist. The value is a string that consists of JSON arrays. Each element in a JSON array is a JSON struct that contains the following fields:
        /// 
        /// *   **src**: the IP address that you want to add. This parameter is required. Data type: string.
        /// </summary>
        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public string Whitelist { get; set; }

    }

}
