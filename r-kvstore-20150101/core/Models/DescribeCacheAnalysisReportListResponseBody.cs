// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeCacheAnalysisReportListResponseBody : TeaModel {
        /// <summary>
        /// Details of the offline key analytics tasks.
        /// </summary>
        [NameInMap("DailyTasks")]
        [Validation(Required=false)]
        public DescribeCacheAnalysisReportListResponseBodyDailyTasks DailyTasks { get; set; }
        public class DescribeCacheAnalysisReportListResponseBodyDailyTasks : TeaModel {
            [NameInMap("DailyTask")]
            [Validation(Required=false)]
            public List<DescribeCacheAnalysisReportListResponseBodyDailyTasksDailyTask> DailyTask { get; set; }
            public class DescribeCacheAnalysisReportListResponseBodyDailyTasksDailyTask : TeaModel {
                /// <summary>
                /// The date when the offline key analytics task was performed.
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// Details of the offline key analytics tasks.
                /// </summary>
                [NameInMap("Tasks")]
                [Validation(Required=false)]
                public DescribeCacheAnalysisReportListResponseBodyDailyTasksDailyTaskTasks Tasks { get; set; }
                public class DescribeCacheAnalysisReportListResponseBodyDailyTasksDailyTaskTasks : TeaModel {
                    [NameInMap("Task")]
                    [Validation(Required=false)]
                    public List<DescribeCacheAnalysisReportListResponseBodyDailyTasksDailyTaskTasksTask> Task { get; set; }
                    public class DescribeCacheAnalysisReportListResponseBodyDailyTasksDailyTaskTasksTask : TeaModel {
                        /// <summary>
                        /// The ID of the child node in the cluster instance.
                        /// </summary>
                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public string NodeId { get; set; }

                        /// <summary>
                        /// The start time of the offline key analytics task.
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// The state of the offline key analytics task. Valid values:
                        /// 
                        /// *   **success**
                        /// *   **running**
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// The ID of the task.
                        /// </summary>
                        [NameInMap("TaskId")]
                        [Validation(Required=false)]
                        public string TaskId { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
