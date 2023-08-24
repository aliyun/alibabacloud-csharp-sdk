// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyIntranetAttributeRequest : TeaModel {
        /// <summary>
        /// The amount of bandwidth that you want to add. Unit: Mbit/s. The value must be an integer greater than or equal to 0. In most cases, the maximum bandwidth that can be added can be two times the default maximum bandwidth of the current instance type. For more information about the bandwidth specifications supported by different instance types, see [Overview](~~26350~~). The bandwidth is also subject to the following limits:
        /// 
        /// *   The bandwidth of an individual instance cannot exceed 75% of the bandwidth of the host. For more information about the host specifications and bandwidth, see [Instance types of hosts](~~206343~~).
        /// *   The total bandwidth of all of the instances on the host cannot exceed 150% of the bandwidth of the host. You can configure resource overcommitment to handle traffic spikes. For more information, see [Configure resource overcommitment to reduce costs](~~183798~~).
        /// 
        /// > If you do not specify this parameter for a standard instance, the bandwidth of the instance is set to two times that of the current bandwidth.
        /// </summary>
        [NameInMap("BandWidth")]
        [Validation(Required=false)]
        public long? BandWidth { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the data node. You can call the [DescribeClusterMemberInfo](~~193462~~) operation to query the node ID. Separate multiple IDs with commas (,).
        /// 
        /// > This parameter is available and required only when the instance uses the [cluster architecture](~~52228~~).
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
