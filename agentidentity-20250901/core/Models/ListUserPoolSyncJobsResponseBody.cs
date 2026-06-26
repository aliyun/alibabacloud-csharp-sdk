// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class ListUserPoolSyncJobsResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SynchronizationJobs")]
        [Validation(Required=false)]
        public List<ListUserPoolSyncJobsResponseBodySynchronizationJobs> SynchronizationJobs { get; set; }
        public class ListUserPoolSyncJobsResponseBodySynchronizationJobs : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("IdentityProviderType")]
            [Validation(Required=false)]
            public string IdentityProviderType { get; set; }

            [NameInMap("JobSummary")]
            [Validation(Required=false)]
            public ListUserPoolSyncJobsResponseBodySynchronizationJobsJobSummary JobSummary { get; set; }
            public class ListUserPoolSyncJobsResponseBodySynchronizationJobsJobSummary : TeaModel {
                [NameInMap("Created")]
                [Validation(Required=false)]
                public string Created { get; set; }

                [NameInMap("Deleted")]
                [Validation(Required=false)]
                public string Deleted { get; set; }

                [NameInMap("Same")]
                [Validation(Required=false)]
                public string Same { get; set; }

                [NameInMap("Updated")]
                [Validation(Required=false)]
                public string Updated { get; set; }

            }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SynchronizationJobId")]
            [Validation(Required=false)]
            public string SynchronizationJobId { get; set; }

            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
