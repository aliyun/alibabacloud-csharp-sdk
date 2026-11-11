// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagLanListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of LAN port information.</para>
        /// </summary>
        [NameInMap("Lans")]
        [Validation(Required=false)]
        public List<DescribeSagLanListResponseBodyLans> Lans { get; set; }
        public class DescribeSagLanListResponseBodyLans : TeaModel {
            /// <summary>
            /// <para>The end address of the DHCP address pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.XX.XX.254</para>
            /// </summary>
            [NameInMap("EndIp")]
            [Validation(Required=false)]
            public string EndIp { get; set; }

            /// <summary>
            /// <para>The IP address of the LAN port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.XX.XX.1</para>
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// <para>The connection type of the LAN port. Valid values:</para>
            /// <para><b>DHCP</b>: Dynamic IP. Uses the DHCP protocol to dynamically assign IP addresses to connected devices.</para>
            /// <para><b>STATIC</b>: Static IP. Statically specifies the IP address of the LAN port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DHCP</para>
            /// </summary>
            [NameInMap("IPType")]
            [Validation(Required=false)]
            public string IPType { get; set; }

            /// <summary>
            /// <para>The DHCP lease time. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("Lease")]
            [Validation(Required=false)]
            public string Lease { get; set; }

            /// <summary>
            /// <para>The subnet mask.</para>
            /// 
            /// <b>Example:</b>
            /// <para>255.255.255.0</para>
            /// </summary>
            [NameInMap("Mask")]
            [Validation(Required=false)]
            public string Mask { get; set; }

            /// <summary>
            /// <para>The name of the port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PortName")]
            [Validation(Required=false)]
            public string PortName { get; set; }

            /// <summary>
            /// <para>The start IP address of the DHCP address pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.XX.XX.2</para>
            /// </summary>
            [NameInMap("StartIp")]
            [Validation(Required=false)]
            public string StartIp { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1120228A-E5E1-4E9C-B56D-96887E1A2B2F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status information of the query task.</para>
        /// </summary>
        [NameInMap("TaskStates")]
        [Validation(Required=false)]
        public List<DescribeSagLanListResponseBodyTaskStates> TaskStates { get; set; }
        public class DescribeSagLanListResponseBodyTaskStates : TeaModel {
            /// <summary>
            /// <para>The time when the query task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1586852928000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error code. 200 indicates that the query task succeeded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message. Successful indicates that the query task succeeded.</para>
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
            /// <item><description><b>Offline</b>: The Smart Access Gateway device is offline and the query task is not delivered. The task will be delivered after the device comes online.</description></item>
            /// <item><description><b>Succeed</b>: The query task was delivered successfully.</description></item>
            /// <item><description><b>Processing</b>: The query task is being delivered.</description></item>
            /// <item><description><b>VersionNotSupport</b>: The current version of the Smart Access Gateway device does not support this operation.</description></item>
            /// <item><description><b>BuildRequestError</b>: The request is not supported by the management system.</description></item>
            /// <item><description><b>HardwareError</b>: The query task failed to be delivered due to a device error.</description></item>
            /// <item><description><b>TaskNotExist</b>: The query task does not exist.</description></item>
            /// <item><description><b>OfflineNotConfiged</b>: The Smart Access Gateway device is offline and the query task is not delivered. The task will not be delivered even after the device comes online.</description></item>
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
