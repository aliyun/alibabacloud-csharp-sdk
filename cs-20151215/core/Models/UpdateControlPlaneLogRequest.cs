// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateControlPlaneLogRequest : TeaModel {
        /// <summary>
        /// The ID of the Alibaba Cloud account.
        /// </summary>
        [NameInMap("aliuid")]
        [Validation(Required=false)]
        public string Aliuid { get; set; }

        /// <summary>
        /// The control plane components for which you want to enable log collection.
        /// </summary>
        [NameInMap("components")]
        [Validation(Required=false)]
        public List<string> Components { get; set; }

        /// <summary>
        /// The name of the Simple Log Service Project that you want to use to store the logs of control plane components.
        /// 
        /// Default value: k8s-log-$Cluster ID.
        /// </summary>
        [NameInMap("log_project")]
        [Validation(Required=false)]
        public string LogProject { get; set; }

        /// <summary>
        /// The retention period of the log data stored in the Logstore. Valid values: 1 to 3000. Unit: days.
        /// 
        /// Default value: 30.
        /// </summary>
        [NameInMap("log_ttl")]
        [Validation(Required=false)]
        public string LogTtl { get; set; }

    }

}
