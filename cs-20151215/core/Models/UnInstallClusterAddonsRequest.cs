// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UnInstallClusterAddonsRequest : TeaModel {
        /// <summary>
        /// <para>The list of components that you want to uninstall. The list is an array.</para>
        /// </summary>
        [NameInMap("addons")]
        [Validation(Required=false)]
        public List<UnInstallClusterAddonsRequestAddons> Addons { get; set; }
        public class UnInstallClusterAddonsRequestAddons : TeaModel {
            /// <summary>
            /// <para>Specifies whether to clear cloud resources.</para>
            /// <list type="bullet">
            /// <item><description>true: clears the data and cloud resources.</description></item>
            /// <item><description>false: retains the data and cloud resources.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("cleanup_cloud_resources")]
            [Validation(Required=false)]
            public bool? CleanupCloudResources { get; set; }

            /// <summary>
            /// <para>The name of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack-node-problem-detector</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
