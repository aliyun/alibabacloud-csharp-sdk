// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeEventDisposeRequest : TeaModel {
        /// <summary>
        /// The page number. Pages start from page 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The UUID of the event.
        /// </summary>
        [NameInMap("IncidentUuid")]
        [Validation(Required=false)]
        public string IncidentUuid { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: 500.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The data management center of the threat analysis feature. Specify this parameter based on the region in which your assets reside. Valid values:
        /// 
        /// *   cn-hangzhou: Your assets reside in regions inside China.
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

    }

}
