// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeQuickSaleConfigRequest : TeaModel {
        /// <summary>
        /// The product code. Valid values:
        /// 
        /// *   rds: The instance is a subscription instance.
        /// *   bards: The instance is a pay-as-you-go instance.
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public string Commodity { get; set; }

        /// <summary>
        /// The database engine of the instance. Valid values:
        /// 
        /// *   **MySQL**
        /// *   **SQLServer**
        /// *   **PostgreSQL**
        /// *   **MariaDB**
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/26243.html) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
