// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeAlertsCountRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. Unit: milliseconds.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The region in which the data management center of the threat analysis feature resides. Specify this parameter based on the regions in which your assets reside. Valid values:
        /// 
        /// *   cn-hangzhou: Your assets reside in regions in China.
        /// *   ap-southeast-1: Your assets reside in regions outside China.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Unit: milliseconds.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
