// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class GetFusionAuthTokenRequest : TeaModel {
        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        [NameInMap("DurationSeconds")]
        [Validation(Required=false)]
        public long? DurationSeconds { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PackageName")]
        [Validation(Required=false)]
        public string PackageName { get; set; }

        [NameInMap("PackageSign")]
        [Validation(Required=false)]
        public string PackageSign { get; set; }

        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SchemeCode")]
        [Validation(Required=false)]
        public string SchemeCode { get; set; }

    }

}
