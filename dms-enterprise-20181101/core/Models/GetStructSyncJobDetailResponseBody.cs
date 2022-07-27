// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetStructSyncJobDetailResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StructSyncJobDetail")]
        [Validation(Required=false)]
        public GetStructSyncJobDetailResponseBodyStructSyncJobDetail StructSyncJobDetail { get; set; }
        public class GetStructSyncJobDetailResponseBodyStructSyncJobDetail : TeaModel {
            [NameInMap("DBTaskGroupId")]
            [Validation(Required=false)]
            public long? DBTaskGroupId { get; set; }
            [NameInMap("ExecuteCount")]
            [Validation(Required=false)]
            public long? ExecuteCount { get; set; }
            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("SecurityRule")]
            [Validation(Required=false)]
            public string SecurityRule { get; set; }
            [NameInMap("SqlCount")]
            [Validation(Required=false)]
            public long? SqlCount { get; set; }
            [NameInMap("TableAnalyzed")]
            [Validation(Required=false)]
            public long? TableAnalyzed { get; set; }
            [NameInMap("TableCount")]
            [Validation(Required=false)]
            public long? TableCount { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
