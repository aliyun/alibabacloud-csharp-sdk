// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetStructSyncJobAnalyzeResultResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("StructSyncJobAnalyzeResult")]
        [Validation(Required=false)]
        public GetStructSyncJobAnalyzeResultResponseBodyStructSyncJobAnalyzeResult StructSyncJobAnalyzeResult { get; set; }
        public class GetStructSyncJobAnalyzeResultResponseBodyStructSyncJobAnalyzeResult : TeaModel {
            [NameInMap("SummaryList")]
            [Validation(Required=false)]
            public List<GetStructSyncJobAnalyzeResultResponseBodyStructSyncJobAnalyzeResultSummaryList> SummaryList { get; set; }
            public class GetStructSyncJobAnalyzeResultResponseBodyStructSyncJobAnalyzeResultSummaryList : TeaModel {
                public string CompareType { get; set; }
                public long? Count { get; set; }
            }
            [NameInMap("ResultList")]
            [Validation(Required=false)]
            public List<GetStructSyncJobAnalyzeResultResponseBodyStructSyncJobAnalyzeResultResultList> ResultList { get; set; }
            public class GetStructSyncJobAnalyzeResultResponseBodyStructSyncJobAnalyzeResultResultList : TeaModel {
                public string SourceTableName { get; set; }
                public string TargetTableName { get; set; }
                public string Script { get; set; }
            }
        };

    }

}
