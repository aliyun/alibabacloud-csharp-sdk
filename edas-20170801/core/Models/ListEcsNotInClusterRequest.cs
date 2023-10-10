// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListEcsNotInClusterRequest : TeaModel {
        /// <summary>
        /// The network type. Valid values:
        /// 
        /// *   1: classic network
        /// *   2: virtual private cloud (VPC)
        /// </summary>
        [NameInMap("NetworkMode")]
        [Validation(Required=false)]
        public int? NetworkMode { get; set; }

        /// <summary>
        /// The ID of the VPC. This parameter is required if the NetworkMode parameter is set to 2.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
