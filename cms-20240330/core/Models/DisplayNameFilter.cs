// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DisplayNameFilter : TeaModel {
        [NameInMap("contains")]
        [Validation(Required=false)]
        public string Contains { get; set; }

        [NameInMap("notContains")]
        [Validation(Required=false)]
        public string NotContains { get; set; }

    }

}
