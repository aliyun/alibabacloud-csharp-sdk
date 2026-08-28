// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateGatewayLoadBalancerResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateGatewayLoadBalancerResponseBodyData Data { get; set; }
        public class UpdateGatewayLoadBalancerResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("editEnable")]
            [Validation(Required=false)]
            public bool? EditEnable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>47.x.x.x</para>
            /// </summary>
            [NameInMap("loadBalancerAddress")]
            [Validation(Required=false)]
            public string LoadBalancerAddress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>lb-bp1xxxx</para>
            /// </summary>
            [NameInMap("loadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my-clb</para>
            /// </summary>
            [NameInMap("loadBalancerName")]
            [Validation(Required=false)]
            public string LoadBalancerName { get; set; }

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

            [NameInMap("ports")]
            [Validation(Required=false)]
            public List<int?> Ports { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("serviceWeight")]
            [Validation(Required=false)]
            public long? ServiceWeight { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>状态描述</para>
            /// </summary>
            [NameInMap("statusDescription")]
            [Validation(Required=false)]
            public string StatusDescription { get; set; }

            [NameInMap("virtualServiceList")]
            [Validation(Required=false)]
            public List<UpdateGatewayLoadBalancerResponseBodyDataVirtualServiceList> VirtualServiceList { get; set; }
            public class UpdateGatewayLoadBalancerResponseBodyDataVirtualServiceList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public string Port { get; set; }

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
