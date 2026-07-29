// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class GetInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The instance details.</para>
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyInstance Instance { get; set; }
        public class GetInstanceResponseBodyInstance : TeaModel {
            /// <summary>
            /// <para>Indicates whether auto-renewal is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoRenewal")]
            [Validation(Required=false)]
            public string AutoRenewal { get; set; }

            /// <summary>
            /// <para>The cold storage capacity. Unit: GB. SSD is hot storage, which is also standard storage. HDD is cold storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>800</para>
            /// </summary>
            [NameInMap("ColdStorage")]
            [Validation(Required=false)]
            public long? ColdStorage { get; set; }

            /// <summary>
            /// <para>The commodity code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hologram_combo_public_cn</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The number of compute nodes. A node has 16 vCPUs and 32 GB of memory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ComputeNodeCount")]
            [Validation(Required=false)]
            public long? ComputeNodeCount { get; set; }

            /// <summary>
            /// <para>The number of vCPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public long? Cpu { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-03T13:06:06Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The size of the standard storage. Unit: GB.</para>
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

            /// <summary>
            /// <para>Indicates whether SSL is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableSSL")]
            [Validation(Required=false)]
            public bool? EnableSSL { get; set; }

            /// <summary>
            /// <para>Indicates whether Serverless Computing is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
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
                /// <para>Some earlier instances have both AnyTunnel and SingleTunnel enabled. When you switch from AnyTunnel to SingleTunnel, the endpoints for both are retained. This field is used to store the extra endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hgprecn-cn-uqm362o1b001-cn-hangzhou-internal.hologres.aliyuncs.com:80</para>
                /// </summary>
                [NameInMap("AlternativeEndpoints")]
                [Validation(Required=false)]
                public string AlternativeEndpoints { get; set; }

                /// <summary>
                /// <para>Indicates whether the network is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The domain name of the endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hgprecn-cn-uqm362o1b001-cn-hangzhou-internal.hologres.aliyuncs.com:80</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The network type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Internet</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1jqwp2ys6kp7tc9t983</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf66jjber3hgvwhki3wna</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The VPC instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hgprecn-cn-uqm362o1b001-frontend-st</para>
                /// </summary>
                [NameInMap("VpcInstanceId")]
                [Validation(Required=false)]
                public string VpcInstanceId { get; set; }

            }

            /// <summary>
            /// <para>The expiration time. Pay-as-you-go instances do not expire.</para>
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
            /// <para>The vCPU resources of the gateway. Unit: cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("GatewayCpu")]
            [Validation(Required=false)]
            public long? GatewayCpu { get; set; }

            /// <summary>
            /// <para>The memory resources of the gateway. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("GatewayMemory")]
            [Validation(Required=false)]
            public long? GatewayMemory { get; set; }

            /// <summary>
            /// <para>The billing method of the instance.</para>
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
            /// <para>The name of the instance. The name must be 2 to 64 characters in length. Each letter or Chinese character is counted as a single character.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The instance owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345678900000</para>
            /// </summary>
            [NameInMap("InstanceOwner")]
            [Validation(Required=false)]
            public string InstanceOwner { get; set; }

            /// <summary>
            /// <para>The instance status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// <para>The instance type.</para>
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
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The role of instance in disaster recovery. Active: the primary instance. Passive: the secondary instance. PreActive: a primary instance that has not reached the desired state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
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
            /// <para>The storage class:</para>
            /// <list type="bullet">
            /// <item><description><para>redundant: Zone-redundant storage</para>
            /// </description></item>
            /// <item><description><para>local: Locally redundant storage</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>redundant</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>The reason why the instance was stopped.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("SuspendReason")]
            [Validation(Required=false)]
            public string SuspendReason { get; set; }

            /// <summary>
            /// <para>The tags of the instance.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyInstanceTags> Tags { get; set; }
            public class GetInstanceResponseBodyInstanceTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
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
            /// <para>The zone ID.</para>
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
        /// <para>The result of the request, which indicates whether an exception occurred. This parameter is not related to the business logic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
