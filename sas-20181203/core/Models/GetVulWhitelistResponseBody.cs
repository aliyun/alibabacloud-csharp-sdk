// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetVulWhitelistResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the whitelist.
        /// </summary>
        [NameInMap("VulWhitelist")]
        [Validation(Required=false)]
        public GetVulWhitelistResponseBodyVulWhitelist VulWhitelist { get; set; }
        public class GetVulWhitelistResponseBodyVulWhitelist : TeaModel {
            /// <summary>
            /// The alias of the vulnerability.
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// The ID of the whitelist.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the vulnerability.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The reason why the vulnerability is added to the whitelist.
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// The application scope of the rule. The value is a JSON string that contains the following fields:
            /// 
            /// *   **type**: the type of the assets to which the rule is applied. Valid values:
            /// 
            ///     *   **Uuid**: server
            ///     *   **GroupId**: server group
            /// 
            /// *   **groupIds**: the ID of the server group
            /// 
            /// *   **uuids**: the UUID of the server
            /// 
            /// > If this parameter is empty, the rule is applied to all types of assets.
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// The type of the vulnerability.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The information about the vulnerability that is added to the whitelist. The value is a JSON string that contains the following fields:
            /// 
            /// *   **Name**: the name of the vulnerability.
            /// 
            /// *   **Type**: the type of the vulnerability. Valid values:
            /// 
            ///     *   **cve**: Linux software vulnerability
            ///     *   **sys**: Windows system vulnerability
            ///     *   **cms**: Web-CMS vulnerability
            ///     *   **app**: application vulnerability
            ///     *   **emg**: urgent vulnerabilities
            /// 
            /// *   **AliasName**: the alias of the vulnerability.
            /// </summary>
            [NameInMap("Whitelist")]
            [Validation(Required=false)]
            public string Whitelist { get; set; }

        }

    }

}
