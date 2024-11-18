// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class GetInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code that is returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>404</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internal server error.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The information about the instance.</para>
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyInstance Instance { get; set; }
        public class GetInstanceResponseBodyInstance : TeaModel {
            /// <summary>
            /// <para>Indicates whether auto-renewal is enabled.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>false</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoRenewal")]
            [Validation(Required=false)]
            public string AutoRenewal { get; set; }

            /// <summary>
            /// <para>The cold storage capacity of the instance. Unit: GB. Standard SSD is used for hot storage, and HDD is used for cold storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>800</para>
            /// </summary>
            [NameInMap("ColdStorage")]
            [Validation(Required=false)]
            public long? ColdStorage { get; set; }

            /// <summary>
            /// <para>The commodity code.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>hologram_maxcomputeAccelerate_public_cn</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>China site/Lakehouse Acceleration Edition</para>
            /// <!-- -->
            /// 
            /// <para>.</para>
            /// </description></item>
            /// <item><description><para>hologram_combo_public_cn</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>China site/Subscription</para>
            /// <!-- -->
            /// 
            /// <para>.</para>
            /// </description></item>
            /// <item><description><para>hologram_prepay_public_intl</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>International site/Subscription</para>
            /// <!-- -->
            /// 
            /// <para>.</para>
            /// </description></item>
            /// <item><description><para>hologram_storage_dp_cn</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>China site/Storage plan</para>
            /// <!-- -->
            /// 
            /// <para>.</para>
            /// </description></item>
            /// <item><description><para>hologram_postpay_public_cn</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>China site/Pay-as-you-go</para>
            /// <!-- -->
            /// 
            /// <para>.</para>
            /// </description></item>
            /// <item><description><para>hologram_postpay_public_intl</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>International site/Pay-as-you-go</para>
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>hologram_maxcomputeAccelerate_public_intl</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>International site/Lakehouse Acceleration Edition</para>
            /// <!-- -->
            /// 
            /// <para>.</para>
            /// </description></item>
            /// <item><description><para>hologram_cu_dp_cn</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>China site/Compute plan</para>
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>hologram_combo_public_cn</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The number of compute nodes. In a typical configuration, a node has 16 CPU cores and 32 GB of memory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ComputeNodeCount")]
            [Validation(Required=false)]
            public long? ComputeNodeCount { get; set; }

            /// <summary>
            /// <para>The number of CPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public long? Cpu { get; set; }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-03T13:06:06Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The amount of data that can be stored in the disk of the Standard storage class. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("Disk")]
            [Validation(Required=false)]
            public string Disk { get; set; }

            /// <summary>
            /// <para>Indicates whether data lake acceleration is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableHiveAccess")]
            [Validation(Required=false)]
            public string EnableHiveAccess { get; set; }

            [NameInMap("EnableServerless")]
            [Validation(Required=false)]
            public bool? EnableServerless { get; set; }

            /// <summary>
            /// <para>The list of endpoints.</para>
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyInstanceEndpoints> Endpoints { get; set; }
            public class GetInstanceResponseBodyInstanceEndpoints : TeaModel {
                /// <summary>
                /// <para>The endpoint. This parameter is returned if both the AnyTunnel and SingleTunnel modes are enabled for an instance, and the instance is switched from the AnyTunnel mode to the SingleTunnel mode. In this case, two endpoints are returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hgprecn-cn-uqm362o1b001-cn-hangzhou-internal.hologres.aliyuncs.com:80</para>
                /// </summary>
                [NameInMap("AlternativeEndpoints")]
                [Validation(Required=false)]
                public string AlternativeEndpoints { get; set; }

                /// <summary>
                /// <para>Indicates whether the network is enabled.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- -->
                /// </description></item>
                /// <item><description><para>false</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- --></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hgprecn-cn-uqm362o1b001-cn-hangzhou-internal.hologres.aliyuncs.com:80</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The network type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>VPCSingleTunnel</para>
                /// <!-- -->
                /// 
                /// <para>:</para>
                /// <!-- -->
                /// 
                /// <para>virtual private cloud (VPC)</para>
                /// <!-- -->
                /// 
                /// <para>.</para>
                /// </description></item>
                /// <item><description><para>Intranet</para>
                /// <!-- -->
                /// 
                /// <para>:</para>
                /// <!-- -->
                /// 
                /// <para>internal network</para>
                /// <!-- -->
                /// 
                /// <para>.</para>
                /// </description></item>
                /// <item><description><para>VPCAnyTunnel</para>
                /// <!-- -->
                /// 
                /// <para>:</para>
                /// <!-- -->
                /// 
                /// <para>not supported by new instances</para>
                /// <!-- -->
                /// </description></item>
                /// <item><description><para>Internet</para>
                /// <!-- -->
                /// 
                /// <para>:</para>
                /// <!-- -->
                /// 
                /// <para>Internet</para>
                /// <!-- -->
                /// 
                /// <para>.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Internet</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1jqwp2ys6kp7tc9t983</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The ID of the VPC to which the instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf66jjber3hgvwhki3wna</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The ID of the instance that is deployed in the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hgprecn-cn-uqm362o1b001-frontend-st</para>
                /// </summary>
                [NameInMap("VpcInstanceId")]
                [Validation(Required=false)]
                public string VpcInstanceId { get; set; }

            }

            /// <summary>
            /// <para>The expiration time. This parameter is invalid for pay-as-you-go instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-03T13:06:06Z</para>
            /// </summary>
            [NameInMap("ExpirationTime")]
            [Validation(Required=false)]
            public string ExpirationTime { get; set; }

            /// <summary>
            /// <para>The number of gateway nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("GatewayCount")]
            [Validation(Required=false)]
            public long? GatewayCount { get; set; }

            /// <summary>
            /// <para>The number of CPU cores of the gateway. Unit: core.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("GatewayCpu")]
            [Validation(Required=false)]
            public long? GatewayCpu { get; set; }

            /// <summary>
            /// <para>The size of memory resources of the gateway. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("GatewayMemory")]
            [Validation(Required=false)]
            public long? GatewayMemory { get; set; }

            /// <summary>
            /// <para>The billing method of the instance.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PostPaid</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>pay-as-you-go</para>
            /// <!-- -->
            /// 
            /// <para>.</para>
            /// </description></item>
            /// <item><description><para>PrePaid</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>subscription</para>
            /// <!-- -->
            /// 
            /// <para>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("InstanceChargeType")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hgpostcn-cn-tl32s6cgw00b</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance name. The instance name must be 2 to 64 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The owner of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345678900000</para>
            /// </summary>
            [NameInMap("InstanceOwner")]
            [Validation(Required=false)]
            public string InstanceOwner { get; set; }

            /// <summary>
            /// <para>The status of the instance.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Creating</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>Running</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>Suspended</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>Allocating</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// <para>The type of the instance.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Follower</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>read-only secondary instance</para>
            /// <!-- -->
            /// 
            /// <para>.</para>
            /// </description></item>
            /// <item><description><para>Standard</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>normal instance</para>
            /// <!-- -->
            /// 
            /// <para>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The ID of the primary instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hgpostcn-cn-i7m2ncd6w002</para>
            /// </summary>
            [NameInMap("LeaderInstanceId")]
            [Validation(Required=false)]
            public string LeaderInstanceId { get; set; }

            /// <summary>
            /// <para>The memory size. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <para>The ID of the region in which the instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ReplicaRole")]
            [Validation(Required=false)]
            public string ReplicaRole { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzuq7hpybze2i</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The reason for the suspension.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Indebet</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>The instance has an overdue payment</para>
            /// <!-- -->
            /// 
            /// <para>.</para>
            /// </description></item>
            /// <item><description><para>Manual</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>The instance is manually suspended</para>
            /// <!-- -->
            /// 
            /// <para>.</para>
            /// </description></item>
            /// <item><description><para>Overdue</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>The instance has expired</para>
            /// <!-- -->
            /// 
            /// <para>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("SuspendReason")]
            [Validation(Required=false)]
            public string SuspendReason { get; set; }

            /// <summary>
            /// <para>The instance tag.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyInstanceTags> Tags { get; set; }
            public class GetInstanceResponseBodyInstanceTags : TeaModel {
                /// <summary>
                /// <para>The key of tag N.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of tag N.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The instance version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>r1.3.37</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The ID of the zone where the instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>865A02C2-B374-5DD4-9B34-0CA15DA1AEBD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The request result, which indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
