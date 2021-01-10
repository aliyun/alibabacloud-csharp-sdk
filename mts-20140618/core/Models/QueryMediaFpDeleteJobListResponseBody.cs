// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMediaFpDeleteJobListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public QueryMediaFpDeleteJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryMediaFpDeleteJobListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

        [NameInMap("MediaFpDeleteJobList")]
        [Validation(Required=false)]
        public QueryMediaFpDeleteJobListResponseBodyMediaFpDeleteJobList MediaFpDeleteJobList { get; set; }
        public class QueryMediaFpDeleteJobListResponseBodyMediaFpDeleteJobList : TeaModel {
            [NameInMap("MediaFpDeleteJob")]
            [Validation(Required=false)]
            public List<QueryMediaFpDeleteJobListResponseBodyMediaFpDeleteJobListMediaFpDeleteJob> MediaFpDeleteJob { get; set; }
            public class QueryMediaFpDeleteJobListResponseBodyMediaFpDeleteJobListMediaFpDeleteJob : TeaModel {
                public string CreationTime { get; set; }
                public string FinishTime { get; set; }
                public string PrimaryKey { get; set; }
                public string State { get; set; }
                public string UserData { get; set; }
                public string Code { get; set; }
                public string Message { get; set; }
                public string PipelineId { get; set; }
                public string FpDBId { get; set; }
                public string Id { get; set; }
            }
        };

    }

}
