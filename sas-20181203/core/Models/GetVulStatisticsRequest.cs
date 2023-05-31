// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetVulStatisticsRequest : TeaModel {
        /// <summary>
        /// The ID of the asset group. Separate multiple IDs with commas (,).
        /// 
        /// >  You can call the [DescribeAllGroups](~~DescribeAllGroups~~) operation to query the IDs of asset groups.
        /// </summary>
        [NameInMap("GroupIdList")]
        [Validation(Required=false)]
        public string GroupIdList { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The type of the vulnerability whose statistics you want to query. Separate multiple types with commas (,). Valid values:
        /// 
        /// *   **cve**: Linux software vulnerability
        /// *   **sys**: Windows system vulnerability
        /// *   **cms**: Web-CMS vulnerability
        /// *   **emg**: urgent vulnerability
        /// *   **app**: vulnerability detected by using a web scanner
        /// *   **sca**: vulnerability detected based on software component analysis
        /// </summary>
        [NameInMap("TypeList")]
        [Validation(Required=false)]
        public string TypeList { get; set; }

    }

}
