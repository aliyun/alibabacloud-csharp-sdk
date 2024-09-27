// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CleanClusterUserPermissionsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to forcefully delete the specified kubeconfig files. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default): checks the cluster access records within the previous seven days before deleting the kubeconfig files. The kubeconfig files are not deleted if cluster access records are found or fail to be retrieved.</description></item>
        /// <item><description>true: forcefully deletes the kubeconfig files without checking the cluster access records.</description></item>
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
