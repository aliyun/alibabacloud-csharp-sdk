// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SetClusterInterceptionConfigRequest : TeaModel {
        [NameInMap("ClusterIds")]
        [Validation(Required=false)]
        public string ClusterIds { get; set; }

        [NameInMap("SwitchOn")]
        [Validation(Required=false)]
        public int? SwitchOn { get; set; }

        [NameInMap("SwitchType")]
        [Validation(Required=false)]
        public int? SwitchType { get; set; }

    }

}
