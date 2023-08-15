// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class UpdateInstanceIpWhiteListRequest : TeaModel {
        /// <summary>
        /// The name of the group to which the instance belongs. The group name can contain only letters, digits, and underscores (\_).
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// The ID of the instance for which you want to configure a whitelist. You can call the [GetLindormInstanceList](~~426069~~) operation to obtain the ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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
        /// The IP addresses that you want to add to the whitelist. For example, if you add 192.168.0.0/24 to the whitelist, you can use all IP addresses within this CIDR block to access the Lindorm instance.
        /// 
        /// > If you add 127.0.0.1 to the whitelist, all IP addresses cannot be used to access the Lindorm instance. Separate multiple IP addresses or CIDR blocks with commas (,).
        /// </summary>
        [NameInMap("SecurityIpList")]
        [Validation(Required=false)]
        public string SecurityIpList { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
