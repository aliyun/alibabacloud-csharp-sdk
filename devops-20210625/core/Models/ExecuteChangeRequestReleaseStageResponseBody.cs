// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ExecuteChangeRequestReleaseStageResponseBody : TeaModel {
        [NameInMap("object")]
        [Validation(Required=false)]
        public long? Object { get; set; }

        [NameInMap("pipelineId")]
        [Validation(Required=false)]
        public long? PipelineId { get; set; }

        [NameInMap("pipelineRunId")]
        [Validation(Required=false)]
        public long? PipelineRunId { get; set; }

    }

}
