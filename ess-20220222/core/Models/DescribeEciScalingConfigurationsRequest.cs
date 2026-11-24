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
        /// <para>The page number of the scaling configuration list. Pages start from 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query. Settings for paging: Maximum value: 50.</para>
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
        /// <para>The IDs of the scaling configurations to be queried. You can specify 1 to 10 IDs.</para>
        /// <para>The query results include both active and inactive scaling configurations, which are identified by the LifecycleState response parameter.</para>
        /// </summary>
        [NameInMap("ScalingConfigurationIds")]
        [Validation(Required=false)]
        public List<string> ScalingConfigurationIds { get; set; }

        /// <summary>
        /// <para>The names of the scaling configurations to be queried. You can specify 1 to 10 names.</para>
        /// <para>Invalid scaling configuration names are ignored in the query results, and no error is reported.</para>
        /// </summary>
        [NameInMap("ScalingConfigurationNames")]
        [Validation(Required=false)]
        public List<string> ScalingConfigurationNames { get; set; }

        /// <summary>
        /// <para>The ID of the scaling group. You can query all scaling configurations in the scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp17pelvl720x3v7****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

    }

}
