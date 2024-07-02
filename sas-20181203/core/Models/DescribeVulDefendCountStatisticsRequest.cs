// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulDefendCountStatisticsRequest : TeaModel {
        /// <summary>
        /// The type of the vulnerabilities. Valid values:
        /// 
        /// *   app: application vulnerabilities
        /// *   emg: urgent vulnerabilities
        /// </summary>
        [NameInMap("VulType")]
        [Validation(Required=false)]
        public string VulType { get; set; }

    }

}
