// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AdvanceSecurityEventOperationsResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The operation performed on the alert event.
        /// </summary>
        [NameInMap("SecurityEventOperationsResponse")]
        [Validation(Required=false)]
        public List<AdvanceSecurityEventOperationsResponseBodySecurityEventOperationsResponse> SecurityEventOperationsResponse { get; set; }
        public class AdvanceSecurityEventOperationsResponseBodySecurityEventOperationsResponse : TeaModel {
            /// <summary>
            /// The object on which the operation is performed. This parameter is required when you set the OperationCode parameter to **advance_mark_mis_info**.
            /// </summary>
            [NameInMap("MarkField")]
            [Validation(Required=false)]
            public List<AdvanceSecurityEventOperationsResponseBodySecurityEventOperationsResponseMarkField> MarkField { get; set; }
            public class AdvanceSecurityEventOperationsResponseBodySecurityEventOperationsResponseMarkField : TeaModel {
                /// <summary>
                /// The alias of the field that is used in the whitelist rule.
                /// </summary>
                [NameInMap("FiledAliasName")]
                [Validation(Required=false)]
                public string FiledAliasName { get; set; }

                /// <summary>
                /// The field that is used in the whitelist rule.
                /// </summary>
                [NameInMap("FiledName")]
                [Validation(Required=false)]
                public string FiledName { get; set; }

                /// <summary>
                /// The operation that is used in the whitelist rule. Valid values:
                /// 
                /// *   **contains**: contains
                /// *   **notContains**: does not contain
                /// *   **regex**: regular expression
                /// *   **strEqual**: equals
                /// *   **strNotEqual**: does not equal
                /// </summary>
                [NameInMap("MarkMisType")]
                [Validation(Required=false)]
                public string MarkMisType { get; set; }

                /// <summary>
                /// The value of the field that is used in the whitelist rule.
                /// </summary>
                [NameInMap("MarkMisValue")]
                [Validation(Required=false)]
                public string MarkMisValue { get; set; }

                /// <summary>
                /// The operation that is used and can be modified in the whitelist rule. Valid values:
                /// 
                /// *   **contains**: contains
                /// *   **notContains**: does not contain
                /// *   **regex**: regular expression
                /// *   **strEqual**: equals
                /// *   **strNotEqual**: does not equal
                /// </summary>
                [NameInMap("SupportedMisType")]
                [Validation(Required=false)]
                public List<string> SupportedMisType { get; set; }

            }

            /// <summary>
            /// The metadata configuration returned by the advanced whitelist rule.
            /// </summary>
            [NameInMap("MarkFieldsSource")]
            [Validation(Required=false)]
            public List<AdvanceSecurityEventOperationsResponseBodySecurityEventOperationsResponseMarkFieldsSource> MarkFieldsSource { get; set; }
            public class AdvanceSecurityEventOperationsResponseBodySecurityEventOperationsResponseMarkFieldsSource : TeaModel {
                /// <summary>
                /// The alias of the field that can be used in the whitelist rule.
                /// </summary>
                [NameInMap("FiledAliasName")]
                [Validation(Required=false)]
                public string FiledAliasName { get; set; }

                /// <summary>
                /// The field that can be used in the whitelist rule.
                /// </summary>
                [NameInMap("FiledName")]
                [Validation(Required=false)]
                public string FiledName { get; set; }

                /// <summary>
                /// The value of the field that can be used in the whitelist rule.
                /// </summary>
                [NameInMap("MarkMisValue")]
                [Validation(Required=false)]
                public string MarkMisValue { get; set; }

                /// <summary>
                /// The operation that is supported in the whitelist rule. Valid values:
                /// 
                /// *   **contains**: contains
                /// *   **notContains**: does not contain
                /// *   **regex**: regular expression
                /// *   **strEqual**: equals
                /// *   **strNotEqual**: does not equal
                /// </summary>
                [NameInMap("SupportedMisType")]
                [Validation(Required=false)]
                public List<string> SupportedMisType { get; set; }

            }

            /// <summary>
            /// The operation performed to handle the alert. Valid values:
            /// 
            /// *   **block_ip**: blocks the alert.
            /// *   **advance_mark_mis_info**: adds the alert to the whitelist.
            /// *   **ignore**: ignores the alert.
            /// *   **manual_handled**: marks the alert as manually handled.
            /// *   **kill_process**: terminates the malicious process.
            /// *   **cleanup**: performs in-depth virus detection and removal.
            /// *   **kill_and_quara**: performs virus detection and removal.
            /// *   **disable_malicious_defense**: turns off malicious defense behavior.
            /// *   **client_problem_check**: performs troubleshooting.
            /// *   **quara**: performs quarantine operations.
            /// </summary>
            [NameInMap("OperationCode")]
            [Validation(Required=false)]
            public string OperationCode { get; set; }

            /// <summary>
            /// The configuration of the operation performed to handle the alert event.
            /// </summary>
            [NameInMap("OperationParams")]
            [Validation(Required=false)]
            public string OperationParams { get; set; }

            /// <summary>
            /// Indicates whether the operation can be performed.
            /// 
            /// *   **true**: The operation can be performed.
            /// *   **false**: The operation cannot be performed.
            /// </summary>
            [NameInMap("UserCanOperate")]
            [Validation(Required=false)]
            public bool? UserCanOperate { get; set; }

        }

    }

}
