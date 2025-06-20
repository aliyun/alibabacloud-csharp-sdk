// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safe20220117.Models
{
    public class ChangeStartRequest : TeaModel {
        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        [NameInMap("AuthSign")]
        [Validation(Required=false)]
        public string AuthSign { get; set; }

        [NameInMap("ChangeEndTime")]
        [Validation(Required=false)]
        public long? ChangeEndTime { get; set; }

        [NameInMap("ChangeObject")]
        [Validation(Required=false)]
        public string ChangeObject { get; set; }

        [NameInMap("ChangeOptType")]
        [Validation(Required=false)]
        public string ChangeOptType { get; set; }

        [NameInMap("ChangeStartTime")]
        [Validation(Required=false)]
        public long? ChangeStartTime { get; set; }

        [NameInMap("ChangeTitle")]
        [Validation(Required=false)]
        public string ChangeTitle { get; set; }

        [NameInMap("CreatorEmpId")]
        [Validation(Required=false)]
        public string CreatorEmpId { get; set; }

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
