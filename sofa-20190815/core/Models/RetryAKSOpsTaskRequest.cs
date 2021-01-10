// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class RetryAKSOpsTaskRequest : TeaModel {
        [NameInMap("BaseControlOperationRequestJsonStr")]
        [Validation(Required=false)]
        public string BaseControlOperationRequestJsonStr { get; set; }

        [NameInMap("ControlType")]
        [Validation(Required=false)]
        public string ControlType { get; set; }

        [NameInMap("ScopeJsonStr")]
        [Validation(Required=false)]
        public string ScopeJsonStr { get; set; }

        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        [NameInMap("TargetName")]
        [Validation(Required=false)]
        public string TargetName { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
