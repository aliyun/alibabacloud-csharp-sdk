// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryCommunicationLogsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCommunicationLogsResponseBodyData Data { get; set; }
        public class QueryCommunicationLogsResponseBodyData : TeaModel {
            [NameInMap("TaskList")]
            [Validation(Required=false)]
            public List<QueryCommunicationLogsResponseBodyDataTaskList> TaskList { get; set; }
            public class QueryCommunicationLogsResponseBodyDataTaskList : TeaModel {
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Note")]
                [Validation(Required=false)]
                public string Note { get; set; }

                [NameInMap("PartnerCode")]
                [Validation(Required=false)]
                public string PartnerCode { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
