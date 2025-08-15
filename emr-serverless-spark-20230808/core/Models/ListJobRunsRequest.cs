// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListJobRunsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the user who created the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1509789347011222</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The range of end time.</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public ListJobRunsRequestEndTime EndTime { get; set; }
        public class ListJobRunsRequestEndTime : TeaModel {
            /// <summary>
            /// <para>The end of the end time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710432000000</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The beginning of the end time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1709740800000</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        [NameInMap("isWorkflow")]
        [Validation(Required=false)]
        public string IsWorkflow { get; set; }

        /// <summary>
        /// <para>The job run ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jd-b6d003f1930f****</para>
        /// </summary>
        [NameInMap("jobRunDeploymentId")]
        [Validation(Required=false)]
        public string JobRunDeploymentId { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>j-xxx</para>
        /// </summary>
        [NameInMap("jobRunId")]
        [Validation(Required=false)]
        public string JobRunId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The minimum running duration of the job. Unit: ms.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60000</para>
        /// </summary>
        [NameInMap("minDuration")]
        [Validation(Required=false)]
        public long? MinDuration { get; set; }

        /// <summary>
        /// <para>The job name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>emr-spark-demo-job</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C89568980</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the resource queue on which the Spark jobs run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dev_queue</para>
        /// </summary>
        [NameInMap("resourceQueueId")]
        [Validation(Required=false)]
        public string ResourceQueueId { get; set; }

        /// <summary>
        /// <para>The range of start time.</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public ListJobRunsRequestStartTime StartTime { get; set; }
        public class ListJobRunsRequestStartTime : TeaModel {
            /// <summary>
            /// <para>The end of the start time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710432000000</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The beginning of the start time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1709740800000</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>The job states.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Running&quot;,&quot;Submitted&quot;]</para>
        /// </summary>
        [NameInMap("states")]
        [Validation(Required=false)]
        public List<string> States { get; set; }

        /// <summary>
        /// <para>The tags of the job.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<ListJobRunsRequestTags> Tags { get; set; }
        public class ListJobRunsRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of tag N.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag_key</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
