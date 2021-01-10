// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryTSTriggerInstanceNewestResponseBody : TeaModel {
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
        public string PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<QueryTSTriggerInstanceNewestResponseBodyList> List { get; set; }
        public class QueryTSTriggerInstanceNewestResponseBodyList : TeaModel {
            [NameInMap("ActivityInstanceId")]
            [Validation(Required=false)]
            public string ActivityInstanceId { get; set; }

            [NameInMap("Consume")]
            [Validation(Required=false)]
            public long? Consume { get; set; }

            [NameInMap("Context")]
            [Validation(Required=false)]
            public string Context { get; set; }

            [NameInMap("GmtEnd")]
            [Validation(Required=false)]
            public string GmtEnd { get; set; }

            [NameInMap("GmtExpectTrigger")]
            [Validation(Required=false)]
            public string GmtExpectTrigger { get; set; }

            [NameInMap("GmtModify")]
            [Validation(Required=false)]
            public string GmtModify { get; set; }

            [NameInMap("GmtTrigger")]
            [Validation(Required=false)]
            public string GmtTrigger { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("JobItemId")]
            [Validation(Required=false)]
            public long? JobItemId { get; set; }

            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            [NameInMap("JobZone")]
            [Validation(Required=false)]
            public string JobZone { get; set; }

            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("ShardingCount")]
            [Validation(Required=false)]
            public long? ShardingCount { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Handlers")]
            [Validation(Required=false)]
            public List<string> Handlers { get; set; }

            [NameInMap("RuntimeConfig")]
            [Validation(Required=false)]
            public QueryTSTriggerInstanceNewestResponseBodyListRuntimeConfig RuntimeConfig { get; set; }
            public class QueryTSTriggerInstanceNewestResponseBodyListRuntimeConfig : TeaModel {
                [NameInMap("MaxExecutingChunks")]
                [Validation(Required=false)]
                public string MaxExecutingChunks { get; set; }
                [NameInMap("MaxExecutingChunksPerClient")]
                [Validation(Required=false)]
                public long? MaxExecutingChunksPerClient { get; set; }
                [NameInMap("PermitsPerSecond")]
                [Validation(Required=false)]
                public long? PermitsPerSecond { get; set; }
                [NameInMap("TolerateProcessFailedCount")]
                [Validation(Required=false)]
                public long? TolerateProcessFailedCount { get; set; }
            };

        }

    }

}
