// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class QueryDISyncTaskConfigProcessResultResponseBody : TeaModel {
        /// <summary>
        /// The information returned for the parameters that are asynchronously generated and used to create or update a real-time synchronization task in Data Integration.
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
            /// *   success: The parameters are obtained.
            /// *   fail: The parameters fail to be obtained. You can view the reason for the failure and troubleshoot the issue based on the reason.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The parameters that are obtained. The parameters are used as the request parameters of the [CreateDISyncTask](https://help.aliyun.com/document_detail/278725.html) or [UpdateDISyncTask](https://help.aliyun.com/document_detail/289109.html) operation to create or update a real-time synchronization task in Data Integration.
            /// </summary>
            [NameInMap("TaskContent")]
            [Validation(Required=false)]
            public string TaskContent { get; set; }

        }

        /// <summary>
        /// The request ID. You can locate logs and troubleshoot issues based on the ID.
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
