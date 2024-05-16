// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class QueryDISyncTaskConfigProcessResultResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the parameters are obtained. Valid values:
        /// 
        /// *   success: indicates that the parameters are obtained.
        /// *   fail: indicates that the parameters fail to be obtained. You can view the reason for the failure and troubleshoot the issue based on the reason.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDISyncTaskConfigProcessResultResponseBodyData Data { get; set; }
        public class QueryDISyncTaskConfigProcessResultResponseBodyData : TeaModel {
            /// <summary>
            /// The parameters that are obtained. The parameters are used as the request parameters of the [CreateDISyncTask](https://help.aliyun.com/document_detail/278725.html) or [UpdateDISyncTask](https://help.aliyun.com/document_detail/289109.html) operation to create or update a real-time synchronization node or a synchronization solution in Data Integration.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The reason why the parameters fail to be obtained. If the parameters are obtained, the value null is returned.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TaskContent")]
            [Validation(Required=false)]
            public string TaskContent { get; set; }

        }

        /// <summary>
        /// The information returned for the parameters that are asynchronously generated and used to create or update a real-time synchronization node or a synchronization solution in Data Integration.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the request. You can locate logs and troubleshoot issues based on the ID.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
