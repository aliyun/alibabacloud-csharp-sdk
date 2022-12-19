// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class HandleSecurityEventsRequest : TeaModel {
        /// <summary>
        /// Specifies whether to add multiple alert events to the whitelist at a time. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("MarkBatch")]
        [Validation(Required=false)]
        public string MarkBatch { get; set; }

        /// <summary>
        /// The whitelist rule. The value of this parameter is in the JSON format and contains the following fields:
        /// 
        /// *   **field**: The field based on which alert events are added to the whitelist.
        /// 
        /// *   **operate**: The method that is used to added alert events to the whitelist. Valid values:
        /// 
        ///     *   **notContains**: does not contain
        ///     *   **contains**: contains
        ///     *   **regex**: matches by regular expression
        ///     *   **strEqual**: equals
        ///     *   **strNotEqual**: does not equal
        /// 
        /// *   **fieldValue**: The value of the field based on which alert events are added to the whitelist.
        /// 
        /// *   **uuid**: The application scope of the whitelist rule. Valid values:
        /// 
        ///     *   **part**: the current asset
        ///     *   **ALL**: all assets
        /// 
        /// >  You can call the [DescribeSecurityEventOperations](~~DescribeSecurityEventOperations~~) operation to obtain the fields that you can specify for **field**.
        /// </summary>
        [NameInMap("MarkMissParam")]
        [Validation(Required=false)]
        public string MarkMissParam { get; set; }

        /// <summary>
        /// The operation that you want to perform to handle the alert events. Valid values:
        /// 
        /// *   **block_ip**: blocks the source IP address.
        /// *   **advance\_mark\_mis_info**: adds the alert events to the whitelist.
        /// *   **ignore**: ignores the alert events.
        /// *   **manual_handled**: marks the alert events as manually handled.
        /// *   **kill_process**: terminates the malicious process.
        /// *   **cleanup**: performs in-depth virus detection and removal.
        /// *   **kill\_and_quara**: kills the malicious processes and quarantines the source file.
        /// *   **disable\_malicious_defense**: stops the container on which the alerting files or processes exist.
        /// *   **client\_problem_check**: performs troubleshooting.
        /// *   **quara**: quarantines the source file of the malicious process.
        /// </summary>
        [NameInMap("OperationCode")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

        /// <summary>
        /// The configuration of the operation that you want to perform to handle the alert events.
        /// 
        /// >  If you set OperationCode to `kill_and_quara` or `block_ip`, you must specify OperationParams. If you set OperationCode to other values, you can leave OperationParams empty.
        /// </summary>
        [NameInMap("OperationParams")]
        [Validation(Required=false)]
        public string OperationParams { get; set; }

        /// <summary>
        /// The IDs of the alert events.
        /// </summary>
        [NameInMap("SecurityEventIds")]
        [Validation(Required=false)]
        public List<string> SecurityEventIds { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
