// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class SelectMetaStatus : TeaModel {
        [NameInMap("ColsCount")]
        [Validation(Required=false)]
        public long? ColsCount { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        [NameInMap("RowsCount")]
        [Validation(Required=false)]
        public long? RowsCount { get; set; }

        [NameInMap("SplitsCount")]
        [Validation(Required=false)]
        public long? SplitsCount { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        [NameInMap("TotalScannedBytes")]
        [Validation(Required=false)]
        public long? TotalScannedBytes { get; set; }

    }

}
