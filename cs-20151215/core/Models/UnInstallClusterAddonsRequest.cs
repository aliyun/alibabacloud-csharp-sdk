// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UnInstallClusterAddonsRequest : TeaModel {
        /// <summary>
        /// <para>The list of components.</para>
        /// </summary>
        [NameInMap("addons")]
        [Validation(Required=false)]
        public List<UnInstallClusterAddonsRequestAddons> Addons { get; set; }
        public class UnInstallClusterAddonsRequestAddons : TeaModel {
            /// <summary>
            /// <para>Specifies whether to clean up associated cloud resources when uninstalling the component. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Clean up.</description></item>
            /// <item><description>false: Retain.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("cleanup_cloud_resources")]
            [Validation(Required=false)]
            public bool? CleanupCloudResources { get; set; }

            /// <summary>
            /// <para>The name of the component to uninstall. You can call the <a href="https://help.aliyun.com/document_detail/2667940.html">ListClusterAddonInstances</a> operation to query the components installed in a cluster.</para>
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
