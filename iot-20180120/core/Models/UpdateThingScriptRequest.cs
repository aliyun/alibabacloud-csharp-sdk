// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class UpdateThingScriptRequest : TeaModel {
        [NameInMap("ScriptContent")]
        [Validation(Required=true)]
        public string ScriptContent { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=true)]
        public string ProductKey { get; set; }

        [NameInMap("ScriptType")]
        [Validation(Required=true)]
        public string ScriptType { get; set; }

    }

}
