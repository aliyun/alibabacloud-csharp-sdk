// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribeMaterialPackageInfoRequest : TeaModel {
        [NameInMap("MaterialPackageId")]
        [Validation(Required=false)]
        public string MaterialPackageId { get; set; }

        [NameInMap("MaterialPackageType")]
        [Validation(Required=false)]
        public string MaterialPackageType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
