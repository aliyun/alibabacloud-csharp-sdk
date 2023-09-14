// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListReleaseVersionsRequest : TeaModel {
        /// <summary>
        /// The type of the cluster.
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// The type of the IaaS resource.
        /// </summary>
        [NameInMap("IaasType")]
        [Validation(Required=false)]
        public string IaasType { get; set; }

        /// <summary>
        /// The ID of the region in which you want to create the instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
