// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class CreateSchemeConfigRequest : TeaModel {
        [NameInMap("AndroidPackageName")]
        [Validation(Required=false)]
        public string AndroidPackageName { get; set; }

        [NameInMap("AndroidPackageSign")]
        [Validation(Required=false)]
        public string AndroidPackageSign { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("H5Origin")]
        [Validation(Required=false)]
        public string H5Origin { get; set; }

        [NameInMap("H5Url")]
        [Validation(Required=false)]
        public string H5Url { get; set; }

        [NameInMap("IosBundleId")]
        [Validation(Required=false)]
        public string IosBundleId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SchemeName")]
        [Validation(Required=false)]
        public string SchemeName { get; set; }

    }

}
