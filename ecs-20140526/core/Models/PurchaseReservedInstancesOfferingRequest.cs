// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class PurchaseReservedInstancesOfferingRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables auto-renewal.</description></item>
        /// <item><description>false (default): disables auto-renewal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal period, in months. This parameter takes effect only when AutoRenew is set to True.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;Valid values of AutoRenewPeriod: 1, 12, 36, and 60.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;If PeriodUnit is set to Month, the default value is 1.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;Valid values of AutoRenewPeriod: 12 and 36.</para>
        /// <para>If PeriodUnit is set to Year, the default value is 12.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. The <b>ClientToken</b> value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the reserved instance. The description must be 2 to 256 characters in length and cannot start with http:// or https://.</para>
        /// <para>Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The number of pay-as-you-go instances of the same instance type that the reserved instance can match at the same time. Valid values: 1 to 50.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("InstanceAmount")]
        [Validation(Required=false)]
        public int? InstanceAmount { get; set; }

        /// <summary>
        /// <para>The instance type that the reserved instance can match.</para>
        /// <remarks>
        /// <para>Applicable instance types are continuously updated. For more information, see <a href="~~100370#3c1b682051vt4~~">Overview of reserved instances</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g5.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The payment type of the reserved instance. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>No Upfront: no upfront.</description></item>
        /// <item><description>Partial Upfront: partial upfront.</description></item>
        /// <item><description>All Upfront: all upfront.</description></item>
        /// </list>
        /// <para>Default value: All Upfront.</para>
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
        /// <para>The term of the reserved instance.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;Valid values: 1 and 3.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Year</c>, valid values are 1, 3, and 5.</para>
        /// </description></item>
        /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Month</c>, the valid value is 1.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the term of the reserved instance.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;Valid values: Year.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;Default value: Year.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;Valid values: Year and Month.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;Default value: Month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The operating system type of the image used by the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Windows: Windows Server operating system.</description></item>
        /// <item><description>Linux: Linux and Unix-like operating system.</description></item>
        /// </list>
        /// <para>Default value: Linux.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Linux</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the reserved instance. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with http:// or https://. The name can contain letters, digits, colons (:), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testReservedInstanceName</para>
        /// </summary>
        [NameInMap("ReservedInstanceName")]
        [Validation(Required=false)]
        public string ReservedInstanceName { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp199lyny9b3****</para>
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
        /// <para>The scope of the reserved instance. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>Region: regional. </description></item>
        /// <item><description>Zone: zonal.</description></item>
        /// </list>
        /// <para>Default value: Region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zone</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The effective period of the reserved instance. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in UTC+0. Format: <c>yyyy-MM-ddTHHZ</c>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the effective period starts from the nearest time frame by default. For example, if you successfully purchase a reserved instance at 2024-11-01 13:45:35, the effective period starts at 2024-11-01 13:00:00.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2024-07-04T15Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The tags. Array length: 0 to 20.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<PurchaseReservedInstancesOfferingRequestTag> Tag { get; set; }
        public class PurchaseReservedInstancesOfferingRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the reserved instance. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the reserved instance. The tag value cannot be an empty string. The tag value can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The zone ID. This parameter is required and takes effect only when <c>Scope</c> is set to <c>Zone</c>. You can call <a href="https://help.aliyun.com/document_detail/25610.html">DescribeZones</a> to query the zone list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
