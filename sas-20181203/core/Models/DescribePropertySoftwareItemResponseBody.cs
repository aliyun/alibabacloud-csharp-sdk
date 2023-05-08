// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertySoftwareItemResponseBody : TeaModel {
        /// <summary>
        /// 10
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribePropertySoftwareItemResponseBodyPageInfo PageInfo { get; set; }
        public class DescribePropertySoftwareItemResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// Queries information about all software assets.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// true
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// DescribePropertySoftwareItem
        /// </summary>
        [NameInMap("PropertyItems")]
        [Validation(Required=false)]
        public List<DescribePropertySoftwareItemResponseBodyPropertyItems> PropertyItems { get; set; }
        public class DescribePropertySoftwareItemResponseBodyPropertyItems : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The name of the software.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
