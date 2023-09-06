// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class AddQueueRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// 
        /// You can call the [ListClusters](~~87116~~) operation to query the cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("DeploymentSetId")]
        [Validation(Required=false)]
        public string DeploymentSetId { get; set; }

        [NameInMap("NetworkInterfaceTrafficMode")]
        [Validation(Required=false)]
        public string NetworkInterfaceTrafficMode { get; set; }

        /// <summary>
        /// The name of the queue. The name must be 1 to 63 characters in length and start with a letter. It can contain letters, digits, and underscores (\_).
        /// </summary>
        [NameInMap("QueueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

        [NameInMap("UseESS")]
        [Validation(Required=false)]
        public bool? UseESS { get; set; }

    }

}
