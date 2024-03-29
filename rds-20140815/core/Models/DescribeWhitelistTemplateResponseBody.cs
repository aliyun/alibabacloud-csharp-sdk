// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeWhitelistTemplateResponseBody : TeaModel {
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
        public DescribeWhitelistTemplateResponseBodyData Data { get; set; }
        public class DescribeWhitelistTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// The information about the IP whitelist template.
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public DescribeWhitelistTemplateResponseBodyDataTemplate Template { get; set; }
            public class DescribeWhitelistTemplateResponseBodyDataTemplate : TeaModel {
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
                /// The name of the IP whitelist template.
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
