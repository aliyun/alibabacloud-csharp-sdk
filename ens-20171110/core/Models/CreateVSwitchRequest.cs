// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateVSwitchRequest : TeaModel {
        /// <summary>
        /// The CIDR block of the vSwitch. Take note of the following limits:
        /// 
        /// *   The subnet mask must be 16 to 29 bits in length.
        /// *   The CIDR block of the vSwitch must fall within the CIDR block of the VPC to which the vSwitch belongs.
        /// *   The CIDR block of the vSwitch cannot be the same as the destination CIDR block in a route entry of the VPC. However, it can be a subset of the destination CIDR block.
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// The description of the vSwitch.
        /// 
        /// The description must be 2 to 256 characters in length. It must start with a letter but cannot start with http:// or https://.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the edge node.
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// The ID of the network to which the vSwitch that you want to create belongs.
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        /// <summary>
        /// The name of the vSwitch. The name must meet the following requirements:
        /// 
        /// *   The name must be 2 to 128 characters in length.
        /// *   The name must start with a letter and cannot start with http:// or https://. It can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
        /// 
        /// Default value: null.
        /// </summary>
        [NameInMap("VSwitchName")]
        [Validation(Required=false)]
        public string VSwitchName { get; set; }

    }

}
