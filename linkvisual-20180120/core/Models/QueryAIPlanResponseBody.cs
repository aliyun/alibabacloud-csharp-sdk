// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class QueryAIPlanResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAIPlanResponseBodyData Data { get; set; }
        public class QueryAIPlanResponseBodyData : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public int? PageCount { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryAIPlanResponseBodyDataList> List { get; set; }
            public class QueryAIPlanResponseBodyDataList : TeaModel {
                public string PlanId { get; set; }
                public string AppId { get; set; }
                public string PlanTemplateId { get; set; }
                public int? TriggerEnum { get; set; }
                public int? IntervalTiming { get; set; }
                public long? PreTiming { get; set; }
                public string Description { get; set; }
            }
        };

    }

}
