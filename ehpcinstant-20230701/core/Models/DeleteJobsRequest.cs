// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class DeleteJobsRequest : TeaModel {
        /// <summary>
        /// <para>The list of executor IDs. A maximum of 100 IDs are supported.</para>
        /// </summary>
        [NameInMap("ExecutorIds")]
        [Validation(Required=false)]
        public List<string> ExecutorIds { get; set; }

        /// <summary>
        /// <para>The type of the job scheduler.</para>
        /// <list type="bullet">
        /// <item><description>HPC</description></item>
        /// <item><description>K8S</description></item>
        /// </list>
        /// <para>Default value: HPC</para>
        /// 
        /// <b>Example:</b>
        /// <para>HPC</para>
        /// </summary>
        [NameInMap("JobScheduler")]
        [Validation(Required=false)]
        public string JobScheduler { get; set; }

        /// <summary>
        /// <para>The information about the job to be deleted.</para>
        /// </summary>
        [NameInMap("JobSpec")]
        [Validation(Required=false)]
        public List<DeleteJobsRequestJobSpec> JobSpec { get; set; }
        public class DeleteJobsRequestJobSpec : TeaModel {
            /// <summary>
            /// <para>The ID of the job to be deleted.\
            /// You can call the ListJobs operation to query job IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-xxxx</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The task details of the job to be deleted.</para>
            /// </summary>
            [NameInMap("TaskSpec")]
            [Validation(Required=false)]
            public List<DeleteJobsRequestJobSpecTaskSpec> TaskSpec { get; set; }
            public class DeleteJobsRequestJobSpecTaskSpec : TeaModel {
                /// <summary>
                /// <para>The list of array job indexes to be deleted.</para>
                /// </summary>
                [NameInMap("ArrayIndex")]
                [Validation(Required=false)]
                public List<int?> ArrayIndex { get; set; }

                /// <summary>
                /// <para>The name of the task to be deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>task0</para>
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

            }

        }

    }

}
