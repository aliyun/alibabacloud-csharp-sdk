// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Openanalytics_open20180619.Models
{
    public class GetJobDetailResponseBody : TeaModel {
        [NameInMap("JobDetail")]
        [Validation(Required=false)]
        public GetJobDetailResponseBodyJobDetail JobDetail { get; set; }
        public class GetJobDetailResponseBodyJobDetail : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }
            [NameInMap("ExecutorResourceSpec")]
            [Validation(Required=false)]
            public string ExecutorResourceSpec { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("CreateTimeValue")]
            [Validation(Required=false)]
            public string CreateTimeValue { get; set; }
            [NameInMap("DriverResourceSpec")]
            [Validation(Required=false)]
            public string DriverResourceSpec { get; set; }
            [NameInMap("UpdateTimeValue")]
            [Validation(Required=false)]
            public string UpdateTimeValue { get; set; }
            [NameInMap("SparkUI")]
            [Validation(Required=false)]
            public string SparkUI { get; set; }
            [NameInMap("SubmitTimeValue")]
            [Validation(Required=false)]
            public string SubmitTimeValue { get; set; }
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }
            [NameInMap("ExecutorInstances")]
            [Validation(Required=false)]
            public string ExecutorInstances { get; set; }
            [NameInMap("VcName")]
            [Validation(Required=false)]
            public string VcName { get; set; }
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
