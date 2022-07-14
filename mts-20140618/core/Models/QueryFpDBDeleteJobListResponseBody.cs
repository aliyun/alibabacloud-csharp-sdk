// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryFpDBDeleteJobListResponseBody : TeaModel {
        [NameInMap("FpDBDeleteJobList")]
        [Validation(Required=false)]
        public QueryFpDBDeleteJobListResponseBodyFpDBDeleteJobList FpDBDeleteJobList { get; set; }
        public class QueryFpDBDeleteJobListResponseBodyFpDBDeleteJobList : TeaModel {
            [NameInMap("FpDBDeleteJob")]
            [Validation(Required=false)]
            public List<QueryFpDBDeleteJobListResponseBodyFpDBDeleteJobListFpDBDeleteJob> FpDBDeleteJob { get; set; }
            public class QueryFpDBDeleteJobListResponseBodyFpDBDeleteJobListFpDBDeleteJob : TeaModel {
                public string Code { get; set; }
                public string CreationTime { get; set; }
                public string DelType { get; set; }
                public string FinishTime { get; set; }
                public string FpDBId { get; set; }
                public string Id { get; set; }
                public string Message { get; set; }
                public string PipelineId { get; set; }
                public string Status { get; set; }
                public string UserData { get; set; }
            }
        };

        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public QueryFpDBDeleteJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryFpDBDeleteJobListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
