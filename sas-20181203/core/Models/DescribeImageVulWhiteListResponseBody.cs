// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageVulWhiteListResponseBody : TeaModel {
        /// <summary>
        /// The status code returned. A value of **200** indicates that the request was successful. Other values indicate that the request failed. You can identify the cause of the failure based on the value of this parameter.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The information about the whitelist of image vulnerabilities.
        /// </summary>
        [NameInMap("ImageVulWhitelist")]
        [Validation(Required=false)]
        public List<DescribeImageVulWhiteListResponseBodyImageVulWhitelist> ImageVulWhitelist { get; set; }
        public class DescribeImageVulWhiteListResponseBodyImageVulWhitelist : TeaModel {
            /// <summary>
            /// The alias of the vulnerability that is specified in Common Vulnerabilities and Exposures (CVE).
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// The primary key ID of the vulnerability.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the vulnerability.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The reason the vulnerability is added to the whitelist.
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// The object on which the query is performed. The value of this parameter is in the JSON format and contains the following fields:
            /// 
            /// *   **type**: the object type. The value is fixed to repo.
            /// *   **target**: the object content. The value is in the Namespace/Image repository format.
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// The type of the vulnerability. Valid values:
            /// 
            /// *   **cve**: system vulnerability
            /// *   **sca**: application vulnerability
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeImageVulWhiteListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeImageVulWhiteListResponseBodyPageInfo : TeaModel {
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
            /// The number of entries per page.
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The amount of time that was consumed to process the request. Unit: milliseconds.
        /// </summary>
        [NameInMap("TimeCost")]
        [Validation(Required=false)]
        public long? TimeCost { get; set; }

    }

}
