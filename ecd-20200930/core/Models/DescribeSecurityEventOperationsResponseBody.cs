// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeSecurityEventOperationsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The operations performed on the alert.
        /// </summary>
        [NameInMap("SecurityEventOperations")]
        [Validation(Required=false)]
        public List<DescribeSecurityEventOperationsResponseBodySecurityEventOperations> SecurityEventOperations { get; set; }
        public class DescribeSecurityEventOperationsResponseBodySecurityEventOperations : TeaModel {
            /// <summary>
            /// The code of the operation performed on the alert. Valid values:
            /// 
            /// *   mark_mis_info: adds the alert to the whitelist without configuring rules. This operation is triggered by adding multiple alerts to the whitelist at a time.
            /// *   advance_mark_mis_inf: adds the alert to the whitelist by configuring advanced rules.
            /// *   defense_mark_mis_info: adds the alert to the whitelist by configuring precise defense rules.
            /// *   rm_mark_mis_info: removes the alert from the whitelist.
            /// *   rm_defense_mark_mis_info: removes the alert from the whitelist configured with precise defense rules.
            /// *   manual_handled: manually handles the alert.
            /// *   ignore: ignores the alert.
            /// *   quara: quarantines the source file of the malicious process.
            /// *   block_ip: blocks access from the source IP address.
            /// *   kill_and_quara: terminates the malicious process and quarantines the source file.
            /// </summary>
            [NameInMap("OperationCode")]
            [Validation(Required=false)]
            public string OperationCode { get; set; }

            /// <summary>
            /// The parameters of the operation.
            /// </summary>
            [NameInMap("OperationParams")]
            [Validation(Required=false)]
            public string OperationParams { get; set; }

            /// <summary>
            /// Indicates whether the alert can be handled. Valid values:
            /// 
            /// *   true: The alert can be handled.
            /// *   false: The alert cannot be handled.
            /// </summary>
            [NameInMap("UserCanOperate")]
            [Validation(Required=false)]
            public bool? UserCanOperate { get; set; }

        }

    }

}
