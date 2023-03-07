// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListNodesRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// 
        /// You can call the [ListClusters](~~87116~~) operation to query the cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The filter options of the node list.
        /// 
        /// Format: {"status":"node_status"}. Replace node_status with the node status. Valid values of node_status:
        /// 
        /// *   uninit: The node is being installed.
        /// *   exception: An exception has occurred on the node.
        /// *   running: The node is running.
        /// *   initing: The node is being initialized.
        /// *   releasing: The node is being released.
        /// *   untracking: The node is not added to the cluster.
        /// *   stopped: The node is stopped.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// The name of the node. You can perform a fuzzy search. MySQL regular expressions are supported.
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// The prefix of the hostname. You can query nodes that have a specified prefix.
        /// </summary>
        [NameInMap("HostNamePrefix")]
        [Validation(Required=false)]
        public string HostNamePrefix { get; set; }

        /// <summary>
        /// The suffix of the hostname. You can query nodes that have a specified suffix.
        /// </summary>
        [NameInMap("HostNameSuffix")]
        [Validation(Required=false)]
        public string HostNameSuffix { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 1 to 100.
        /// 
        /// Default value: 10
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The private IP address of the node.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// The type of the node. Valid values:
        /// 
        /// *   Manager: management node
        /// *   Login: logon node
        /// *   Compute: compute node
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
        /// 
        /// >  Sequence is used in combination with SortBy. If SortBy is set to AddedTime and Sequence is set to Forward, nodes are sorted by the time that they were added in chronological order.
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public string Sequence { get; set; }

        /// <summary>
        /// The sorting method of the node list. Valid values:
        /// 
        /// *   AddedTime: sorts the nodes by the time that they were added.
        /// *   HostName: sorts the nodes by their host names.
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

    }

}
