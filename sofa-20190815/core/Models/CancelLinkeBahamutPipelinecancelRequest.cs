// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CancelLinkeBahamutPipelinecancelRequest : TeaModel {
        [NameInMap("ExecutionId")]
        [Validation(Required=false)]
        public long? ExecutionId { get; set; }

        [NameInMap("IterationId")]
        [Validation(Required=false)]
        public string IterationId { get; set; }

        [NameInMap("IterationUnitId")]
        [Validation(Required=false)]
        public string IterationUnitId { get; set; }

        [NameInMap("PipelineGroupId")]
        [Validation(Required=false)]
        public string PipelineGroupId { get; set; }

        [NameInMap("PipelineGroupType")]
        [Validation(Required=false)]
        public string PipelineGroupType { get; set; }

        [NameInMap("SkipGetLatestContext")]
        [Validation(Required=false)]
        public bool? SkipGetLatestContext { get; set; }

        [NameInMap("StageId")]
        [Validation(Required=false)]
        public string StageId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
