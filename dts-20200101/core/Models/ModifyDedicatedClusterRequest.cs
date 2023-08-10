// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifyDedicatedClusterRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// 
        /// >  You must specify one of the **InstanceId** and **DedicatedClusterId** parameters.
        /// </summary>
        [NameInMap("DedicatedClusterId")]
        [Validation(Required=false)]
        public string DedicatedClusterId { get; set; }

        /// <summary>
        /// The name of the cluster.
        /// </summary>
        [NameInMap("DedicatedClusterName")]
        [Validation(Required=false)]
        public string DedicatedClusterName { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// >  You must specify one of the **InstanceId** and **DedicatedClusterId** parameters.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The overcommit ratio. Unit: %.
        /// </summary>
        [NameInMap("OversoldRatio")]
        [Validation(Required=false)]
        public int? OversoldRatio { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// The ID of the region in which the Data Transmission Service (DTS) instance resides.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
