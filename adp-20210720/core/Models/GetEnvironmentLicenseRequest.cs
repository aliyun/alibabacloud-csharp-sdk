// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class GetEnvironmentLicenseRequest : TeaModel {
        [NameInMap("options")]
        [Validation(Required=false)]
        public GetEnvironmentLicenseRequestOptions Options { get; set; }
        public class GetEnvironmentLicenseRequestOptions : TeaModel {
            [NameInMap("withSecretYAML")]
            [Validation(Required=false)]
            public bool? WithSecretYAML { get; set; }

        }

    }

}
