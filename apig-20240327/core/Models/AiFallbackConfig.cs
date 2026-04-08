// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiFallbackConfig : TeaModel {
        [NameInMap("onlyRedirectUpstreamCode")]
        [Validation(Required=false)]
        public bool? OnlyRedirectUpstreamCode { get; set; }

        [NameInMap("serviceConfigs")]
        [Validation(Required=false)]
        public List<AiFallbackConfigServiceConfigs> ServiceConfigs { get; set; }
        public class AiFallbackConfigServiceConfigs : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("passThroughModelName")]
            [Validation(Required=false)]
            public bool? PassThroughModelName { get; set; }

            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            [NameInMap("targetModelName")]
            [Validation(Required=false)]
            public string TargetModelName { get; set; }

        }

    }

}
