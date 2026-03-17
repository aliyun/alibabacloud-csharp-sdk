// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagHaResponseBody : TeaModel {
        /// <summary>
        /// <para>The HA mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NONE</b>: HA is disabled.</description></item>
        /// <item><description><b>STATIC</b>: static HA is enabled.</description></item>
        /// <item><description><b>DYNAMIC</b>: dynamic HA is enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NONE</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The information about the port.</para>
        /// </summary>
        [NameInMap("Ports")]
        [Validation(Required=false)]
        public List<DescribeSagHaResponseBodyPorts> Ports { get; set; }
        public class DescribeSagHaResponseBodyPorts : TeaModel {
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
            /// <para>The virtual IP address of the SAG device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.XX.XX.1</para>
            /// </summary>
            [NameInMap("VirtualIp")]
            [Validation(Required=false)]
            public string VirtualIp { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>273D62FD-E346-4959-AA18-D79B9276FEFB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the query task.</para>
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
            /// <para>The error code returned for a query task. The 200 error code indicates that the query task is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message returned for a query task. The Successful error message indicates that the query task is successful.</para>
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
            /// <item><description><b>Initialized</b>: The query task has been initialized.</description></item>
            /// <item><description><b>Offline</b>: The query task is not dispatched because the SAG device is disconnected from Alibaba Cloud. The task will be dispatched after the SAG device is connected to Alibaba Cloud.</description></item>
            /// <item><description><b>Succeed</b>: The query task has been dispatched.</description></item>
            /// <item><description><b>Processing</b>: The query task is being dispatched.</description></item>
            /// <item><description><b>VersionNotSupport</b>: The current version of the SAG device does not support query tasks.</description></item>
            /// <item><description><b>BuildRequestError</b>: The SAG control system does not support query tasks.</description></item>
            /// <item><description><b>HardwareError</b>: The query task failed to be dispatched due to device errors.</description></item>
            /// <item><description><b>TaskNotExist</b>: The query task does not exist.</description></item>
            /// <item><description><b>OfflineNotConfiged</b>: The query task is not dispatched because the SAG device is disconnected from Alibaba Cloud. The task will not be dispatched after the device is connected to Alibaba Cloud.</description></item>
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
