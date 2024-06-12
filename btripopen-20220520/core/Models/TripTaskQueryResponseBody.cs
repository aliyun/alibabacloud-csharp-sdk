// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TripTaskQueryResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// module。
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public TripTaskQueryResponseBodyModule Module { get; set; }
        public class TripTaskQueryResponseBodyModule : TeaModel {
            [NameInMap("needRefresh")]
            [Validation(Required=false)]
            public bool? NeedRefresh { get; set; }

            [NameInMap("record_tasks")]
            [Validation(Required=false)]
            public List<TripTaskQueryResponseBodyModuleRecordTasks> RecordTasks { get; set; }
            public class TripTaskQueryResponseBodyModuleRecordTasks : TeaModel {
                [NameInMap("actioner")]
                [Validation(Required=false)]
                public string Actioner { get; set; }

                [NameInMap("attributes")]
                [Validation(Required=false)]
                public string Attributes { get; set; }

                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("gmt_finished")]
                [Validation(Required=false)]
                public long? GmtFinished { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("node_id")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("out_result")]
                [Validation(Required=false)]
                public string OutResult { get; set; }

                [NameInMap("owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("running_tasks")]
            [Validation(Required=false)]
            public List<TripTaskQueryResponseBodyModuleRunningTasks> RunningTasks { get; set; }
            public class TripTaskQueryResponseBodyModuleRunningTasks : TeaModel {
                [NameInMap("actioner")]
                [Validation(Required=false)]
                public string Actioner { get; set; }

                [NameInMap("attributes")]
                [Validation(Required=false)]
                public string Attributes { get; set; }

                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("gmt_finished")]
                [Validation(Required=false)]
                public long? GmtFinished { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("node_id")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("out_result")]
                [Validation(Required=false)]
                public string OutResult { get; set; }

                [NameInMap("owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// traceId
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
