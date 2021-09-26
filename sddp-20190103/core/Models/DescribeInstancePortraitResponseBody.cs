// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeInstancePortraitResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<DescribeInstancePortraitResponseBodyContent> Content { get; set; }
        public class DescribeInstancePortraitResponseBodyContent : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("ItemKey")]
            [Validation(Required=false)]
            public string ItemKey { get; set; }

        }

    }

}
