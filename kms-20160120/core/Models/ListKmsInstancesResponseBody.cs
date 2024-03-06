// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListKmsInstancesResponseBody : TeaModel {
        /// <summary>
        /// A list of KMS instances.
        /// </summary>
        [NameInMap("KmsInstances")]
        [Validation(Required=false)]
        public ListKmsInstancesResponseBodyKmsInstances KmsInstances { get; set; }
        public class ListKmsInstancesResponseBodyKmsInstances : TeaModel {
            [NameInMap("KmsInstance")]
            [Validation(Required=false)]
            public List<ListKmsInstancesResponseBodyKmsInstancesKmsInstance> KmsInstance { get; set; }
            public class ListKmsInstancesResponseBodyKmsInstancesKmsInstance : TeaModel {
                /// <summary>
                /// The ARN of the KMS instance.
                /// </summary>
                [NameInMap("KmsInstanceArn")]
                [Validation(Required=false)]
                public string KmsInstanceArn { get; set; }

                /// <summary>
                /// The ID of the KMS instance.
                /// </summary>
                [NameInMap("KmsInstanceId")]
                [Validation(Required=false)]
                public string KmsInstanceId { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of KMS instances.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
