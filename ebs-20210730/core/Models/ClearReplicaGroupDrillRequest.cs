// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class ClearReplicaGroupDrillRequest : TeaModel {
        /// <summary>
        /// The ID of the drill. You can call the [DescribeReplicaGroupDrills](https://help.aliyun.com/document_detail/2584481.html) operation to query disaster recovery drills that were performed on replication pairs in a specific region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DrillId")]
        [Validation(Required=false)]
        public string DrillId { get; set; }

        /// <summary>
        /// The ID of the replication pair-consistent group. You can call the [DescribeDiskReplicaGroups](https://help.aliyun.com/document_detail/426614.html) operation to query the most recent list of replication pair-consistent groups, including group IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/354276.html) operation to query the most recent list of regions in which async replication is supported.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
