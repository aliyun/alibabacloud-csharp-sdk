// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeCacheAnalysisReportListResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the offline key analytics tasks.</para>
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
                /// <para>The date when the offline key analytics task was performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-08-01Z</para>
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <para>Details of the offline key analytics tasks.</para>
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
                        /// <para>The ID of the child node in the cluster instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>r-bp1zxszhcgatnx****-db-0</para>
                        /// </summary>
                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public string NodeId { get; set; }

                        /// <summary>
                        /// <para>The start time of the offline key analytics task.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-08-01T19:08:49Z</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <para>The state of the offline key analytics task. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>success</b></description></item>
                        /// <item><description><b>running</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>success</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// <para>The ID of the task.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>156465****</para>
                        /// </summary>
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
