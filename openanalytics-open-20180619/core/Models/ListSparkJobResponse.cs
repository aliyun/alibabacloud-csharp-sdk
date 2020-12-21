// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Openanalytics_open20180619.Models
{
    public class ListSparkJobResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DataResult")]
        [Validation(Required=true)]
        public ListSparkJobResponseDataResult DataResult { get; set; }
        public class ListSparkJobResponseDataResult : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=true)]
            public string PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public string PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public string TotalCount { get; set; }
            [NameInMap("JobList")]
            [Validation(Required=true)]
            public List<ListSparkJobResponseDataResultJobList> JobList { get; set; }
            public class ListSparkJobResponseDataResultJobList : TeaModel {
                public string CreateTime { get; set; }
                public string CreateTimeValue { get; set; }
                public string Detail { get; set; }
                public string DriverResourceSpec { get; set; }
                public string ExecutorInstances { get; set; }
                public string ExecutorResourceSpec { get; set; }
                public string JobId { get; set; }
                public string JobName { get; set; }
                public string SparkUI { get; set; }
                public string Status { get; set; }
                public string SubmitTime { get; set; }
                public string SubmitTimeValue { get; set; }
                public string UpdateTime { get; set; }
                public string UpdateTimeValue { get; set; }
                public string VcName { get; set; }
            }
        };

    }

}
