// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListNodesNoPagingRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// 
        /// You can call the [ListClusters](~~87116~~) operation to query the cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The name of the node. You can perform a fuzzy search. MySQL regular expressions are supported.
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// The type of the node. Valid values:
        /// 
        /// *   Manager: management node
        /// *   Login: logon node
        /// *   Compute: compute node
        /// 
        /// Default value: Compute
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// The sorting method of the node list. Valid values:
        /// 
        /// *   Forward: sorts the nodes in chronological order.
        /// *   Backward: sorts the nodes in reverse chronological order.
        /// 
        /// Default value: Forward
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public string Sequence { get; set; }

    }

}
