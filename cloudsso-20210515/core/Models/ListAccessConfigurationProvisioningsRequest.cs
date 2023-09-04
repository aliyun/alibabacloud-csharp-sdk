// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListAccessConfigurationProvisioningsRequest : TeaModel {
        /// <summary>
        /// The ID of the access configuration. The ID can be used to filter accounts.
        /// </summary>
        [NameInMap("AccessConfigurationId")]
        [Validation(Required=false)]
        public string AccessConfigurationId { get; set; }

        /// <summary>
        /// The ID of the directory.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Valid values: 1 to 20.
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
        /// The status of the access configuration. The value can be used to filter accounts. Valid values:
        /// 
        /// *   Provisioned: The access configuration is provisioned.
        /// *   ReprovisionRequired: The access configuration needs to be re-provisioned.
        /// *   DeprovisionFailed: The access configuration failed to be provisioned.
        /// </summary>
        [NameInMap("ProvisioningStatus")]
        [Validation(Required=false)]
        public string ProvisioningStatus { get; set; }

        /// <summary>
        /// The ID of the task object. The ID can be used to filter accounts.
        /// 
        /// >  You can use the ID to filter accounts only if you specify both `TargetId` and `TargetType`.
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// The type of the task object. The type can be used to filter accounts.
        /// 
        /// Set the value to RD-Account, which indicates an account in your resource directory.
        /// 
        /// >  You can use the type to filter accounts only if you specify both `TargetId` and `TargetType`.
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
