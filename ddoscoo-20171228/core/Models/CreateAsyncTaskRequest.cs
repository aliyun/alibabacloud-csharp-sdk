// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class CreateAsyncTaskRequest : TeaModel {
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=true)]
        public int? TaskType { get; set; }

        [NameInMap("TaskParams")]
        [Validation(Required=true)]
        public string TaskParams { get; set; }

    }

}
