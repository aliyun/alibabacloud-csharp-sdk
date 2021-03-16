// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryFpFileDeleteJobListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("FpFileDeleteJobList")]
        [Validation(Required=false)]
        public QueryFpFileDeleteJobListResponseBodyFpFileDeleteJobList FpFileDeleteJobList { get; set; }
        public class QueryFpFileDeleteJobListResponseBodyFpFileDeleteJobList : TeaModel {
            [NameInMap("FpFileDeleteJob")]
            [Validation(Required=false)]
            public List<QueryFpFileDeleteJobListResponseBodyFpFileDeleteJobListFpFileDeleteJob> FpFileDeleteJob { get; set; }
            public class QueryFpFileDeleteJobListResponseBodyFpFileDeleteJobListFpFileDeleteJob : TeaModel {
                public string CreationTime { get; set; }
                public string Status { get; set; }
                public string FinishTime { get; set; }
                public string UserData { get; set; }
                public string Code { get; set; }
                public string Message { get; set; }
                public string PipelineId { get; set; }
                public string FpDBId { get; set; }
                public string Id { get; set; }
                public string FileIds { get; set; }
            }
        };

        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public QueryFpFileDeleteJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryFpFileDeleteJobListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

    }

}
