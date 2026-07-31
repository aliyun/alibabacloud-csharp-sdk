// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyReservedInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The configuration information of the reserved instances. Array length: 1 to 100.</para>
        /// </summary>
        [NameInMap("Configuration")]
        [Validation(Required=false)]
        public List<ModifyReservedInstancesRequestConfiguration> Configuration { get; set; }
        public class ModifyReservedInstancesRequestConfiguration : TeaModel {
            /// <summary>
            /// <para>The number of pay-as-you-go instances of the same instance type that the reserved instance can match simultaneously. Valid values: ≥ 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstanceAmount")]
            [Validation(Required=false)]
            public int? InstanceAmount { get; set; }

            /// <summary>
            /// <para>The instance type that the reserved instance can match.</para>
            /// <remarks>
            /// <para>Applicable instance types are continuously updated. For more information, see <a href="~~100370#3c1b682051vt4~~">Reserved instance overview</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.c5.4xlarge</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The name of the reserved instance.</para>
            /// <para>The name must be 2 to 128 characters in length. It must start with a letter or Chinese character and cannot start with http:// or https://. It can contain digits, colons (:), underscores (_), or hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>testReservedInstanceName</para>
            /// </summary>
            [NameInMap("ReservedInstanceName")]
            [Validation(Required=false)]
            public string ReservedInstanceName { get; set; }

            /// <summary>
            /// <para>The scope of the reserved instance. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>Region: regional.</description></item>
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
            /// <para>The zone ID of the reserved instance.</para>
            /// <para>This parameter is required when the <c>Scope</c> parameter is set to <c>Zone</c>.</para>
            /// <para>You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeZones</a> to query the zone list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the reserved instance.</para>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IDs of the reserved instances. Array length: 1 to 20.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ReservedInstanceId.1=&quot;ecsri-bp1cx3****&quot;,ReservedInstanceId.2=&quot;ecsri-bp15xx2****&quot;......</para>
        /// </summary>
        [NameInMap("ReservedInstanceId")]
        [Validation(Required=false)]
        public List<string> ReservedInstanceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
