// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeEventsRequest : TeaModel {
        /// <summary>
        /// The page number of the page to return.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The ID of the account that handles the anomalous event.
        /// </summary>
        [NameInMap("DealUserId")]
        [Validation(Required=false)]
        public string DealUserId { get; set; }

        /// <summary>
        /// The end of the time range during which the anomalous events are detected. The value is a UNIX timestamp. Unit: milliseconds.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The unique ID of the anomalous event.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The name of the data asset.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh_cn**. Valid values:
        /// 
        /// *   **zh_cn**: Chinese
        /// *   **en_us**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The name of the service to which the table belongs. Valid values include **MaxCompute, OSS, ADS, OTS, and RDS**.
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The beginning of the time range during which the anomalous events are detected. The value is a UNIX timestamp. Unit: milliseconds.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The handling status of the anomalous event. Valid values:
        /// 
        /// *   0: unhandled
        /// *   1: confirmed
        /// *   2: marked as false positive
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The name of the anomalous event subtype.
        /// 
        /// > You can call the **DescribeEventTypes** operation to query the name of the anomalous event subtype.
        /// </summary>
        [NameInMap("SubTypeCode")]
        [Validation(Required=false)]
        public string SubTypeCode { get; set; }

        /// <summary>
        /// The name of the destination service in an anomalous data flow. Valid values include **MaxCompute, OSS, ADS, OTS, and RDS**
        /// </summary>
        [NameInMap("TargetProductCode")]
        [Validation(Required=false)]
        public string TargetProductCode { get; set; }

        /// <summary>
        /// The name of the anomalous event type. Valid values:
        /// 
        /// *   01: anomalous permission usage
        /// *   02: anomalous data flow
        /// *   03: anomalous data operation
        /// </summary>
        [NameInMap("TypeCode")]
        [Validation(Required=false)]
        public string TypeCode { get; set; }

        /// <summary>
        /// The ID of the account that triggered the anomalous event.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

        /// <summary>
        /// The username of the RAM user.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// The risk level of the alert that is triggered. Valid values:
        /// 
        /// *   **1**: low
        /// *   **2**: medium
        /// *   **3**: high
        /// </summary>
        [NameInMap("WarnLevel")]
        [Validation(Required=false)]
        public int? WarnLevel { get; set; }

    }

}
