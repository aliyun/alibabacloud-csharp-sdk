// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateNatGatewayRequest : TeaModel {
        /// <summary>
        /// The ID of the Edge Node Service (ENS) node.
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// The instance type of the NAT gateway. Set the value to **enat.default**.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The name of the NAT gateway. The name must be 1 to 128 characters in length. The name cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the network.
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        /// <summary>
        /// The ID of the vSwitch.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
