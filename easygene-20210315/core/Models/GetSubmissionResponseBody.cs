// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class GetSubmissionResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 主机ID
        /// </summary>
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        /// <summary>
        /// 投递列表
        /// </summary>
        [NameInMap("Submission")]
        [Validation(Required=false)]
        public GetSubmissionResponseBodySubmission Submission { get; set; }
        public class GetSubmissionResponseBodySubmission : TeaModel {
            [NameInMap("Workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }
            [NameInMap("SubmissionId")]
            [Validation(Required=false)]
            public string SubmissionId { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }
            [NameInMap("RunStats")]
            [Validation(Required=false)]
            public GetSubmissionResponseBodySubmissionRunStats RunStats { get; set; }
            public class GetSubmissionResponseBodySubmissionRunStats : TeaModel {
                [NameInMap("Submitted")]
                [Validation(Required=false)]
                public long? Submitted { get; set; }

                [NameInMap("Pending")]
                [Validation(Required=false)]
                public long? Pending { get; set; }

                [NameInMap("Running")]
                [Validation(Required=false)]
                public long? Running { get; set; }

                [NameInMap("Succeeded")]
                [Validation(Required=false)]
                public long? Succeeded { get; set; }

                [NameInMap("Failed")]
                [Validation(Required=false)]
                public long? Failed { get; set; }

                [NameInMap("Aborting")]
                [Validation(Required=false)]
                public long? Aborting { get; set; }

                [NameInMap("Aborted")]
                [Validation(Required=false)]
                public long? Aborted { get; set; }

            }
        };

    }

}
