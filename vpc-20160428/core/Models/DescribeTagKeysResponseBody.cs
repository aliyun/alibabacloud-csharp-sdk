// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeTagKeysResponseBody : TeaModel {
        /// <summary>
        /// The token that is used for the next query. Valid values:
        /// 
        /// *   If the value of **NextToken** is not returned, it indicates that no next query is to be sent.
        /// *   If a value of **NextToken** is returned, the value is the token that is used for the subsequent query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of tag keys.
        /// </summary>
        [NameInMap("TagKeys")]
        [Validation(Required=false)]
        public DescribeTagKeysResponseBodyTagKeys TagKeys { get; set; }
        public class DescribeTagKeysResponseBodyTagKeys : TeaModel {
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public List<DescribeTagKeysResponseBodyTagKeysTagKey> TagKey { get; set; }
            public class DescribeTagKeysResponseBodyTagKeysTagKey : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The type of the tag key. Valid values:
                /// 
                /// *   **Custom**: custom
                /// *   **System**: system
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
