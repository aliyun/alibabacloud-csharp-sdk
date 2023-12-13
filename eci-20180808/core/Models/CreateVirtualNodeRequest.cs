// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class CreateVirtualNodeRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that the value is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The IP address of the DNS server. If dnsPolicy=ClusterFirst is configured for the Elastic Container Instance pod, Elastic Container Instance uses the configuration to provide DNS services to containers. You can configure multiple IP addresses. Separate multiple IP addresses with commas (,).
        /// </summary>
        [NameInMap("ClusterDNS")]
        [Validation(Required=false)]
        public string ClusterDNS { get; set; }

        /// <summary>
        /// The domain name of the cluster. If this parameter is specified, in addition to the search domain of the host, Kubelet configures all containers to search for the specified domain name.
        /// </summary>
        [NameInMap("ClusterDomain")]
        [Validation(Required=false)]
        public string ClusterDomain { get; set; }

        /// <summary>
        /// The custom resources that are supported by the virtual node. If a custom resource is specified in the request of an Elastic Container Instance pod, the pod is scheduled to run on the virtual node that supports the custom resource. You can use the Resource name = Number of resources format to specify custom resources. Separate multiple resources with commas (,).
        /// </summary>
        [NameInMap("CustomResources")]
        [Validation(Required=false)]
        public string CustomResources { get; set; }

        /// <summary>
        /// The ID of the elastic IP address (EIP).
        /// </summary>
        [NameInMap("EipInstanceId")]
        [Validation(Required=false)]
        public string EipInstanceId { get; set; }

        /// <summary>
        /// Specifies whether to enable Internet access for the VNode. Default value: false.
        /// 
        /// If the value of this parameter is true, the VNode exposes a public IP address to external services.
        /// </summary>
        [NameInMap("EnablePublicNetwork")]
        [Validation(Required=false)]
        public bool? EnablePublicNetwork { get; set; }

        /// <summary>
        /// KubeConfig of the Kubernetes cluster to which the VNode is to be connected. The value must be Base64-encoded.
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
        /// The region ID of the virtual node.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
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
        /// The ID of the security group. The VNode and the elastic container instances in the VNode are added to the security group.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// Tag.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateVirtualNodeRequestTag> Tag { get; set; }
        public class CreateVirtualNodeRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// Taint.
        /// </summary>
        [NameInMap("Taint")]
        [Validation(Required=false)]
        public List<CreateVirtualNodeRequestTaint> Taint { get; set; }
        public class CreateVirtualNodeRequestTaint : TeaModel {
            /// <summary>
            /// The effect of taint N. Valid values of N: 1 to 20. Valid values:
            /// 
            /// - NoSchedule: No pods are scheduled to the nodes that have the taint.
            /// - NoExecute: Existing pods in the node are evicted while no pods are scheduled to the nodes that have the taint.
            /// - PreferNoSchedule: Pods are preferentially not scheduled to the nodes that have the taint.
            /// </summary>
            [NameInMap("Effect")]
            [Validation(Required=false)]
            public string Effect { get; set; }

            /// <summary>
            /// The key of taint.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of taint.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// Specifies whether to enable TLS bootstrapping. If you set this parameter to true, use the KubeConfig certificate for TLS bootstrapping. Valid values:
        /// 
        /// - true
        /// - false
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("TlsBootstrapEnabled")]
        [Validation(Required=false)]
        public bool? TlsBootstrapEnabled { get; set; }

        /// <summary>
        /// The ID of the vSwitch. The vSwitch is connected to the VNode and the elastic container instances in the VNode.
        /// 
        /// You can specify 1 to 10 vSwitches for a VPC.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// he name of the VNode. The name must be 2 to 128 characters in length, and can contain lowercase letters, digits, periods (.), and hyphens (-).
        /// </summary>
        [NameInMap("VirtualNodeName")]
        [Validation(Required=false)]
        public string VirtualNodeName { get; set; }

        /// <summary>
        /// The zone ID of the VNode.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
