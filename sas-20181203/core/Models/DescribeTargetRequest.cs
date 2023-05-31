// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeTargetRequest : TeaModel {
        /// <summary>
        /// The type of the vulnerability. Valid values:
        /// 
        /// *   **cms**: Web CMS vulnerability
        /// *   **sys**: Windows system vulnerability
        /// *   **cve**: Linux software vulnerability
        /// *   **emg**: urgent vulnerability
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The type of the query. Set the value to vul.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
