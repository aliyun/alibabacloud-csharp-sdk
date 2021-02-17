// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class CreateMediaComplexTaskRequest : TeaModel {
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        [NameInMap("NotifyTopicName")]
        [Validation(Required=false)]
        public string NotifyTopicName { get; set; }

        [NameInMap("NotifyEndpoint")]
        [Validation(Required=false)]
        public string NotifyEndpoint { get; set; }

    }

}
