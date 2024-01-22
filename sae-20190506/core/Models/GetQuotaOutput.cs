// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class GetQuotaOutput : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("instanceLimit")]
        [Validation(Required=false)]
        public long? InstanceLimit { get; set; }

        [NameInMap("instanceUsed")]
        [Validation(Required=false)]
        public long? InstanceUsed { get; set; }

    }

}
