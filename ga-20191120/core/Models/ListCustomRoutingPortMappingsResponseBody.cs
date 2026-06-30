// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListCustomRoutingPortMappingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The information about the port mappings.</para>
        /// </summary>
        [NameInMap("PortMappings")]
        [Validation(Required=false)]
        public List<ListCustomRoutingPortMappingsResponseBodyPortMappings> PortMappings { get; set; }
        public class ListCustomRoutingPortMappingsResponseBodyPortMappings : TeaModel {
            /// <summary>
            /// <para>The ID of the GA instance to which the port mapping belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ga-bp1odcab8tmno0hdq****</para>
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// <para>The acceleration port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3000</para>
            /// </summary>
            [NameInMap("AcceleratorPort")]
            [Validation(Required=false)]
            public int? AcceleratorPort { get; set; }

            /// <summary>
            /// <para>The IP address and port of the backend service.</para>
            /// </summary>
            [NameInMap("DestinationSocketAddress")]
            [Validation(Required=false)]
            public ListCustomRoutingPortMappingsResponseBodyPortMappingsDestinationSocketAddress DestinationSocketAddress { get; set; }
            public class ListCustomRoutingPortMappingsResponseBodyPortMappingsDestinationSocketAddress : TeaModel {
                /// <summary>
                /// <para>The IP address of the backend service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.XX.XX</para>
                /// </summary>
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                /// <summary>
                /// <para>The port of the backend service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>443</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

            }

            /// <summary>
            /// <para>The traffic policy for the backend instance.</para>
            /// <list type="bullet">
            /// <item><description><para><b>allow</b>: allows the backend instance to receive traffic.</para>
            /// </description></item>
            /// <item><description><para><b>deny</b>: denies the backend instance from receiving traffic.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>allow</para>
            /// </summary>
            [NameInMap("DestinationTrafficState")]
            [Validation(Required=false)]
            public string DestinationTrafficState { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>epg-bp14sz7ftcwwjgrdm****</para>
            /// </summary>
            [NameInMap("EndpointGroupId")]
            [Validation(Required=false)]
            public string EndpointGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the region to which the endpoint group belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>us-west-1</para>
            /// </summary>
            [NameInMap("EndpointGroupRegion")]
            [Validation(Required=false)]
            public string EndpointGroupRegion { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ep-bp14sz7ftcwwjgrdm****</para>
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// <para>The ID of the custom routing listener to which the port mapping belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lsr-bp1bpn0kn908w4nbw****</para>
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// <para>The protocol of the backend service.</para>
            /// <list type="bullet">
            /// <item><description><para><b>TCP</b>: the TCP protocol.</para>
            /// </description></item>
            /// <item><description><para><b>UDP</b>: the UDP protocol.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("Protocols")]
            [Validation(Required=false)]
            public List<string> Protocols { get; set; }

            /// <summary>
            /// <para>The name of the vSwitch of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-test01</para>
            /// </summary>
            [NameInMap("Vswitch")]
            [Validation(Required=false)]
            public string Vswitch { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
