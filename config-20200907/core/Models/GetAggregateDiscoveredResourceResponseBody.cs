// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateDiscoveredResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the resource.</para>
        /// </summary>
        [NameInMap("DiscoveredResourceDetail")]
        [Validation(Required=false)]
        public GetAggregateDiscoveredResourceResponseBodyDiscoveredResourceDetail DiscoveredResourceDetail { get; set; }
        public class GetAggregateDiscoveredResourceResponseBodyDiscoveredResourceDetail : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100931896542****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// <para>The ID of the zone where the resource resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("AvailabilityZone")]
            [Validation(Required=false)]
            public string AvailabilityZone { get; set; }

            /// <summary>
            /// <para>The compliance evaluation result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>COMPLIANT: The resource is compliant.</para>
            /// </description></item>
            /// <item><description><para>NON_COMPLIANT: The resource is non-compliant.</para>
            /// </description></item>
            /// <item><description><para>NOT_APPLICABLE: The rule did not apply to your resource.</para>
            /// </description></item>
            /// <item><description><para>INSUFFICIENT_DATA: No data is available.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLIANT</para>
            /// </summary>
            [NameInMap("ComplianceType")]
            [Validation(Required=false)]
            public string ComplianceType { get; set; }

            /// <summary>
            /// <para>The configuration of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;ResourceGroupId\&quot;:\&quot;\&quot;,\&quot;Memory\&quot;:4096,\&quot;InstanceChargeType\&quot;:\&quot;PostPaid\&quot;,\&quot;Cpu\&quot;:2,\&quot;OSName\&quot;:\&quot;Windows Server  2022 数据中心版 64位中文版\&quot;,\&quot;InstanceNetworkType\&quot;:\&quot;vpc\&quot;,\&quot;InnerIpAddress\&quot;:{\&quot;IpAddress\&quot;:[]},\&quot;ExpiredTime\&quot;:\&quot;2099-12-31T15:59Z\&quot;,\&quot;ImageId\&quot;:\&quot;win2022_21H2_x64_dtc_zh-cn_40G_alibase_20240110.vhd\&quot;,\&quot;EipAddress\&quot;:{\&quot;AllocationId\&quot;:\&quot;\&quot;,\&quot;IpAddress\&quot;:\&quot;\&quot;,\&quot;InternetChargeType\&quot;:\&quot;\&quot;},\&quot;ImageOptions\&quot;:{},\&quot;VlanId\&quot;:\&quot;\&quot;,\&quot;HostName\&quot;:\&quot;iZl4i0brknq****\&quot;,\&quot;Status\&quot;:\&quot;Stopped\&quot;,\&quot;HibernationOptions\&quot;:{\&quot;Configured\&quot;:false},\&quot;MetadataOptions\&quot;:{\&quot;HttpTokens\&quot;:\&quot;\&quot;,\&quot;HttpEndpoint\&quot;:\&quot;\&quot;},\&quot;InstanceId\&quot;:\&quot;i-bp12g4xbl4i0brkn****\&quot;,\&quot;StoppedMode\&quot;:\&quot;KeepCharging\&quot;,\&quot;CpuOptions\&quot;:{\&quot;ThreadsPerCore\&quot;:2,\&quot;Numa\&quot;:\&quot;ON\&quot;,\&quot;CoreCount\&quot;:1},\&quot;StartTime\&quot;:\&quot;2024-02-29T07:08Z\&quot;,\&quot;DeletionProtection\&quot;:false,\&quot;VpcAttributes\&quot;:{\&quot;PrivateIpAddress\&quot;:{\&quot;IpAddress\&quot;:[\&quot;172.16.XX.XX\&quot;]},\&quot;VpcId\&quot;:\&quot;vpc-bp1wjaw8t272wwmkg****\&quot;,\&quot;VSwitchId\&quot;:\&quot;vsw-bp103i8xzww5132ul****\&quot;,\&quot;NatIpAddress\&quot;:\&quot;\&quot;},\&quot;SecurityGroupIds\&quot;:{\&quot;SecurityGroupId\&quot;:[\&quot;sg-bp1h96fz9fagaegp****\&quot;]},\&quot;InternetChargeType\&quot;:\&quot;PayByTraffic\&quot;,\&quot;InstanceName\&quot;:\&quot;test123\&quot;,\&quot;DeploymentSetId\&quot;:\&quot;\&quot;,\&quot;InternetMaxBandwidthOut\&quot;:5,\&quot;SerialNumber\&quot;:\&quot;6764f567-28fb-4a39-bfc3-48404995****\&quot;,\&quot;OSType\&quot;:\&quot;windows\&quot;,\&quot;CreationTime\&quot;:\&quot;2024-02-29T07:08Z\&quot;,\&quot;AutoReleaseTime\&quot;:\&quot;\&quot;,\&quot;Description\&quot;:\&quot;\&quot;,\&quot;InstanceTypeFamily\&quot;:\&quot;ecs.c7\&quot;,\&quot;DedicatedInstanceAttribute\&quot;:{\&quot;Tenancy\&quot;:\&quot;\&quot;,\&quot;Affinity\&quot;:\&quot;\&quot;},\&quot;PublicIpAddress\&quot;:{\&quot;IpAddress\&quot;:[\&quot;47.98.XX.XX\&quot;]},\&quot;GPUSpec\&quot;:\&quot;\&quot;,\&quot;NetworkInterfaces\&quot;:{\&quot;NetworkInterface\&quot;:[{\&quot;Type\&quot;:\&quot;Primary\&quot;,\&quot;PrimaryIpAddress\&quot;:\&quot;172.16.XX.XX\&quot;,\&quot;MacAddress\&quot;:\&quot;00:16:3e:0c:<b>:</b>\&quot;,\&quot;NetworkInterfaceId\&quot;:\&quot;eni-bp19uj35v8won3x9****\&quot;,\&quot;PrivateIpSets\&quot;:{\&quot;PrivateIpSet\&quot;:[{\&quot;PrivateIpAddress\&quot;:\&quot;172.16.XX.XX\&quot;,\&quot;Primary\&quot;:true}]}}]},\&quot;SpotPriceLimit\&quot;:0.0,\&quot;SaleCycle\&quot;:\&quot;\&quot;,\&quot;DeviceAvailable\&quot;:true,\&quot;InstanceType\&quot;:\&quot;ecs.c7.large\&quot;,\&quot;OSNameEn\&quot;:\&quot;Windows Server  2022 DataCenter Edition 64bit Chinese Edition\&quot;,\&quot;SpotStrategy\&quot;:\&quot;NoSpot\&quot;,\&quot;IoOptimized\&quot;:true,\&quot;ZoneId\&quot;:\&quot;cn-hangzhou-b\&quot;,\&quot;ClusterId\&quot;:\&quot;\&quot;,\&quot;EcsCapacityReservationAttr\&quot;:{\&quot;CapacityReservationPreference\&quot;:\&quot;\&quot;,\&quot;CapacityReservationId\&quot;:\&quot;\&quot;},\&quot;DedicatedHostAttribute\&quot;:{\&quot;DedicatedHostId\&quot;:\&quot;\&quot;,\&quot;DedicatedHostName\&quot;:\&quot;\&quot;,\&quot;DedicatedHostClusterId\&quot;:\&quot;\&quot;},\&quot;GPUAmount\&quot;:0,\&quot;OperationLocks\&quot;:{\&quot;LockReason\&quot;:[]},\&quot;InternetMaxBandwidthIn\&quot;:2000,\&quot;Recyclable\&quot;:false,\&quot;RegionId\&quot;:\&quot;cn-hangzhou\&quot;,\&quot;CreditSpecification\&quot;:\&quot;\&quot;}</para>
            /// </summary>
            [NameInMap("Configuration")]
            [Validation(Required=false)]
            public string Configuration { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The timestamp when the resource was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1624961112000</para>
            /// </summary>
            [NameInMap("ResourceCreationTime")]
            [Validation(Required=false)]
            public long? ResourceCreationTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the resource was deleted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1: The resource was not deleted.</para>
            /// </description></item>
            /// <item><description><para>0: The resource was deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ResourceDeleted")]
            [Validation(Required=false)]
            public int? ResourceDeleted { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp12g4xbl4i0brkn****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The resource name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test123</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <para>The resource status. The value of this parameter varies based on the resource type and may be empty. For example:</para>
            /// <list type="bullet">
            /// <item><description><para>If the ResourceType parameter is set to ACS::ECS::Instance, the resource is an ECS instance that has a specific state. In this case, the valid values of this parameter are Running and Stopped.</para>
            /// </description></item>
            /// <item><description><para>If the ResourceType parameter is ACS::OSS::Bucket, the resource is an Object Storage Service (OSS) bucket that is not in a specific state. In this case, this parameter is left empty.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Stopped</para>
            /// </summary>
            [NameInMap("ResourceStatus")]
            [Validation(Required=false)]
            public string ResourceStatus { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS::ECS::Instance</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The resource tags.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;\&quot;hc\&quot;\&quot;:[\&quot;\&quot;value2\&quot;\&quot;]}</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch to which the resource belongs, in the format of vsw-t4n7pokxxxxxxxxxxxxxx. If the resource belongs to multiple vSwitches, the IDs are separated by commas, such as vsw-t4n7pokxxxxxxxxxxxxxx, vsw-t4n7pokxxxxxxxxxxxxxx. If the resource does not belong to any vSwitch, an empty string is returned: &quot;&quot;</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-t4n7pokxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the VPC to which the resource belongs, in the format of vpc-t4nhheyvay74fp7n0hxxx. If the resource does not belong to a VPC, an empty string is returned: &quot;&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-t4nhheyvay74fp7n0hxxx</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E4D71ACE-6B0A-46E0-8352-56952378CC7F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
