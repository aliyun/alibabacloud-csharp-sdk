// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class SyncUsersRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// 
        /// You can call the [ListClusters](~~87116~~) operation to query the list of E-HPC clusters.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// You can call the [ListRegions](~~188593~~) operation to query the list of regions where E-HPC is supported.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
