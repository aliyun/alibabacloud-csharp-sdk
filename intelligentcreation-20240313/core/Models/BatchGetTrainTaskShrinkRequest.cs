// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class BatchGetTrainTaskShrinkRequest : TeaModel {
        [NameInMap("aliyunMainId")]
        [Validation(Required=false)]
        public string AliyunMainId { get; set; }

        [NameInMap("taskIdList")]
        [Validation(Required=false)]
        public string TaskIdListShrink { get; set; }

    }

}
