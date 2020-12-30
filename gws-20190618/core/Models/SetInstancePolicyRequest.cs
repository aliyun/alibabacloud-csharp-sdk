// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gws20190618.Models
{
    public class SetInstancePolicyRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("VisualLossless")]
        [Validation(Required=false)]
        public string VisualLossless { get; set; }

        [NameInMap("OptimizeFor3d")]
        [Validation(Required=false)]
        public string OptimizeFor3d { get; set; }

        [NameInMap("AsyncMode")]
        [Validation(Required=false)]
        public bool? AsyncMode { get; set; }

    }

}
