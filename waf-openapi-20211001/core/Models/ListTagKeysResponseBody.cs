// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ListTagKeysResponseBody : TeaModel {
        /// <summary>
        /// The keys and types of the tags.
        /// </summary>
        [NameInMap("Keys")]
        [Validation(Required=false)]
        public List<ListTagKeysResponseBodyKeys> Keys { get; set; }
        public class ListTagKeysResponseBodyKeys : TeaModel {
            /// <summary>
            /// The type of the tag. Valid values:
            /// 
            /// *   custom
            /// *   system
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The key of the tag.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

        }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
