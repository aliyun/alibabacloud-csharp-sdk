// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetProjectBuildContextRequest : TeaModel {
        [NameInMap("isPassAssertCheck")]
        [Validation(Required=false)]
        public bool? IsPassAssertCheck { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
