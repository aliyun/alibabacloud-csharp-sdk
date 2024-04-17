// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListClusterAddonInstancesResponseBody : TeaModel {
        /// <summary>
        /// A list of components that are installed in the cluster.
        /// </summary>
        [NameInMap("addons")]
        [Validation(Required=false)]
        public List<ListClusterAddonInstancesResponseBodyAddons> Addons { get; set; }
        public class ListClusterAddonInstancesResponseBodyAddons : TeaModel {
            /// <summary>
            /// The component name.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The status of the component. Valid values:
            /// 
            /// *   active: The component is installed.
            /// *   updating: The component is being modified.
            /// *   upgrading: The component is being updated.
            /// *   deleting: The component is being uninstalled.
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The version of the component.
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
