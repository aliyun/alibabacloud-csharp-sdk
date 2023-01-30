// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiSignaturesResponseBody : TeaModel {
        /// <summary>
        /// The time when the backend signature key was bound.
        /// </summary>
        [NameInMap("ApiSignatures")]
        [Validation(Required=false)]
        public DescribeApiSignaturesResponseBodyApiSignatures ApiSignatures { get; set; }
        public class DescribeApiSignaturesResponseBodyApiSignatures : TeaModel {
            [NameInMap("ApiSignatureItem")]
            [Validation(Required=false)]
            public List<DescribeApiSignaturesResponseBodyApiSignaturesApiSignatureItem> ApiSignatureItem { get; set; }
            public class DescribeApiSignaturesResponseBodyApiSignaturesApiSignatureItem : TeaModel {
                /// <summary>
                /// The ID of the backend signature key.
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                /// <summary>
                /// *   This API is intended for API providers.
                /// *   The ApiIds parameter is optional. If this parameter is not specified, all results in the specified environment of an API group are returned.
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// The ID of the API.
                /// </summary>
                [NameInMap("BoundTime")]
                [Validation(Required=false)]
                public string BoundTime { get; set; }

                /// <summary>
                /// The name of the backend signature key.
                /// </summary>
                [NameInMap("SignatureId")]
                [Validation(Required=false)]
                public string SignatureId { get; set; }

                /// <summary>
                /// The name of the API.
                /// </summary>
                [NameInMap("SignatureName")]
                [Validation(Required=false)]
                public string SignatureName { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned signature key information. It is an array consisting of ApiSignatureItem data.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
