// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class ListTaskGroupsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTaskGroupsResponseBodyData Data { get; set; }
        public class ListTaskGroupsResponseBodyData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<ListTaskGroupsResponseBodyDataItems> Items { get; set; }
            public class ListTaskGroupsResponseBodyDataItems : TeaModel {
                public string Status { get; set; }
                public int? CompletedTasks { get; set; }
                public int? TotalTasks { get; set; }
                public string CreatedAt { get; set; }
                public string Name { get; set; }
                public List<string> TaskIds { get; set; }
                public string Id { get; set; }
                public string RuleId { get; set; }
                public string RuleName { get; set; }
            }
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }
            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public long? TotalElements { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
