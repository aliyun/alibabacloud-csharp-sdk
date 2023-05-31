// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class FindContainerNetworkConnectShrinkRequest : TeaModel {
        /// <summary>
        /// The type of the information that you want to query. Valid values:
        /// 
        /// *   **EDGE**: connection information
        /// </summary>
        [NameInMap("CriteriaType")]
        [Validation(Required=false)]
        public string CriteriaType { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// The information about the destination node.
        /// </summary>
        [NameInMap("DstNode")]
        [Validation(Required=false)]
        public string DstNodeShrink { get; set; }

        /// <summary>
        /// The end time of the network connection.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.
        /// 
        /// > We recommend that you do not leave this parameter empty.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The information about the source node.
        /// </summary>
        [NameInMap("SrcNode")]
        [Validation(Required=false)]
        public string SrcNodeShrink { get; set; }

        /// <summary>
        /// The start time of the network connection.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
