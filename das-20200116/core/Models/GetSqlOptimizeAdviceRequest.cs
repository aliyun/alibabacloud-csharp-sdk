// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetSqlOptimizeAdviceRequest : TeaModel {
        /// <summary>
        /// The reserved parameter.
        /// </summary>
        [NameInMap("ConsoleContext")]
        [Validation(Required=false)]
        public string ConsoleContext { get; set; }

        /// <summary>
        /// The end date of the time range to query. Specify the date in the *yyyyMMdd* format. The time must be in UTC.
        /// 
        /// *   The default value of this parameter is one day before the current day.
        /// *   The value must be earlier than the current day. The interval between the start date and the end date cannot exceed 30 days.
        /// </summary>
        [NameInMap("EndDt")]
        [Validation(Required=false)]
        public string EndDt { get; set; }

        /// <summary>
        /// The database engine. Valid values:
        /// 
        /// *   **MySQL**: ApsaraDB RDS for MySQL.
        /// *   **PolarDBMySQL**: PolarDB for MySQL.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// >  You must specify the instance ID only if your database instance is an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// The region in which the instance resides. Valid values:
        /// 
        /// *   **cn-china**: Chinese mainland.
        /// *   **cn-hongkong**: China (Hong Kong).
        /// *   **ap-southeast-1**: Singapore.
        /// 
        /// This parameter takes effect only if **InstanceIds** is left empty. If you leave **InstanceIds** empty, the system obtains data from the region specified by **Region**. By default, Region is set to **cn-china**. If you specify **InstanceIds**, **Region** does not take effect, and the system obtains data from the region in which the first specified instance resides.****
        /// 
        /// >  If your instances reside in the regions inside the Chinese mainland, set this parameter to **cn-china**.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The start date of the time range to query. Specify the date in the *yyyyMMdd* format. The time must be in UTC.
        /// 
        /// *   The default value of this parameter is one day before the current day.
        /// *   The value must be earlier than the current day.
        /// </summary>
        [NameInMap("StartDt")]
        [Validation(Required=false)]
        public string StartDt { get; set; }

    }

}
