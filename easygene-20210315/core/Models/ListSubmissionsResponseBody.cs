// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListSubmissionsResponseBody : TeaModel {
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Submissions")]
        [Validation(Required=false)]
        public List<ListSubmissionsResponseBodySubmissions> Submissions { get; set; }
        public class ListSubmissionsResponseBodySubmissions : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            [NameInMap("RunStats")]
            [Validation(Required=false)]
            public ListSubmissionsResponseBodySubmissionsRunStats RunStats { get; set; }
            public class ListSubmissionsResponseBodySubmissionsRunStats : TeaModel {
                [NameInMap("Aborted")]
                [Validation(Required=false)]
                public long? Aborted { get; set; }

                [NameInMap("Aborting")]
                [Validation(Required=false)]
                public long? Aborting { get; set; }

                [NameInMap("Failed")]
                [Validation(Required=false)]
                public long? Failed { get; set; }

                [NameInMap("Pending")]
                [Validation(Required=false)]
                public long? Pending { get; set; }

                [NameInMap("Running")]
                [Validation(Required=false)]
                public long? Running { get; set; }

                [NameInMap("Submitted")]
                [Validation(Required=false)]
                public long? Submitted { get; set; }

                [NameInMap("Succeeded")]
                [Validation(Required=false)]
                public long? Succeeded { get; set; }

            }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SubmissionId")]
            [Validation(Required=false)]
            public string SubmissionId { get; set; }

            [NameInMap("Workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
