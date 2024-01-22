// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribePipelineRequest : TeaModel {
        /// <summary>
        /// The ID of the batch. You can call the [DescribeChangeOrder](~~126617~~) operation to obtain the ID.
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

    }

}
