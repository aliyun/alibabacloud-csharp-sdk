// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gws20190618.Models
{
    public class DescribeInstancePolicyResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("VisualLossless")]
        [Validation(Required=true)]
        public string VisualLossless { get; set; }

        [NameInMap("OptimizeFor3d")]
        [Validation(Required=true)]
        public string OptimizeFor3d { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=true)]
        public string TaskId { get; set; }

        [NameInMap("TaskFinished")]
        [Validation(Required=true)]
        public bool? TaskFinished { get; set; }

    }

}
