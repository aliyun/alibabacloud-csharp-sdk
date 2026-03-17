// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagUserDnsResponseBody : TeaModel {
        /// <summary>
        /// <para>The IP address of the primary DNS server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.XX.XX.1</para>
        /// </summary>
        [NameInMap("MasterDns")]
        [Validation(Required=false)]
        public string MasterDns { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0937DEA0-AB4B-42F4-9314-07B97D30282B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The IP address of the secondary DNS server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.XX.XX.2</para>
        /// </summary>
        [NameInMap("SlaveDns")]
        [Validation(Required=false)]
        public string SlaveDns { get; set; }

        /// <summary>
        /// <para>The state of the query task.</para>
        /// </summary>
        [NameInMap("TaskStates")]
        [Validation(Required=false)]
        public List<DescribeSagUserDnsResponseBodyTaskStates> TaskStates { get; set; }
        public class DescribeSagUserDnsResponseBodyTaskStates : TeaModel {
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
            /// <para>The error code returned. A value of 200 indicates that the query task is successful.</para>
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
            /// <para>The state of the query task. Valid values:</para>
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
