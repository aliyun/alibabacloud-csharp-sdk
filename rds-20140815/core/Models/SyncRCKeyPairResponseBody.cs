// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class SyncRCKeyPairResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SyncRCKeyPairResponseBodyData Data { get; set; }
        public class SyncRCKeyPairResponseBodyData : TeaModel {
            [NameInMap("IsSyncInfo")]
            [Validation(Required=false)]
            public bool? IsSyncInfo { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
