// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListContactFlowsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListContactFlowsResponseBodyData Data { get; set; }
        public class ListContactFlowsResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListContactFlowsResponseBodyDataList> List { get; set; }
            public class ListContactFlowsResponseBodyDataList : TeaModel {
                public string ContactFlowId { get; set; }
                public string CreatedTime { get; set; }
                public string Definition { get; set; }
                public string Description { get; set; }
                public string DraftId { get; set; }
                public string Editor { get; set; }
                public string InstanceId { get; set; }
                public string Name { get; set; }
                public List<string> NumberList { get; set; }
                public bool? Published { get; set; }
                public string Type { get; set; }
                public string UpdatedTime { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
