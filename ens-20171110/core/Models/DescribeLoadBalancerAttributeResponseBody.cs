// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeLoadBalancerAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The IP address that the Edge Load Balancer (ELB) instance uses to provide services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168XX.XX</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The IP version of the ELB instance. Valid values: ipv4 and ipv6.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("AddressIPVersion")]
        [Validation(Required=false)]
        public string AddressIPVersion { get; set; }

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
            /// <para>The port that is used by the backend server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The ID of the backend server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-5vb5h5njxiuhn48a****</para>
            /// </summary>
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            /// <summary>
            /// <para>The type of backend server.</para>
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
        /// <para>The peak bandwidth of the ELB. The default value is -1, which indicates that the bandwidth is unlimited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The time when the ELB instance was created. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-05-21T12:22:00Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The time when the ELB instance was disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-05-21T12:22:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the ENS node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu-telecom</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The frontend ports that are used by the ELB instance.</para>
        /// </summary>
        [NameInMap("ListenerPorts")]
        [Validation(Required=false)]
        public List<string> ListenerPorts { get; set; }

        /// <summary>
        /// <para>The frontend ports and protocols that are used by the ELB instance.</para>
        /// </summary>
        [NameInMap("ListenerPortsAndProtocols")]
        [Validation(Required=false)]
        public List<DescribeLoadBalancerAttributeResponseBodyListenerPortsAndProtocols> ListenerPortsAndProtocols { get; set; }
        public class DescribeLoadBalancerAttributeResponseBodyListenerPortsAndProtocols : TeaModel {
            [NameInMap("BackendServerPort")]
            [Validation(Required=false)]
            public int? BackendServerPort { get; set; }

            /// <summary>
            /// <para>The description of the listener.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The destination listening port to which requests are forwarded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ForwardPort")]
            [Validation(Required=false)]
            public int? ForwardPort { get; set; }

            /// <summary>
            /// <para>Indicates whether the listener is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("ListenerForward")]
            [Validation(Required=false)]
            public string ListenerForward { get; set; }

            /// <summary>
            /// <para>The listener port of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }

            /// <summary>
            /// <para>The listener protocol of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("ListenerProtocol")]
            [Validation(Required=false)]
            public string ListenerProtocol { get; set; }

        }

        /// <summary>
        /// <para>The ID of the ELB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5rcvo1n1t3hykfhhjwjgqp****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The name of the ELB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// <para>The specifications of the ELB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>elb.s2.medium</para>
        /// </summary>
        [NameInMap("LoadBalancerSpec")]
        [Validation(Required=false)]
        public string LoadBalancerSpec { get; set; }

        /// <summary>
        /// <para>The status of the ELB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Active</b> (default): The listener for the instance can forward the received traffic based on the rule.</description></item>
        /// <item><description><b>InActive</b>: The listener for the instance does not forward the received traffic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("LoadBalancerStatus")]
        [Validation(Required=false)]
        public string LoadBalancerStatus { get; set; }

        /// <summary>
        /// <para>The ID of the network.</para>
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
        /// <item><description><b>PostPaid</b>: pay-as-you-go. Only this billing method is supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-5s78m2pdr9osa0j64bn78****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
