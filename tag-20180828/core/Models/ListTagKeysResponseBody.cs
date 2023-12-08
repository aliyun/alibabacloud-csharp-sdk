// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListTagKeysResponseBody : TeaModel {
        /// <summary>
        /// The information of the tag keys.
        /// </summary>
        [NameInMap("Keys")]
        [Validation(Required=false)]
        public ListTagKeysResponseBodyKeys Keys { get; set; }
        public class ListTagKeysResponseBodyKeys : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public List<ListTagKeysResponseBodyKeysKey> Key { get; set; }
            public class ListTagKeysResponseBodyKeysKey : TeaModel {
                /// <summary>
                /// The type of the resource tag. Valid values:
                /// 
                /// *   custom
                /// *   system
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// The description of the tag key.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether the next query is required. The value of this parameter may be empty.
        /// 
        /// *   If the value of this parameter is empty (`"NextToken": ""`), all results are returned, and the next query is not required.
        /// *   If the value of this parameter is not empty, the next query is required, and the value is the token used to start the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
