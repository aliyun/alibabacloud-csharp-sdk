// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateGatewayLoadBalancerResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateGatewayLoadBalancerResponseBodyData Data { get; set; }
        public class UpdateGatewayLoadBalancerResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the load balancer can be edited. This serves as the edit toggle for a load balancer that is being migrated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("editEnable")]
            [Validation(Required=false)]
            public bool? EditEnable { get; set; }

            /// <summary>
            /// <para>The load balancer address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.x.x.x</para>
            /// </summary>
            [NameInMap("loadBalancerAddress")]
            [Validation(Required=false)]
            public string LoadBalancerAddress { get; set; }

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
            /// <para>The load balancer name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-clb</para>
            /// </summary>
            [NameInMap("loadBalancerName")]
            [Validation(Required=false)]
            public string LoadBalancerName { get; set; }

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
            /// <para>The port information.</para>
            /// </summary>
            [NameInMap("ports")]
            [Validation(Required=false)]
            public List<int?> Ports { get; set; }

            /// <summary>
            /// <para>The gateway service weight for traffic shifting during migration. Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("serviceWeight")]
            [Validation(Required=false)]
            public long? ServiceWeight { get; set; }

            /// <summary>
            /// <para>The status description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Status description</para>
            /// </summary>
            [NameInMap("statusDescription")]
            [Validation(Required=false)]
            public string StatusDescription { get; set; }

            /// <summary>
            /// <para>The backend server group bindings.</para>
            /// </summary>
            [NameInMap("virtualServiceList")]
            [Validation(Required=false)]
            public List<UpdateGatewayLoadBalancerResponseBodyDataVirtualServiceList> VirtualServiceList { get; set; }
            public class UpdateGatewayLoadBalancerResponseBodyDataVirtualServiceList : TeaModel {
                /// <summary>
                /// <para>The port. When an NLB instance is associated, two placeholder entries with ports 80 and 443 are returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The protocol. When an NLB instance is associated, HTTP and HTTPS are returned as placeholders. For CLB, the value is deserialized from the stored vServerGroupMetaInfo.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The VServerGroup or ServerGroup ID. When an NLB instance is associated, this field is an empty string placeholder.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rsp-xxxx</para>
                /// </summary>
                [NameInMap("virtualServiceGroupId")]
                [Validation(Required=false)]
                public string VirtualServiceGroupId { get; set; }

                /// <summary>
                /// <para>The group name. When an NLB instance is associated, this field is an empty string placeholder.</para>
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
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEB8F71F-F889-599E-9D03-250978412350</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
