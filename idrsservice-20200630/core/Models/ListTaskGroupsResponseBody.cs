// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class ListTaskGroupsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// -
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTaskGroupsResponseBodyData Data { get; set; }
        public class ListTaskGroupsResponseBodyData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<ListTaskGroupsResponseBodyDataItems> Items { get; set; }
            public class ListTaskGroupsResponseBodyDataItems : TeaModel {
                [NameInMap("CompletedTasks")]
                [Validation(Required=false)]
                public int? CompletedTasks { get; set; }

                [NameInMap("CreatedAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// ID
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TaskIds")]
                [Validation(Required=false)]
                public List<string> TaskIds { get; set; }

                [NameInMap("TotalTasks")]
                [Validation(Required=false)]
                public int? TotalTasks { get; set; }

            }

            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public long? TotalElements { get; set; }

            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
