// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspiciousUUIDConfigRequest : TeaModel {
        /// <summary>
        /// The type of proactive defense. Valid values:
        /// 
        /// *   **auto_breaking**: virus defense
        /// *   **ransomware_breaking**: ransomware capture
        /// *   **webshell_cloud_breaking**: webshell defense
        /// *   **alinet**: malicious behavior defense
        /// *   **alisecguard**: client protection
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
