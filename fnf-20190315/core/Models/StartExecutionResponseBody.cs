// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class StartExecutionResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        [NameInMap("StoppedTime")]
        [Validation(Required=false)]
        public string StoppedTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        [NameInMap("ExternalOutputUri")]
        [Validation(Required=false)]
        public string ExternalOutputUri { get; set; }

        [NameInMap("StartedTime")]
        [Validation(Required=false)]
        public string StartedTime { get; set; }

        [NameInMap("ExternalInputUri")]
        [Validation(Required=false)]
        public string ExternalInputUri { get; set; }

        [NameInMap("FlowDefinition")]
        [Validation(Required=false)]
        public string FlowDefinition { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
