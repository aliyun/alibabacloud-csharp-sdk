// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetRuleResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The error message returned if the call fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The rule information returned if the call is successful. For more information, see RuleInfo.
        /// </summary>
        [NameInMap("RuleInfo")]
        [Validation(Required=false)]
        public GetRuleResponseBodyRuleInfo RuleInfo { get; set; }
        public class GetRuleResponseBodyRuleInfo : TeaModel {
            /// <summary>
            /// The ID of the user who created the rule.
            /// </summary>
            [NameInMap("CreateUserId")]
            [Validation(Required=false)]
            public long? CreateUserId { get; set; }

            /// <summary>
            /// The time when the rule was created. The time is displayed in UTC-6.
            /// </summary>
            [NameInMap("Created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// The data type of the rule. Valid values: **JSON** and **BINARY** .
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// The ID of the rule.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The time when the rule was last modified. The time is displayed in UTC-6.
            /// </summary>
            [NameInMap("Modified")]
            [Validation(Required=false)]
            public string Modified { get; set; }

            /// <summary>
            /// The name of the rule.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ProductKey of the product to which the rule applies.
            /// </summary>
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

            /// <summary>
            /// The description of this rule.
            /// </summary>
            [NameInMap("RuleDesc")]
            [Validation(Required=false)]
            public string RuleDesc { get; set; }

            /// <summary>
            /// The values of **Select** in the SQL statements of the rule.
            /// </summary>
            [NameInMap("Select")]
            [Validation(Required=false)]
            public string Select { get; set; }

            /// <summary>
            /// The topic to which the rule applies. The topic does not include the ProductKey level. Format: `${deviceName}/topicShortName`. ${deviceName} indicates the name of the device, and topicShortName indicates the custom name of the topic.
            /// 
            /// >  For information about how to use the `+` or `#` wildcard in a topic, see [Topic wildcards](~~73731~~).
            /// </summary>
            [NameInMap("ShortTopic")]
            [Validation(Required=false)]
            public string ShortTopic { get; set; }

            /// <summary>
            /// The status of the rule. Valid values:
            /// 
            /// *   **RUNNING**: Running
            /// *   **STOP**: Stopped
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The complete topic to which the rule applies. Format: `${productKey}/${deviceName}/topicShortName`.
            /// 
            /// >  For information about how to use the `+` or `#` wildcard in a topic, see [Topic wildcards](~~73731~~).
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// The type of the topic. This parameter is returned if you set the SQL statement for the rule. Valid values:
            /// 
            /// *   **0**: a basic communication topic or TSL communication topic.
            /// *   **1**: a custom topic.
            /// *   **2**: a device status topic.
            /// 
            /// If no SQL statement is set for the rule, the value **-1** is returned.
            /// </summary>
            [NameInMap("TopicType")]
            [Validation(Required=false)]
            public int? TopicType { get; set; }

            /// <summary>
            /// The time when the rule was created. The time is displayed in UTC.
            /// </summary>
            [NameInMap("UtcCreated")]
            [Validation(Required=false)]
            public string UtcCreated { get; set; }

            /// <summary>
            /// The time when the rule was last modified. The time is displayed in UTC.
            /// </summary>
            [NameInMap("UtcModified")]
            [Validation(Required=false)]
            public string UtcModified { get; set; }

            /// <summary>
            /// The **Where** query condition in the SQL statements of the rule.
            /// </summary>
            [NameInMap("Where")]
            [Validation(Required=false)]
            public string Where { get; set; }

        }

        /// <summary>
        /// Indicates whether the call was successful.
        /// 
        /// *   **true**: The call was successful.
        /// *   **false**: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
