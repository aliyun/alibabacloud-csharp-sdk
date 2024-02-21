// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetAutoIncrementUsageStatisticRequest : TeaModel {
        /// <summary>
        /// The database name. If you specify a database, the operation queries the usage of auto-increment table IDs in the specified database. Otherwise, the operation queries the usage of auto-increment table IDs in all databases on the instance.
        /// 
        /// >  Specify the parameter value as a JSON array, such as \[\"db1\",\"db2\"]. Separate multiple database names with commas (,).
        /// </summary>
        [NameInMap("DbNames")]
        [Validation(Required=false)]
        public string DbNames { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The usage threshold of auto-increment IDs. Only usage that exceeds the threshold can be returned. Valid values are decimals that range from 0 to 1.
        /// </summary>
        [NameInMap("RatioFilter")]
        [Validation(Required=false)]
        public double? RatioFilter { get; set; }

        /// <summary>
        /// Specifies whether to query real-time data. Valid values:
        /// 
        /// *   **true**: queries data in real time except for data generated in the last 10 minutes.****
        /// *   **false**: queries data generated in the last 2 hours. If no such data exists, queries the latest data.
        /// </summary>
        [NameInMap("RealTime")]
        [Validation(Required=false)]
        public bool? RealTime { get; set; }

    }

}
