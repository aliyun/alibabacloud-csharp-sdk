// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class CheckComponentsVersionResponseBody : TeaModel {
        [NameInMap("Components")]
        [Validation(Required=false)]
        public CheckComponentsVersionResponseBodyComponents Components { get; set; }
        public class CheckComponentsVersionResponseBodyComponents : TeaModel {
            [NameInMap("Component")]
            [Validation(Required=false)]
            public List<CheckComponentsVersionResponseBodyComponentsComponent> Component { get; set; }
            public class CheckComponentsVersionResponseBodyComponentsComponent : TeaModel {
                public string IsLatestVersion { get; set; }
                public string Component { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
