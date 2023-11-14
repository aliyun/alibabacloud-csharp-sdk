// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetLogMetaResponseBody : TeaModel {
        /// <summary>
        /// The data of a data shipping task.
        /// </summary>
        [NameInMap("LogMeta")]
        [Validation(Required=false)]
        public GetLogMetaResponseBodyLogMeta LogMeta { get; set; }
        public class GetLogMetaResponseBodyLogMeta : TeaModel {
            /// <summary>
            /// The name of the dedicated Logstore in which logs are stored.
            /// </summary>
            [NameInMap("LogStore")]
            [Validation(Required=false)]
            public string LogStore { get; set; }

            /// <summary>
            /// The Simple Log Service project.
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// The status of a data shipping task of a log. Valid values:
            /// 
            /// *   **enabled**
            /// *   **disabled**
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

    }

}
