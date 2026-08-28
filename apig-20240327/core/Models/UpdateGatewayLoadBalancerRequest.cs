// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateGatewayLoadBalancerRequest : TeaModel {
        [NameInMap("loadBalancerDTO")]
        [Validation(Required=false)]
        public UpdateGatewayLoadBalancerRequestLoadBalancerDTO LoadBalancerDTO { get; set; }
        public class UpdateGatewayLoadBalancerRequestLoadBalancerDTO : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>lb-bp1xxxx</para>
            /// </summary>
            [NameInMap("loadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CLB</para>
            /// </summary>
            [NameInMap("loadBalancerType")]
            [Validation(Required=false)]
            public string LoadBalancerType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Internet</para>
            /// </summary>
            [NameInMap("networkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("serviceWeight")]
            [Validation(Required=false)]
            public long? ServiceWeight { get; set; }

            [NameInMap("virtualServiceList")]
            [Validation(Required=false)]
            public List<UpdateGatewayLoadBalancerRequestLoadBalancerDTOVirtualServiceList> VirtualServiceList { get; set; }
            public class UpdateGatewayLoadBalancerRequestLoadBalancerDTOVirtualServiceList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public long? Port { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>http</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rsp-xxxx</para>
                /// </summary>
                [NameInMap("virtualServiceGroupId")]
                [Validation(Required=false)]
                public string VirtualServiceGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>80-tcp</para>
                /// </summary>
                [NameInMap("virtualServiceGroupName")]
                [Validation(Required=false)]
                public string VirtualServiceGroupName { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Add</para>
        /// </summary>
        [NameInMap("option")]
        [Validation(Required=false)]
        public string Option { get; set; }

        [NameInMap("ports")]
        [Validation(Required=false)]
        public List<UpdateGatewayLoadBalancerRequestPorts> Ports { get; set; }
        public class UpdateGatewayLoadBalancerRequestPorts : TeaModel {
            [NameInMap("gatewayLoadBalancerPorts")]
            [Validation(Required=false)]
            public List<UpdateGatewayLoadBalancerRequestPortsGatewayLoadBalancerPorts> GatewayLoadBalancerPorts { get; set; }
            public class UpdateGatewayLoadBalancerRequestPortsGatewayLoadBalancerPorts : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NLB</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
