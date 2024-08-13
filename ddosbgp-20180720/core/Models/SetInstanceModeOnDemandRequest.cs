// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class SetInstanceModeOnDemandRequest : TeaModel {
        /// <summary>
        /// The IDs of on-demand instances.
        /// 
        /// > You can call the [DescribeOnDemandInstance](https://help.aliyun.com/document_detail/152120.html) operation to query the IDs of all on-demand instances.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceIdList")]
        [Validation(Required=false)]
        public List<string> InstanceIdList { get; set; }

        /// <summary>
        /// Specifies the scheduling mode for on-demand instances. Valid values:
        /// 
        /// *   **manual**: manual scheduling
        /// *   **netflow-auto**: automatic scheduling
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// The region ID of the on-demand instance.
        /// 
        /// > You can call the [DescribeRegions](https://help.aliyun.com/document_detail/118703.html) operation to query all regions that are supported by Anti-DDoS Origin.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
