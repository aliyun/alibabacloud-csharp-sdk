// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyOperateVulRequest : TeaModel {
        /// <summary>
        /// The ID of the request source. Set the value to **sas**.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// The details of the vulnerability. The value of this parameter is in the JSON format and contains the following fields:
        /// 
        /// *   **name**: the name of the vulnerability.
        /// 
        /// *   **uuid**: the UUID of the server on which the vulnerability is detected.
        /// 
        /// *   **tag**: the tag that is added to the vulnerability. Valid values:
        /// 
        ///     *   **oval**: Linux software vulnerability
        ///     *   **system**: Windows system vulnerability
        ///     *   **cms**: Web-CMS vulnerability
        /// 
        /// >  You can call the [DescribeVulList](~~DescribeVulList~~) operation to query the tags that are added to vulnerabilities of other types.
        /// 
        /// *   **isFront**: specifies whether a pre-patch is required to fix the Windows system vulnerability. This field is required only for Windows system vulnerabilities. Valid values:
        /// 
        ///     *   **0**: no
        ///     *   **1**: yes
        /// 
        /// >  You can fix multiple vulnerabilities at a time. Separate the details of multiple vulnerabilities with commas (,). You can call the [DescribeVulLIst](~~DescribeVulList~~) operation to query the details of vulnerabilities.
        /// </summary>
        [NameInMap("Info")]
        [Validation(Required=false)]
        public string Info { get; set; }

        /// <summary>
        /// The operation that you want to perform on the vulnerability. Valid values:
        /// 
        /// *   **vul_fix**: fixes the vulnerability.
        /// *   **vul_verify**: verifies the vulnerability fix.
        /// *   **vul_ignore**: ignores the vulnerability.
        /// *   **vul\_undo_ignore**: cancels ignoring the vulnerability.
        /// *   **vul_delete**: deletes the vulnerability.
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// The reason why the vulnerability is **ignored**.
        /// 
        /// >  This parameter is required only when you set **OperateType** to **vul_ignore**.
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// The type of the vulnerability. Valid values:
        /// 
        /// *   **cve**: Linux software vulnerability
        /// *   **sys**: Windows system vulnerability
        /// *   **cms**: Web-CMS vulnerability
        /// *   **emg**: urgent vulnerability
        /// *   **app**: application vulnerability
        /// *   **sca**: vulnerability that is detected based on software component analysis
        /// 
        /// >  You cannot fix the urgent vulnerabilities, application vulnerabilities, or vulnerabilities that are detected based on software component analysis.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
