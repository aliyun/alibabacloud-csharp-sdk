// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeEciScalingConfigurationsRequest : TeaModel {
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
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the scaling group to which the scaling configuration belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
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
        /// <para>The IDs of the scaling configurations that you want to query. You can specify 1 to 10 scaling configuration IDs.</para>
        /// <para>The IDs of active and inactive scaling configurations are displayed in the query results. You can distinguish between active and inactive scaling configurations based on the value of <c>LifecycleState</c>.</para>
        /// </summary>
        [NameInMap("ScalingConfigurationIds")]
        [Validation(Required=false)]
        public List<string> ScalingConfigurationIds { get; set; }

        /// <summary>
        /// <para>The names of the scaling configurations that you want to query. You can specify 1 to 10 scaling configuration names.</para>
        /// <para>The names of inactive scaling configurations are not displayed in the query results, and no error is reported.</para>
        /// </summary>
        [NameInMap("ScalingConfigurationNames")]
        [Validation(Required=false)]
        public List<string> ScalingConfigurationNames { get; set; }

        /// <summary>
        /// <para>The ID of the scaling group. You can use the ID to query all scaling configurations in the scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp17pelvl720x3v7****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

    }

}
