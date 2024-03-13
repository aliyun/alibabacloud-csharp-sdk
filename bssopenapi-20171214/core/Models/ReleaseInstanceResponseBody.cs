// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class ReleaseInstanceResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// data
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ReleaseInstanceResponseBodyData Data { get; set; }
        public class ReleaseInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// The site of the execution host.
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// Indicates whether the instance is released.
            /// </summary>
            [NameInMap("ReleaseResult")]
            [Validation(Required=false)]
            public bool? ReleaseResult { get; set; }

        }

        /// <summary>
        /// The description of the execution result.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request, which can be used for troubleshooting.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// A value of true indicates that the execution is complete.
        /// 
        /// A value of false indicates that an error occurs during the execution.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
