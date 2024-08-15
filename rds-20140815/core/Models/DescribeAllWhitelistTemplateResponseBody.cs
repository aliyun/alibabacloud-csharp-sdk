// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAllWhitelistTemplateResponseBody : TeaModel {
        /// <summary>
        /// The response code returned. Valid values:
        /// 
        /// *   **200**: success
        /// *   **400**: client error
        /// *   **401**: identity authentication failed
        /// *   **404**: request page not found
        /// *   **500**: server error
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAllWhitelistTemplateResponseBodyData Data { get; set; }
        public class DescribeAllWhitelistTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("CurrPageNumbers")]
            [Validation(Required=false)]
            public int? CurrPageNumbers { get; set; }

            /// <summary>
            /// Indicates whether the data that meets the conditions is displayed on the next page. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("HasNext")]
            [Validation(Required=false)]
            public bool? HasNext { get; set; }

            /// <summary>
            /// Indicates whether the data that meets the conditions is displayed on the previous page. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("HasPrev")]
            [Validation(Required=false)]
            public bool? HasPrev { get; set; }

            /// <summary>
            /// The number of entries to return on each page.
            /// </summary>
            [NameInMap("MaxRecordsPerPage")]
            [Validation(Required=false)]
            public int? MaxRecordsPerPage { get; set; }

            /// <summary>
            /// The information about whitelist templates that are returned by page.
            /// </summary>
            [NameInMap("Templates")]
            [Validation(Required=false)]
            public List<DescribeAllWhitelistTemplateResponseBodyDataTemplates> Templates { get; set; }
            public class DescribeAllWhitelistTemplateResponseBodyDataTemplates : TeaModel {
                /// <summary>
                /// The primary key of the data table.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// The IP addresses.
                /// </summary>
                [NameInMap("Ips")]
                [Validation(Required=false)]
                public string Ips { get; set; }

                /// <summary>
                /// The ID of the whitelist template.
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public int? TemplateId { get; set; }

                /// <summary>
                /// The name of the whitelist template.
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// The user ID.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public int? UserId { get; set; }

            }

            /// <summary>
            /// The total number of pages returned.
            /// </summary>
            [NameInMap("TotalPageNumbers")]
            [Validation(Required=false)]
            public int? TotalPageNumbers { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalRecords")]
            [Validation(Required=false)]
            public int? TotalRecords { get; set; }

        }

        /// <summary>
        /// The HTTP status code returned. Valid values:
        /// 
        /// *   **200**: success
        /// *   **400**: client error
        /// *   **500**: server error
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
