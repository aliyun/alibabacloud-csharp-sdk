// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagHaResponseBody : TeaModel {
        /// <summary>
        /// <para>The high-availability (HA) pattern. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NONE</b>: The HA feature is not enabled.</description></item>
        /// <item><description><b>STATIC</b>: static pattern.</description></item>
        /// <item><description><b>DYNAMIC</b>: dynamic schema.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NONE</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The list of port information.</para>
        /// </summary>
        [NameInMap("Ports")]
        [Validation(Required=false)]
        public List<DescribeSagHaResponseBodyPorts> Ports { get; set; }
        public class DescribeSagHaResponseBodyPorts : TeaModel {
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
            /// <para>The virtual IP address of the Smart Access Gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.XX.XX.1</para>
            /// </summary>
            [NameInMap("VirtualIp")]
            [Validation(Required=false)]
            public string VirtualIp { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>273D62FD-E346-4959-AA18-D79B9276FEFB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of query task information.</para>
        /// </summary>
        [NameInMap("TaskStates")]
        [Validation(Required=false)]
        public List<DescribeSagHaResponseBodyTaskStates> TaskStates { get; set; }
        public class DescribeSagHaResponseBodyTaskStates : TeaModel {
            /// <summary>
            /// <para>The time when the query task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1586836343000</para>
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
            /// <para>The error message. &quot;Successful&quot; indicates that the query task succeeded.</para>
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
            /// <item><description><b>VersionNotSupport</b>: The current version of the Smart Access Gateway device does not support this operation.</description></item>
            /// <item><description><b>BuildRequestError</b>: The China Cloud Management Platform does not support this operation.</description></item>
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
