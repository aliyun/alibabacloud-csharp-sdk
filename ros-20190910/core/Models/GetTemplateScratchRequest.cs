// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetTemplateScratchRequest : TeaModel {
        /// <summary>
        /// The region ID of the scenario.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/131035.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The data display option. Valid values:
        /// 
        /// *   Sources: displays only the data of source nodes. This setting takes effect only when TemplateScratchType is set to ArchitectureDetection.
        /// *   Source: displays only the data of the source node. This setting takes effect only when TemplateScratchType is not set to ArchitectureDetection.
        /// *   Provisions: displays only the data of new nodes. This setting takes effect only when TemplateScratchType is not set to ArchitectureDetection.
        /// *   All: displays all data.
        /// 
        /// For more information about source nodes and new nodes, see [Overview](https://help.aliyun.com/document_detail/352074.html).
        /// 
        /// >  If you do not specify this parameter, the node data is not displayed.
        /// </summary>
        [NameInMap("ShowDataOption")]
        [Validation(Required=false)]
        public string ShowDataOption { get; set; }

        /// <summary>
        /// The ID of the scenario.
        /// </summary>
        [NameInMap("TemplateScratchId")]
        [Validation(Required=false)]
        public string TemplateScratchId { get; set; }

    }

}
