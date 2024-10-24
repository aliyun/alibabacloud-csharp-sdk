// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class DeleteJobsRequest : TeaModel {
        [NameInMap("ExecutorIds")]
        [Validation(Required=false)]
        public List<string> ExecutorIds { get; set; }

        [NameInMap("JobSpec")]
        [Validation(Required=false)]
        public List<DeleteJobsRequestJobSpec> JobSpec { get; set; }
        public class DeleteJobsRequestJobSpec : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>job-xxxx</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("TaskSpec")]
            [Validation(Required=false)]
            public List<DeleteJobsRequestJobSpecTaskSpec> TaskSpec { get; set; }
            public class DeleteJobsRequestJobSpecTaskSpec : TeaModel {
                [NameInMap("ArrayIndex")]
                [Validation(Required=false)]
                public List<int?> ArrayIndex { get; set; }

                /// <summary>
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
