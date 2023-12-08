// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListResourcesByTagRequest : TeaModel {
        [NameInMap("TagFilter")]
        [Validation(Required=false)]
        public ListResourcesByTagRequestTagFilter TagFilter { get; set; }
        public class ListResourcesByTagRequestTagFilter : TeaModel {
            /// <summary>
            /// The tag key. This parameter specifies a filter condition for the query.
            /// 
            /// The tag key can be a maximum of 128 characters in length. It cannot contain `http://` or `https://` and cannot start with `acs:` or `aliyun`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value. This parameter specifies a filter condition for the query.
            /// 
            /// The tag value can be a maximum of 128 characters in length. It cannot contain `http://` or `https://` and cannot start with `acs:` or `aliyun`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The type of the query. Valid values:
        /// 
        /// *   EQUAL: exact match for resources to which the specified tag is added. This is the default value.
        /// *   NOT: exact match for resources to which the specified tag is not added.
        /// </summary>
        [NameInMap("FuzzyType")]
        [Validation(Required=false)]
        public string FuzzyType { get; set; }

        /// <summary>
        /// Specifies whether to return the information of tags added to the resources. Valid values:
        /// 
        /// *   False: does not return the information of tags added to the resources. This is the default value.
        /// *   True: returns the information of all tags added to the resources.
        /// </summary>
        [NameInMap("IncludeAllTags")]
        [Validation(Required=false)]
        public bool? IncludeAllTags { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Default value: 50. Maximum value: 1000.
        /// </summary>
        [NameInMap("MaxResult")]
        [Validation(Required=false)]
        public int? MaxResult { get; set; }

        /// <summary>
        /// The token that is used to start the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// For more information about region IDs, see [Endpoints](~~2330902~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The resource type. This parameter specifies a filter condition for the query.
        /// 
        /// *   If you set the FuzzyType parameter to EQUAL, you can set this parameter to a value obtained from the response of the [ListSupportResourceTypes](~~2330915~~) operation.
        /// *   If you set the FuzzyType parameter to NOT, you can set this parameter to a resource type provided in **Types of resources that support queries based on the NOT operator**.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
