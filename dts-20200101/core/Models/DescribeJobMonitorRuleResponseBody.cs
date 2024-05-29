// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeJobMonitorRuleResponseBody : TeaModel {
        /// <summary>
        /// The error code. This parameter will be removed in the future.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The ID of the data migration, data synchronization, or change tracking task.
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// The dynamic part in the error message. This parameter is used to replace the **%s** variable in the **ErrMessage** parameter.
        /// 
        /// >  If the specified **DtsJobId** parameter is invalid, **The Value of Input Parameter %s is not valid** is returned for **ErrMessage** and **DtsJobId** is returned for **DynamicMessage**.
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// The error code returned if the call failed.
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// The error message returned if the call failed.
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The monitoring rules of the DTS task.
        /// </summary>
        [NameInMap("MonitorRules")]
        [Validation(Required=false)]
        public List<DescribeJobMonitorRuleResponseBodyMonitorRules> MonitorRules { get; set; }
        public class DescribeJobMonitorRuleResponseBodyMonitorRules : TeaModel {
            /// <summary>
            /// The threshold that triggers the alert.
            /// 
            /// *   If the request parameter **Type** of the [CreateJobMonitorRule](https://help.aliyun.com/document_detail/212332.html) operation is set to **delay**, the unit of DelayRuleTime is seconds.
            /// *   If the request parameter **Type** of the [CreateJobMonitorRule](https://help.aliyun.com/document_detail/212332.html) operation is set to **full_timeout**, the unit of DelayRuleTime is hours.
            /// </summary>
            [NameInMap("DelayRuleTime")]
            [Validation(Required=false)]
            public long? DelayRuleTime { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            [NameInMap("NoticeValue")]
            [Validation(Required=false)]
            public int? NoticeValue { get; set; }

            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// The mobile phone numbers that receive alert notifications. Multiple mobile numbers are separated by commas (,).
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// Indicates whether the monitoring rule is enabled. Valid values:
            /// 
            /// *   **Y**: The monitoring rule is enabled.
            /// *   **N**: The monitoring rule is disabled.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("Times")]
            [Validation(Required=false)]
            public int? Times { get; set; }

            /// <summary>
            /// The type of the monitoring rule. Valid values:
            /// 
            /// *   **delay**: If the task latency reaches the threshold, an alert is triggered.
            /// *   **error**: If an exception occurs, an alert is triggered.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   **true**: The call was successful.
        /// *   **false**:The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The topics of all subtasks in the distributed change tracking task.
        /// </summary>
        [NameInMap("Topics")]
        [Validation(Required=false)]
        public List<string> Topics { get; set; }

    }

}
