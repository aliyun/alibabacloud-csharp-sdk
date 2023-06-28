// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class Trigger : TeaModel {
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("httpTrigger")]
        [Validation(Required=false)]
        public HTTPTrigger HttpTrigger { get; set; }

        [NameInMap("invocationRole")]
        [Validation(Required=false)]
        public string InvocationRole { get; set; }

        [NameInMap("lastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        [NameInMap("sourceArn")]
        [Validation(Required=false)]
        public string SourceArn { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("targetArn")]
        [Validation(Required=false)]
        public string TargetArn { get; set; }

        [NameInMap("triggerConfig")]
        [Validation(Required=false)]
        public string TriggerConfig { get; set; }

        [NameInMap("triggerId")]
        [Validation(Required=false)]
        public string TriggerId { get; set; }

        [NameInMap("triggerName")]
        [Validation(Required=false)]
        public string TriggerName { get; set; }

        [NameInMap("triggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

    }

}
