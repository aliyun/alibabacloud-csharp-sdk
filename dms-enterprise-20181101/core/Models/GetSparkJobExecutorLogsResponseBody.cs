// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetSparkJobExecutorLogsResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// log of the spark job
        /// </summary>
        [NameInMap("ExecutorLogs")]
        [Validation(Required=false)]
        public GetSparkJobExecutorLogsResponseBodyExecutorLogs ExecutorLogs { get; set; }
        public class GetSparkJobExecutorLogsResponseBodyExecutorLogs : TeaModel {
            [NameInMap("executorLogs")]
            [Validation(Required=false)]
            public List<string> ExecutorLogs { get; set; }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
