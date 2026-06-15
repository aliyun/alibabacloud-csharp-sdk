// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribePlanMaintenanceWindowsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Indicates whether the maintenance window is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the last query as the value of NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the maintenance window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pw-bp1jarob1aup7yvlrdt6</para>
        /// </summary>
        [NameInMap("PlanWindowId")]
        [Validation(Required=false)]
        public string PlanWindowId { get; set; }

        /// <summary>
        /// <para>The name of the maintenance window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WIndowName</para>
        /// </summary>
        [NameInMap("PlanWindowName")]
        [Validation(Required=false)]
        public string PlanWindowName { get; set; }

        /// <summary>
        /// <para>The ID of the region where the ECS instance is located. You can call the DescribeRegions operation to query the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the maintenance window applies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-d85g5yocioezmdrll</para>
        /// </summary>
        [NameInMap("TargetResourceGroupId")]
        [Validation(Required=false)]
        public string TargetResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags of the resources to which the maintenance window applies.</para>
        /// </summary>
        [NameInMap("TargetResourceTags")]
        [Validation(Required=false)]
        public string TargetResourceTagsShrink { get; set; }

    }

}
