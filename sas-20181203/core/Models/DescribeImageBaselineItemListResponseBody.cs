// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBaselineItemListResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of baseline check items.
        /// </summary>
        [NameInMap("BaselineItemInfos")]
        [Validation(Required=false)]
        public List<DescribeImageBaselineItemListResponseBodyBaselineItemInfos> BaselineItemInfos { get; set; }
        public class DescribeImageBaselineItemListResponseBodyBaselineItemInfos : TeaModel {
            /// <summary>
            /// The alias of the baseline type.
            /// </summary>
            [NameInMap("BaselineClassAlias")]
            [Validation(Required=false)]
            public string BaselineClassAlias { get; set; }

            /// <summary>
            /// The key of the baseline type.
            /// </summary>
            [NameInMap("BaselineClassKey")]
            [Validation(Required=false)]
            public string BaselineClassKey { get; set; }

            /// <summary>
            /// The alias of the baseline check item.
            /// </summary>
            [NameInMap("BaselineItemAlias")]
            [Validation(Required=false)]
            public string BaselineItemAlias { get; set; }

            /// <summary>
            /// The key of the baseline check item.
            /// </summary>
            [NameInMap("BaselineItemKey")]
            [Validation(Required=false)]
            public string BaselineItemKey { get; set; }

            /// <summary>
            /// The alias of the baseline.
            /// </summary>
            [NameInMap("BaselineNameAlias")]
            [Validation(Required=false)]
            public string BaselineNameAlias { get; set; }

            /// <summary>
            /// The key of the baseline name.
            /// </summary>
            [NameInMap("BaselineNameKey")]
            [Validation(Required=false)]
            public string BaselineNameKey { get; set; }

            /// <summary>
            /// The status of the baseline risk item. Valid values:
            /// 
            /// *   **0**: unfixed
            /// *   **1**: fixed
            /// *   **2**: pending verification
            /// *   **3**: fixing failed
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// Indicates whether the baseline check item is added to the whitelist. Valid values:
            /// 
            /// *   **0**: no
            /// *   **1**: yes
            /// </summary>
            [NameInMap("WhiteList")]
            [Validation(Required=false)]
            public int? WhiteList { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeImageBaselineItemListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeImageBaselineItemListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
