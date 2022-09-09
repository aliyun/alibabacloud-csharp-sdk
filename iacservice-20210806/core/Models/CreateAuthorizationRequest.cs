// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateAuthorizationRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("dueTime")]
        [Validation(Required=false)]
        public string DueTime { get; set; }

        [NameInMap("moduleId")]
        [Validation(Required=false)]
        public string ModuleId { get; set; }

        [NameInMap("moduleVersion")]
        [Validation(Required=false)]
        public string ModuleVersion { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
