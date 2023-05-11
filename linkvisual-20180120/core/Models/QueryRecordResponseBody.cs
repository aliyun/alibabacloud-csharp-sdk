// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class QueryRecordResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryRecordResponseBodyData Data { get; set; }
        public class QueryRecordResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryRecordResponseBodyDataList> List { get; set; }
            public class QueryRecordResponseBodyDataList : TeaModel {
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public string BeginTime { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public int? FileSize { get; set; }

                [NameInMap("RecordType")]
                [Validation(Required=false)]
                public int? RecordType { get; set; }

                [NameInMap("SnapshotUrl")]
                [Validation(Required=false)]
                public string SnapshotUrl { get; set; }

                [NameInMap("StreamType")]
                [Validation(Required=false)]
                public int? StreamType { get; set; }

                [NameInMap("VideoFrameNumber")]
                [Validation(Required=false)]
                public int? VideoFrameNumber { get; set; }

            }

            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

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
