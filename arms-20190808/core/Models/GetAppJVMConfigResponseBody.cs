// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetAppJVMConfigResponseBody : TeaModel {
        /// <summary>
        /// The response code. Valid values: 2XX: The request is successful. 3XX: A redirection message is returned. 4XX: The request is invalid. 5XX: A server error occurs.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The list of JVM information.
        /// </summary>
        [NameInMap("JvmInfoList")]
        [Validation(Required=false)]
        public List<GetAppJVMConfigResponseBodyJvmInfoList> JvmInfoList { get; set; }
        public class GetAppJVMConfigResponseBodyJvmInfoList : TeaModel {
            /// <summary>
            /// The version of the agent.
            /// </summary>
            [NameInMap("AgentVersion")]
            [Validation(Required=false)]
            public string AgentVersion { get; set; }

            /// <summary>
            /// The hostname.
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// The IP address.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The application ID.
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// The process ID.
            /// </summary>
            [NameInMap("ProcId")]
            [Validation(Required=false)]
            public string ProcId { get; set; }

            /// <summary>
            /// The VM parameters.
            /// </summary>
            [NameInMap("VmArgs")]
            [Validation(Required=false)]
            public string VmArgs { get; set; }

        }

        /// <summary>
        /// The error message returned if the request failed.
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
        /// Indicates whether the request was successful. Valid values: true and false.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
