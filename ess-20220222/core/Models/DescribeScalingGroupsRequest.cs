// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The type of instances managed by the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ECS: The scaling group manages ECS instances.</para>
        /// </description></item>
        /// <item><description><para>ECI: The scaling group manages ECI instances.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The Settings for the number of entries per page during paging in a paged query. Maximum value: 50.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the scaling groups to query belong.</para>
        /// <remarks>
        /// <para>If no scaling group belongs to the specified resource group, an empty result is returned and no error is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rg-123******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The IDs of the scaling groups to query.</para>
        /// <para>Invalid scaling group IDs are ignored in the response and no error is returned.</para>
        /// </summary>
        [NameInMap("ScalingGroupIds")]
        [Validation(Required=false)]
        public List<string> ScalingGroupIds { get; set; }

        /// <summary>
        /// <para>The name of the scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scalinggroup****</para>
        /// </summary>
        [NameInMap("ScalingGroupName")]
        [Validation(Required=false)]
        public string ScalingGroupName { get; set; }

        /// <summary>
        /// <para>The names of the scaling groups to query.</para>
        /// <para>Invalid scaling group names are ignored in the response and no error is returned.</para>
        /// </summary>
        [NameInMap("ScalingGroupNames")]
        [Validation(Required=false)]
        public List<string> ScalingGroupNames { get; set; }

        /// <summary>
        /// <para>The tags of the scaling group.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeScalingGroupsRequestTags> Tags { get; set; }
        public class DescribeScalingGroupsRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Department</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Finance</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
