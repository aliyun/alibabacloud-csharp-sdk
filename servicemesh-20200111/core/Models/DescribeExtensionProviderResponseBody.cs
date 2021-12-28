// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeExtensionProviderResponseBody : TeaModel {
        [NameInMap("ExtensionProviders")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> ExtensionProviders { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
