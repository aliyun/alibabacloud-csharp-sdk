// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListPipelineJobsResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("jobs")]
        [Validation(Required=false)]
        public List<ListPipelineJobsResponseBodyJobs> Jobs { get; set; }
        public class ListPipelineJobsResponseBodyJobs : TeaModel {
            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            [NameInMap("jobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            [NameInMap("lastJobId")]
            [Validation(Required=false)]
            public long? LastJobId { get; set; }

            [NameInMap("lastJobParams")]
            [Validation(Required=false)]
            public string LastJobParams { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
