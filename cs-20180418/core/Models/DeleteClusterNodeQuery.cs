// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20180418.Models
{
    public class DeleteClusterNodeQuery : TeaModel {
        [NameInMap("force")]
        [Validation(Required=false)]
        public string Force { get; set; }

        [NameInMap("releaseInstance")]
        [Validation(Required=false)]
        public string ReleaseInstance { get; set; }

    }

}
