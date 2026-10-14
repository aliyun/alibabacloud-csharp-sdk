// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeLoadBalancerAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The service address of the load balancing instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The IP version of the load balancing instance. Valid values: ipv4 or ipv6.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("AddressIPVersion")]
        [Validation(Required=false)]
        public string AddressIPVersion { get; set; }

        /// <summary>
        /// <para>The address type of the load balancing instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internet</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <para>The list of backend servers.</para>
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public List<DescribeLoadBalancerAttributeResponseBodyBackendServers> BackendServers { get; set; }
        public class DescribeLoadBalancerAttributeResponseBodyBackendServers : TeaModel {
            /// <summary>
            /// <para>The IP address of the backend server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The port used by the backend server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The instance ID of the backend server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-5vb5h5njxiuhn48a****</para>
            /// </summary>
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            /// <summary>
            /// <para>The server type of the backend server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ens</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The weight of the backend server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The peak bandwidth of the load balancing instance. The default value is -1, which indicates that bandwidth is not throttled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The creation time of the load balancing instance (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-05-21T12:22:00Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The end time of the load balancing instance in ISO 8601 UTC format (YYYY-MM-DDTHH:mm:ssZ).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-05-21T12:22:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ENS node ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu-telecom</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The frontend ports used by the load balancing instance.</para>
        /// </summary>
        [NameInMap("ListenerPorts")]
        [Validation(Required=false)]
        public List<string> ListenerPorts { get; set; }

        /// <summary>
        /// <para>The frontend ports and protocols used by the load balancing instance.</para>
        /// </summary>
        [NameInMap("ListenerPortsAndProtocols")]
        [Validation(Required=false)]
        public List<DescribeLoadBalancerAttributeResponseBodyListenerPortsAndProtocols> ListenerPortsAndProtocols { get; set; }
        public class DescribeLoadBalancerAttributeResponseBodyListenerPortsAndProtocols : TeaModel {
            /// <summary>
            /// <para>The backend port used by the load balancing instance. Valid values: <b>1</b> to <b>65535</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6000</para>
            /// </summary>
            [NameInMap("BackendServerPort")]
            [Validation(Required=false)]
            public int? BackendServerPort { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The destination listener port to which traffic is forwarded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ForwardPort")]
            [Validation(Required=false)]
            public int? ForwardPort { get; set; }

            /// <summary>
            /// <para>Indicates whether listener forwarding is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("ListenerForward")]
            [Validation(Required=false)]
            public string ListenerForward { get; set; }

            /// <summary>
            /// <para>The listener port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }

            /// <summary>
            /// <para>The listener protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("ListenerProtocol")]
            [Validation(Required=false)]
            public string ListenerProtocol { get; set; }

        }

        /// <summary>
        /// <para>The ID of the load balancing instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5rcvo1n1t3hykfhhjwjgqp****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The name of the load balancing instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// <para>The specification of the load balancing instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>elb.s2.medium</para>
        /// </summary>
        [NameInMap("LoadBalancerSpec")]
        [Validation(Required=false)]
        public string LoadBalancerSpec { get; set; }

        /// <summary>
        /// <para>The listener status of the load balancing instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Active</b>: The listeners of the instance can forward received traffic based on rules.</description></item>
        /// <item><description><b>InActive</b>: The listeners of the instance no longer forward received traffic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("LoadBalancerStatus")]
        [Validation(Required=false)]
        public string LoadBalancerStatus { get; set; }

        /// <summary>
        /// <para>The type of the load balancing instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CLB</para>
        /// </summary>
        [NameInMap("LoadBalancerType")]
        [Validation(Required=false)]
        public string LoadBalancerType { get; set; }

        /// <summary>
        /// <para>The network ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n-5rwbi3g9zvgxcsiufwhw8****</para>
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrePaid</b>: subscription.</description></item>
        /// <item><description><b>PostPaid</b> (currently the only supported billing method): pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-5s78m2pdr9osa0j64bn78****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
