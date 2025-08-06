// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListWorkflowResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WorkflowInfoList")]
        [Validation(Required=false)]
        public List<ListWorkflowResponseBodyWorkflowInfoList> WorkflowInfoList { get; set; }
        public class ListWorkflowResponseBodyWorkflowInfoList : TeaModel {
            [NameInMap("ActionList")]
            [Validation(Required=false)]
            public string ActionList { get; set; }

            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("WorkflowId")]
            [Validation(Required=false)]
            public string WorkflowId { get; set; }

        }

    }

}
