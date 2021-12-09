// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class WebsiteConfiguration : TeaModel {
        /// <summary>
        /// description
        /// </summary>
        [NameInMap("ErrorDocument")]
        [Validation(Required=false)]
        public WebsiteConfigurationErrorDocument ErrorDocument { get; set; }
        public class WebsiteConfigurationErrorDocument : TeaModel {
            [NameInMap("HttpStatus")]
            [Validation(Required=false)]
            public string HttpStatus { get; set; }
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }
        };

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("IndexDocument")]
        [Validation(Required=false)]
        public WebsiteConfigurationIndexDocument IndexDocument { get; set; }
        public class WebsiteConfigurationIndexDocument : TeaModel {
            [NameInMap("Suffix")]
            [Validation(Required=false)]
            public string Suffix { get; set; }
            [NameInMap("SupportSubDir")]
            [Validation(Required=false)]
            public bool? SupportSubDir { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
        };

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("RoutingRules")]
        [Validation(Required=false)]
        public WebsiteConfigurationRoutingRules RoutingRules { get; set; }
        public class WebsiteConfigurationRoutingRules : TeaModel {
            [NameInMap("RoutingRule")]
            [Validation(Required=false)]
            public List<string> RoutingRules { get; set; }
        };

    }

}
