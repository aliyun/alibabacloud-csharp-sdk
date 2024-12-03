// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ParentResourceInfo : TeaModel {
        [NameInMap("apiInfo")]
        [Validation(Required=false)]
        public HttpApiApiInfo ApiInfo { get; set; }

        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
