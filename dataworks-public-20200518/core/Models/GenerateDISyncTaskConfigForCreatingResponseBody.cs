// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GenerateDISyncTaskConfigForCreatingResponseBody : TeaModel {
        /// <summary>
        /// The information returned for the ID of the asynchronous thread.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateDISyncTaskConfigForCreatingResponseBodyData Data { get; set; }
        public class GenerateDISyncTaskConfigForCreatingResponseBodyData : TeaModel {
            /// <summary>
            /// The reason why the ID of the asynchronous thread fails to be generated. If the ID is successfully generated, no value is returned for this parameter.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The ID of the asynchronous thread. You can call the [QueryDISyncTaskConfigProcessResult](https://help.aliyun.com/document_detail/383465.html) operation to obtain the asynchronously generated parameters based on the ID. The parameters are used to create a synchronization task in Data Integration.
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public long? ProcessId { get; set; }

            /// <summary>
            /// Indicates whether the ID of the asynchronous thread is generated. Valid values: Valid values:
            /// 
            /// *   success: indicates that the ID of the asynchronous thread is generated.
            /// *   fail: indicates that the ID of the asynchronous thread fails to be generated. You can view the reason for the failure and troubleshoot the issue based on the reason.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
