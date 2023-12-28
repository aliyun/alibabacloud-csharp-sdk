// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class ClearPairDrillRequest : TeaModel {
        /// <summary>
        /// The ID of the drill. You can call the [DescribePairDrills](~~2584480~~) operation to query the disaster recovery drills that were performed on replication pairs in a specific region.
        /// </summary>
        [NameInMap("DrillId")]
        [Validation(Required=false)]
        public string DrillId { get; set; }

        /// <summary>
        /// The ID of the replication pair. You can call the [DescribeDiskReplicaPairs](~~354206~~) operation to query the most recent list of replication pairs, including replication pair IDs.
        /// </summary>
        [NameInMap("PairId")]
        [Validation(Required=false)]
        public string PairId { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~354276~~) operation to query the most recent list of regions in which async replication is supported.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
