// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetSQLReviewCheckResultStatusResponseBody : TeaModel {
        [NameInMap("CheckResultStatus")]
        [Validation(Required=false)]
        public GetSQLReviewCheckResultStatusResponseBodyCheckResultStatus CheckResultStatus { get; set; }
        public class GetSQLReviewCheckResultStatusResponseBodyCheckResultStatus : TeaModel {
            [NameInMap("CheckStatusResult")]
            [Validation(Required=false)]
            public GetSQLReviewCheckResultStatusResponseBodyCheckResultStatusCheckStatusResult CheckStatusResult { get; set; }
            public class GetSQLReviewCheckResultStatusResponseBodyCheckResultStatusCheckStatusResult : TeaModel {
                [NameInMap("CheckNotPass")]
                [Validation(Required=false)]
                public long? CheckNotPass { get; set; }

                [NameInMap("CheckPass")]
                [Validation(Required=false)]
                public long? CheckPass { get; set; }

                [NameInMap("ForceNotPass")]
                [Validation(Required=false)]
                public long? ForceNotPass { get; set; }

                [NameInMap("ForcePass")]
                [Validation(Required=false)]
                public long? ForcePass { get; set; }

                [NameInMap("New")]
                [Validation(Required=false)]
                public long? New { get; set; }

                [NameInMap("Unknown")]
                [Validation(Required=false)]
                public long? Unknown { get; set; }

            }

            [NameInMap("CheckedCount")]
            [Validation(Required=false)]
            public long? CheckedCount { get; set; }

            [NameInMap("SQLReviewResult")]
            [Validation(Required=false)]
            public GetSQLReviewCheckResultStatusResponseBodyCheckResultStatusSQLReviewResult SQLReviewResult { get; set; }
            public class GetSQLReviewCheckResultStatusResponseBodyCheckResultStatusSQLReviewResult : TeaModel {
                [NameInMap("MustImprove")]
                [Validation(Required=false)]
                public long? MustImprove { get; set; }

                [NameInMap("PotentialIssue")]
                [Validation(Required=false)]
                public long? PotentialIssue { get; set; }

                [NameInMap("SuggestImprove")]
                [Validation(Required=false)]
                public long? SuggestImprove { get; set; }

                [NameInMap("TableIndexSuggest")]
                [Validation(Required=false)]
                public long? TableIndexSuggest { get; set; }

                [NameInMap("UseDmsDmlUnlock")]
                [Validation(Required=false)]
                public long? UseDmsDmlUnlock { get; set; }

                [NameInMap("UseDmsToolkit")]
                [Validation(Required=false)]
                public long? UseDmsToolkit { get; set; }

            }

            [NameInMap("TotalSQLCount")]
            [Validation(Required=false)]
            public long? TotalSQLCount { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
