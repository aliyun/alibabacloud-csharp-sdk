// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeImageFamiliesResponseBody : TeaModel {
        [NameInMap("ImageFamilies")]
        [Validation(Required=false)]
        public DescribeImageFamiliesResponseBodyImageFamilies ImageFamilies { get; set; }
        public class DescribeImageFamiliesResponseBodyImageFamilies : TeaModel {
            [NameInMap("ImageFamily")]
            [Validation(Required=false)]
            public List<string> ImageFamily { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
