// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListTenantAddonsResponseBody : TeaModel {
        [NameInMap("Addons")]
        [Validation(Required=false)]
        public List<ListTenantAddonsResponseBodyAddons> Addons { get; set; }
        public class ListTenantAddonsResponseBodyAddons : TeaModel {
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public Dictionary<string, string> Attributes { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
