// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeBahamutPipelinererunRequest : TeaModel {
        [NameInMap("ComponentExecutionId")]
        [Validation(Required=false)]
        public string ComponentExecutionId { get; set; }

        [NameInMap("IterationUnitId")]
        [Validation(Required=false)]
        public string IterationUnitId { get; set; }

        [NameInMap("JobExecutionId")]
        [Validation(Required=false)]
        public long? JobExecutionId { get; set; }

        [NameInMap("PipelineExecutionId")]
        [Validation(Required=false)]
        public long? PipelineExecutionId { get; set; }

        [NameInMap("PipelineInstanceId")]
        [Validation(Required=false)]
        public long? PipelineInstanceId { get; set; }

        [NameInMap("ReRunTestCaseClassesRepeatList")]
        [Validation(Required=false)]
        public List<string> ReRunTestCaseClassesRepeatList { get; set; }

        [NameInMap("StageId")]
        [Validation(Required=false)]
        public string StageId { get; set; }

    }

}
