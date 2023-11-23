// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageEventOperationConditionResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeImageEventOperationConditionResponseBodyData Data { get; set; }
        public class DescribeImageEventOperationConditionResponseBodyData : TeaModel {
            /// <summary>
            /// The alert type.
            /// 
            /// *   Only **sensitiveFile** may be returned.
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// The operations.
            /// </summary>
            [NameInMap("Operations")]
            [Validation(Required=false)]
            public List<DescribeImageEventOperationConditionResponseBodyDataOperations> Operations { get; set; }
            public class DescribeImageEventOperationConditionResponseBodyDataOperations : TeaModel {
                /// <summary>
                /// The rule conditions.
                /// </summary>
                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<DescribeImageEventOperationConditionResponseBodyDataOperationsConditions> Conditions { get; set; }
                public class DescribeImageEventOperationConditionResponseBodyDataOperationsConditions : TeaModel {
                    /// <summary>
                    /// The keyword of the condition. Valid values:
                    /// 
                    /// *   **MD5**
                    /// *   **PATH**
                    /// </summary>
                    [NameInMap("ConditionKey")]
                    [Validation(Required=false)]
                    public string ConditionKey { get; set; }

                    /// <summary>
                    /// The name of the condition.
                    /// </summary>
                    [NameInMap("ConditionName")]
                    [Validation(Required=false)]
                    public string ConditionName { get; set; }

                    /// <summary>
                    /// The matching types.
                    /// </summary>
                    [NameInMap("SupportedMisType")]
                    [Validation(Required=false)]
                    public List<string> SupportedMisType { get; set; }

                }

                /// <summary>
                /// The operation code.
                /// 
                /// *   Only **whitelist** may be returned, which indicates that the alert event is added to the whitelist.
                /// </summary>
                [NameInMap("OperationCode")]
                [Validation(Required=false)]
                public string OperationCode { get; set; }

                /// <summary>
                /// The name of the operation.
                /// </summary>
                [NameInMap("OperationName")]
                [Validation(Required=false)]
                public string OperationName { get; set; }

            }

            /// <summary>
            /// The application scopes of the rules.
            /// </summary>
            [NameInMap("Scenarios")]
            [Validation(Required=false)]
            public List<string> Scenarios { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
