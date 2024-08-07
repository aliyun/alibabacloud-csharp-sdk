// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiInfoByName : TeaModel {
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("versionEnabled")]
        [Validation(Required=false)]
        public bool? VersionEnabled { get; set; }

        [NameInMap("versionedHttpApis")]
        [Validation(Required=false)]
        public List<HttpApiApiInfo> VersionedHttpApis { get; set; }

    }

}
