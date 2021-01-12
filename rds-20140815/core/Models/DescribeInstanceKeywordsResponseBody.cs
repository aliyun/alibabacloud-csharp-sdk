// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeInstanceKeywordsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("Words")]
        [Validation(Required=false)]
        public DescribeInstanceKeywordsResponseBodyWords Words { get; set; }
        public class DescribeInstanceKeywordsResponseBodyWords : TeaModel {
            [NameInMap("word")]
            [Validation(Required=false)]
            public List<string> Word { get; set; }
        };

    }

}
