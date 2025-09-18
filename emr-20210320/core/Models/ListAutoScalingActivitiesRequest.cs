// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListAutoScalingActivitiesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b933c5aac8fe****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1639718634819</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>实例付费类型枚举值：</para>
        /// <list type="bullet">
        /// <item><description>ONDEMAND: 按量付费实例</description></item>
        /// <item><description>SPOT: 竞价实例
        /// 默认为null代表全选
        /// 举例: [&quot;ONDEMAND&quot;, &quot;SPOT&quot;]</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ONDEMAND</para>
        /// </summary>
        [NameInMap("InstanceChargeTypes")]
        [Validation(Required=false)]
        public List<string> InstanceChargeTypes { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C89568980</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the node group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-869471354ecd****</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The status of the scaling activity. Number of elements in the array: 1-20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;REJECTED&quot;,&quot;SUCCESSFUL&quot;]</para>
        /// </summary>
        [NameInMap("ScalingActivityStates")]
        [Validation(Required=false)]
        public List<string> ScalingActivityStates { get; set; }

        /// <summary>
        /// <para>The type of the scaling activity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SCALE_OUT</description></item>
        /// <item><description>SCALE_IN</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SCALE_IN</para>
        /// </summary>
        [NameInMap("ScalingActivityType")]
        [Validation(Required=false)]
        public string ScalingActivityType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MANAGED</para>
        /// </summary>
        [NameInMap("ScalingPolicyType")]
        [Validation(Required=false)]
        public string ScalingPolicyType { get; set; }

        /// <summary>
        /// <para>The name of the scaling rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scale-out-by-memroy</para>
        /// </summary>
        [NameInMap("ScalingRuleName")]
        [Validation(Required=false)]
        public string ScalingRuleName { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1639714634819</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
