// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagPortRouteProtocolListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of port information.</para>
        /// </summary>
        [NameInMap("Ports")]
        [Validation(Required=false)]
        public List<DescribeSagPortRouteProtocolListResponseBodyPorts> Ports { get; set; }
        public class DescribeSagPortRouteProtocolListResponseBodyPorts : TeaModel {
            /// <summary>
            /// <para>The neighbor IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.XX.XX.1</para>
            /// </summary>
            [NameInMap("NeighborIp")]
            [Validation(Required=false)]
            public string NeighborIp { get; set; }

            /// <summary>
            /// <para>The port name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("PortName")]
            [Validation(Required=false)]
            public string PortName { get; set; }

            /// <summary>
            /// <para>The autonomous system number of the peer BGP network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("RemoteAs")]
            [Validation(Required=false)]
            public string RemoteAs { get; set; }

            /// <summary>
            /// <para>The IP address of the peer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.XX.XX.1</para>
            /// </summary>
            [NameInMap("RemoteIp")]
            [Validation(Required=false)]
            public string RemoteIp { get; set; }

            /// <summary>
            /// <para>The routable protocol of the port. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>STATIC</b>: static routable protocol.</description></item>
            /// <item><description><b>OSPF</b>: OSPF dynamic routable protocol.</description></item>
            /// <item><description><b>BGP</b>: BGP dynamic routable protocol.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BGP</para>
            /// </summary>
            [NameInMap("RouteProtocol")]
            [Validation(Required=false)]
            public string RouteProtocol { get; set; }

            /// <summary>
            /// <para>The port status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UP</b>: The port is enabled.</description></item>
            /// <item><description><b>DOWN</b>: The port is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UP</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The VLAN ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Vlan")]
            [Validation(Required=false)]
            public string Vlan { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE6642D4-21EB-4168-9BF9-F217953F9892</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The query task status.</para>
        /// </summary>
        [NameInMap("TaskStates")]
        [Validation(Required=false)]
        public List<DescribeSagPortRouteProtocolListResponseBodyTaskStates> TaskStates { get; set; }
        public class DescribeSagPortRouteProtocolListResponseBodyTaskStates : TeaModel {
            /// <summary>
            /// <para>The time when the query task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1586843621000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error code. A value of 200 indicates that the query task succeeded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message. A value of Successful indicates that the query task succeeded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Successful</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The status of the asynchronous task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Initialized</b>: The query task is initialized.</description></item>
            /// <item><description><b>Offline</b>: The Smart Access Gateway device is offline and the query task has not been delivered. The task will be delivered after the device comes online.</description></item>
            /// <item><description><b>Succeed</b>: The query task is delivered.</description></item>
            /// <item><description><b>Processing</b>: The query task is being delivered.</description></item>
            /// <item><description><b>VersionNotSupport</b>: The current version of the Smart Access Gateway device does not support this operation.</description></item>
            /// <item><description><b>BuildRequestError</b>: The China Cloud Management Platform does not support this operation.</description></item>
            /// <item><description><b>HardwareError</b>: The query task failed to be delivered due to a device error.</description></item>
            /// <item><description><b>TaskNotExist</b>: The query task does not exist.</description></item>
            /// <item><description><b>OfflineNotConfiged</b>: The Smart Access Gateway device is offline and the query task has not been delivered. The task will not be delivered even after the device comes online.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Succeed</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

    }

}
