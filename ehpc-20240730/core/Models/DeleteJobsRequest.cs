// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class DeleteJobsRequest : TeaModel {
        [NameInMap("JobSpec")]
        [Validation(Required=false)]
        public List<DeleteJobsRequestJobSpec> JobSpec { get; set; }
        public class DeleteJobsRequestJobSpec : TeaModel {
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

                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

            }

        }

    }

}
