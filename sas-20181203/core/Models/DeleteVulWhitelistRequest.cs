// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteVulWhitelistRequest : TeaModel {
        /// <summary>
        /// The ID of the whitelist.
        /// 
        /// >  To delete a vulnerability whitelist, you must provide the ID of the whitelist. You can call the [DescribeVulWhitelist](~~DescribeVulWhitelist~~) operation to query the IDs of whitelists.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// The information about the whitelist. The value is a JSON string that contains the following fields:
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
        /// *   **AliasName**: the alias of the vulnerability.
        /// </summary>
        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public string Whitelist { get; set; }

    }

}
