// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AllocateEipAddressRequest : TeaModel {
        [NameInMap("Version")]
        [Validation(Required=true)]
        public string Version { get; set; }

        [NameInMap("EnsRegionId")]
        [Validation(Required=true)]
        public string EnsRegionId { get; set; }

        [NameInMap("Count")]
        [Validation(Required=true)]
        public int? Count { get; set; }

        [NameInMap("MinCount")]
        [Validation(Required=false)]
        public int? MinCount { get; set; }

    }

}
