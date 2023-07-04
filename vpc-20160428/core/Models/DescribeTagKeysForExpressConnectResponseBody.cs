// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeTagKeysForExpressConnectResponseBody : TeaModel {
        /// <summary>
        /// The token that is used for the next query. Valid values:
        /// 
        /// *   If no value is returned for **NextToken**, no next queries are sent.
        /// *   If a value is returned for **NextToken**, the value is the token that is used for the next query.
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
        public DescribeTagKeysForExpressConnectResponseBodyTagKeys TagKeys { get; set; }
        public class DescribeTagKeysForExpressConnectResponseBodyTagKeys : TeaModel {
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public List<DescribeTagKeysForExpressConnectResponseBodyTagKeysTagKey> TagKey { get; set; }
            public class DescribeTagKeysForExpressConnectResponseBodyTagKeysTagKey : TeaModel {
                /// <summary>
                /// The tag key.
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
