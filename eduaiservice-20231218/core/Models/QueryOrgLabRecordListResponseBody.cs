// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eduaiservice20231218.Models
{
    public class QueryOrgLabRecordListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryOrgLabRecordListResponseBodyData> Data { get; set; }
        public class QueryOrgLabRecordListResponseBodyData : TeaModel {
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            [NameInMap("LabRecordId")]
            [Validation(Required=false)]
            public string LabRecordId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("SubmittedAt")]
            [Validation(Required=false)]
            public long? SubmittedAt { get; set; }

        }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public long? PageIndex { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
