// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Openanalytics_open20180619.Models
{
    public class ListSparkJobResponseBody : TeaModel {
        [NameInMap("DataResult")]
        [Validation(Required=false)]
        public ListSparkJobResponseBodyDataResult DataResult { get; set; }
        public class ListSparkJobResponseBodyDataResult : TeaModel {
            [NameInMap("JobList")]
            [Validation(Required=false)]
            public List<ListSparkJobResponseBodyDataResultJobList> JobList { get; set; }
            public class ListSparkJobResponseBodyDataResultJobList : TeaModel {
                public string Status { get; set; }
                public string UpdateTime { get; set; }
                public string ExecutorResourceSpec { get; set; }
                public string CreateTime { get; set; }
                public string DriverResourceSpec { get; set; }
                public string CreateTimeValue { get; set; }
                public string UpdateTimeValue { get; set; }
                public string SparkUI { get; set; }
                public string SubmitTimeValue { get; set; }
                public string JobName { get; set; }
                public string JobId { get; set; }
                public string VcName { get; set; }
                public string ExecutorInstances { get; set; }
                public string SubmitTime { get; set; }
                public string Detail { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
