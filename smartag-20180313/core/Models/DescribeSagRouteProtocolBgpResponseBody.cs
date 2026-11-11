// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagRouteProtocolBgpResponseBody : TeaModel {
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
        /// <para>The keepalive interval. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("KeepAlive")]
        [Validation(Required=false)]
        public int? KeepAlive { get; set; }

        /// <summary>
        /// <para>The autonomous system (AS) number of the Smart Access Gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65536</para>
        /// </summary>
        [NameInMap("LocalAs")]
        [Validation(Required=false)]
        public int? LocalAs { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2F39E4FE-B45C-47FF-9921-95780486F52D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The BGP router ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.XX.XX.1</para>
        /// </summary>
        [NameInMap("RouterId")]
        [Validation(Required=false)]
        public string RouterId { get; set; }

        /// <summary>
        /// <para>The status of the query task.</para>
        /// </summary>
        [NameInMap("TaskStates")]
        [Validation(Required=false)]
        public List<DescribeSagRouteProtocolBgpResponseBodyTaskStates> TaskStates { get; set; }
        public class DescribeSagRouteProtocolBgpResponseBodyTaskStates : TeaModel {
            /// <summary>
            /// <para>The timestamp when the query task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1586765938000</para>
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
            /// <item><description><b>Succeed</b>: The query task succeeded.</description></item>
            /// <item><description><b>Processing</b>: The query task is being delivered.</description></item>
            /// <item><description><b>VersionNotSupport</b>: The current version of the Smart Access Gateway device does not support this feature.</description></item>
            /// <item><description><b>BuildRequestError</b>: The management and control system does not support the operation.</description></item>
            /// <item><description><b>HardwareError</b>: The query task failed to be delivered due to a device error.</description></item>
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
