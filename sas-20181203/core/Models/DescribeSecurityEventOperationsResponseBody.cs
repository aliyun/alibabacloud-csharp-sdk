// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSecurityEventOperationsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array consisting of the operations that you can perform to handle the alert event.
        /// </summary>
        [NameInMap("SecurityEventOperationsResponse")]
        [Validation(Required=false)]
        public List<DescribeSecurityEventOperationsResponseBodySecurityEventOperationsResponse> SecurityEventOperationsResponse { get; set; }
        public class DescribeSecurityEventOperationsResponseBodySecurityEventOperationsResponse : TeaModel {
            /// <summary>
            /// An array consisting of the configuration information that is used when the value of the OperationCode parameter is **advance_mark_mis_info**.
            /// </summary>
            [NameInMap("MarkField")]
            [Validation(Required=false)]
            public List<DescribeSecurityEventOperationsResponseBodySecurityEventOperationsResponseMarkField> MarkField { get; set; }
            public class DescribeSecurityEventOperationsResponseBodySecurityEventOperationsResponseMarkField : TeaModel {
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
                /// An array consisting of the operations that are supported by the method to add the alert event to the whitelist.
                /// </summary>
                [NameInMap("SupportedMisType")]
                [Validation(Required=false)]
                public List<string> SupportedMisType { get; set; }

                /// <summary>
                /// The UUID of the server on which the alert event is detected.
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// An array consisting of the configuration items that can be used when the value of the OperationCode parameter is advance_mark_mis_info.
            /// </summary>
            [NameInMap("MarkFieldsSource")]
            [Validation(Required=false)]
            public List<DescribeSecurityEventOperationsResponseBodySecurityEventOperationsResponseMarkFieldsSource> MarkFieldsSource { get; set; }
            public class DescribeSecurityEventOperationsResponseBodySecurityEventOperationsResponseMarkFieldsSource : TeaModel {
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
                /// An array consisting of the operations that are supported by the method to add the alert event to the whitelist.
                /// </summary>
                [NameInMap("SupportedMisType")]
                [Validation(Required=false)]
                public List<string> SupportedMisType { get; set; }

            }

            /// <summary>
            /// The operation that you can perform to handle the alert. Valid values:
            /// 
            /// *   **block_ip**: blocks the source IP address.
            /// *   **advance_mark_mis_info**: adds the alert to the whitelist.
            /// *   **ignore**: ignores the alert.
            /// *   **manual_handled**: marks the alert as manually handled.
            /// *   **kill_process**: terminates the malicious process.
            /// *   **cleanup**: performs in-depth virus detection and removal.
            /// *   **kill_and_quara**: terminates the malicious process and quarantines the source file.
            /// *   **disable_malicious_defense**: stops the container on which the alerting files or processes exist.
            /// *   **client_problem_check**: performs troubleshooting.
            /// *   **quara**: quarantines the source file of the malicious process.
            /// </summary>
            [NameInMap("OperationCode")]
            [Validation(Required=false)]
            public string OperationCode { get; set; }

            /// <summary>
            /// The configuration of the operation that you can perform to handle the alert event.
            /// 
            /// >  If the value of the OperationCode parameter is `kill_and_quara` or `block_ip`, the OperationParams parameter is required. If the value of the OperationCode parameter is a different value, the OperationParams parameter can be left empty.
            /// </summary>
            [NameInMap("OperationParams")]
            [Validation(Required=false)]
            public string OperationParams { get; set; }

            /// <summary>
            /// Indicates whether you can handle the alert event in the current edition of Security Center. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("UserCanOperate")]
            [Validation(Required=false)]
            public bool? UserCanOperate { get; set; }

        }

    }

}
