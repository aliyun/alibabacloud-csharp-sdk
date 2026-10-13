// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ListMetaProfilingSkillJobPageResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of profiling tasks. For the element structure, see the descriptions of the child fields.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListMetaProfilingSkillJobPageResponseBodyData> Data { get; set; }
        public class ListMetaProfilingSkillJobPageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The component ID, which is the primary key identifier of the data source component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2001</para>
            /// </summary>
            [NameInMap("componentId")]
            [Validation(Required=false)]
            public long? ComponentId { get; set; }

            /// <summary>
            /// <para>The identifier of the current execution status of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("currentTaskStatus")]
            [Validation(Required=false)]
            public int? CurrentTaskStatus { get; set; }

            /// <summary>
            /// <para>The data component name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hive_cluster_a</para>
            /// </summary>
            [NameInMap("dcName")]
            [Validation(Required=false)]
            public string DcName { get; set; }

            /// <summary>
            /// <para>The status identifier of the data component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("dcStatus")]
            [Validation(Required=false)]
            public int? DcStatus { get; set; }

            /// <summary>
            /// <para>The type identifier of the data component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HIVE</para>
            /// </summary>
            [NameInMap("dcType")]
            [Validation(Required=false)]
            public string DcType { get; set; }

            /// <summary>
            /// <para>The number of differing nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("diffNodeNum")]
            [Validation(Required=false)]
            public int? DiffNodeNum { get; set; }

            /// <summary>
            /// <para>The number of differing partitions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("diffPartitionNum")]
            [Validation(Required=false)]
            public int? DiffPartitionNum { get; set; }

            /// <summary>
            /// <para>The number of differing tables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("diffTableNum")]
            [Validation(Required=false)]
            public int? DiffTableNum { get; set; }

            /// <summary>
            /// <para>The number of differing workflows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("diffWorkflowNum")]
            [Validation(Required=false)]
            public int? DiffWorkflowNum { get; set; }

            /// <summary>
            /// <para>The category type identifier of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SOURCE</para>
            /// </summary>
            [NameInMap("dsCategoryType")]
            [Validation(Required=false)]
            public string DsCategoryType { get; set; }

            /// <summary>
            /// <para>The time when the record was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-19 22:00:02</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>Indicates whether incremental changes exist.</para>
            /// </summary>
            [NameInMap("hasIncrementChanges")]
            [Validation(Required=false)]
            public bool? HasIncrementChanges { get; set; }

            /// <summary>
            /// <para>The primary key ID of the object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7001</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The description of the profiling task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Daily full metadata profiling task</para>
            /// </summary>
            [NameInMap("jobDesc")]
            [Validation(Required=false)]
            public string JobDesc { get; set; }

            /// <summary>
            /// <para>The profiling task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>profiling_daily</para>
            /// </summary>
            [NameInMap("jobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>The status identifier of the profiling task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("jobStatus")]
            [Validation(Required=false)]
            public int? JobStatus { get; set; }

            /// <summary>
            /// <para>The ID of the most recent execution batch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20240719220000</para>
            /// </summary>
            [NameInMap("lastBatchId")]
            [Validation(Required=false)]
            public string LastBatchId { get; set; }

            /// <summary>
            /// <para>The ID of the most recently executed task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8001</para>
            /// </summary>
            [NameInMap("lastTaskId")]
            [Validation(Required=false)]
            public long? LastTaskId { get; set; }

            /// <summary>
            /// <para>The estimated time for the next scheduled execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-20 02:00:00</para>
            /// </summary>
            [NameInMap("nextCronTime")]
            [Validation(Required=false)]
            public string NextCronTime { get; set; }

            /// <summary>
            /// <para>Indicates whether data profiling is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("profilingEnable")]
            [Validation(Required=false)]
            public int? ProfilingEnable { get; set; }

            /// <summary>
            /// <para>The list of schemas (databases) to be profiled.</para>
            /// </summary>
            [NameInMap("profilingSchemaList")]
            [Validation(Required=false)]
            public List<string> ProfilingSchemaList { get; set; }

            /// <summary>
            /// <para>The identifier of the task execution result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("taskExecResult")]
            [Validation(Required=false)]
            public int? TaskExecResult { get; set; }

            /// <summary>
            /// <para>The time when the task execution was completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-19 22:00:02</para>
            /// </summary>
            [NameInMap("taskFinishTime")]
            [Validation(Required=false)]
            public string TaskFinishTime { get; set; }

            /// <summary>
            /// <para>The type identifier of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROFILING</para>
            /// </summary>
            [NameInMap("taskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// <para>The error code. This parameter is an empty string if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameter</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message. This parameter is an empty string if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The parameter is invalid or missing.</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The current page number, starting from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of records to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID used to locate and troubleshoot issues for this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3F45B8C1-2A6E-4C9B-9E1F-7D2A1B0C5E66</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. A value of true indicates success, and a value of false indicates failure. If the call fails, troubleshoot the issue based on the errCode and errMessage parameters.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records that meet the specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
