// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ConfirmPipelineBatchRequest : TeaModel {
        /// <summary>
        /// true
        /// </summary>
        [NameInMap("Confirm")]
        [Validation(Required=false)]
        public bool? Confirm { get; set; }

        /// <summary>
        /// e2e-vds-feh-\*\*\*
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

    }

}
