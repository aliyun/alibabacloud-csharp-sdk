// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CleanUserPermissionsRequest : TeaModel {
        /// <summary>
        /// <para>The cluster IDs.</para>
        /// <list type="bullet">
        /// <item><description>If cluster IDs are specified, only the kubeconfig files of the specified clusters and the relevant RBAC permissions are deleted and revoked.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ClusterIds")]
        [Validation(Required=false)]
        public List<string> ClusterIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully delete the specified kubeconfig files. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): checks the cluster access records within the previous seven days before deleting the kubeconfig files. The kubeconfig files are not deleted if cluster access records are found or fail to be retrieved.</description></item>
        /// <item><description><b>true</b>: forcefully deletes the kubeconfig files without checking cluster access records.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

    }

}
