// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class CreateLayerVersionInput : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public InputCodeLocation Code { get; set; }

        [NameInMap("compatibleRuntime")]
        [Validation(Required=false)]
        public List<string> CompatibleRuntime { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("license")]
        [Validation(Required=false)]
        public string License { get; set; }

    }

}
