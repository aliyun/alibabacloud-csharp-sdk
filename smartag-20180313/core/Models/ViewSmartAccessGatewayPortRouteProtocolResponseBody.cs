// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ViewSmartAccessGatewayPortRouteProtocolResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of port information.</para>
        /// </summary>
        [NameInMap("Ports")]
        [Validation(Required=false)]
        public List<ViewSmartAccessGatewayPortRouteProtocolResponseBodyPorts> Ports { get; set; }
        public class ViewSmartAccessGatewayPortRouteProtocolResponseBodyPorts : TeaModel {
            /// <summary>
            /// <para>The IP address of the neighbor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.XX.XX.2</para>
            /// </summary>
            [NameInMap("NeighborIp")]
            [Validation(Required=false)]
            public string NeighborIp { get; set; }

            /// <summary>
            /// <para>The name of the port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("PortName")]
            [Validation(Required=false)]
            public string PortName { get; set; }

            /// <summary>
            /// <para>The autonomous system (AS) number of the BGP peer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65535</para>
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
            /// <item><description><b>STATIC</b>: static routing protocol.</description></item>
            /// <item><description><b>OSPF</b>: Open Shortest Path First (OSPF) dynamic routing protocol.</description></item>
            /// <item><description><b>BGP</b>: Border Gateway Protocol (BGP) dynamic routing protocol.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BGP</para>
            /// </summary>
            [NameInMap("RouteProtocol")]
            [Validation(Required=false)]
            public string RouteProtocol { get; set; }

            /// <summary>
            /// <para>The status of the port. Valid values:</para>
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
        /// <para>877F5673-FFD1-5168-99D1-1E8009FBFF7B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the query task.</para>
        /// </summary>
        [NameInMap("TaskStates")]
        [Validation(Required=false)]
        public List<ViewSmartAccessGatewayPortRouteProtocolResponseBodyTaskStates> TaskStates { get; set; }
        public class ViewSmartAccessGatewayPortRouteProtocolResponseBodyTaskStates : TeaModel {
            /// <summary>
            /// <para>The time when the query task was created.</para>
            /// <para>This is a UNIX timestamp that represents the number of milliseconds that have elapsed since 00:00:00 UTC on January 1, 1970.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1586765938000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error code. \<c>200\\</c> indicates that the query task is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message. \<c>Successful\\</c> indicates that the query task is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Successful</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The status of the asynchronous task:</para>
            /// <list type="bullet">
            /// <item><description><b>Initialized</b>: The query task is being initialized.</description></item>
            /// <item><description><b>Offline</b>: The SAG device is offline and the query task is not sent. The task will be sent after the device goes online.</description></item>
            /// <item><description><b>Succeed</b>: The query task is sent.</description></item>
            /// <item><description><b>Processing</b>: The query task is being sent.</description></item>
            /// <item><description><b>VersionNotSupport</b>: The current version of the SAG device is not supported.</description></item>
            /// <item><description><b>BuildRequestError</b>: The management plane does not support the operation.</description></item>
            /// <item><description><b>HardwareError</b>: The query task failed to be sent due to a device error.</description></item>
            /// <item><description><b>TaskNotExist</b>: The query task does not exist.</description></item>
            /// <item><description><b>OfflineNotConfiged</b>: The SAG device is offline and the query task is not sent. The task will not be sent even after the device goes online.</description></item>
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
