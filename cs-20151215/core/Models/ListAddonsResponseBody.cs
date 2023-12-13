// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListAddonsResponseBody : TeaModel {
        [NameInMap("addons")]
        [Validation(Required=false)]
        public List<ListAddonsResponseBodyAddons> Addons { get; set; }
        public class ListAddonsResponseBodyAddons : TeaModel {
            [NameInMap("architecture")]
            [Validation(Required=false)]
            public List<string> Architecture { get; set; }

            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("config_schema")]
            [Validation(Required=false)]
            public string ConfigSchema { get; set; }

            [NameInMap("install_by_default")]
            [Validation(Required=false)]
            public bool? InstallByDefault { get; set; }

            [NameInMap("managed")]
            [Validation(Required=false)]
            public bool? Managed { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("supported_actions")]
            [Validation(Required=false)]
            public List<string> SupportedActions { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
