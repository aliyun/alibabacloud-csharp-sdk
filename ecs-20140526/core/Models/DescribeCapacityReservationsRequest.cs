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
            /// <para>The IDs of the capacity reservations. The value can be a JSON array that consists of up to 100 capacity reservation IDs.</para>
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
        /// <item><description><para>PostPaid: pay-as-you-go.</para>
        /// </description></item>
        /// <item><description><para>PrePaid: subscription.</para>
        /// </description></item>
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
        /// <para>The instance type. You can use this parameter to query only active capacity reservations. To query released capacity reservations, you must specify <c>PrivatePoolOptions.Ids</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c6.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
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
        /// <para>The query token. Set the value to the <c>NextToken</c> value returned in the previous call to retrieve the next page of results.</para>
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
        /// <item><description><para>windows: Returns only capacity reservations for Windows.</para>
        /// </description></item>
        /// <item><description><para>linux: Returns only capacity reservations for Linux.</para>
        /// </description></item>
        /// <item><description><para>all: Returns all capacity reservations.</para>
        /// </description></item>
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
        /// <para>The region ID of the capacity reservation. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. When you use this parameter to filter resources, the operation returns a maximum of 1,000 resources.</para>
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
        /// <para>The status of the capacity reservation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>All: all statuses.</para>
        /// </description></item>
        /// <item><description><para>Pending: The capacity reservation is initializing. This is the initial status of a scheduled capacity reservation.</para>
        /// </description></item>
        /// <item><description><para>Preparing: The system is preparing resources for the scheduled capacity reservation.</para>
        /// </description></item>
        /// <item><description><para>Prepared: The resources are prepared, and the scheduled capacity reservation is waiting to take effect.</para>
        /// </description></item>
        /// <item><description><para>Active: The capacity reservation is active.</para>
        /// </description></item>
        /// <item><description><para>Released: The capacity reservation is released, either manually or automatically upon expiration.</para>
        /// </description></item>
        /// </list>
        /// <para>If you do not specify this parameter, the operation returns capacity reservations in all states except <c>Pending</c> and <c>Released</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags attached to the capacity reservations.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeCapacityReservationsRequestTag> Tag { get; set; }
        public class DescribeCapacityReservationsRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the Nth tag. You can specify up to 20 tags.</para>
            /// <para>A maximum of 1,000 resources that match the specified tags can be returned. If you specify multiple tags, only resources that have all of these tags are returned. If the number of matching resources exceeds 1,000, call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation to query the resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the Nth tag. You can specify up to 20 tags.</para>
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
