// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedTagsRequest : TeaModel {
        /// <summary>
        /// The type of the asset to query. If you do not specify this parameter, the tags of all asset types are queried. Valid values:
        /// 
        /// *   **ecs**: server
        /// *   **cloud_product**: Alibaba Cloud service
        /// </summary>
        [NameInMap("MachineTypes")]
        [Validation(Required=false)]
        public string MachineTypes { get; set; }

    }

}
