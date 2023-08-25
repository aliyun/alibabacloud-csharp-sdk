// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkAppLogResponseBody : TeaModel {
        /// <summary>
        /// The content of the log.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSparkAppLogResponseBodyData Data { get; set; }
        public class GetSparkAppLogResponseBodyData : TeaModel {
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// The alert message returned for the operation, such as task execution failure or insufficient resources. Null is returned if no alert occurs.
            /// </summary>
            [NameInMap("LogContent")]
            [Validation(Required=false)]
            public string LogContent { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// Details of the logs.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
