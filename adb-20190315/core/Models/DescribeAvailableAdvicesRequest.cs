// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeAvailableAdvicesRequest : TeaModel {
        /// <summary>
        /// The date when the suggestion is generated. Specify the date in the yyyyMMdd format. The date must be in UTC.
        /// </summary>
        [NameInMap("AdviceDate")]
        [Validation(Required=false)]
        public long? AdviceDate { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// 
        /// >  You can call the [DescribeDBClusters](~~129857~~) operation to query the IDs of Data Warehouse Edition (V3.0) clusters.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The display language of the suggestion. Default value: zh. Valid values:
        /// 
        /// *   **zh**: simplified Chinese
        /// *   **en**: English
        /// *   **ja**: Japanese
        /// *   **zh-tw**: traditional Chinese
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of the page to return. The value must be an integer that is greater than 0. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 30. Valid values:
        /// 
        /// *   **30**
        /// *   **50**
        /// *   **100**
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// 
        /// >  You can call the [DescribeRegions](~~143074~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
