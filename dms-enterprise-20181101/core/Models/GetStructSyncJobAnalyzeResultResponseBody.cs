// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetStructSyncJobAnalyzeResultResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StructSyncJobAnalyzeResult")]
        [Validation(Required=false)]
        public GetStructSyncJobAnalyzeResultResponseBodyStructSyncJobAnalyzeResult StructSyncJobAnalyzeResult { get; set; }
        public class GetStructSyncJobAnalyzeResultResponseBodyStructSyncJobAnalyzeResult : TeaModel {
            [NameInMap("ResultList")]
            [Validation(Required=false)]
            public List<GetStructSyncJobAnalyzeResultResponseBodyStructSyncJobAnalyzeResultResultList> ResultList { get; set; }
            public class GetStructSyncJobAnalyzeResultResponseBodyStructSyncJobAnalyzeResultResultList : TeaModel {
                [NameInMap("Script")]
                [Validation(Required=false)]
                public string Script { get; set; }

                [NameInMap("SourceTableName")]
                [Validation(Required=false)]
                public string SourceTableName { get; set; }

                [NameInMap("TargetTableName")]
                [Validation(Required=false)]
                public string TargetTableName { get; set; }

            }

            [NameInMap("SummaryList")]
            [Validation(Required=false)]
            public List<GetStructSyncJobAnalyzeResultResponseBodyStructSyncJobAnalyzeResultSummaryList> SummaryList { get; set; }
            public class GetStructSyncJobAnalyzeResultResponseBodyStructSyncJobAnalyzeResultSummaryList : TeaModel {
                [NameInMap("CompareType")]
                [Validation(Required=false)]
                public string CompareType { get; set; }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
