// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeSignaturesResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The returned signature information. It is an array consisting of SignatureInfo data.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the backend signature key.
        /// </summary>
        [NameInMap("SignatureInfos")]
        [Validation(Required=false)]
        public DescribeSignaturesResponseBodySignatureInfos SignatureInfos { get; set; }
        public class DescribeSignaturesResponseBodySignatureInfos : TeaModel {
            [NameInMap("SignatureInfo")]
            [Validation(Required=false)]
            public List<DescribeSignaturesResponseBodySignatureInfosSignatureInfo> SignatureInfo { get; set; }
            public class DescribeSignaturesResponseBodySignatureInfosSignatureInfo : TeaModel {
                /// <summary>
                /// *   This API is intended for API providers.
                /// *   This operation is used to query the backend signature keys in a Region. Region is a system parameter.
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// The Secret value of the backend signature key.
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// Queries backend signature keys.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The name of the backend signature key.
                /// </summary>
                [NameInMap("SignatureId")]
                [Validation(Required=false)]
                public string SignatureId { get; set; }

                /// <summary>
                /// The region where the key is located.
                /// </summary>
                [NameInMap("SignatureKey")]
                [Validation(Required=false)]
                public string SignatureKey { get; set; }

                /// <summary>
                /// The creation time of the key.
                /// </summary>
                [NameInMap("SignatureName")]
                [Validation(Required=false)]
                public string SignatureName { get; set; }

                /// <summary>
                /// The Key value of the backend signature key.
                /// </summary>
                [NameInMap("SignatureSecret")]
                [Validation(Required=false)]
                public string SignatureSecret { get; set; }

            }

        }

        /// <summary>
        /// The last modification time of the key.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
