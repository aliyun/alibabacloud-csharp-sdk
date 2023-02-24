// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListKeysResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the CMKs of the current Alibaba Cloud account in the current region.
        /// </summary>
        [NameInMap("Keys")]
        [Validation(Required=false)]
        public ListKeysResponseBodyKeys Keys { get; set; }
        public class ListKeysResponseBodyKeys : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public List<ListKeysResponseBodyKeysKey> Key { get; set; }
            public class ListKeysResponseBodyKeysKey : TeaModel {
                /// <summary>
                /// The Alibaba Cloud Resource Name (ARN) of the CMK.
                /// </summary>
                [NameInMap("KeyArn")]
                [Validation(Required=false)]
                public string KeyArn { get; set; }

                /// <summary>
                /// The ID of the CMK. The ID must be globally unique.
                /// </summary>
                [NameInMap("KeyId")]
                [Validation(Required=false)]
                public string KeyId { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of CMKs.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
