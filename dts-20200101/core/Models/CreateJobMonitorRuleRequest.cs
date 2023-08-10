// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class CreateJobMonitorRuleRequest : TeaModel {
        /// <summary>
        /// The threshold for triggering latency alerts.
        /// 
        /// *   If the **Type** parameter is set to **delay**, the threshold must be an integer. You can set the threshold based on your requirements. To prevent jitters caused by network and database overloads, we recommend that you set the threshold to more than 10 seconds. Unit: seconds.
        /// *   If the **Type** parameter is set to **full_timeout**, the threshold must be an integer. Unit: hours.
        /// 
        /// >  This parameter is required if the **Type** parameter is set to **delay** or **full_timeout** and the **State** parameter is set to **Y**.
        /// </summary>
        [NameInMap("DelayRuleTime")]
        [Validation(Required=false)]
        public long? DelayRuleTime { get; set; }

        /// <summary>
        /// The ID of the data migration, data synchronization, or change tracking task. You can call the [DescribeDtsJobs](~~209702~~) operation to query the task ID.
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// The alert threshold.
        /// </summary>
        [NameInMap("NoticeValue")]
        [Validation(Required=false)]
        public int? NoticeValue { get; set; }

        /// <summary>
        /// The statistical period of the incremental data verification task. Unit: minutes.
        /// 
        /// >  Valid values: 1, 3, 5, and 30.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The mobile numbers that receive alert notifications. Separate multiple mobile numbers with commas (,).
        /// 
        /// > 
        /// *   This parameter is available only for users of the China site (aliyun.com). Only mobile numbers in the Chinese mainland are supported. You can specify up to 10 mobile numbers.
        /// *   Users of the international site (alibabacloud.com) cannot receive alerts by using mobile phones, but can [configure alert rules for DTS tasks in the CloudMonitor console](~~175876~~).
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// The region ID of the DTS instance. For more information, see [List of supported regions](~~141033~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to enable the alert rule. Valid values:
        /// 
        /// *   **Y**: enables the alert rule.
        /// *   **N**: disables the alert rule.
        /// 
        /// Default value: **Y**.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// The number of statistical periods of the incremental data verification task.
        /// </summary>
        [NameInMap("Times")]
        [Validation(Required=false)]
        public int? Times { get; set; }

        /// <summary>
        /// The metric that is used to monitor the task. Valid values:
        /// 
        /// *   **delay**: the **Latency** metric.
        /// *   **error**: the **Status** metric.
        /// *   **full_timeout**: the **Full Timeout** metric.
        /// 
        /// Default value: **error**. You must manually set this value.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
