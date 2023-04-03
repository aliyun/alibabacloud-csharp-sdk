// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeBatchResultDetailResponseBody : TeaModel {
        /// <summary>
        /// Detailed information about the batch operation result.
        /// </summary>
        [NameInMap("BatchResultDetails")]
        [Validation(Required=false)]
        public DescribeBatchResultDetailResponseBodyBatchResultDetails BatchResultDetails { get; set; }
        public class DescribeBatchResultDetailResponseBodyBatchResultDetails : TeaModel {
            [NameInMap("BatchResultDetail")]
            [Validation(Required=false)]
            public List<DescribeBatchResultDetailResponseBodyBatchResultDetailsBatchResultDetail> BatchResultDetail { get; set; }
            public class DescribeBatchResultDetailResponseBodyBatchResultDetailsBatchResultDetail : TeaModel {
                /// <summary>
                /// The type of the batch operation.
                /// </summary>
                [NameInMap("BatchType")]
                [Validation(Required=false)]
                public string BatchType { get; set; }

                /// <summary>
                /// The domain name.
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// The line code.
                /// </summary>
                [NameInMap("Line")]
                [Validation(Required=false)]
                public string Line { get; set; }

                /// <summary>
                /// The new host record.
                /// </summary>
                [NameInMap("NewRr")]
                [Validation(Required=false)]
                public string NewRr { get; set; }

                /// <summary>
                /// The new record value.
                /// </summary>
                [NameInMap("NewValue")]
                [Validation(Required=false)]
                public string NewValue { get; set; }

                /// <summary>
                /// The time when the operation was performed.
                /// </summary>
                [NameInMap("OperateDateStr")]
                [Validation(Required=false)]
                public string OperateDateStr { get; set; }

                /// <summary>
                /// The priority of an MX-type DNS record.
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public string Priority { get; set; }

                /// <summary>
                /// The cause of the execution failure.
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// The ID of the DNS record.
                /// </summary>
                [NameInMap("RecordId")]
                [Validation(Required=false)]
                public string RecordId { get; set; }

                /// <summary>
                /// The description of the DNS record.
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// The host record.
                /// </summary>
                [NameInMap("Rr")]
                [Validation(Required=false)]
                public string Rr { get; set; }

                /// <summary>
                /// The status of the DNS record.
                /// </summary>
                [NameInMap("RrStatus")]
                [Validation(Required=false)]
                public string RrStatus { get; set; }

                /// <summary>
                /// The execution result. Valid values:**true**: The execution succeeded.**false**: The execution failed.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public bool? Status { get; set; }

                /// <summary>
                /// The TTL of the DNS record.
                /// </summary>
                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public string Ttl { get; set; }

                /// <summary>
                /// The type of the DNS record.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The value of the DNS record.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
