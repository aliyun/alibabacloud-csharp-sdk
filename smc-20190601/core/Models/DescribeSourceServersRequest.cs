// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class DescribeSourceServersRequest : TeaModel {
        /// <summary>
        /// The migration job ID.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// The name of the migration source. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with http:// or https://. It can contain digits, colons (:), underscores (\_), and hyphens (-).
        /// 
        /// Default value: null.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 1 to 50.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The migration source IDs. You can specify multiple IDs.
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public List<string> SourceId { get; set; }

        /// <summary>
        /// The state of the migration source. Valid Values:
        /// 
        /// *   Unavailable: The migration source is inactive, or an error occurs in the migration source.
        /// *   Available: The migration source is active.
        /// *   InUse: The migration source is being migrated.
        /// *   Deleting: The migration source is being deleted from Server Migration Center (SMC).
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// The tag.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeSourceServersRequestTag> Tag { get; set; }
        public class DescribeSourceServersRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N that is added to the SMC resource. Valid values of N: 1 to 20.
            /// 
            /// The tag key cannot be an empty string. It can be up to 64 characters in length and cannot start with acs: or aliyun. It cannot contain http:// or https://.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N that is added to the SMC resource. Valid values of N: 1 to 20.
            /// 
            /// The tag value can be an empty string. It can be up to 64 characters in length and cannot contain http:// or https://.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
