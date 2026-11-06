// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CleanUserPermissionsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of cluster IDs. If you specify this list, only the KubeConfig credentials and RBAC permissions of the user in the specified clusters are cleared.</para>
        /// </summary>
        [NameInMap("ClusterIds")]
        [Validation(Required=false)]
        public string ClusterIdsShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to force delete the specified KubeConfig. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default): Before deleting the KubeConfig, the system checks whether there are cluster access records within the last seven days. If such records exist or cannot be found, the deletion is not allowed.</description></item>
        /// <item><description>true: Force deletes the KubeConfig without checking cluster access records.</description></item>
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
