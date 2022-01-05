// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDiagnosisDimensionsResponseBody : TeaModel {
        [NameInMap("ClientIps")]
        [Validation(Required=false)]
        public List<string> ClientIps { get; set; }

        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<string> Databases { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroups")]
        [Validation(Required=false)]
        public List<string> ResourceGroups { get; set; }

        [NameInMap("UserNames")]
        [Validation(Required=false)]
        public List<string> UserNames { get; set; }

    }

}
