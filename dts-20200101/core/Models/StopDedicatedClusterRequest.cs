// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class StopDedicatedClusterRequest : TeaModel {
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

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// The ID of the region in which the instance resides.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
