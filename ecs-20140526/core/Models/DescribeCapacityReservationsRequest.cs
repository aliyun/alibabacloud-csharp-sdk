// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeCapacityReservationsRequest : TeaModel {
        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public DescribeCapacityReservationsRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class DescribeCapacityReservationsRequestPrivatePoolOptions : TeaModel {
            /// <summary>
            /// <para>The IDs of the capacity reservations. The value can be a JSON array that consists of up to 100 IDs. Separate multiple IDs with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;crp-bp1gubrkqutenqdd****&quot;, &quot;crp-bp67acfmxazb5****&quot;]</para>
            /// </summary>
            [NameInMap("Ids")]
            [Validation(Required=false)]
            public string Ids { get; set; }

        }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PostPaid: Pay-as-you-go.</description></item>
        /// <item><description>PrePaid: Subscription.</description></item>
        /// </list>
        /// <para>Default value: PostPaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The instance type. You can use this parameter to query only active capacity reservations. To query released capacity reservations, you can only use the PrivatePoolOptions.Ids parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c6.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paging query.</para>
        /// <para>Maximum value: 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the capacity reservation query. Obtain the token from the response of the previous request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The operating system of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>windows: Queries only capacity reservations for Windows instances.</description></item>
        /// <item><description>linux: Queries only capacity reservations for Linux instances.</description></item>
        /// <item><description>all: Queries all capacity reservations.</description></item>
        /// </list>
        /// <para>Default value: all.</para>
        /// 
        /// <b>Example:</b>
        /// <para>linux</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The region ID of the capacity reservation. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. When you use this parameter to filter resources, the resource count cannot exceed 1,000.</para>
        /// <remarks>
        /// <para>Default resource group filtering is not supported.</para>
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
        /// <para>The status of the capacity reservation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>All: All statuses.</description></item>
        /// <item><description>Pending: Initialization. Capacity reservations that take effect at a specified time enter the initialization status first.</description></item>
        /// <item><description>Preparing: Preparing. Capacity reservations that take effect at a specified time are in the preparing status during resource delivery.</description></item>
        /// <item><description>Prepared: Pending. Capacity reservations that take effect at a specified time are in the pending status after resource delivery is complete and before the service officially takes effect.</description></item>
        /// <item><description>Active: Active.</description></item>
        /// <item><description>Released: Released, including manual release and automatic release upon expiration.</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, capacity reservations in all statuses except Pending and Released are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags bound to the capacity reservation.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeCapacityReservationsRequestTag> Tag { get; set; }
        public class DescribeCapacityReservationsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. N specifies that you can configure multiple tag keys for filtering. Valid values of N: 1 to 20.</para>
            /// <para>If you use a single tag to filter resources, the resource count returned cannot exceed 1,000. If you use multiple tags to filter resources, the resource count of resources that are attached to all the specified tags cannot exceed 1,000. If the resource count exceeds 1,000, call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation to query the resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. N specifies that you can configure multiple tag values for filtering. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The zone ID of the capacity reservation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
