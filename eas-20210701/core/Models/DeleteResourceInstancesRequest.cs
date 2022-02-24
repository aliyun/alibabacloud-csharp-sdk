// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DeleteResourceInstancesRequest : TeaModel {
        [NameInMap("AllFailed")]
        [Validation(Required=false)]
        public bool? AllFailed { get; set; }

        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public string InstanceList { get; set; }

    }

}
