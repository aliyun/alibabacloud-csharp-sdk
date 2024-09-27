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
        /// <item><description>Normal: queries all reserved instances that belong to the current account.</description></item>
        /// <item><description>Shared: queries reserved instances that are shared between the main account and linked accounts.</description></item>
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
        /// <para>The instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g5.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The instance family. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g5</para>
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public string InstanceTypeFamily { get; set; }

        /// <summary>
        /// <para>The reason why the instance is locked. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>financial: You have an overdue payment in your account, or the reserved instance has expired.</description></item>
        /// <item><description>security: The reserved instance is locked for security reasons.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>security</para>
        /// </summary>
        [NameInMap("LockReason")]
        [Validation(Required=false)]
        public string LockReason { get; set; }

        /// <summary>
        /// <para>The payment option of the reserved instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>No Upfront</description></item>
        /// <item><description>Partial Upfront</description></item>
        /// <item><description>All Upfront</description></item>
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
        /// <para>The page number. Pages start from page 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the instances. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of reserved instance N. Valid values of N: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ri-bpzhex2ulpzf53****</para>
        /// </summary>
        [NameInMap("ReservedInstanceId")]
        [Validation(Required=false)]
        public List<string> ReservedInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the reserved instance.</para>
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
        /// <para>The scope of the reserved instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Region</description></item>
        /// <item><description>Zone</description></item>
        /// </list>
        /// <para>Default value: Region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Region</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The status of reserved instance N. Valid values of N: 1 to 100. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Creating</description></item>
        /// <item><description>Active</description></item>
        /// <item><description>Expired</description></item>
        /// <item><description>Updating</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<string> Status { get; set; }

        /// <summary>
        /// <para>The tags to add to the instances.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeReservedInstancesRequestTag> Tag { get; set; }
        public class DescribeReservedInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N to add to the reserved instance. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot contain <a href="http://https://%E3%80%82">http:// or https://</a>. The tag key cannot start with acs: or aliyun.</para>
            /// <para>Up to 1,000 resources with the specified tags can be returned in the response. To query more than 1,000 resources with the specified tags, call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N to add to the reserved instance. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot contain <a href="http://https://%E3%80%82">http:// or https://</a>. The tag value cannot start with acs:.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The zone ID of the reserved instances. This parameter is required when Scope is set to Zone. You can call the <a href="https://help.aliyun.com/document_detail/25610.html">DescribeZones</a> operation to query the most recent zone list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-z</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
