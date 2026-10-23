// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeReservedInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The allocation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Normal: queries the reserved instances under the current account.</description></item>
        /// <item><description>Shared: queries the reserved instances that are shared between the main account and linked accounts under the current account.</description></item>
        /// </list>
        /// <para>Default value: Normal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("AllocationType")]
        [Validation(Required=false)]
        public string AllocationType { get; set; }

        /// <summary>
        /// <para>The instance type that matches the reserved instance. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>. </para>
        /// <remarks>
        /// <para>This is the instance type selected when you purchase the reserved instance. When the reserved instance is applied, a regional reserved instance can be applied to different instance types within the same instance family based on the equivalence calculation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g5.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The instance family that matches the reserved instance. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g5</para>
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public string InstanceTypeFamily { get; set; }

        /// <summary>
        /// <para>The lock type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>financial: The account has overdue payments or the service has expired.</description></item>
        /// <item><description>security: The instance is locked for security reasons.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>security</para>
        /// </summary>
        [NameInMap("LockReason")]
        [Validation(Required=false)]
        public string LockReason { get; set; }

        /// <summary>
        /// <para>The payment type of the reserved instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>No Upfront: no upfront.</description></item>
        /// <item><description>Partial Upfront: partial upfront.</description></item>
        /// <item><description>All Upfront: all upfront.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>All Upfront</para>
        /// </summary>
        [NameInMap("OfferingType")]
        [Validation(Required=false)]
        public string OfferingType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number of the reserved instance list. Pages start from 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paging query. Maximum value: 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the reserved instance. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The reserved instance IDs. Array length: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ri-bpzhex2ulpzf53****</para>
        /// </summary>
        [NameInMap("ReservedInstanceId")]
        [Validation(Required=false)]
        public List<string> ReservedInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the reserved instance.</para>
        /// <remarks>
        /// <para>Exact match is used. Fuzzy match is not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testReservedInstanceName</para>
        /// </summary>
        [NameInMap("ReservedInstanceName")]
        [Validation(Required=false)]
        public string ReservedInstanceName { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The scope of the reserved instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Region: regional.</description></item>
        /// <item><description>Zone: zonal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Region</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The statuses of the reserved instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<string> Status { get; set; }

        /// <summary>
        /// <para>The tags. Array length: 1 to 20.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeReservedInstancesRequestTag> Tag { get; set; }
        public class DescribeReservedInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the reserved instance. The tag key cannot be an empty string and can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http:// or https://.</para>
            /// <remarks>
            /// <para>If you use a single tag to filter resources, the resource count returned cannot exceed 1,000. If you use multiple tags to filter resources, the resource count of resources that have multiple tags attached cannot exceed 1,000. If the resource count exceeds 1,000, call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation to query the resources.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the reserved instance. The tag value cannot be an empty string and can be up to 128 characters in length. It cannot start with <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The zone ID of the instance. This parameter is required and takes effect only when Scope is set to Zone. You can call the <a href="https://help.aliyun.com/document_detail/25610.html">DescribeZones</a> operation to query the zone list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-z</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
