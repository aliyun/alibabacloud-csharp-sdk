// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class QueryStreamSnapshotJobResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryStreamSnapshotJobResponseBodyData Data { get; set; }
        public class QueryStreamSnapshotJobResponseBodyData : TeaModel {
            [NameInMap("JobList")]
            [Validation(Required=false)]
            public List<QueryStreamSnapshotJobResponseBodyDataJobList> JobList { get; set; }
            public class QueryStreamSnapshotJobResponseBodyDataJobList : TeaModel {
                [NameInMap("SnapshotInterval")]
                [Validation(Required=false)]
                public int? SnapshotInterval { get; set; }

                [NameInMap("StreamType")]
                [Validation(Required=false)]
                public int? StreamType { get; set; }

            }

        }

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
