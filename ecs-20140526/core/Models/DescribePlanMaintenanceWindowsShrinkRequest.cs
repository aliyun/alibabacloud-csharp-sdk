// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribePlanMaintenanceWindowsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the window is enabled or disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paging query. Maximum value: 100. Default value: 10. If no value is specified or the specified value is less than 10, the default value 10 is used. If the specified value is greater than 100, the default value 100 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Set the value to the NextToken value returned in the last API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the O&amp;M window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pw-bp1jarob1aup7yvlrdt6</para>
        /// </summary>
        [NameInMap("PlanWindowId")]
        [Validation(Required=false)]
        public string PlanWindowId { get; set; }

        /// <summary>
        /// <para>The name of the O&amp;M window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WIndowName</para>
        /// </summary>
        [NameInMap("PlanWindowName")]
        [Validation(Required=false)]
        public string PlanWindowName { get; set; }

        /// <summary>
        /// <para>The region ID. This parameter is required for Alibaba Cloud SDK routing. However, setting any region ID for this operation makes no difference, and the operation returns O&amp;M windows that meet the conditions across the entire network.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the O&amp;M window applies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-d85g5yocioezmdrll</para>
        /// </summary>
        [NameInMap("TargetResourceGroupId")]
        [Validation(Required=false)]
        public string TargetResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags to which the O&amp;M window applies.</para>
        /// </summary>
        [NameInMap("TargetResourceTags")]
        [Validation(Required=false)]
        public string TargetResourceTagsShrink { get; set; }

    }

}
