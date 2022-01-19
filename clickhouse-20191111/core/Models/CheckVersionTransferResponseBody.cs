// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class CheckVersionTransferResponseBody : TeaModel {
        [NameInMap("CheckAccess")]
        [Validation(Required=false)]
        public CheckVersionTransferResponseBodyCheckAccess CheckAccess { get; set; }
        public class CheckVersionTransferResponseBodyCheckAccess : TeaModel {
            [NameInMap("ErrCode")]
            [Validation(Required=false)]
            public long? ErrCode { get; set; }
            [NameInMap("ErrMessage")]
            [Validation(Required=false)]
            public string ErrMessage { get; set; }
        };

        [NameInMap("CheckCategory")]
        [Validation(Required=false)]
        public bool? CheckCategory { get; set; }

        [NameInMap("CheckCode")]
        [Validation(Required=false)]
        public CheckVersionTransferResponseBodyCheckCode CheckCode { get; set; }
        public class CheckVersionTransferResponseBodyCheckCode : TeaModel {
            [NameInMap("ErrCode")]
            [Validation(Required=false)]
            public long? ErrCode { get; set; }
            [NameInMap("ErrMessage")]
            [Validation(Required=false)]
            public string ErrMessage { get; set; }
        };

        [NameInMap("CheckConnection")]
        [Validation(Required=false)]
        public bool? CheckConnection { get; set; }

        [NameInMap("CheckStatus")]
        [Validation(Required=false)]
        public CheckVersionTransferResponseBodyCheckStatus CheckStatus { get; set; }
        public class CheckVersionTransferResponseBodyCheckStatus : TeaModel {
            [NameInMap("ErrCode")]
            [Validation(Required=false)]
            public long? ErrCode { get; set; }
            [NameInMap("ErrMessage")]
            [Validation(Required=false)]
            public string ErrMessage { get; set; }
        };

        [NameInMap("CheckStorage")]
        [Validation(Required=false)]
        public bool? CheckStorage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TimeDuration")]
        [Validation(Required=false)]
        public string TimeDuration { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
