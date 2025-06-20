// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safe20220117.Models
{
    public class CancelBlockRequest : TeaModel {
        [NameInMap("BlockId")]
        [Validation(Required=false)]
        public long? BlockId { get; set; }

        [NameInMap("CancelBLockDesc")]
        [Validation(Required=false)]
        public string CancelBLockDesc { get; set; }

        [NameInMap("CreateEmpId")]
        [Validation(Required=false)]
        public string CreateEmpId { get; set; }

    }

}
