// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20180528.Models
{
    public class SearchMediaWorkflowResponseBody : TeaModel {
        [NameInMap("MediaWorkflowList")]
        [Validation(Required=false)]
        public SearchMediaWorkflowResponseBodyMediaWorkflowList MediaWorkflowList { get; set; }
        public class SearchMediaWorkflowResponseBodyMediaWorkflowList : TeaModel {
            [NameInMap("MediaWorkflow")]
            [Validation(Required=false)]
            public List<SearchMediaWorkflowResponseBodyMediaWorkflowListMediaWorkflow> MediaWorkflow { get; set; }
            public class SearchMediaWorkflowResponseBodyMediaWorkflowListMediaWorkflow : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("MediaWorkflowId")]
                [Validation(Required=false)]
                public string MediaWorkflowId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Topology")]
                [Validation(Required=false)]
                public string Topology { get; set; }

                [NameInMap("TriggerMode")]
                [Validation(Required=false)]
                public string TriggerMode { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
