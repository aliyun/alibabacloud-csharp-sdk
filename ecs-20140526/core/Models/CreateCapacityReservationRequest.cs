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
            /// <para>The type of the private pool generated after the capacity reservation takes effect. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Open: open mode. When an instance is started, the system automatically matches the capacity of an open private pool. If no eligible private pool capacity is available, the instance is started by using public pool resources.</description></item>
            /// <item><description>Target: targeted mode. The instance is started by using the capacity of the specified private pool. If the capacity of the private pool is unavailable, the instance fails to be started.</description></item>
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
            /// <para>The name of the capacity reservation. The name must be 2 to 128 characters in length, and can contain letters and Chinese characters. It must start with a letter or a Chinese character, and cannot start with http:// or https://. It can contain digits, colons (:), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>crpTestName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, and you must make sure that the value is unique among different requests. The client token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the capacity reservation. The description must be 2 to 256 characters in length, and can contain letters and Chinese characters. It cannot start with http:// or https://.</para>
        /// <para>Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The expiration time of the capacity reservation. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be displayed in UTC+0. For more information, see <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-10-30T06:32:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The expiration pattern of the capacity reservation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Limited: releases the reservation at a specified time. You must also specify the EndTime parameter.</description></item>
        /// <item><description>Unlimited: manual release. The expiration time is not limited.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Unlimited</para>
        /// </summary>
        [NameInMap("EndTimeType")]
        [Validation(Required=false)]
        public string EndTimeType { get; set; }

        /// <summary>
        /// <para>The total number of instances to be reserved for the instance type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("InstanceAmount")]
        [Validation(Required=false)]
        public int? InstanceAmount { get; set; }

        /// <summary>
        /// <para>The billing method for the instance. Currently, only PostPaid (pay-as-you-go) is supported. Default value: PostPaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The instance type. Currently, you can configure the settings for a capacity reservation for only one instance type. You can invoke <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> to query the instance types of servers provided by Elastic Compute Service (ECS).</para>
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
        /// <para>The operating system type of the image used by the instance. This parameter corresponds to the Platform parameter of a regional reserved instance. If the operating system type of the capacity reservation matches that of the regional reserved instance, you can use the regional reserved instance to offset the bills for the unused capacity of the capacity reservation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Windows: Windows Server operating systems.</description></item>
        /// <item><description>Linux: Linux and Unix-like operating systems.</description></item>
        /// </list>
        /// <para>Default value: Linux.</para>
        /// <remarks>
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Linux</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The region ID of the capacity reservation. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the enterprise resource group to which the capacity reservation belongs.</para>
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
        /// <para>The effective mode of the capacity reservation. Currently, calling this API operation only supports setting the reservation to take effect immediately. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be displayed in UTC.</para>
        /// <remarks>
        /// <para>If this parameter is not specified, the capacity reservation takes effect immediately.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-10-30T05:32:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The list of tags bound to the capacity reservation.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateCapacityReservationRequestTag> Tag { get; set; }
        public class CreateCapacityReservationRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the capacity reservation. Valid values of N: 1 to 20. If this parameter is specified, it cannot be an empty string. The tag key can be up to 128 characters in length. It cannot start with aliyun or acs:, or contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the capacity reservation. Valid values of N: 1 to 20. If this parameter is specified, it can be an empty string. The tag value can be up to 128 characters in length. It cannot start with acs:, or contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The zone ID of the region to which the capacity reservation belongs. Currently, you can create a capacity reservation in only one zone.</para>
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
