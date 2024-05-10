// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeFrontVulPatchListRequest : TeaModel {
        /// <summary>
        /// The information about the Windows system vulnerability. The value is a JSON string that contains the following fields:
        /// 
        /// *   **name**: the name of the vulnerability.
        /// *   **uuid**: the UUID of the server on which the vulnerability is detected.
        /// *   **tag**: the tag that is added to the vulnerability. Set this field to **system**, which indicates Windows system vulnerabilities.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Info")]
        [Validation(Required=false)]
        public string Info { get; set; }

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
        /// The operation that you want to perform on the vulnerability. Set the value to **vul_fix**, which indicates vulnerability fixing.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// The type of the vulnerability. Set the value to **sys**, which indicates Windows system vulnerabilities.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
