// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class CreateScanTaskRequest : TeaModel {
        /// <summary>
        /// The unique ID of the data asset, such as an instance, a database, and a bucket. You can call the [DescribeDataLimits](~~DescribeDataLimits~~) operation to query the unique ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DataLimitId")]
        [Validation(Required=false)]
        public long? DataLimitId { get; set; }

        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

        /// <summary>
        /// The interval between two consecutive custom scan tasks. Unit: days. Valid values: 1 to 2147483648.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IntervalDay")]
        [Validation(Required=false)]
        public int? IntervalDay { get; set; }

        /// <summary>
        /// The language of the content within the request and response.
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The data to be scanned in the Object Storage Service (OSS) bucket. Prefix match, suffix match, and regular expression match are supported.
        /// </summary>
        [NameInMap("OssScanPath")]
        [Validation(Required=false)]
        public string OssScanPath { get; set; }

        /// <summary>
        /// The type of the service to which the data assets to be scanned belong. Valid values include **1**, **2**, **3**, **4**, and **5**. The value 1 indicates MaxCompute. The value 2 indicates OSS. The value 3 indicates AnalyticDB for MySQL. The value 4 indicates Tablestore. The value 5 indicates ApsaraDB RDS.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public long? ResourceType { get; set; }

        /// <summary>
        /// The time when the scan task is executed next time. Unit: hours.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RunHour")]
        [Validation(Required=false)]
        public int? RunHour { get; set; }

        /// <summary>
        /// The time when the scan task is executed next time. Unit: minutes.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RunMinute")]
        [Validation(Required=false)]
        public int? RunMinute { get; set; }

        /// <summary>
        /// The matching rule that specifies the scan scope of the custom scan task. This parameter takes effect only if you set the **ScanRangeContent** parameter. Valid values:
        /// 
        /// *   **0**: exact match
        /// *   **1**: prefix match
        /// *   **2**: suffix match
        /// *   **3**: regular expression match
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public int? ScanRange { get; set; }

        /// <summary>
        /// The data to be scanned in a structured data asset. Prefix match, suffix match, and regular expression match are supported.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScanRangeContent")]
        [Validation(Required=false)]
        public string ScanRangeContent { get; set; }

        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The name of the scan task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// The account that is used to create the scan task.
        /// </summary>
        [NameInMap("TaskUserName")]
        [Validation(Required=false)]
        public string TaskUserName { get; set; }

    }

}
