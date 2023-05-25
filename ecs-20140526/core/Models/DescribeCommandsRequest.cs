// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeCommandsRequest : TeaModel {
        /// <summary>
        /// The name of the command. Partial command names are not supported.
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// The page number of the page to return.
        /// 
        /// Pages start from page 1.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// The command type. Valid values:
        /// 
        /// *   RunBatScript: batch command, applicable to Windows instances
        /// *   RunPowerShellScript: PowerShell command, applicable to Windows instances
        /// *   RunShellScript: shell command, applicable to Linux instances
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The list of tags.
        /// </summary>
        [NameInMap("Latest")]
        [Validation(Required=false)]
        public bool? Latest { get; set; }

        /// <summary>
        /// > This parameter is deprecated and does not take effect.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Maximum value: 50.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// Specifies whether to query only the latest version of common commands when common commands are queried. This parameter does not affect the query for private commands. Valid values:
        /// 
        /// *   true: queries only the latest version of common commands.
        /// *   false: queries all versions of common commands.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the command.
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// The provider of the common command. Take note of the following items:
        /// 
        /// *   If you do not specify this parameter, all the commands that you created are queried.
        /// 
        /// *   If you set this parameter to `AlibabaCloud`, all the common commands provided by Alibaba Cloud are queried.
        /// 
        /// *   If you set this parameter to a specific provider, all the common commands provided by the provider are queried. Examples:
        /// 
        ///     *   If you set `Provider` to AlibabaCloud.ECS.GuestOS, all the common commands provided by `AlibabaCloud.ECS.GuestOS` are queried.
        ///     *   If you set `Provider` to AlibabaCloud.ECS.GuestOSDiagnose, all the common commands provided by `AlibabaCloud.ECS.GuestOSDiagnose` are queried.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeCommandsRequestTag> Tag { get; set; }
        public class DescribeCommandsRequestTag : TeaModel {
            /// <summary>
            /// The value of tag N to add to the command. Valid values of N: 1 to 20. The tag value can be an empty string.
            /// 
            /// It can be up to 128 characters in length and cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The number of entries returned on each page.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The encoding mode of the `CommandContent` and `Output` response parameters. Valid values:
        /// 
        /// *   PlainText: returns the original command content and command output.
        /// *   Base64: returns the Base64-encoded command content and command output
        /// 
        /// Default value: Base64.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
