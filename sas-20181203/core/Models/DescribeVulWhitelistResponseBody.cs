// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulWhitelistResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned on the current page.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// An array that consists of information about the whitelist of vulnerabilities.
        /// </summary>
        [NameInMap("VulWhitelists")]
        [Validation(Required=false)]
        public List<DescribeVulWhitelistResponseBodyVulWhitelists> VulWhitelists { get; set; }
        public class DescribeVulWhitelistResponseBodyVulWhitelists : TeaModel {
            /// <summary>
            /// The alias of the vulnerability.
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// The ID of the rule.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

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
            /// > If this field is empty, the rule is applied to all assets.
            /// </summary>
            [NameInMap("TargetInfo")]
            [Validation(Required=false)]
            public string TargetInfo { get; set; }

            /// <summary>
            /// The type of the vulnerability.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The information about the vulnerability. The value of this parameter is in the JSON format. Valid values:
            /// 
            /// *   **name**: the name of the vulnerability
            /// *   **type**: the type of the vulnerability.
            /// *   **aliasName**: the alias of the vulnerability
            /// </summary>
            [NameInMap("Whitelist")]
            [Validation(Required=false)]
            public string Whitelist { get; set; }

        }

    }

}
