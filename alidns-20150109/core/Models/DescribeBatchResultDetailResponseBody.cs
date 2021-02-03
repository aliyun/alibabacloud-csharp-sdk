// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeBatchResultDetailResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("BatchResultDetails")]
        [Validation(Required=false)]
        public DescribeBatchResultDetailResponseBodyBatchResultDetails BatchResultDetails { get; set; }
        public class DescribeBatchResultDetailResponseBodyBatchResultDetails : TeaModel {
            [NameInMap("BatchResultDetail")]
            [Validation(Required=false)]
            public List<DescribeBatchResultDetailResponseBodyBatchResultDetailsBatchResultDetail> BatchResultDetail { get; set; }
            public class DescribeBatchResultDetailResponseBodyBatchResultDetailsBatchResultDetail : TeaModel {
                public bool? Status { get; set; }
                public string Type { get; set; }
                public string Domain { get; set; }
                public string Remark { get; set; }
                public string RecordId { get; set; }
                public string Rr { get; set; }
                public string Priority { get; set; }
                public string RrStatus { get; set; }
                public string OperateDateStr { get; set; }
                public string NewValue { get; set; }
                public string Value { get; set; }
                public string Ttl { get; set; }
                public string BatchType { get; set; }
                public string Line { get; set; }
                public string NewRr { get; set; }
                public string Reason { get; set; }
            }
        };

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

    }

}
