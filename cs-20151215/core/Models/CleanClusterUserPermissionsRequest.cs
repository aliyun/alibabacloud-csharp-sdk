// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CleanClusterUserPermissionsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to force delete the specified KubeConfig. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default): Before deleting the KubeConfig, the system checks whether cluster access records exist within the last seven days. If access records exist or cannot be retrieved, the deletion is not allowed.</description></item>
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
