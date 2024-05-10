// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateSuspiciousTargetConfigRequest : TeaModel {
        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The configuration of proactive defense for your server. The value includes the following fields:
        /// 
        /// *   **targetType**: specifies the dimension from which you manage proactive defense. UUIDs are supported. Set the value to **uuid**.
        /// *   **target**: specifies the UUID of the server for which you want to configure proactive defense.
        /// *   **flag**: specifies whether to enable or disable proactive defense for your server. Valid values are **add** and **del**. The value add indicates that proactive defense will be enabled for your server. The value del indicates that proactive defense will be disabled for your server.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetOperations")]
        [Validation(Required=false)]
        public string TargetOperations { get; set; }

        /// <summary>
        /// The dimension from which you manage proactive defense. Only the server UUID dimension is supported.
        /// 
        /// Set the value to **uuid**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// The type of proactive defense. Valid Values:
        /// 
        /// *   **auto_breaking**: automatic blocking
        /// *   **webshell_cloud_breaking**: webshell defense
        /// *   **alinet**: malicious behavior defense
        /// *   **ransomware_breaking**: ransomware capture
        /// *   **alisecguard**: client protection
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
