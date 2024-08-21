// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs_workbench20220220.Models
{
    public class ListInstanceRecordsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Root")]
        [Validation(Required=false)]
        public ListInstanceRecordsResponseBodyRoot Root { get; set; }
        public class ListInstanceRecordsResponseBodyRoot : TeaModel {
            [NameInMap("RecordList")]
            [Validation(Required=false)]
            public List<ListInstanceRecordsResponseBodyRootRecordList> RecordList { get; set; }
            public class ListInstanceRecordsResponseBodyRootRecordList : TeaModel {
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceRecordUrl")]
                [Validation(Required=false)]
                public string InstanceRecordUrl { get; set; }

                [NameInMap("RecordDurationMillis")]
                [Validation(Required=false)]
                public long? RecordDurationMillis { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TerminalSessionToken")]
                [Validation(Required=false)]
                public string TerminalSessionToken { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
