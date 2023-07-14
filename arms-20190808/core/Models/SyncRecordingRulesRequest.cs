// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SyncRecordingRulesRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster whose aggregation rule you want to synchronize.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The ID of the region. The destination region can be the same as the source region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The IDs of clusters to which you want to synchronize the aggregation rule.
        /// </summary>
        [NameInMap("TargetClusters")]
        [Validation(Required=false)]
        public string TargetClusters { get; set; }

    }

}
