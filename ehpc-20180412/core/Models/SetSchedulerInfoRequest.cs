// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class SetSchedulerInfoRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("PbsInfo")]
        [Validation(Required=false)]
        public List<SetSchedulerInfoRequestPbsInfo> PbsInfo { get; set; }
        public class SetSchedulerInfoRequestPbsInfo : TeaModel {
            [NameInMap("AclLimit")]
            [Validation(Required=false)]
            public List<SetSchedulerInfoRequestPbsInfoAclLimit> AclLimit { get; set; }
            public class SetSchedulerInfoRequestPbsInfoAclLimit : TeaModel {
                [NameInMap("AclUsers")]
                [Validation(Required=false)]
                public string AclUsers { get; set; }

                [NameInMap("Queue")]
                [Validation(Required=false)]
                public string Queue { get; set; }

            }

            [NameInMap("JobHistoryDuration")]
            [Validation(Required=false)]
            public int? JobHistoryDuration { get; set; }

            [NameInMap("ResourceLimit")]
            [Validation(Required=false)]
            public List<SetSchedulerInfoRequestPbsInfoResourceLimit> ResourceLimit { get; set; }
            public class SetSchedulerInfoRequestPbsInfoResourceLimit : TeaModel {
                [NameInMap("Cpus")]
                [Validation(Required=false)]
                public int? Cpus { get; set; }

                [NameInMap("MaxJobs")]
                [Validation(Required=false)]
                public int? MaxJobs { get; set; }

                [NameInMap("Mem")]
                [Validation(Required=false)]
                public string Mem { get; set; }

                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public int? Nodes { get; set; }

                [NameInMap("Queue")]
                [Validation(Required=false)]
                public string Queue { get; set; }

                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

            [NameInMap("SchedInterval")]
            [Validation(Required=false)]
            public int? SchedInterval { get; set; }

            [NameInMap("SchedMaxJobs")]
            [Validation(Required=false)]
            public int? SchedMaxJobs { get; set; }

            [NameInMap("SchedMaxQueuedJobs")]
            [Validation(Required=false)]
            public int? SchedMaxQueuedJobs { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public List<SetSchedulerInfoRequestScheduler> Scheduler { get; set; }
        public class SetSchedulerInfoRequestScheduler : TeaModel {
            [NameInMap("SchedName")]
            [Validation(Required=false)]
            public string SchedName { get; set; }

        }

        [NameInMap("SlurmInfo")]
        [Validation(Required=false)]
        public List<SetSchedulerInfoRequestSlurmInfo> SlurmInfo { get; set; }
        public class SetSchedulerInfoRequestSlurmInfo : TeaModel {
            [NameInMap("BackfillInterval")]
            [Validation(Required=false)]
            public int? BackfillInterval { get; set; }

            [NameInMap("SchedInterval")]
            [Validation(Required=false)]
            public int? SchedInterval { get; set; }

        }

    }

}
