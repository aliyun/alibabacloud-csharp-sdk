// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class OSSTriggerConfig : TeaModel {
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<string> Events { get; set; }

        [NameInMap("filter")]
        [Validation(Required=false)]
        public Filter Filter { get; set; }

    }

}
