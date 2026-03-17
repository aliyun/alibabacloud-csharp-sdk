// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagWanListResponseBody : TeaModel {
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
        /// <para>The status of and information about the query task.</para>
        /// </summary>
        [NameInMap("TaskStates")]
        [Validation(Required=false)]
        public List<DescribeSagWanListResponseBodyTaskStates> TaskStates { get; set; }
        public class DescribeSagWanListResponseBodyTaskStates : TeaModel {
            /// <summary>
            /// <para>The time when the query task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1586834861000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error code returned to the query task. A value of 200 indicates that the query task is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message returned to the query task. A value of Successful indicates that the query task is successful.</para>
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

        /// <summary>
        /// <para>The settings of the WAN port.</para>
        /// </summary>
        [NameInMap("Wans")]
        [Validation(Required=false)]
        public List<DescribeSagWanListResponseBodyWans> Wans { get; set; }
        public class DescribeSagWanListResponseBodyWans : TeaModel {
            /// <summary>
            /// <para>The bandwidth cap of the WAN port. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("BandWidth")]
            [Validation(Required=false)]
            public int? BandWidth { get; set; }

            /// <summary>
            /// <para>The IP address of the gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.XX.XX.1</para>
            /// </summary>
            [NameInMap("Gateway")]
            [Validation(Required=false)]
            public string Gateway { get; set; }

            /// <summary>
            /// <para>The IP address of the WAN port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.XX.XX.1</para>
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// <para>The connection type of the WAN port. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>DHCP</b>: The WAN port connects to the Internet through an IP address that is dynamically assigned by the Dynamic Host Configuration Protocol (DHCP) server.</description></item>
            /// <item><description><b>STATIC</b>: The WAN port connects to the Internet through a static IP address.</description></item>
            /// <item><description><b>PPPOE</b>: The WAN port connects to the Internet through dial-up connections.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>STATIC</para>
            /// </summary>
            [NameInMap("IPType")]
            [Validation(Required=false)]
            public string IPType { get; set; }

            /// <summary>
            /// <para>The Internet service provider (ISP) used by the WAN port.</para>
            /// <list type="bullet">
            /// <item><description><b>CT</b>: China Telecom</description></item>
            /// <item><description><b>CM</b>: China Mobile</description></item>
            /// <item><description><b>CU</b>: China Unicom</description></item>
            /// <item><description><b>Other</b>: Other ISPs</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CT</para>
            /// </summary>
            [NameInMap("ISP")]
            [Validation(Required=false)]
            public string ISP { get; set; }

            /// <summary>
            /// <para>The subnet mask of the WAN port IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>255.255.255.240</para>
            /// </summary>
            [NameInMap("Mask")]
            [Validation(Required=false)]
            public string Mask { get; set; }

            /// <summary>
            /// <para>The number of the WAN port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PortName")]
            [Validation(Required=false)]
            public string PortName { get; set; }

            /// <summary>
            /// <para>The priority of the WAN port.</para>
            /// <para>Valid values: <b>-1</b> and <b>1 to 50</b>. A smaller number represents a higher priority.</para>
            /// <remarks>
            /// <para> A value of <b>-1</b> indicates that the WAN port is not used to forward network traffic.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The status of data transfer on the WAN port. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>active</b>: The WAN port is the active port for data transfer.</description></item>
            /// <item><description><b>standby</b>: The WAN port is a standby port. If the active port is down, data transfer is switched to the WAN port.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("TrafficState")]
            [Validation(Required=false)]
            public string TrafficState { get; set; }

            /// <summary>
            /// <para>The username of the PPPoE account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Usernamexx</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

            /// <summary>
            /// <para>The weight of the WAN port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

    }

}
