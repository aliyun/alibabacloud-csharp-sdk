// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class HandleSimilarSecurityEventsRequest : TeaModel {
        /// <summary>
        /// The rule condition based on which the alerts are added to the whitelist. For example, if you want to add a file that contains the string a to the whitelist based on the MD5 hash value, set this parameter to {"field":"md5","operate":"contains","fieldValue":"aa"}.
        /// </summary>
        [NameInMap("MarkMissParam")]
        [Validation(Required=false)]
        public string MarkMissParam { get; set; }

        /// <summary>
        /// The operation that is performed to handle alerts of the same type at a time. Valid values: 
        /// - **deal**: quarantines the source file of the malicious process.
        /// - **killand_quara**: kills the malicious processes and quarantines the source file.
        /// - **kill_virus**: deletes the source file of the malicious process.
        /// - **block_ip**: blocks the source IP address.
        /// - **ignore**: ignores the alerts.
        /// - **advance\_mark\_mis_info**: marks the alerts as false positives by adding the alerts to the whitelist.
        /// - **rm\_mark\_mis\_info**: cancels false positives by removing the alerts from the whitelist.
        /// - **offline_handled**: marks the alerts as handled.
        /// </summary>
        [NameInMap("OperationCode")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

        /// <summary>
        /// The configuration for a sub-operation to handle alerts. 
        /// 
        /// > If you set OperationCode to kill_and_quara or block_ip, you must specify OperationParams. If you set OperationCode to other values, you can leave OperationParams empty.
        /// </summary>
        [NameInMap("OperationParams")]
        [Validation(Required=false)]
        public string OperationParams { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The ID of the task that handles multiple alerts of the same type at a time.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
