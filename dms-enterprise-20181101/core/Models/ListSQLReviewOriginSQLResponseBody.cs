// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSQLReviewOriginSQLResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("OriginSQLList")]
        [Validation(Required=false)]
        public List<ListSQLReviewOriginSQLResponseBodyOriginSQLList> OriginSQLList { get; set; }
        public class ListSQLReviewOriginSQLResponseBodyOriginSQLList : TeaModel {
            [NameInMap("CheckStatus")]
            [Validation(Required=false)]
            public string CheckStatus { get; set; }

            [NameInMap("CheckedTime")]
            [Validation(Required=false)]
            public string CheckedTime { get; set; }

            [NameInMap("FileId")]
            [Validation(Required=false)]
            public long? FileId { get; set; }

            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("ReviewSummary")]
            [Validation(Required=false)]
            public string ReviewSummary { get; set; }

            [NameInMap("SQLContent")]
            [Validation(Required=false)]
            public string SQLContent { get; set; }

            [NameInMap("SQLId")]
            [Validation(Required=false)]
            public long? SQLId { get; set; }

            [NameInMap("SQLName")]
            [Validation(Required=false)]
            public string SQLName { get; set; }

            [NameInMap("SQLReviewQueryKey")]
            [Validation(Required=false)]
            public string SQLReviewQueryKey { get; set; }

            [NameInMap("SqlHash")]
            [Validation(Required=false)]
            public string SqlHash { get; set; }

            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
