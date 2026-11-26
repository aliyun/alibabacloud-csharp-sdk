// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class UpdateScriptHotWordRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("hotWord")]
        [Validation(Required=false)]
        public string HotWord { get; set; }

        [NameInMap("hotWordId")]
        [Validation(Required=false)]
        public string HotWordId { get; set; }

    }

}
