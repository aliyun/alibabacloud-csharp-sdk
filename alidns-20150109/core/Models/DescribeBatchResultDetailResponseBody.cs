// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeBatchResultDetailResponseBody : TeaModel {
        [NameInMap("BatchResultDetails")]
        [Validation(Required=false)]
        public DescribeBatchResultDetailResponseBodyBatchResultDetails BatchResultDetails { get; set; }
        public class DescribeBatchResultDetailResponseBodyBatchResultDetails : TeaModel {
            [NameInMap("BatchResultDetail")]
            [Validation(Required=false)]
            public List<DescribeBatchResultDetailResponseBodyBatchResultDetailsBatchResultDetail> BatchResultDetail { get; set; }
            public class DescribeBatchResultDetailResponseBodyBatchResultDetailsBatchResultDetail : TeaModel {
                [NameInMap("BatchType")]
                [Validation(Required=false)]
                public string BatchType { get; set; }

                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("Line")]
                [Validation(Required=false)]
                public string Line { get; set; }

                [NameInMap("NewRr")]
                [Validation(Required=false)]
                public string NewRr { get; set; }

                [NameInMap("NewValue")]
                [Validation(Required=false)]
                public string NewValue { get; set; }

                [NameInMap("OperateDateStr")]
                [Validation(Required=false)]
                public string OperateDateStr { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public string Priority { get; set; }

                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                [NameInMap("RecordId")]
                [Validation(Required=false)]
                public string RecordId { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("Rr")]
                [Validation(Required=false)]
                public string Rr { get; set; }

                [NameInMap("RrStatus")]
                [Validation(Required=false)]
                public string RrStatus { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public bool? Status { get; set; }

                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public string Ttl { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
