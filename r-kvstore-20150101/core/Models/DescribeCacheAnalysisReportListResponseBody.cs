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
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                [NameInMap("Tasks")]
                [Validation(Required=false)]
                public DescribeCacheAnalysisReportListResponseBodyDailyTasksDailyTaskTasks Tasks { get; set; }
                public class DescribeCacheAnalysisReportListResponseBodyDailyTasksDailyTaskTasks : TeaModel {
                    [NameInMap("Task")]
                    [Validation(Required=false)]
                    public List<DescribeCacheAnalysisReportListResponseBodyDailyTasksDailyTaskTasksTask> Task { get; set; }
                    public class DescribeCacheAnalysisReportListResponseBodyDailyTasksDailyTaskTasksTask : TeaModel {
                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public string NodeId { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        [NameInMap("TaskId")]
                        [Validation(Required=false)]
                        public string TaskId { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1041xxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>743D0A03-52DE-4E6F-8D09-EC1414CF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
