// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20180528.Models
{
    public class DeactivateMediaWorkflowResponseBody : TeaModel {
        [NameInMap("MediaWorkflow")]
        [Validation(Required=false)]
        public DeactivateMediaWorkflowResponseBodyMediaWorkflow MediaWorkflow { get; set; }
        public class DeactivateMediaWorkflowResponseBodyMediaWorkflow : TeaModel {
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

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
