// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class WebsiteConfiguration : TeaModel {
        [NameInMap("ErrorDocument")]
        [Validation(Required=false)]
        public ErrorDocument ErrorDocument { get; set; }

        [NameInMap("IndexDocument")]
        [Validation(Required=false)]
        public IndexDocument IndexDocument { get; set; }

        [NameInMap("RoutingRules")]
        [Validation(Required=false)]
        public WebsiteConfigurationRoutingRules RoutingRules { get; set; }
        public class WebsiteConfigurationRoutingRules : TeaModel {
            [NameInMap("RoutingRule")]
            [Validation(Required=false)]
            public List<RoutingRule> RoutingRule { get; set; }

        }

    }

}
