// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryTSExecuteInstanceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<QueryTSExecuteInstanceResponseBodyList> List { get; set; }
        public class QueryTSExecuteInstanceResponseBodyList : TeaModel {
            [NameInMap("Consume")]
            [Validation(Required=false)]
            public long? Consume { get; set; }

            [NameInMap("Context")]
            [Validation(Required=false)]
            public string Context { get; set; }

            [NameInMap("ExecuteId")]
            [Validation(Required=false)]
            public string ExecuteId { get; set; }

            [NameInMap("GmtBegin")]
            [Validation(Required=false)]
            public string GmtBegin { get; set; }

            [NameInMap("GmtEnd")]
            [Validation(Required=false)]
            public string GmtEnd { get; set; }

            [NameInMap("Handler")]
            [Validation(Required=false)]
            public string Handler { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("JobItemId")]
            [Validation(Required=false)]
            public long? JobItemId { get; set; }

            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("Sharding")]
            [Validation(Required=false)]
            public long? Sharding { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TargerServer")]
            [Validation(Required=false)]
            public string TargerServer { get; set; }

            [NameInMap("TriggerServer")]
            [Validation(Required=false)]
            public string TriggerServer { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
