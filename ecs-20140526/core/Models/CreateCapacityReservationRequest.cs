// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateCapacityReservationRequest : TeaModel {
        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public CreateCapacityReservationRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class CreateCapacityReservationRequestPrivatePoolOptions : TeaModel {
            /// <summary>
            /// <para>The type of the private pool that is generated after the capacity reservation takes effect. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Open: open mode. When you launch an instance, it is automatically matched with the capacity of an open private pool. If no suitable private pool capacity is available, the instance is launched by using public pool resources.</para>
            /// </description></item>
            /// <item><description><para>Target: targeted mode. The instance is launched by using the capacity of a specified private pool. If the capacity is unavailable, the instance fails to launch.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: Open.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Open</para>
            /// </summary>
            [NameInMap("MatchCriteria")]
            [Validation(Required=false)]
            public string MatchCriteria { get; set; }

            /// <summary>
            /// <para>The name of the capacity reservation. The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character and cannot start with <c>http://</c> or <c>https://</c>. It can contain digits, colons (:), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>crpTestName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>A client-generated token that ensures the request is idempotent. You can use the same token to retry a request. The <c>ClientToken</c> value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the capacity reservation. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// <para>Default value: empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The end time of the capacity reservation. Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC. For more information, see <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-10-30T06:32:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The release mode of the capacity reservation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Limited: The capacity reservation is automatically released at a specific time. You must also specify the <c>EndTime</c> parameter.</para>
        /// </description></item>
        /// <item><description><para>Unlimited: The capacity reservation must be released manually.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Unlimited</para>
        /// </summary>
        [NameInMap("EndTimeType")]
        [Validation(Required=false)]
        public string EndTimeType { get; set; }

        /// <summary>
        /// <para>The number of instances of the specified instance type for which to reserve capacity.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("InstanceAmount")]
        [Validation(Required=false)]
        public int? InstanceAmount { get; set; }

        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The instance type for which to reserve capacity. You can call <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> to view the instance types that ECS provides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.xlarge</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The operating system of the image used by the instance. This parameter corresponds to the <c>Platform</c> parameter of a regional reserved instance. If this platform matches the platform of a regional reserved instance, the regional reserved instance can be used to offset the costs of unused capacity in the reservation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Windows: Windows Server operating systems.</para>
        /// </description></item>
        /// <item><description><para>Linux: Linux and Unix-like operating systems.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: Linux.</para>
        /// <remarks>
        /// <para>This parameter is not yet available for use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Linux</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The ID of the region in which to create the capacity reservation. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the capacity reservation belongs.</para>
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
        /// <para>The time when the capacity reservation takes effect. The capacity reservation takes effect immediately after it is created.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the capacity reservation takes effect immediately.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-10-30T05:32:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The tags to add to the capacity reservation.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateCapacityReservationRequestTag> Tag { get; set; }
        public class CreateCapacityReservationRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the capacity reservation. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the capacity reservation. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot start with <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the zone in which you want to create the capacity reservation. A capacity reservation can reserve resources within only one zone.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public List<string> ZoneId { get; set; }

    }

}
