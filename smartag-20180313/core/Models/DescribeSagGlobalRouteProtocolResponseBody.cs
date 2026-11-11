// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagGlobalRouteProtocolResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3712F0B2-721E-4FBF-BBEF-888E3BFE0A20</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The routable protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>STATIC</b>: static routable protocol</description></item>
        /// <item><description><b>OSPF</b>: OSPF dynamic routable protocol</description></item>
        /// <item><description><b>BGP</b>: BGP dynamic routable protocol</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>STATIC</para>
        /// </summary>
        [NameInMap("RouteProtocol")]
        [Validation(Required=false)]
        public string RouteProtocol { get; set; }

        /// <summary>
        /// <para>The status of the query task.</para>
        /// </summary>
        [NameInMap("TaskStates")]
        [Validation(Required=false)]
        public List<DescribeSagGlobalRouteProtocolResponseBodyTaskStates> TaskStates { get; set; }
        public class DescribeSagGlobalRouteProtocolResponseBodyTaskStates : TeaModel {
            /// <summary>
            /// <para>The time when the query task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1586855592000</para>
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
            /// <item><description><b>Offline</b>: The Smart Access Gateway device is offline and the query task is not delivered. The task will be delivered after the device comes online.</description></item>
            /// <item><description><b>Succeed</b>: The query task is delivered.</description></item>
            /// <item><description><b>Processing</b>: The query task is being delivered.</description></item>
            /// <item><description><b>VersionNotSupport</b>: The current version of the Smart Access Gateway device does not support the feature.</description></item>
            /// <item><description><b>BuildRequestError</b>: The management and control system does not support the operation.</description></item>
            /// <item><description><b>HardwareError</b>: The query task delivery failed due to a device error.</description></item>
            /// <item><description><b>TaskNotExist</b>: The query task does not exist.</description></item>
            /// <item><description><b>OfflineNotConfiged</b>: The Smart Access Gateway device is offline and the query task is not delivered. The task will not be delivered after the device comes online.</description></item>
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
