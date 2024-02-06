// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyNetworkAttributeRequest : TeaModel {
        /// <summary>
        /// The description of the network.
        /// 
        /// The description must be 2 to 256 characters in length. It must start with a letter but cannot start with http:// or https://.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the network.
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        /// <summary>
        /// The name of the network. The name must meet the following requirements:
        /// 
        /// *   The name must be 2 to 128 characters in length.
        /// *   The name must start with a letter but cannot start with http:// or https://.
        /// *   The name can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("NetworkName")]
        [Validation(Required=false)]
        public string NetworkName { get; set; }

    }

}
