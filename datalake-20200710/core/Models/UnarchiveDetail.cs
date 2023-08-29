// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class UnarchiveDetail : TeaModel {
        [NameInMap("ApiCallTimes")]
        [Validation(Required=false)]
        public long? ApiCallTimes { get; set; }

        [NameInMap("Cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public long? StorageSize { get; set; }

        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        [NameInMap("UnarchiveTaskStatus")]
        [Validation(Required=false)]
        public string UnarchiveTaskStatus { get; set; }

    }

}
