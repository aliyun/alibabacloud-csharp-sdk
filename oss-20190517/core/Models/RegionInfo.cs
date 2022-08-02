// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class RegionInfo : TeaModel {
        [NameInMap("AccelerateEndpoint")]
        [Validation(Required=false)]
        public string AccelerateEndpoint { get; set; }

        [NameInMap("InternalEndpoint")]
        [Validation(Required=false)]
        public string InternalEndpoint { get; set; }

        [NameInMap("InternetEndpoint")]
        [Validation(Required=false)]
        public string InternetEndpoint { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

    }

}
