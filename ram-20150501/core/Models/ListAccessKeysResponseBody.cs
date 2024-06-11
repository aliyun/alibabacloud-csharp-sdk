// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListAccessKeysResponseBody : TeaModel {
        /// <summary>
        /// The list of AccessKey pairs that belong to the RAM user.
        /// </summary>
        [NameInMap("AccessKeys")]
        [Validation(Required=false)]
        public ListAccessKeysResponseBodyAccessKeys AccessKeys { get; set; }
        public class ListAccessKeysResponseBodyAccessKeys : TeaModel {
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public List<ListAccessKeysResponseBodyAccessKeysAccessKey> AccessKey { get; set; }
            public class ListAccessKeysResponseBodyAccessKeysAccessKey : TeaModel {
                /// <summary>
                /// The AccessKey ID.
                /// </summary>
                [NameInMap("AccessKeyId")]
                [Validation(Required=false)]
                public string AccessKeyId { get; set; }

                /// <summary>
                /// The time when the AccessKey pair was created.
                /// </summary>
                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                /// <summary>
                /// The status of the AccessKey pair. Valid values: Active and Inactive.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
