// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeTagKeysForExpressConnectResponseBody : TeaModel {
        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// 
        /// *   If **NextToken** is empty, no next page exists.
        /// *   If a value is returned for **NextToken**, the value can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The tag keys.
        /// </summary>
        [NameInMap("TagKeys")]
        [Validation(Required=false)]
        public DescribeTagKeysForExpressConnectResponseBodyTagKeys TagKeys { get; set; }
        public class DescribeTagKeysForExpressConnectResponseBodyTagKeys : TeaModel {
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public List<DescribeTagKeysForExpressConnectResponseBodyTagKeysTagKey> TagKey { get; set; }
            public class DescribeTagKeysForExpressConnectResponseBodyTagKeysTagKey : TeaModel {
                /// <summary>
                /// The key of the tag.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The type of the resource. The value is set to **PHYSICALCONNECTION**, which indicates an Express Connect circuit.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
