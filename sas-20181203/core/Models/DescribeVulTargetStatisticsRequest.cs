// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulTargetStatisticsRequest : TeaModel {
        /// <summary>
        /// The type of the vulnerabilities. Valid values:
        /// 
        /// *   **cve**: Linux software vulnerabilities
        /// *   **sys**: Windows system vulnerabilities
        /// *   **cms**: Web-CMS vulnerabilities
        /// *   **emg**: urgent vulnerabilities
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
