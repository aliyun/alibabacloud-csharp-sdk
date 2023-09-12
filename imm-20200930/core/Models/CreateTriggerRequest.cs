// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateTriggerRequest : TeaModel {
        [NameInMap("Actions")]
        [Validation(Required=false)]
        public List<CreateTriggerRequestActions> Actions { get; set; }
        public class CreateTriggerRequestActions : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<string> Parameters { get; set; }

        }

        [NameInMap("Input")]
        [Validation(Required=false)]
        public Input Input { get; set; }

        [NameInMap("Notification")]
        [Validation(Required=false)]
        public CreateTriggerRequestNotification Notification { get; set; }
        public class CreateTriggerRequestNotification : TeaModel {
            [NameInMap("MNS")]
            [Validation(Required=false)]
            public MNS MNS { get; set; }

        }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("ServiceRole")]
        [Validation(Required=false)]
        public string ServiceRole { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

    }

}
