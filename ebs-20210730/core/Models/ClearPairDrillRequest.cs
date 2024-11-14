// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class ClearPairDrillRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the drill. You can call the <a href="https://help.aliyun.com/document_detail/2584480.html">DescribePairDrills</a> operation to query the disaster recovery drills that were performed on replication pairs in a specific region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drill-xxxx</para>
        /// </summary>
        [NameInMap("DrillId")]
        [Validation(Required=false)]
        public string DrillId { get; set; }

        /// <summary>
        /// <para>The ID of the replication pair. You can call the <a href="https://help.aliyun.com/document_detail/354206.html">DescribeDiskReplicaPairs</a> operation to query the most recent list of replication pairs, including replication pair IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pair-xxxx</para>
        /// </summary>
        [NameInMap("PairId")]
        [Validation(Required=false)]
        public string PairId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/354276.html">DescribeRegions</a> operation to query the most recent list of regions in which async replication is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
