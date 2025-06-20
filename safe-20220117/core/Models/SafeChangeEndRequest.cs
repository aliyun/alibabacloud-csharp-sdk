// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safe20220117.Models
{
    public class SafeChangeEndRequest : TeaModel {
        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        [NameInMap("AuthSign")]
        [Validation(Required=false)]
        public string AuthSign { get; set; }

        [NameInMap("ChangeEndTime")]
        [Validation(Required=false)]
        public long? ChangeEndTime { get; set; }

        [NameInMap("ChangeResult")]
        [Validation(Required=false)]
        public string ChangeResult { get; set; }

        [NameInMap("CurBatchNo")]
        [Validation(Required=false)]
        public int? CurBatchNo { get; set; }

        [NameInMap("ExecutorEmpId")]
        [Validation(Required=false)]
        public string ExecutorEmpId { get; set; }

        [NameInMap("ReqTimestamp")]
        [Validation(Required=false)]
        public long? ReqTimestamp { get; set; }

        [NameInMap("SourceOrderId")]
        [Validation(Required=false)]
        public string SourceOrderId { get; set; }

        [NameInMap("TotalBatchNo")]
        [Validation(Required=false)]
        public int? TotalBatchNo { get; set; }

    }

}
