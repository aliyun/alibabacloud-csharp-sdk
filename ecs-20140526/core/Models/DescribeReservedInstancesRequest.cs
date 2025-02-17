// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeReservedInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The allocation type of the reserved instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Normal: queries all reserved instances that belong to the current account.</description></item>
        /// <item><description>Shared: queries the reserved instances that are shared between the current main account and linked accounts.</description></item>
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
        /// <para>The instance type of the reserved instance. For information about the valid values, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a>.</para>
        /// <remarks>
        /// <para> Specify the instance type that you selected when you purchased the reserved instance. If the reserved instance is a regional reserved instance, it can be used to offset the bills of instance types that belong to the same instance family as the specified instance type, regardless of instance specifications.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g5.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The instance family of the reserved instance. For information about the valid values, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g5</para>
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public string InstanceTypeFamily { get; set; }

        /// <summary>
        /// <para>The reason why the reserved instance is locked. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>financial: The reserved instance is locked because the account has overdue payments or the service expires.</description></item>
        /// <item><description>security: The reserved instance is locked due to security reasons.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>security</para>
        /// </summary>
        [NameInMap("LockReason")]
        [Validation(Required=false)]
        public string LockReason { get; set; }

        /// <summary>
        /// <para>The payment option of the reserved instance. Valid values:</para>
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
        /// <para>The number of entries per page. Valid values: 1 to 100.</para>
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
        /// <para>The IDs of reserved instances. You can specify up to 100 IDs of reserved instances.</para>
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
        /// <para> Only exact search is supported.</para>
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
        /// <para>The scope level of the reserved instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Region: regional</description></item>
        /// <item><description>Zone: zonal</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Region</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The status of the reserved instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<string> Status { get; set; }

        /// <summary>
        /// <para>The tags of the reserved instance. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeReservedInstancesRequestTag> Tag { get; set; }
        public class DescribeReservedInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N of the reserved instance. The tag key cannot be empty and can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http:// or https://.</para>
            /// <remarks>
            /// <para> If you specify a single tag to query resources, up to 1,000 resources to which the tag is added are returned. If you specify multiple tags to query resources, up to 1,000 resources to which all specified tags are added are returned. To query more than 1,000 resources that have specified tags added, call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N of the reserved instance. The tag value cannot be empty and can be up to 128 characters in length. It cannot start with <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The zone ID of the reserved instance. This parameter is valid and required if you set Scope to Zone. You can call the <a href="https://help.aliyun.com/document_detail/25610.html">DescribeZones</a> operation to query the most recent zone list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-z</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
