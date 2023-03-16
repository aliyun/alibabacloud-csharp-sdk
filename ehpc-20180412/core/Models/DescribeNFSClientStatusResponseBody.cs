// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeNFSClientStatusResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of results.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeNFSClientStatusResponseBodyResult Result { get; set; }
        public class DescribeNFSClientStatusResponseBodyResult : TeaModel {
            /// <summary>
            /// The Base64-decoded Output parameter value. A True in the last line indicates successful installation. Otherwise, the installation fails.
            /// </summary>
            [NameInMap("ExitCode")]
            [Validation(Required=false)]
            public int? ExitCode { get; set; }

            /// <summary>
            /// The status of the invocation record, which is the same as the value of the Status parameter.
            /// </summary>
            [NameInMap("InvokeRecordStatus")]
            [Validation(Required=false)]
            public string InvokeRecordStatus { get; set; }

            /// <summary>
            /// The execution result of the command.
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

        }

        /// <summary>
        /// The deployment status of the NFS client. Valid values:
        /// 
        /// *   NotInstalled: The client is not installed.
        /// *   Running: The client is being installed.
        /// *   Finished: The client is installed on the instance.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
