// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ContinuePipelineRequest : TeaModel {
        [NameInMap("Confirm")]
        [Validation(Required=false)]
        public bool? Confirm { get; set; }

        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

    }

}
