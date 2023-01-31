// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeTagKeysResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TagKeys")]
        [Validation(Required=false)]
        public DescribeTagKeysResponseBodyTagKeys TagKeys { get; set; }
        public class DescribeTagKeysResponseBodyTagKeys : TeaModel {
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public List<DescribeTagKeysResponseBodyTagKeysTagKey> TagKey { get; set; }
            public class DescribeTagKeysResponseBodyTagKeysTagKey : TeaModel {
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
