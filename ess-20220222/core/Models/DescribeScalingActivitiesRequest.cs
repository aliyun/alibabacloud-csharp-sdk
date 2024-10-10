// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingActivitiesRequest : TeaModel {
        [NameInMap("InstanceRefreshTaskId")]
        [Validation(Required=false)]
        public string InstanceRefreshTaskId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Pages start from page 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: 50.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the scaling group to which the scaling activity that you want to query belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The IDs of the scaling activities that you want to query.</para>
        /// <remarks>
        /// <para>When you call this operation, you must specify one of the <c>ScalingGroupId</c> and <c>ScalingActivityId.N</c> parameters. Otherwise, an error is reported.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ScalingActivityIds")]
        [Validation(Required=false)]
        public List<string> ScalingActivityIds { get; set; }

        /// <summary>
        /// <para>The ID of the scaling group.</para>
        /// <remarks>
        /// <para>When you call this operation, you must specify one of the <c>ScalingGroupId</c> and <c>ScalingActivityId.N</c> parameters. Otherwise, an error is reported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp18p2yfxow2dloq****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// <para>The status of the scaling activity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Successful: The scaling activity is successful.</description></item>
        /// <item><description>Warning: The scaling activity is partially successful.</description></item>
        /// <item><description>Failed: The scaling activity failed.</description></item>
        /// <item><description>InProgress: The scaling activity is in progress.</description></item>
        /// <item><description>Rejected: The request to trigger the scaling activity is rejected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public string StatusCode { get; set; }

    }

}
