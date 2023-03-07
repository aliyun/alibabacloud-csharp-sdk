// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class UninstallSoftwareRequest : TeaModel {
        /// <summary>
        /// The name of the software that you want to uninstall.
        /// 
        /// You can call the [ListInstalledSoftware](~~188591~~) operation to query the software that is installed in the cluster.
        /// </summary>
        [NameInMap("Application")]
        [Validation(Required=false)]
        public string Application { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// 
        /// You can call the [ListClusters](~~87116~~) operation to query the cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

    }

}
