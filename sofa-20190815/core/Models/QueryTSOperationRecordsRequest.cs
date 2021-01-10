// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryTSOperationRecordsRequest : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        [NameInMap("OperationResult")]
        [Validation(Required=false)]
        public string OperationResult { get; set; }

        [NameInMap("OperationTarget")]
        [Validation(Required=false)]
        public string OperationTarget { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
