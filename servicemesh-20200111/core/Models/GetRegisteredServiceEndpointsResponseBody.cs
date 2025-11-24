// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetRegisteredServiceEndpointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the registered service.</para>
        /// </summary>
        [NameInMap("EndPointSlice")]
        [Validation(Required=false)]
        public GetRegisteredServiceEndpointsResponseBodyEndPointSlice EndPointSlice { get; set; }
        public class GetRegisteredServiceEndpointsResponseBodyEndPointSlice : TeaModel {
            /// <summary>
            /// <para>The name of the pod.</para>
            /// </summary>
            [NameInMap("EndpointsDetails")]
            [Validation(Required=false)]
            public List<GetRegisteredServiceEndpointsResponseBodyEndPointSliceEndpointsDetails> EndpointsDetails { get; set; }
            public class GetRegisteredServiceEndpointsResponseBodyEndPointSliceEndpointsDetails : TeaModel {
                /// <summary>
                /// <para>The port of the registered service.</para>
                /// 
                /// <b>Example:</b>
                /// <para><c>127.2.**.**</c></para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>The ID of the region in which the registered service resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.demo.com">www.demo.com</a></para>
                /// </summary>
                [NameInMap("Hostname")]
                [Validation(Required=false)]
                public string Hostname { get; set; }

                /// <summary>
                /// <para>The IP address of the registered service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>provider-v1-8c86b6898-h***</para>
                /// </summary>
                [NameInMap("PodName")]
                [Validation(Required=false)]
                public string PodName { get; set; }

                /// <summary>
                /// <para>The host name of the registered service.</para>
                /// </summary>
                [NameInMap("Ports")]
                [Validation(Required=false)]
                public List<int?> Ports { get; set; }

                /// <summary>
                /// <para>Indicates whether sidecar proxies are injected. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: yes</description></item>
                /// <item><description><c>false</c>: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The ID of the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SidecarInjected")]
                [Validation(Required=false)]
                public bool? SidecarInjected { get; set; }

            }

            /// <summary>
            /// <para>The details of the endpoint of the registered service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MESH_INTERNAL</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <para>The location of the registered service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>MESH_INTERNAL</c>: The service is deployed inside the ASM instance.</description></item>
            /// <item><description><c>MESH_EXTERNAL</c>: The service is deployed outside the ASM instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The name of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>reviews</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>31d3a0f0-07ed-4f6e-9004-1804498c****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The IP address of the registered service.</para>
        /// </summary>
        [NameInMap("ServiceEndpoints")]
        [Validation(Required=false)]
        public List<GetRegisteredServiceEndpointsResponseBodyServiceEndpoints> ServiceEndpoints { get; set; }
        public class GetRegisteredServiceEndpointsResponseBodyServiceEndpoints : TeaModel {
            /// <summary>
            /// <para>The ID of the cluster on the data plane.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.25.153</para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>The details of the endpoints of the registered service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c80f45444b3da447da60a911390c2****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

        }

    }

}
