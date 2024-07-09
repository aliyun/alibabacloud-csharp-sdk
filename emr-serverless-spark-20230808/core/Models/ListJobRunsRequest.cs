// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListJobRunsRequest : TeaModel {
        /// <summary>
        /// The ID of the user who creates a Spark job.
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// The range of end time.
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public ListJobRunsRequestEndTime EndTime { get; set; }
        public class ListJobRunsRequestEndTime : TeaModel {
            /// <summary>
            /// The end of the end time range.
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The beginning of the end time range.
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        [NameInMap("jobRunDeploymentId")]
        [Validation(Required=false)]
        public string JobRunDeploymentId { get; set; }

        /// <summary>
        /// The job ID.
        /// </summary>
        [NameInMap("jobRunId")]
        [Validation(Required=false)]
        public string JobRunId { get; set; }

        /// <summary>
        /// The maximum number of entries to return.
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The job name.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The pagination token that is used in the request to retrieve a new page of results.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the resource queue on which the Spark jobs run.
        /// </summary>
        [NameInMap("resourceQueueId")]
        [Validation(Required=false)]
        public string ResourceQueueId { get; set; }

        /// <summary>
        /// The range of start time.
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public ListJobRunsRequestStartTime StartTime { get; set; }
        public class ListJobRunsRequestStartTime : TeaModel {
            /// <summary>
            /// The end of the start time range.
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The beginning of the start time range.
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// The job states.
        /// </summary>
        [NameInMap("states")]
        [Validation(Required=false)]
        public List<string> States { get; set; }

        /// <summary>
        /// The tags of the job.
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<ListJobRunsRequestTags> Tags { get; set; }
        public class ListJobRunsRequestTags : TeaModel {
            /// <summary>
            /// The key of tag N.
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N.
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
