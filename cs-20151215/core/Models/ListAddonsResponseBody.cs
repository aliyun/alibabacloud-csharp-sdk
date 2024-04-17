// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListAddonsResponseBody : TeaModel {
        /// <summary>
        /// The list of available components.
        /// </summary>
        [NameInMap("addons")]
        [Validation(Required=false)]
        public List<ListAddonsResponseBodyAddons> Addons { get; set; }
        public class ListAddonsResponseBodyAddons : TeaModel {
            /// <summary>
            /// Architectures supported by the component. Valid values:
            /// 
            /// *   amd64
            /// *   arm64
            /// </summary>
            [NameInMap("architecture")]
            [Validation(Required=false)]
            public List<string> Architecture { get; set; }

            /// <summary>
            /// The category of the component.
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The schema of the custom parameters of the component.
            /// </summary>
            [NameInMap("config_schema")]
            [Validation(Required=false)]
            public string ConfigSchema { get; set; }

            /// <summary>
            /// Indicates whether the component is automatically installed by default.
            /// </summary>
            [NameInMap("install_by_default")]
            [Validation(Required=false)]
            public bool? InstallByDefault { get; set; }

            /// <summary>
            /// Indicates whether the component is fully managed.
            /// </summary>
            [NameInMap("managed")]
            [Validation(Required=false)]
            public bool? Managed { get; set; }

            /// <summary>
            /// The component name.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Operations supported by the component. Valid values:
            /// 
            /// *   Install
            /// *   Upgrade
            /// *   Modify
            /// *   Uninstall
            /// </summary>
            [NameInMap("supported_actions")]
            [Validation(Required=false)]
            public List<string> SupportedActions { get; set; }

            /// <summary>
            /// The version number.
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
