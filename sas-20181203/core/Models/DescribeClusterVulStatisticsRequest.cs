// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterVulStatisticsRequest : TeaModel {
        /// <summary>
        /// The ID of the container cluster.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The type of the vulnerabilities. Valid values:
        /// 
        /// *   **cve**: Linux software vulnerabilities
        /// *   **app**: application vulnerabilities
        /// *   **sca**: vulnerabilities that are detected based on software component analysis
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public string Types { get; set; }

    }

}
