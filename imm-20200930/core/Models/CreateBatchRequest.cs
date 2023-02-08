// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateBatchRequest : TeaModel {
        [NameInMap("Actions")]
        [Validation(Required=false)]
        public List<CreateBatchRequestActions> Actions { get; set; }
        public class CreateBatchRequestActions : TeaModel {
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
        public CreateBatchRequestNotification Notification { get; set; }
        public class CreateBatchRequestNotification : TeaModel {
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

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
