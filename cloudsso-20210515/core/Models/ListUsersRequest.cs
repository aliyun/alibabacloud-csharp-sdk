// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListUsersRequest : TeaModel {
        /// <summary>
        /// The ID of the directory.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The filter condition.
        /// 
        /// Specify the value in the `<Attribute> <Operator> <Value>` format. The value is not case-sensitive. You can set `<Attribute>` only to `UserName` and `Operator` only to `eq` or `sw`. The value eq indicates Equals, and the value sw indicates Starts With.
        /// 
        /// For example, if you set Filter to UserName sw test, the operation queries the users whose names start with test. If you set Filter to UserName eq testuser, the operation queries the user whose name is `testuser`.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Valid values: 1 to 100.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token to return for the next page. If this is your first time to call this operation, you do not need to specify `NextToken`.
        /// 
        /// When you call this operation for the first time, if the total number of entries to return exceeds the value of `MaxResults`, the entries are truncated. Only the entries that match the value of `MaxResults` are returned, and the excess entries are not returned. In this case, the value of the response parameter `IsTruncated` is `true`, and `NextToken` is returned. In the next call, you can use the value of `NextToken` and maintain the settings of the other request parameters to query the excess entries. You can repeat the call until the value of `IsTruncated` becomes `false`. This way, all entries are returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The type of the user. The type can be used to filter users. Valid values:
        /// 
        /// *   Manual: The user is manually created.
        /// *   Synchronized: The user is synchronized from an external IdP.
        /// </summary>
        [NameInMap("ProvisionType")]
        [Validation(Required=false)]
        public string ProvisionType { get; set; }

        /// <summary>
        /// The status of the user. The status can be used to filter users. Valid values:
        /// 
        /// *   Enabled: The logon of the user is enabled.
        /// *   Disabled: The logon of the user is disabled.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
