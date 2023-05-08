// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyScaItemResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribePropertyScaItemResponseBodyPageInfo PageInfo { get; set; }
        public class DescribePropertyScaItemResponseBodyPageInfo : TeaModel {
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
        /// An array that consists of the information about middleware fingerprints.
        /// </summary>
        [NameInMap("PropertyItems")]
        [Validation(Required=false)]
        public List<DescribePropertyScaItemResponseBodyPropertyItems> PropertyItems { get; set; }
        public class DescribePropertyScaItemResponseBodyPropertyItems : TeaModel {
            /// <summary>
            /// The type of the middleware, database, or web service. Valid values:
            /// 
            /// *   **system_service**: system service
            /// *   **software_library**: software library
            /// *   **docker_component**: container component
            /// *   **database**: database
            /// *   **web_container**: web container
            /// *   **jar**: JAR package
            /// *   **web_framework**: web framework
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// The number of servers on which the middleware is run.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The name of the middleware.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The display name of the middleware type.
            /// </summary>
            [NameInMap("TypeDisplay")]
            [Validation(Required=false)]
            public string TypeDisplay { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
