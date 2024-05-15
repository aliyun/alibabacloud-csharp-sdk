// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetQueryOptimizeDataTopRequest : TeaModel {
        /// <summary>
        /// The database engine. Valid values:
        /// 
        /// *   **MySQL**
        /// *   **PolarDBMySQL**
        /// *   **PostgreSQL**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The instance IDs. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// The region in which the instance resides. Valid values:
        /// 
        /// *   **cn-china**: Chinese mainland
        /// *   **cn-hongkong**: China (Hong Kong)
        /// *   **ap-southeast-1**: Singapore
        /// 
        /// This parameter takes effect only if **InstanceIds** is left empty. If you leave **InstanceIds** empty, the system obtains data from the region set by **Region**. By default, Region is set to **cn-china**. If you specify **InstanceIds**, **Region** does not take effect and the system obtains data from the region in which the first specified instance resides.****
        /// 
        /// >  Set this parameter to **cn-china** for all your instances that reside in the regions in the Chinese mainland.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The reserved parameter.
        /// </summary>
        [NameInMap("TagNames")]
        [Validation(Required=false)]
        public string TagNames { get; set; }

        /// <summary>
        /// The time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public string Time { get; set; }

        /// <summary>
        /// The type of instances that you want to query. Valid values:
        /// 
        /// *   **RED**: the best-performing instances
        /// *   **BLACK**: the worst-performing instances
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
