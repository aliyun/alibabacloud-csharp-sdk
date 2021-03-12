// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeUpgradeVersionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public DescribeUpgradeVersionResponseBodyVersion Version { get; set; }
        public class DescribeUpgradeVersionResponseBodyVersion : TeaModel {
            [NameInMap("KubernetesVersion")]
            [Validation(Required=false)]
            public string KubernetesVersion { get; set; }
            [NameInMap("IstioOperatorVersion")]
            [Validation(Required=false)]
            public string IstioOperatorVersion { get; set; }
            [NameInMap("IstioVersion")]
            [Validation(Required=false)]
            public string IstioVersion { get; set; }
        };

    }

}
