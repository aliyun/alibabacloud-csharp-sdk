// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateEipInstanceRequest : TeaModel {
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
