// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_finplus20220913.Models
{
    public class SelectComputeTask2Request : TeaModel {
        [NameInMap("bcConfirm")]
        [Validation(Required=false)]
        public bool? BcConfirm { get; set; }

        [NameInMap("bcId")]
        [Validation(Required=false)]
        public long? BcId { get; set; }

        [NameInMap("clientId")]
        [Validation(Required=false)]
        public long? ClientId { get; set; }

    }

}
