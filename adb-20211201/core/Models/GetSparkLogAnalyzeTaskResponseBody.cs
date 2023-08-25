// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkLogAnalyzeTaskResponseBody : TeaModel {
        /// <summary>
        /// The information about the Spark log analysis task.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SparkAnalyzeLogTask Data { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
