// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class CreateEnvironmentRequest : TeaModel {
        [NameInMap("annotations")]
        [Validation(Required=false)]
        public string Annotations { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("expiredAt")]
        [Validation(Required=false)]
        public string ExpiredAt { get; set; }

        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("platform")]
        [Validation(Required=false)]
        public CreateEnvironmentRequestPlatform Platform { get; set; }
        public class CreateEnvironmentRequestPlatform : TeaModel {
            [NameInMap("architecture")]
            [Validation(Required=false)]
            public string Architecture { get; set; }

            [NameInMap("os")]
            [Validation(Required=false)]
            public string Os { get; set; }

        }

        [NameInMap("platformList")]
        [Validation(Required=false)]
        public List<Platform> PlatformList { get; set; }

        [NameInMap("productVersionUID")]
        [Validation(Required=false)]
        public string ProductVersionUID { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("vendorConfig")]
        [Validation(Required=false)]
        public string VendorConfig { get; set; }

        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
