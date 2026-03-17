// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagPortRouteProtocolListResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the details of the port.</para>
        /// </summary>
        [NameInMap("Ports")]
        [Validation(Required=false)]
        public List<DescribeSagPortRouteProtocolListResponseBodyPorts> Ports { get; set; }
        public class DescribeSagPortRouteProtocolListResponseBodyPorts : TeaModel {
            /// <summary>
            /// <para>The IP address of the neighbor device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.XX.XX.1</para>
            /// </summary>
            [NameInMap("NeighborIp")]
            [Validation(Required=false)]
            public string NeighborIp { get; set; }

            /// <summary>
            /// <para>The name of the port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("PortName")]
            [Validation(Required=false)]
            public string PortName { get; set; }

            /// <summary>
            /// <para>The number of the autonomous system (AS) to which the SAG device belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("RemoteAs")]
            [Validation(Required=false)]
            public string RemoteAs { get; set; }

            /// <summary>
            /// <para>The IP address of the peer device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.XX.XX.1</para>
            /// </summary>
            [NameInMap("RemoteIp")]
            [Validation(Required=false)]
            public string RemoteIp { get; set; }

            /// <summary>
            /// <para>The routing protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>STATIC</b>: static routing protocol</description></item>
            /// <item><description><b>OSPF</b>: Open Shortest Path First protocol (OSPF)</description></item>
            /// <item><description><b>BGP</b>: Border Gateway Protocol (BGP)</description></item>
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
            /// <item><description><b>UP</b>: The port was enabled.</description></item>
            /// <item><description><b>DOWN</b>: The port was disabled.</description></item>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE6642D4-21EB-4168-9BF9-F217953F9892</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details about the status of the query task.</para>
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
            /// <para>The error code returned. A value of 200 indicates that the query task is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message returned. A value of Successful indicates that the query task is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Successful</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The status of the query task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Initialized</b>: The query task is initialized.</description></item>
            /// <item><description><b>Offline</b>: The SAG device is disconnected from Alibaba Cloud and Alibaba Cloud has not assigned the query task to the SAG device. After the SAG device is connected to Alibaba Cloud, Alibaba Cloud assigns the query task to the SAG device.</description></item>
            /// <item><description><b>Succeed</b>: Alibaba Cloud has assigned the query task to the SAG device.</description></item>
            /// <item><description><b>Processing</b>: Alibaba Cloud is assigning the query task to the SAG device.</description></item>
            /// <item><description><b>VersionNotSupport</b>: The query task is not supported by the current version of the SAG device.</description></item>
            /// <item><description><b>BuildRequestError</b>: The query task is not supported by the controller of the SAG device.</description></item>
            /// <item><description><b>HardwareError</b>: Alibaba Cloud failed to assign the query task to the SAG device because the SAG device is faulty.</description></item>
            /// <item><description><b>TaskNotExist</b>: The query task does not exist.</description></item>
            /// <item><description><b>OfflineNotConfiged</b>: The SAG device is disconnected from Alibaba Cloud and Alibaba Cloud has not assigned the query task to the SAG device. Alibaba Cloud does not assign the query task to the SAG device even after the SAG device is connected to Alibaba Cloud.</description></item>
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
