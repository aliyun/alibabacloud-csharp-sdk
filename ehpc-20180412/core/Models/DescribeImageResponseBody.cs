// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeImageResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ImageInfo")]
        [Validation(Required=false)]
        public DescribeImageResponseBodyImageInfo ImageInfo { get; set; }
        public class DescribeImageResponseBodyImageInfo : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("UpdateDateTime")]
            [Validation(Required=false)]
            public string UpdateDateTime { get; set; }
            [NameInMap("Repository")]
            [Validation(Required=false)]
            public string Repository { get; set; }
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }
            [NameInMap("System")]
            [Validation(Required=false)]
            public string System { get; set; }
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }
        };

    }

}
