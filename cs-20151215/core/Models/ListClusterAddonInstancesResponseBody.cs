// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListClusterAddonInstancesResponseBody : TeaModel {
        [NameInMap("addons")]
        [Validation(Required=false)]
        public List<ListClusterAddonInstancesResponseBodyAddons> Addons { get; set; }
        public class ListClusterAddonInstancesResponseBodyAddons : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
