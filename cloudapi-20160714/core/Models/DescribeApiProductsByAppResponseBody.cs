// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiProductsByAppResponseBody : TeaModel {
        [NameInMap("ApiProductInfoList")]
        [Validation(Required=false)]
        public DescribeApiProductsByAppResponseBodyApiProductInfoList ApiProductInfoList { get; set; }
        public class DescribeApiProductsByAppResponseBodyApiProductInfoList : TeaModel {
            [NameInMap("ApiProductInfo")]
            [Validation(Required=false)]
            public List<DescribeApiProductsByAppResponseBodyApiProductInfoListApiProductInfo> ApiProductInfo { get; set; }
            public class DescribeApiProductsByAppResponseBodyApiProductInfoListApiProductInfo : TeaModel {
                [NameInMap("ApiProductId")]
                [Validation(Required=false)]
                public string ApiProductId { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
