// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AdvanceSecurityEventOperationsRequest : TeaModel {
        /// <summary>
        /// The alert name.
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// The alert event type. Valid values:
        /// 
        /// *   Suspicious process
        /// *   Webshell
        /// *   Unusual logon
        /// *   Exception
        /// *   Sensitive file tampering
        /// *   Malicious process (cloud threat detection)
        /// *   Unusual network connection
        /// *   Abnormal account
        /// *   Application intrusion event
        /// *   Cloud threat detection
        /// *   Precision defense
        /// *   Application whitelist
        /// *   Persistent webshell
        /// *   Web application threat detection
        /// *   Malicious script
        /// *   Threat intelligence
        /// *   Malicious network activity
        /// *   Cluster exception
        /// *   Webshell (on-premises threat detection)
        /// *   Vulnerability exploitation
        /// *   Malicious process (on-premises threat detection)
        /// *   Trusted exception
        /// *   Others
        /// 
        /// For more information about alert types, see [Alerts](https://help.aliyun.com/document_detail/68388.html).
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The rule ID.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public int? RuleId { get; set; }

    }

}
