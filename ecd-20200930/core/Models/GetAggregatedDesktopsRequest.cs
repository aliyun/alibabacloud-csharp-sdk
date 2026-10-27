// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class GetAggregatedDesktopsRequest : TeaModel {
        /// <summary>
        /// <para>The aggregation factor. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>directory_id: office network ID</description></item>
        /// <item><description>region: region</description></item>
        /// <item><description>policy_group_id: cloud desktop policy ID</description></item>
        /// <item><description>status: cloud desktop status</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>STATUS</para>
        /// </summary>
        [NameInMap("AggregationFactor")]
        [Validation(Required=false)]
        public string AggregationFactor { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the list of regions supported by WUYING Workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The search region ID. Used to filter desktop information for a specified region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("SearchRegionId")]
        [Validation(Required=false)]
        public string SearchRegionId { get; set; }

    }

}
