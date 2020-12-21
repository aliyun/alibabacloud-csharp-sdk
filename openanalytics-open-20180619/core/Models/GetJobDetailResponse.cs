// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Openanalytics_open20180619.Models
{
    public class GetJobDetailResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("JobDetail")]
        [Validation(Required=true)]
        public GetJobDetailResponseJobDetail JobDetail { get; set; }
        public class GetJobDetailResponseJobDetail : TeaModel {
            [NameInMap("JobId")]
            [Validation(Required=true)]
            public string JobId { get; set; }
            [NameInMap("JobName")]
            [Validation(Required=true)]
            public string JobName { get; set; }
            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }
            [NameInMap("Detail")]
            [Validation(Required=true)]
            public string Detail { get; set; }
            [NameInMap("SparkUI")]
            [Validation(Required=true)]
            public string SparkUI { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public string CreateTime { get; set; }
            [NameInMap("UpdateTime")]
            [Validation(Required=true)]
            public string UpdateTime { get; set; }
            [NameInMap("SubmitTime")]
            [Validation(Required=true)]
            public string SubmitTime { get; set; }
            [NameInMap("CreateTimeValue")]
            [Validation(Required=true)]
            public string CreateTimeValue { get; set; }
            [NameInMap("UpdateTimeValue")]
            [Validation(Required=true)]
            public string UpdateTimeValue { get; set; }
            [NameInMap("SubmitTimeValue")]
            [Validation(Required=true)]
            public string SubmitTimeValue { get; set; }
            [NameInMap("VcName")]
            [Validation(Required=true)]
            public string VcName { get; set; }
            [NameInMap("DriverResourceSpec")]
            [Validation(Required=true)]
            public string DriverResourceSpec { get; set; }
            [NameInMap("ExecutorResourceSpec")]
            [Validation(Required=true)]
            public string ExecutorResourceSpec { get; set; }
            [NameInMap("ExecutorInstances")]
            [Validation(Required=true)]
            public string ExecutorInstances { get; set; }
        };

    }

}
