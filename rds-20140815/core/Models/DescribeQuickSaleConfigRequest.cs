// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeQuickSaleConfigRequest : TeaModel {
        /// <summary>
        /// Product code.
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public string Commodity { get; set; }

        /// <summary>
        /// The database engine that is run by the instance. Valid values:
        /// 
        /// * **MySQL**
        /// * **SQLServer**
        /// * **PostgreSQL**
        /// * **MariaDB**
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The ID of the region. You can call the [DescribeRegions](~~26243~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
