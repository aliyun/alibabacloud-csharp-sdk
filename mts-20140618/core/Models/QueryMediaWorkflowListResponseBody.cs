// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMediaWorkflowListResponseBody : TeaModel {
        [NameInMap("NonExistMediaWorkflowIds")]
        [Validation(Required=false)]
        public QueryMediaWorkflowListResponseBodyNonExistMediaWorkflowIds NonExistMediaWorkflowIds { get; set; }
        public class QueryMediaWorkflowListResponseBodyNonExistMediaWorkflowIds : TeaModel {
            [NameInMap("MediaWorkflowId")]
            [Validation(Required=false)]
            public List<string> MediaWorkflowId { get; set; }
        };

        [NameInMap("MediaWorkflowList")]
        [Validation(Required=false)]
        public QueryMediaWorkflowListResponseBodyMediaWorkflowList MediaWorkflowList { get; set; }
        public class QueryMediaWorkflowListResponseBodyMediaWorkflowList : TeaModel {
            [NameInMap("MediaWorkflow")]
            [Validation(Required=false)]
            public List<QueryMediaWorkflowListResponseBodyMediaWorkflowListMediaWorkflow> MediaWorkflow { get; set; }
            public class QueryMediaWorkflowListResponseBodyMediaWorkflowListMediaWorkflow : TeaModel {
                public string CreationTime { get; set; }
                public string MediaWorkflowId { get; set; }
                public string State { get; set; }
                public string TriggerMode { get; set; }
                public string Name { get; set; }
                public string Topology { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
