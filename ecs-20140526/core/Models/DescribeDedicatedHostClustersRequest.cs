// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDedicatedHostClustersRequest : TeaModel {
        /// <summary>
        /// <para>The list of host group IDs. The value can be a JSON array consisting of multiple IDs in the <c>[&quot;dc-xxxxxxxxx&quot;, &quot;dc-yyyyyyyyy&quot;,..., &quot;dc-zzzzzzzzz&quot;]</c> format. Separate the IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;dc-bp12wlf6am0vz9v2****&quot;, &quot;dc-bp12wlf6am0vz9v3****&quot;]</para>
        /// </summary>
        [NameInMap("DedicatedHostClusterIds")]
        [Validation(Required=false)]
        public string DedicatedHostClusterIds { get; set; }

        /// <summary>
        /// <para>The name of the host group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myDDHCluster</para>
        /// </summary>
        [NameInMap("DedicatedHostClusterName")]
        [Validation(Required=false)]
        public string DedicatedHostClusterName { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> This parameter is unavailable for use.</para>
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
        /// <para>The page number.</para>
        /// <para>Pages start from page 1.</para>
        /// <para>Default value: 1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
        /// <para>The region ID of the host group. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID of the host group. You can use a resource group ID to filter no more than 1,000 host groups.</para>
        /// <remarks>
        /// <para> A default resource group is not supported.</para>
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
        /// <para> This parameter is unavailable for use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags of the host group.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDedicatedHostClustersRequestTag> Tag { get; set; }
        public class DescribeDedicatedHostClustersRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. Valid values of N: 1 to 20. The tag key cannot be an empty string. It can be up to 64 characters in length, and can neither contain <c>http://</c> or <c>https://</c> nor <c>acs:</c> or <c>aliyun</c>.</para>
            /// <para>You can filter no more than 1,000 host groups, regardless of how many tags are used. To query more than 1,000 host groups, call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> API operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. Valid values of N: 1 to 20. The tag value cannot be an empty string. It can be up to 64 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The zone ID of the host group. You can call the <a href="https://help.aliyun.com/document_detail/25610.html">DescribeZones</a> operation to query the most recent zone list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-f</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
