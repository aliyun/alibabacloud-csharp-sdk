// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ExecLinkeBahamutAppcustompipelineRequest : TeaModel {
        [NameInMap("FromApp")]
        [Validation(Required=false)]
        public string FromApp { get; set; }

        [NameInMap("FromTenant")]
        [Validation(Required=false)]
        public string FromTenant { get; set; }

        [NameInMap("TargetApp")]
        [Validation(Required=false)]
        public string TargetApp { get; set; }

        [NameInMap("TargetTenant")]
        [Validation(Required=false)]
        public string TargetTenant { get; set; }

        [NameInMap("WithExclude")]
        [Validation(Required=false)]
        public string WithExclude { get; set; }

    }

}
