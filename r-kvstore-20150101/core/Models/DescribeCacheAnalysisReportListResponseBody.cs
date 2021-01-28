// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeCacheAnalysisReportListResponseBody : TeaModel {
        [NameInMap("DailyTasks")]
        [Validation(Required=false)]
        public DescribeCacheAnalysisReportListResponseBodyDailyTasks DailyTasks { get; set; }
        public class DescribeCacheAnalysisReportListResponseBodyDailyTasks : TeaModel {
            [NameInMap("DailyTask")]
            [Validation(Required=false)]
            public List<DescribeCacheAnalysisReportListResponseBodyDailyTasksDailyTask> DailyTask { get; set; }
            public class DescribeCacheAnalysisReportListResponseBodyDailyTasksDailyTask : TeaModel {
                [NameInMap("Task")]
                [Validation(Required=false)]
                public List<DescribeCacheAnalysisReportListResponseBodyDailyTasksDailyTaskTask> Task { get; set; }
                public class DescribeCacheAnalysisReportListResponseBodyDailyTasksDailyTaskTask : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
