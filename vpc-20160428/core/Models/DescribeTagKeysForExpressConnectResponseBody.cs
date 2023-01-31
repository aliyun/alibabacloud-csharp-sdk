// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeTagKeysForExpressConnectResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TagKeys")]
        [Validation(Required=false)]
        public DescribeTagKeysForExpressConnectResponseBodyTagKeys TagKeys { get; set; }
        public class DescribeTagKeysForExpressConnectResponseBodyTagKeys : TeaModel {
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public List<DescribeTagKeysForExpressConnectResponseBodyTagKeysTagKey> TagKey { get; set; }
            public class DescribeTagKeysForExpressConnectResponseBodyTagKeysTagKey : TeaModel {
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
