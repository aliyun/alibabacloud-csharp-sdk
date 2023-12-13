// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetAppJVMConfigResponseBody : TeaModel {
        /// <summary>
        /// The status code. The status code 200 indicates that the request was successful. If another status code is returned, the request failed.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// Java VM info list.
        /// </summary>
        [NameInMap("JvmInfoList")]
        [Validation(Required=false)]
        public List<GetAppJVMConfigResponseBodyJvmInfoList> JvmInfoList { get; set; }
        public class GetAppJVMConfigResponseBodyJvmInfoList : TeaModel {
            /// <summary>
            /// Agent version.
            /// </summary>
            [NameInMap("AgentVersion")]
            [Validation(Required=false)]
            public string AgentVersion { get; set; }

            /// <summary>
            /// The name of the elastic container instance.
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// Ip address.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The PID.
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// Process Id.
            /// </summary>
            [NameInMap("ProcId")]
            [Validation(Required=false)]
            public string ProcId { get; set; }

            /// <summary>
            /// Java VM config.
            /// </summary>
            [NameInMap("VmArgs")]
            [Validation(Required=false)]
            public string VmArgs { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
