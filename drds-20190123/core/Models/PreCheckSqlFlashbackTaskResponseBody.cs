// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class PreCheckSqlFlashbackTaskResponseBody : TeaModel {
        [NameInMap("CheckResult")]
        [Validation(Required=false)]
        public PreCheckSqlFlashbackTaskResponseBodyCheckResult CheckResult { get; set; }
        public class PreCheckSqlFlashbackTaskResponseBodyCheckResult : TeaModel {
            [NameInMap("BinlogExists")]
            [Validation(Required=false)]
            public bool? BinlogExists { get; set; }
            [NameInMap("BinlogRowQueryEventEnabled")]
            [Validation(Required=false)]
            public bool? BinlogRowQueryEventEnabled { get; set; }
            [NameInMap("CanUpgradeSupportBinlogRowQueryEvents")]
            [Validation(Required=false)]
            public bool? CanUpgradeSupportBinlogRowQueryEvents { get; set; }
            [NameInMap("HasTable")]
            [Validation(Required=false)]
            public bool? HasTable { get; set; }
            [NameInMap("SupportBinlogRowQueryEvents")]
            [Validation(Required=false)]
            public bool? SupportBinlogRowQueryEvents { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
