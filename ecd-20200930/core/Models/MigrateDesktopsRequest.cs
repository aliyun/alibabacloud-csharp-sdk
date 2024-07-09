// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class MigrateDesktopsRequest : TeaModel {
        /// <summary>
        /// The IDs of the cloud computers. You can specify 1 to 100 IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/196646.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the destination office network.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetOfficeSiteId")]
        [Validation(Required=false)]
        public string TargetOfficeSiteId { get; set; }

    }

}
