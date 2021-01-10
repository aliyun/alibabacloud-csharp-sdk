// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class SkipLinkeBahamutPipelinecomponentexecutskipionidRequest : TeaModel {
        [NameInMap("ComponentExecutionId")]
        [Validation(Required=false)]
        public string ComponentExecutionId { get; set; }

        [NameInMap("ComponentId")]
        [Validation(Required=false)]
        public string ComponentId { get; set; }

        [NameInMap("JobExecutionId")]
        [Validation(Required=false)]
        public string JobExecutionId { get; set; }

        [NameInMap("PipelineExecutionId")]
        [Validation(Required=false)]
        public string PipelineExecutionId { get; set; }

        [NameInMap("PipelineInstanceId")]
        [Validation(Required=false)]
        public string PipelineInstanceId { get; set; }

    }

}
