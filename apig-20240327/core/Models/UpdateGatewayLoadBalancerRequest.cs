// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateGatewayLoadBalancerRequest : TeaModel {
        /// <summary>
        /// <para>The load balancer operation DTO.</para>
        /// </summary>
        [NameInMap("loadBalancerDTO")]
        [Validation(Required=false)]
        public UpdateGatewayLoadBalancerRequestLoadBalancerDTO LoadBalancerDTO { get; set; }
        public class UpdateGatewayLoadBalancerRequestLoadBalancerDTO : TeaModel {
            /// <summary>
            /// <para>The load balancer instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-bp1xxxx</para>
            /// </summary>
            [NameInMap("loadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The load balancer type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CLB</para>
            /// </summary>
            [NameInMap("loadBalancerType")]
            [Validation(Required=false)]
            public string LoadBalancerType { get; set; }

            /// <summary>
            /// <para>The network type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Internet</para>
            /// </summary>
            [NameInMap("networkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// <para>The service weight. Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("serviceWeight")]
            [Validation(Required=false)]
            public long? ServiceWeight { get; set; }

            /// <summary>
            /// <para>The backend server group bindings.</para>
            /// </summary>
            [NameInMap("virtualServiceList")]
            [Validation(Required=false)]
            public List<UpdateGatewayLoadBalancerRequestLoadBalancerDTOVirtualServiceList> VirtualServiceList { get; set; }
            public class UpdateGatewayLoadBalancerRequestLoadBalancerDTOVirtualServiceList : TeaModel {
                /// <summary>
                /// <para>The port number. Valid values: 1 to 65535. An error is returned if an invalid value is specified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public long? Port { get; set; }

                /// <summary>
                /// <para>The protocol. This parameter is required for CLB. If this parameter is not specified for CLB, the error message &quot;protocol is missing for CLB&quot; is returned. No backend enumeration validation is performed. Valid values: tcp, udp, http, https, and tls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The CLB VServerGroupId or NLB ServerGroupId. This parameter is required. If a duplicate group ID is specified, an error is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rsp-xxxx</para>
                /// </summary>
                [NameInMap("virtualServiceGroupId")]
                [Validation(Required=false)]
                public string VirtualServiceGroupId { get; set; }

                /// <summary>
                /// <para>The group name. This parameter is required. If this parameter is not specified, the error message &quot;virtual service parameter is missing&quot; is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80-tcp</para>
                /// </summary>
                [NameInMap("virtualServiceGroupName")]
                [Validation(Required=false)]
                public string VirtualServiceGroupName { get; set; }

            }

        }

        /// <summary>
        /// <para>The operation type. If this parameter is left empty or not specified, only the listening ports are updated (only the ports field is used).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Add</para>
        /// </summary>
        [NameInMap("option")]
        [Validation(Required=false)]
        public string Option { get; set; }

        /// <summary>
        /// <para>The port list.</para>
        /// </summary>
        [NameInMap("ports")]
        [Validation(Required=false)]
        public List<UpdateGatewayLoadBalancerRequestPorts> Ports { get; set; }
        public class UpdateGatewayLoadBalancerRequestPorts : TeaModel {
            /// <summary>
            /// <para>The listening ports.</para>
            /// </summary>
            [NameInMap("gatewayLoadBalancerPorts")]
            [Validation(Required=false)]
            public List<UpdateGatewayLoadBalancerRequestPortsGatewayLoadBalancerPorts> GatewayLoadBalancerPorts { get; set; }
            public class UpdateGatewayLoadBalancerRequestPortsGatewayLoadBalancerPorts : TeaModel {
                /// <summary>
                /// <para>The listening port. Valid values: 0 to 65535. A maximum of 50 custom ports can be configured in the console.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <summary>
            /// <para>The load balancer type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NLB</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
