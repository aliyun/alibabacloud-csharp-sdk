// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDiagnosisSQLInfoRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// 
        /// >  You can call the [DescribeDBClusters](~~129857~~) operation to query the cluster IDs of all AnalyticDB for MySQL Data Warehouse Edition clusters within a specific region.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The language of file titles and error messages. Valid values:
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
        /// The ID of the query.
        /// 
        /// >  You can call the [DescribeDiagnosisRecords](~~308207~~) operation to query the SQL summary information of a specified AnalyticDB for MySQL cluster, including the query ID.
        /// </summary>
        [NameInMap("ProcessId")]
        [Validation(Required=false)]
        public string ProcessId { get; set; }

        /// <summary>
        /// The IP address and port number of the AnalyticDB for MySQL frontend node on which the SQL statement is executed.
        /// 
        /// >  You can call the [DescribeDiagnosisRecords](~~308207~~) operation to query the SQL summary information of a specified AnalyticDB for MySQL cluster, including the IP address and port number of the frontend node.
        /// </summary>
        [NameInMap("ProcessRcHost")]
        [Validation(Required=false)]
        public string ProcessRcHost { get; set; }

        /// <summary>
        /// The execution start time of the SQL statement. Specify the time in the UNIX timestamp format. Unit: milliseconds.
        /// 
        /// >  You can call the [DescribeDiagnosisRecords](~~308207~~) operation to query the SQL summary information of a specified AnalyticDB for MySQL cluster, including the execution start time of the SQL statement.
        /// </summary>
        [NameInMap("ProcessStartTime")]
        [Validation(Required=false)]
        public long? ProcessStartTime { get; set; }

        /// <summary>
        /// The state of the SQL statement. Valid values:
        /// 
        /// *   **running**
        /// 
        /// *   **finished**
        /// 
        /// *   **failed**
        /// 
        /// > You can call the [DescribeDiagnosisRecords](~~308207~~) operation to query the SQL summary information of a specified AnalyticDB for MySQL cluster, including the state of the SQL statement.
        /// </summary>
        [NameInMap("ProcessState")]
        [Validation(Required=false)]
        public string ProcessState { get; set; }

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
