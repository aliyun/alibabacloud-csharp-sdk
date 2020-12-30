// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cityvisual20181030.Models
{
    public class ListComputeJobLogsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("JobLogs")]
        [Validation(Required=false)]
        public ListComputeJobLogsResponseBodyJobLogs JobLogs { get; set; }
        public class ListComputeJobLogsResponseBodyJobLogs : TeaModel {
            [NameInMap("JobLog")]
            [Validation(Required=false)]
            public List<string> JobLog { get; set; }
        };

    }

}
