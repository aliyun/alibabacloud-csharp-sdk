// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeAvailableAdvicesResponseBody : TeaModel {
        /// <summary>
        /// Details of the suggestions.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeAvailableAdvicesResponseBodyItems> Items { get; set; }
        public class DescribeAvailableAdvicesResponseBodyItems : TeaModel {
            /// <summary>
            /// The date when the suggestion was generated. The date follows the yyyyMMdd format. The date is displayed in UTC.
            /// </summary>
            [NameInMap("AdviceDate")]
            [Validation(Required=false)]
            public string AdviceDate { get; set; }

            /// <summary>
            /// The suggestion ID.
            /// </summary>
            [NameInMap("AdviceId")]
            [Validation(Required=false)]
            public string AdviceId { get; set; }

            /// <summary>
            /// The type of the suggestion. Valid values:
            /// 
            /// *   **Index**: index optimization
            /// *   **Tiering**: hot and cold data optimization
            /// </summary>
            [NameInMap("AdviceType")]
            [Validation(Required=false)]
            public string AdviceType { get; set; }

            /// <summary>
            /// The benefit of the suggestion.
            /// </summary>
            [NameInMap("Benefit")]
            [Validation(Required=false)]
            public string Benefit { get; set; }

            /// <summary>
            /// The page number of the returned page. The value must be an integer that is greater than 0. Default value: 1.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page. Default value: 30. Valid values:
            /// 
            /// *   **30**
            /// *   **50**
            /// *   **100**
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// The reason why the suggestion was generated.
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// The SQL statement used to apply the suggestion.
            /// </summary>
            [NameInMap("SQL")]
            [Validation(Required=false)]
            public string SQL { get; set; }

            /// <summary>
            /// The total number of entries returned. The value must be an integer that is greater than or equal to 0. Default value: 0.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The page number of the returned page. The value must be an integer that is greater than 0. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page. Default value: 30. Valid values:
        /// 
        /// *   **30**
        /// *   **50**
        /// *   **100**
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned. The value must be an integer that is greater than or equal to 0. Default value: 0.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
