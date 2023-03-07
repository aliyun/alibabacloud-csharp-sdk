// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetHybridClusterConfigResponseBody : TeaModel {
        /// <summary>
        /// The configurations returned.
        /// 
        /// *   If the parameter Node is null, you can obtain the configurations of the hybrid cloud cluster.
        /// *   If the parameter Node is a specified on-premises compute node, you can obtain the configurations of the on-premises compute node.
        /// 
        /// This parameter is returned in the ini format. You can use this parameter to configure on-premises cluster nodes.
        /// </summary>
        [NameInMap("ClusterConfig")]
        [Validation(Required=false)]
        public string ClusterConfig { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
