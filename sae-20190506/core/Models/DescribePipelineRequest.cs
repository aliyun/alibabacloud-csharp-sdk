// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribePipelineRequest : TeaModel {
        /// <summary>
        /// The ID of the batch. You can call the [DescribeChangeOrder](https://help.aliyun.com/document_detail/126617.html) operation to obtain the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

    }

}
