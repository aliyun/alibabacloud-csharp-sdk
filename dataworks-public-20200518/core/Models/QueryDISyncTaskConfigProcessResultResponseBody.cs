// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class QueryDISyncTaskConfigProcessResultResponseBody : TeaModel {
        /// <summary>
        /// The information returned for the parameters that are asynchronously generated and used to create or update a real-time synchronization node or a synchronization solution in Data Integration.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDISyncTaskConfigProcessResultResponseBodyData Data { get; set; }
        public class QueryDISyncTaskConfigProcessResultResponseBodyData : TeaModel {
            /// <summary>
            /// The reason why the parameters fail to be obtained. If the parameters are obtained, the value null is returned.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// Indicates whether the parameters are obtained. Valid values:
            /// 
            /// *   success: indicates that the parameters are obtained.
            /// *   fail: indicates that the parameters fail to be obtained. You can view the reason for the failure and troubleshoot the issue based on the reason.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The parameters that are obtained. The parameters are used as the request parameters of the [CreateDISyncTask](~~278725~~) or [UpdateDISyncTask](~~289109~~) operation to create or update a real-time synchronization node or a synchronization solution in Data Integration.
            /// </summary>
            [NameInMap("TaskContent")]
            [Validation(Required=false)]
            public string TaskContent { get; set; }

        }

        /// <summary>
        /// The ID of the request. You can locate logs and troubleshoot issues based on the ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   true: The request is successful.
        /// *   false: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
