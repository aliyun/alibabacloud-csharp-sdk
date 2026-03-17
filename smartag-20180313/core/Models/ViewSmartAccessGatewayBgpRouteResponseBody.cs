// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ViewSmartAccessGatewayBgpRouteResponseBody : TeaModel {
        /// <summary>
        /// <para>The hold time. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("HoldTime")]
        [Validation(Required=false)]
        public int? HoldTime { get; set; }

        /// <summary>
        /// <para>The time interval at which keep-alive packets are sent. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("KeepAlive")]
        [Validation(Required=false)]
        public int? KeepAlive { get; set; }

        /// <summary>
        /// <para>The autonomous system number (ASN) to which the SAG device belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12****</para>
        /// </summary>
        [NameInMap("LocalAs")]
        [Validation(Required=false)]
        public int? LocalAs { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F1FEABC0-F7B7-53EA-83EE-AA470ABACE60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the BGP router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.XX.XX.1</para>
        /// </summary>
        [NameInMap("RouterId")]
        [Validation(Required=false)]
        public string RouterId { get; set; }

        /// <summary>
        /// <para>The status of the task.</para>
        /// </summary>
        [NameInMap("TaskStates")]
        [Validation(Required=false)]
        public List<ViewSmartAccessGatewayBgpRouteResponseBodyTaskStates> TaskStates { get; set; }
        public class ViewSmartAccessGatewayBgpRouteResponseBodyTaskStates : TeaModel {
            /// <summary>
            /// <para>The timestamp when the task was created. Unit: milliseconds.</para>
            /// <para>The value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1586855592000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error code. A value of 200 indicates that the task is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message. A value of Successful indicates that the task is successful.</para>
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
