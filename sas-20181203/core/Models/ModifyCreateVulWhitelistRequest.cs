// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyCreateVulWhitelistRequest : TeaModel {
        /// <summary>
        /// The reason why you add the vulnerability to the whitelist.
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// The applicable scope of the whitelist. The value of this parameter is in the JSON format and contains the following fields:
        /// 
        /// *   **type**: the type of the applicable scope. Valid values:
        /// 
        ///     *   **GroupId**: the ID of a server group
        ///     *   **Uuid**: the UUID of a server
        /// 
        /// *   **uuids**: the UUIDs of servers
        /// 
        /// *   **groupIds**: the IDs of server groups
        /// 
        /// >  If you leave this parameter empty, all servers are added to the whitelist. If you set the **type** field to **GroupId**, you must also specify the **groupIds** field. If you set **type** to **Uuid**, you must specify the **uuids** parameter.
        /// </summary>
        [NameInMap("TargetInfo")]
        [Validation(Required=false)]
        public string TargetInfo { get; set; }

        /// <summary>
        /// The information about the vulnerability that you want to add to the whitelist. The value is a JSON string that contains the following fields:
        /// 
        /// *   **Status**: the status of the vulnerability.
        /// 
        /// *   **GmtLast**: the timestamp when the vulnerability was last detected. Unit: milliseconds.
        /// 
        /// *   **LaterCount**: the number of vulnerabilities that have the medium priority.
        /// 
        /// *   **AsapCount**: the number of vulnerabilities that have the high priority.
        /// 
        /// *   **Name**: the name of the vulnerability.
        /// 
        /// *   **Type**: the type of the vulnerability. Valid values:
        /// 
        ///     *   **cve**: Linux software vulnerability
        ///     *   **sys**: Windows system vulnerability
        ///     *   **cms**: Web-CMS vulnerability
        ///     *   **app**: application vulnerability
        ///     *   **emg**: urgent vulnerability
        /// 
        /// *   **Related**: the Common Vulnerabilities and Exposures (CVE) ID of the vulnerability.
        /// 
        /// *   **HandledCount**: the number of handled vulnerabilities.
        /// 
        /// *   **AliasName**: the alias of the vulnerability.
        /// 
        /// *   **RuleModifyTime**: the time when the vulnerability was last disclosed.
        /// 
        /// *   **NntfCount**: the number of vulnerabilities that have the low priority.
        /// 
        /// *   **TotalFixCount**: the total number of fixed vulnerabilities.
        /// 
        /// *   **Tags**: the tag that is added to the vulnerability.
        /// 
        /// >  You can call the [DescribeGroupedVul](~~DescribeGroupedVul~~) operation to query the information about the vulnerability that you want to add to the whitelist.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public string Whitelist { get; set; }

    }

}
