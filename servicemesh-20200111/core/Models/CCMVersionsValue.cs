// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class CCMVersionsValue : TeaModel {
        [NameInMap("QueryState")]
        [Validation(Required=false)]
        public string QueryState { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        [NameInMap("SLBGracefulDrainSupport")]
        [Validation(Required=false)]
        public bool? SLBGracefulDrainSupport { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
