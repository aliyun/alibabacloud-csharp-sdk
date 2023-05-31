// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeTaskErrorLogResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the error logs.
        /// </summary>
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public List<DescribeTaskErrorLogResponseBodyLogs> Logs { get; set; }
        public class DescribeTaskErrorLogResponseBodyLogs : TeaModel {
            /// <summary>
            /// The text content of the log.
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
