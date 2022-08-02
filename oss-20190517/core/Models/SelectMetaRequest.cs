// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class SelectMetaRequest : TeaModel {
        [NameInMap("InputSerialization")]
        [Validation(Required=false)]
        public InputSerialization InputSerialization { get; set; }

        [NameInMap("OverwriteIfExists")]
        [Validation(Required=false)]
        public bool? OverwriteIfExists { get; set; }

    }

}
