// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetStackResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of the method stack.
        /// </summary>
        [NameInMap("StackInfo")]
        [Validation(Required=false)]
        public List<GetStackResponseBodyStackInfo> StackInfo { get; set; }
        public class GetStackResponseBodyStackInfo : TeaModel {
            /// <summary>
            /// The name of the operation.
            /// </summary>
            [NameInMap("Api")]
            [Validation(Required=false)]
            public string Api { get; set; }

            /// <summary>
            /// The duration. Unit: milliseconds.
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// The error message.
            /// </summary>
            [NameInMap("Exception")]
            [Validation(Required=false)]
            public string Exception { get; set; }

            /// <summary>
            /// The information about the array object.
            /// </summary>
            [NameInMap("ExtInfo")]
            [Validation(Required=false)]
            public GetStackResponseBodyStackInfoExtInfo ExtInfo { get; set; }
            public class GetStackResponseBodyStackInfoExtInfo : TeaModel {
                /// <summary>
                /// The content of the custom parameter.
                /// </summary>
                [NameInMap("Info")]
                [Validation(Required=false)]
                public string Info { get; set; }

                /// <summary>
                /// The type of the custom parameter.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The number of rows in the method stack information.
            /// </summary>
            [NameInMap("Line")]
            [Validation(Required=false)]
            public string Line { get; set; }

            /// <summary>
            /// The ID of the RPC mode.
            /// </summary>
            [NameInMap("RpcId")]
            [Validation(Required=false)]
            public string RpcId { get; set; }

            /// <summary>
            /// The name of the service.
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// The start time of the call method.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

    }

}
