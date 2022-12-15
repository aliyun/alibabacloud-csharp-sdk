// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_oxs_cross20200701.Models
{
    public class CreateSDKInstanceRequest : TeaModel {
        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        [NameInMap("Pk")]
        [Validation(Required=false)]
        public string Pk { get; set; }

        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("Recipe")]
        [Validation(Required=false)]
        public string Recipe { get; set; }

        [NameInMap("ValidFrom")]
        [Validation(Required=false)]
        public long? ValidFrom { get; set; }

        [NameInMap("ValidTo")]
        [Validation(Required=false)]
        public long? ValidTo { get; set; }

    }

}
