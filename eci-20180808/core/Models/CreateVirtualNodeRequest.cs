// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class CreateVirtualNodeRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that the value is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The IP address of the DNS server. If dnsPolicy=ClusterFirst is configured for the Elastic Container Instance pod, Elastic Container Instance uses the configuration to provide DNS services to containers. You can configure multiple IP addresses. Separate multiple IP addresses with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>100.1.XX.XX</para>
        /// </summary>
        [NameInMap("ClusterDNS")]
        [Validation(Required=false)]
        public string ClusterDNS { get; set; }

        /// <summary>
        /// <para>The domain name of the cluster. If this parameter is specified, in addition to the search domain of the host, Kubelet configures all containers to search for the specified domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("ClusterDomain")]
        [Validation(Required=false)]
        public string ClusterDomain { get; set; }

        /// <summary>
        /// <para>The custom resources that are supported by the virtual node. If a custom resource is specified in the request of an Elastic Container Instance pod, the pod is scheduled to run on the virtual node that supports the custom resource. You can use the Resource name = Number of resources format to specify custom resources. Separate multiple resources with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>example1.com=100,example2.com=200</para>
        /// </summary>
        [NameInMap("CustomResources")]
        [Validation(Required=false)]
        public string CustomResources { get; set; }

        /// <summary>
        /// <para>The ID of the elastic IP address (EIP).</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-uf66jeqopgqa9hdn****</para>
        /// </summary>
        [NameInMap("EipInstanceId")]
        [Validation(Required=false)]
        public string EipInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Internet access for the VNode. Default value: false.</para>
        /// <para>If the value of this parameter is true, the VNode exposes a public IP address to external services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnablePublicNetwork")]
        [Validation(Required=false)]
        public bool? EnablePublicNetwork { get; set; }

        /// <summary>
        /// <para>The KubeConfig of the Kubernetes cluster with which the VNode is connected. The value must be Base64-encoded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JTVDbmFwaVZlcnNpb24lM0ElMjB2MSU1Q25jbHVzdGVycyUzQSU1Q24tJTIwY2x1c3RlciUzQSU1Q24uLi******</para>
        /// </summary>
        [NameInMap("KubeConfig")]
        [Validation(Required=false)]
        public string KubeConfig { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the virtual node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-uf66jeqopgqa9hdn****</para>
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
        /// <para>The ID of the security group. The VNode and the elastic container instances in the VNode are added to the security group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-2ze81zoc3yl7a3we****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The tags to add to the VNode. You can add up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateVirtualNodeRequestTag> Tag { get; set; }
        public class CreateVirtualNodeRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The taints of the VNode. You can configure up to 20 taints.</para>
        /// </summary>
        [NameInMap("Taint")]
        [Validation(Required=false)]
        public List<CreateVirtualNodeRequestTaint> Taint { get; set; }
        public class CreateVirtualNodeRequestTaint : TeaModel {
            /// <summary>
            /// <para>The effect of the taint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NoSchedule: does not schedule pods to run on the VNodes that have the taint.</description></item>
            /// <item><description>NoExecute: evicts existing pods on the VNodes that have the taint while not scheduling pods to run on the VNodes.</description></item>
            /// <item><description>PreferNoSchedule: avoids scheduling pods to run on the VNodes that have the taint.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NoSchedule</para>
            /// </summary>
            [NameInMap("Effect")]
            [Validation(Required=false)]
            public string Effect { get; set; }

            /// <summary>
            /// <para>The key of the taint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the taint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable TLS bootstrapping. If you set this parameter to true, use the KubeConfig certificate for TLS bootstrapping. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("TlsBootstrapEnabled")]
        [Validation(Required=false)]
        public bool? TlsBootstrapEnabled { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch. The vSwitch is connected to the VNode and the elastic container instances in the VNode.</para>
        /// <para>You can specify 1 to 10 vSwitches for a VPC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2ze23nqzig8inprou****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The name of the VNode. The name must be 2 to 128 characters in length, and can contain lowercase letters, digits, periods (.), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testNode</para>
        /// </summary>
        [NameInMap("VirtualNodeName")]
        [Validation(Required=false)]
        public string VirtualNodeName { get; set; }

        /// <summary>
        /// <para>The zone ID of the VNode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
