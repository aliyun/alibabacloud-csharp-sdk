// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class CreateLayerVersionRequest : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public Code Code { get; set; }

        [NameInMap("compatibleRuntime")]
        [Validation(Required=false)]
        public List<string> CompatibleRuntime { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
