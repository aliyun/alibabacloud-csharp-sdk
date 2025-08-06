// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetWorkflowResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WorkflowInfo")]
        [Validation(Required=false)]
        public GetWorkflowResponseBodyWorkflowInfo WorkflowInfo { get; set; }
        public class GetWorkflowResponseBodyWorkflowInfo : TeaModel {
            [NameInMap("ActionList")]
            [Validation(Required=false)]
            public string ActionList { get; set; }

            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("CallbackConfig")]
            [Validation(Required=false)]
            public string CallbackConfig { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

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
