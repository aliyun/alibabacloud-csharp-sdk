// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyOperateVulRequest : TeaModel {
        /// <summary>
        /// The operation that you want to perform on the vulnerability. Valid values:
        /// 
        /// *   **vul_fix**: fixes the vulnerability.
        /// *   **vul_verify**: verifies the vulnerability fix.
        /// *   **vul_ignore**: ignores the vulnerability.
        /// *   **vul_undo_ignore**: cancels ignoring the vulnerability.
        /// *   **vul_delete**: deletes the vulnerability.
        /// </summary>
        [NameInMap("Info")]
        [Validation(Required=false)]
        public string Info { get; set; }

        /// <summary>
        /// Handles detected vulnerabilities. You can fix or ignore vulnerabilities. You can also verify the vulnerability fixes.
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// ModifyOperateVul
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
