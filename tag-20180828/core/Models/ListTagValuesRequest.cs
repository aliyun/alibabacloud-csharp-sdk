// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListTagValuesRequest : TeaModel {
        [NameInMap("TagFilter")]
        [Validation(Required=false)]
        public ListTagValuesRequestTagFilter TagFilter { get; set; }
        public class ListTagValuesRequestTagFilter : TeaModel {
            /// <summary>
            /// The tag value.
            /// 
            /// This parameter is used together with the `FuzzyType` parameter.
            /// 
            /// >  This parameter is available only in the China (Shenzhen) and China (Hong Kong) regions.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The type of the query. Valid values:
        /// 
        /// *   EQUAL: exact match. This is the default value.
        /// *   PREFIX: prefix-based fuzzy match.
        /// 
        /// >  This parameter is available only in the China (Shenzhen) and China (Hong Kong) regions.
        /// </summary>
        [NameInMap("FuzzyType")]
        [Validation(Required=false)]
        public string FuzzyType { get; set; }

        /// <summary>
        /// The tag key. This parameter specifies a filter condition for the query.
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

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
        /// The number of tag values to return on each page.
        /// 
        /// Maximum value: 1000. Default value: 50.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The category of the tags. This parameter specifies a filter condition for the query. Valid values:
        /// 
        /// *   ResourceTag: resource tags, including custom and system tags. This is the default value.
        /// *   MetaTag: preset tags.
        /// 
        /// >  The value of this parameter is not case-sensitive.
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

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
        /// Format: `ALIYUN::${ProductCode}::${ResourceType}`. All letters in the value of this parameter must be in uppercase.
        /// 
        /// *   `ProductCode`: the service code. You can set this field to a value obtained from the response of the [ListSupportResourceTypes](~~2330915~~) operation.
        /// *   `ResourceType`: the resource type. You can set this field to a value obtained from the response of the [ListSupportResourceTypes](~~2330915~~) operation.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
