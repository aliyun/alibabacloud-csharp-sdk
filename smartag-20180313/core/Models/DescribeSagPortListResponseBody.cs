// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagPortListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of port information.</para>
        /// </summary>
        [NameInMap("Ports")]
        [Validation(Required=false)]
        public List<DescribeSagPortListResponseBodyPorts> Ports { get; set; }
        public class DescribeSagPortListResponseBodyPorts : TeaModel {
            /// <summary>
            /// <para>The MAC address of the port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c4:00:ad:a2:f5:****</para>
            /// </summary>
            [NameInMap("Mac")]
            [Validation(Required=false)]
            public string Mac { get; set; }

            /// <summary>
            /// <para>The port name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("PortName")]
            [Validation(Required=false)]
            public string PortName { get; set; }

            /// <summary>
            /// <para>The port role. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NONE</b>: The port role is unassigned.</description></item>
            /// <item><description><b>WAN</b>: The port is a WAN port. A WAN port is used to connect to the Internet and supports DHCP client, PPPoE, and static IP access methods.</description></item>
            /// <item><description><b>LAN</b>: The port is a LAN port. A LAN port is used to connect to local clients or switches and supports DHCP server and static IP access methods.</description></item>
            /// <item><description><b>ECC</b>: The port is a dedicated connection port used to connect to a dedicated connection.</description></item>
            /// <item><description><b>MGT</b>: The port is a management port.</description></item>
            /// <item><description><b>CELLULAR</b>: The port is a 4G port.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NONE</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The port status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Up</b>: The port is enabled.</description></item>
            /// <item><description><b>Down</b>: The port is disabled.</description></item>
            /// <item><description><b>Unavailable</b>: The device is offline.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Down</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
        /// <para>The status of the query task.</para>
        /// </summary>
        [NameInMap("TaskStates")]
        [Validation(Required=false)]
        public List<DescribeSagPortListResponseBodyTaskStates> TaskStates { get; set; }
        public class DescribeSagPortListResponseBodyTaskStates : TeaModel {
            /// <summary>
            /// <para>The time when the query task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1586762479000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error code. A value of 200 indicates that the query task is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message. A value of Successful indicates that the query task is successful.</para>
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
            /// <item><description><b>Offline</b>: The Smart Access Gateway device is offline and the query task is not delivered. The task will be delivered after the device goes online.</description></item>
            /// <item><description><b>Succeed</b>: The query task is delivered.</description></item>
            /// <item><description><b>Processing</b>: The query task is being delivered.</description></item>
            /// <item><description><b>VersionNotSupport</b>: The current version of the Smart Access Gateway device does not support this feature.</description></item>
            /// <item><description><b>BuildRequestError</b>: The management and control system does not support this operation.</description></item>
            /// <item><description><b>HardwareError</b>: The query task failed to be delivered due to a device error.</description></item>
            /// <item><description><b>TaskNotExist</b>: The query task does not exist.</description></item>
            /// <item><description><b>OfflineNotConfiged</b>: The Smart Access Gateway device is offline and the query task is not delivered. The task will not be delivered after the device goes online.</description></item>
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
