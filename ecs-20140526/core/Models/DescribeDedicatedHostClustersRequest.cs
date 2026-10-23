// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDedicatedHostClustersRequest : TeaModel {
        /// <summary>
        /// <para>The list of dedicated host cluster IDs. The value can be a JSON array that consists of multiple dedicated host cluster IDs in the following format: [&quot;dc-xxxxxxxxx&quot;, &quot;dc-yyyyyyyyy&quot;, ..., &quot;dc-zzzzzzzzz&quot;]. You can specify up to 100 IDs. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;dc-bp12wlf6am0vz9v2****&quot;, &quot;dc-bp12wlf6am0vz9v3****&quot;]</para>
        /// </summary>
        [NameInMap("DedicatedHostClusterIds")]
        [Validation(Required=false)]
        public string DedicatedHostClusterIds { get; set; }

        /// <summary>
        /// <para>The name of the dedicated host cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myDDHCluster</para>
        /// </summary>
        [NameInMap("DedicatedHostClusterName")]
        [Validation(Required=false)]
        public string DedicatedHostClusterName { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not available and is not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("LockReason")]
        [Validation(Required=false)]
        public string LockReason { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number of the dedicated host cluster list.</para>
        /// <para>Starting value: 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The paging Settings for the number of entries per page in a paged query.</para>
        /// <para>Maximum value: 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the dedicated host cluster. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the dedicated host cluster belongs. When you use this parameter to filter resources, the resource count cannot exceed 1,000.</para>
        /// <remarks>
        /// <para>Filtering by the default resource group is not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
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
        /// <remarks>
        /// <para>This parameter is not available and is not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDedicatedHostClustersRequestTag> Tag { get; set; }
        public class DescribeDedicatedHostClustersRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the dedicated host cluster. Valid values of N: 1 to 20. If you specify this parameter, it cannot be an empty string. The tag key can be up to 64 characters in length, and cannot start with aliyun or acs:, or contain http:// or https://.</para>
            /// <para>When you use a single tag to filter resources, the resource count returned cannot exceed 1,000. When you use multiple tags to filter resources, the resource count of resources attached to all the specified tags cannot exceed 1,000. If the resource count exceeds 1,000, call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation to query the resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the dedicated host cluster. Valid values of N: 1 to 20. If you specify this parameter, it cannot be an empty string. The tag value can be up to 64 characters in length, and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The zone ID of the dedicated host cluster. You can call the <a href="https://help.aliyun.com/document_detail/25610.html">DescribeZones</a> operation to query the zones in a region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-f</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
