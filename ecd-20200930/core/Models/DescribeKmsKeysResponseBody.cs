// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeKmsKeysResponseBody : TeaModel {
        /// <summary>
        /// The authorization status.
        /// </summary>
        [NameInMap("AuthorizeStatus")]
        [Validation(Required=false)]
        public string AuthorizeStatus { get; set; }

        /// <summary>
        /// Details about the customer master keys (CMKs).
        /// </summary>
        [NameInMap("Keys")]
        [Validation(Required=false)]
        public List<DescribeKmsKeysResponseBodyKeys> Keys { get; set; }
        public class DescribeKmsKeysResponseBodyKeys : TeaModel {
            /// <summary>
            /// The alias of the key.
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// The Alibaba Cloud Resource Name (ARN) of the key in KMS.
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// The ID of the key.
            /// </summary>
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

            /// <summary>
            /// The type of the key.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// Indicates whether KMS is activated.
        /// </summary>
        [NameInMap("KmsServiceStatus")]
        [Validation(Required=false)]
        public string KmsServiceStatus { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
