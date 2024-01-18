// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DeleteDataSourceLogResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteDataSourceLogResponseBodyData Data { get; set; }
        public class DeleteDataSourceLogResponseBodyData : TeaModel {
            /// <summary>
            /// The number of logs that are removed. The value 1 indicates that the log is removed, and a value less than or equal to 0 indicates that the log failed to be removed.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The ID of the log. The ID is an MD5 hash value that is calculated by the threat analysis feature based on specific parameters.
            /// </summary>
            [NameInMap("LogInstanceId")]
            [Validation(Required=false)]
            public string LogInstanceId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
