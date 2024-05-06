// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20170115.Models
{
    public class CheckVersionsOfComponentsResponseBody : TeaModel {
        [NameInMap("Components")]
        [Validation(Required=false)]
        public CheckVersionsOfComponentsResponseBodyComponents Components { get; set; }
        public class CheckVersionsOfComponentsResponseBodyComponents : TeaModel {
            [NameInMap("Components")]
            [Validation(Required=false)]
            public List<CheckVersionsOfComponentsResponseBodyComponentsComponents> Components { get; set; }
            public class CheckVersionsOfComponentsResponseBodyComponentsComponents : TeaModel {
                [NameInMap("Component")]
                [Validation(Required=false)]
                public string Component { get; set; }

                [NameInMap("IsLatestVersion")]
                [Validation(Required=false)]
                public string IsLatestVersion { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
