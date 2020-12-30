// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class AddDomainRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("LiveFormat")]
        [Validation(Required=false)]
        public string LiveFormat { get; set; }

        [NameInMap("SliceDomain")]
        [Validation(Required=false)]
        public string SliceDomain { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("DemoUrls")]
        [Validation(Required=false)]
        public string DemoUrls { get; set; }

    }

}
