// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListJobsResponseBody : TeaModel {
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public ListJobsResponseBodyJobs Jobs { get; set; }
        public class ListJobsResponseBodyJobs : TeaModel {
            [NameInMap("JobInfo")]
            [Validation(Required=false)]
            public List<ListJobsResponseBodyJobsJobInfo> JobInfo { get; set; }
            public class ListJobsResponseBodyJobsJobInfo : TeaModel {
                public string ArrayRequest { get; set; }
                public string Comment { get; set; }
                public string Id { get; set; }
                public string LastModifyTime { get; set; }
                public string Name { get; set; }
                public string NodeList { get; set; }
                public string Owner { get; set; }
                public string Priority { get; set; }
                public ListJobsResponseBodyJobsJobInfoResources Resources { get; set; }
                public class ListJobsResponseBodyJobsJobInfoResources : TeaModel {
                    [NameInMap("Cores")]
                    [Validation(Required=false)]
                    public int? Cores { get; set; }

                    [NameInMap("Nodes")]
                    [Validation(Required=false)]
                    public int? Nodes { get; set; }

                }
                public string ShellPath { get; set; }
                public string StartTime { get; set; }
                public string State { get; set; }
                public string Stderr { get; set; }
                public string Stdout { get; set; }
                public string SubmitTime { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
