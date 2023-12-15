// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiProductsByAppResponseBody : TeaModel {
        /// <summary>
        /// The information about API products.
        /// </summary>
        [NameInMap("ApiProductInfoList")]
        [Validation(Required=false)]
        public DescribeApiProductsByAppResponseBodyApiProductInfoList ApiProductInfoList { get; set; }
        public class DescribeApiProductsByAppResponseBodyApiProductInfoList : TeaModel {
            [NameInMap("ApiProductInfo")]
            [Validation(Required=false)]
            public List<DescribeApiProductsByAppResponseBodyApiProductInfoListApiProductInfo> ApiProductInfo { get; set; }
            public class DescribeApiProductsByAppResponseBodyApiProductInfoListApiProductInfo : TeaModel {
                /// <summary>
                /// The ID of the API product.
                /// </summary>
                [NameInMap("ApiProductId")]
                [Validation(Required=false)]
                public string ApiProductId { get; set; }

            }

        }

        /// <summary>
        /// The page number. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
